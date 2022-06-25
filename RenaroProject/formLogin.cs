using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace RenaroProject
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn;
        string connString = "host=localhost;uid=postgres;pwd=12345678;database=renaro";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand($"SELECT * FROM login('{txtUsername.Text}', '{txtPassword.Text}')", conn);

                int result = (int)comm.ExecuteScalar();

                if (result == 1)
                {
                    this.Hide(); // hide form login
                    new formPembayaran().Show(); // menampilkan form pembayaran
                }
                else
                {
                    MessageBox.Show("Username atau Password tidak valid!", "Login gagal", MessageBoxButtons.OK);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}