using Npgsql;
using System.Data;
using System.Data.Common;

namespace Praktikum_PBO_Winform
{
    public partial class FormProduk : Form
    {
        private string connStr = "Host=localhost;Username=postgres;Password=dianeka@05;Database=PBO_CRUD";
        private int _userId;
        public FormProduk(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadProduk();
        }

        public void TambahProduk(string nama, int harga, int stok)
        {
            string query = "INSERT INTO products (nama_produk, harga_produk, stok, user_id) VALUES (@nama, @harga, @stok, @userId)";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@stok", stok);
                        cmd.Parameters.AddWithValue("@userId", _userId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProduk(); 
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat menambahkan produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan tidak terduga: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnTambahProduk_Click(object sender, EventArgs e)
        {
            string nama = tbNamaProduk.Text;
            int harga, stok;
            bool isHargaValid = int.TryParse(tbHargaProduk.Text, out harga);
            bool isStokValid = int.TryParse(tbStokProduk.Text, out stok);

            if (string.IsNullOrEmpty(nama) || !isHargaValid || !isStokValid || harga <= 0 || stok <= 0)
            {
                MessageBox.Show("Silakan isi semua field dengan benar. Pastikan harga dan stok berupa angka positif.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TambahProduk(nama, harga, stok);
            tbNamaProduk.Clear();
            tbHargaProduk.Clear();
            tbStokProduk.Clear();
        }

        public void LoadProduk()
        {
            string query = "SELECT product_id, nama_produk, harga_produk, stok FROM products WHERE user_id = @userId";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", _userId);

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;

                            if (dataGridView1.Columns.Contains("product_id"))
                                dataGridView1.Columns["product_id"].HeaderText = "ID Produk";

                            if (dataGridView1.Columns.Contains("nama_produk"))
                                dataGridView1.Columns["nama_produk"].HeaderText = "Nama Produk";

                            if (dataGridView1.Columns.Contains("harga_produk"))
                                dataGridView1.Columns["harga_produk"].HeaderText = "Harga Produk";

                            if (dataGridView1.Columns.Contains("stok"))
                                dataGridView1.Columns["stok"].HeaderText = "Stok Produk";
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memuat produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan tidak terduga: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}