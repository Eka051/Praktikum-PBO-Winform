using Npgsql;

namespace Praktikum_PBO_Winform
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void BtnShowPassword_Click_1(object sender, EventArgs e)
        {
            bool isPasswordHidden = tbPassword.UseSystemPasswordChar;
            tbPassword.UseSystemPasswordChar = !isPasswordHidden;
            tbPassword.PasswordChar = isPasswordHidden ? '\0' : '●';

            Image icon = isPasswordHidden ? Properties.Resources.eye_off : Properties.Resources.eye_on;
            BtnShowPassword.BackgroundImage = icon;
            BtnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public bool Validate(string username, string password, out int userId)
        {
            userId = 0;
            string connStr = "Host=localhost;Username=postgres;Password=Gunungsari;Database=CRUDPR";
            string query = "SELECT user_id, username FROM users WHERE username = @username AND password = @password";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = reader.GetInt32(0);
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memvalidasi login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername != null && tbPassword != null)
                {
                    string username = tbUsername.Text;
                    string password = tbPassword.Text;
                    if (Validate(username, password, out int userId))
                    {
                        MessageBox.Show("Login berhasil. Klik OK untuk melanjutkan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormProduk formProduk = new FormProduk(userId);
                        this.Hide();
                        formProduk.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email atau password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username & Password harus diisi!", "Perhatian!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghubungi database: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterLink_LinkClicked(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }
    }
}
