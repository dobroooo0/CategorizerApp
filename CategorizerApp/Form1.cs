using Npgsql;
using System.Data;

namespace CategorizerApp
{
    public partial class Form1 : Form
    {
        string connString = "Host=localhost;Port=5432;Database=site_db;Username=postgres;Password=30122006a";

        public Form1()
        {
            InitializeComponent();
        }

        void RefreshData()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT s.id, s.url, c.name as category FROM sites s JOIN categories c ON s.category_id = c.id";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvSites.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
            LoadCategories();
        }
        void LoadCategories()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT id, name FROM categories";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCategories.DataSource = dt;
                cmbCategories.DisplayMember = "name";
                cmbCategories.ValueMember = "id";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                MessageBox.Show("Введите адрес сайта!");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "INSERT INTO sites (url, category_id) VALUES (@url, @catId)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("url", txtUrl.Text);
                        cmd.Parameters.AddWithValue("catId", cmbCategories.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Сайт успешно добавлен!");
                txtUrl.Clear();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT s.id, s.url, c.name as category FROM sites s JOIN categories c ON s.category_id = c.id WHERE s.url ILIKE @text";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("text", "%" + txtSearch.Text + "%");
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSites.DataSource = dt;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSites.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvSites.CurrentRow.Cells["id"].Value);

            if (MessageBox.Show("Удалить выбранный сайт?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "DELETE FROM sites WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                RefreshData();
            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSites.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvSites.CurrentRow.Cells["id"].Value);

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "UPDATE sites SET url = @url, category_id = @catId WHERE id = @id";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("url", txtUrl.Text);
                    cmd.Parameters.AddWithValue("catId", cmbCategories.SelectedValue);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            RefreshData();
            MessageBox.Show("Данные обновлены!");
        }
    }
}