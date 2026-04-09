namespace CategorizerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSites = new DataGridView();
            txtUrl = new TextBox();
            cmbCategories = new ComboBox();
            btnAdd = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSites).BeginInit();
            SuspendLayout();
            // 
            // dgvSites
            // 
            dgvSites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSites.Location = new Point(-1, 0);
            dgvSites.Name = "dgvSites";
            dgvSites.Size = new Size(1485, 646);
            dgvSites.TabIndex = 0;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(1056, 10);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(130, 23);
            txtUrl.TabIndex = 1;
            txtUrl.TextAlign = HorizontalAlignment.Center;
            txtUrl.TextChanged += txtUrl_TextChanged;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(1056, 39);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(130, 23);
            cmbCategories.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1056, 68);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить сайт";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1271, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(130, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1271, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1271, 97);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1271, 68);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 646);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategories);
            Controls.Add(txtUrl);
            Controls.Add(dgvSites);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSites;
        private TextBox txtUrl;
        private ComboBox cmbCategories;
        private Button btnAdd;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
    }
}
