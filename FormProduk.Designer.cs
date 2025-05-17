namespace Praktikum_PBO_Winform
{
    partial class FormProduk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNamaProduk = new TextBox();
            tbHargaProduk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            tbStokProduk = new TextBox();
            BtnTambahProduk = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaProduk.Location = new Point(117, 126);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(271, 29);
            tbNamaProduk.TabIndex = 0;
            // 
            // tbHargaProduk
            // 
            tbHargaProduk.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHargaProduk.Location = new Point(117, 191);
            tbHargaProduk.Name = "tbHargaProduk";
            tbHargaProduk.Size = new Size(271, 29);
            tbHargaProduk.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 40);
            label1.Name = "label1";
            label1.Size = new Size(260, 29);
            label1.TabIndex = 2;
            label1.Text = "Form Tambah Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 101);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 3;
            label2.Text = "Nama Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 166);
            label3.Name = "label3";
            label3.Size = new Size(60, 22);
            label3.TabIndex = 4;
            label3.Text = "Harga";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(117, 375);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(591, 333);
            dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 232);
            label4.Name = "label4";
            label4.Size = new Size(48, 22);
            label4.TabIndex = 7;
            label4.Text = "Stok";
            // 
            // tbStokProduk
            // 
            tbStokProduk.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStokProduk.Location = new Point(117, 257);
            tbStokProduk.Name = "tbStokProduk";
            tbStokProduk.Size = new Size(271, 29);
            tbStokProduk.TabIndex = 6;
            // 
            // BtnTambahProduk
            // 
            BtnTambahProduk.BackColor = Color.DeepSkyBlue;
            BtnTambahProduk.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTambahProduk.ForeColor = SystemColors.ControlLightLight;
            BtnTambahProduk.Location = new Point(117, 308);
            BtnTambahProduk.Name = "BtnTambahProduk";
            BtnTambahProduk.Size = new Size(271, 48);
            BtnTambahProduk.TabIndex = 8;
            BtnTambahProduk.Text = "Tambah Produk";
            BtnTambahProduk.UseVisualStyleBackColor = false;
            BtnTambahProduk.Click += BtnTambahProduk_Click;
            // 
            // FormProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 761);
            Controls.Add(BtnTambahProduk);
            Controls.Add(label4);
            Controls.Add(tbStokProduk);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbHargaProduk);
            Controls.Add(tbNamaProduk);
            Name = "FormProduk";
            Text = "FormProduk";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNamaProduk;
        private TextBox tbHargaProduk;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox tbStokProduk;
        private Button BtnTambahProduk;
    }
}