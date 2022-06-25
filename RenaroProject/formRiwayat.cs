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
    public partial class formRiwayat : Form
    {
        public formRiwayat()
        {
            InitializeComponent();
        }

        private void formRiwayat_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("host=localhost;uid=postgres;pwd=12345678;database=renaro");
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT * FROM transaksi", conn);
            NpgsqlDataReader read = comm.ExecuteReader();

            if (read.HasRows)
            {
                DataTable dtab = new DataTable();
                dtab.Load(read);
                dgvRiwayat.DataSource = dtab; // dgv mengambil data dari data table
            }
            comm.Dispose();
            conn.Close();
        }

        private void btnKembali_Click(object sender, EventArgs e) // fungsi saat button kembali di click
        {
            this.Hide(); // menutu[ fomr riwayat
            new formPembayaran().Show(); // menampilkan form pembayaran
        }
    }
}
