using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_PBO_Winform
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            bool isPasswordHidden = tbPassword.UseSystemPasswordChar;
            tbPassword.UseSystemPasswordChar = !isPasswordHidden;
            tbPassword.PasswordChar = isPasswordHidden ? '\0' : '●';

            Image icon = isPasswordHidden ? Properties.Resources.eye_off : Properties.Resources.eye_on;
            BtnShowPassword.BackgroundImage = icon;
            BtnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public bool Register(string username, string password)
        {
            string connStr = "Host=localhost;Username=postgres;Password=Gunungsari;Database=CRUDPR";
            string query_select = "SELECT * FROM users WHERE username = @username";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query_select, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar()!;
                    int count = (result != null) ? Convert.ToInt32(result) : 0;
                    if (count > 0)
                    {
                        return false;
                    }
                }
            }

            string query_insert = "INSERT INTO users (username, password) VALUES (@username, @password) ";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query_insert, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername != null && tbPassword != null)
                {
                    string username = tbUsername.Text;
                    string password = tbPassword.Text;
                    bool isRegistered = Register(username, password);
                    if (isRegistered)
                    {
                        MessageBox.Show("Registrasi Berhasil!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        FormLogin formLogin = new FormLogin();
                        formLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registrasi Gagal. Silahkan coba lagi!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
