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
    public partial class formPembayaran : Form
    {
        public formPembayaran()
        {
            InitializeComponent();
        }

        private void formPembayaran_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("host=localhost;uid=postgres;pwd=12345678;database=renaro");
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand("SELECT daya FROM daya", conn);
            NpgsqlDataReader read = comm.ExecuteReader();

            if (read.HasRows)
            {
                DataTable dtab = new DataTable();
                dtab.Load(read);
                cmbVoltAmpere.DataSource = dtab;
                cmbVoltAmpere.ValueMember = "daya";
                cmbVoltAmpere.DisplayMember = "daya";
            }
            comm.Dispose(); // menghapus perintah sql yang ada pada npgsqlcommand
            conn.Close(); // menutup koneksi database
        }

        private void txtNoListrik_KeyPress(object sender, KeyPressEventArgs e) // inputan hanya integer
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        //membuat inputan kwh sebelum hanya menerima numerik
        private void txtkWhsebelum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        //membuat inputan textbox kwh sekarang hanya menerima numerik
        private void txtkWhsekarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        //membuat inputan textbox bayaran hanya menerima numerik
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int total = int.Parse(txtBiayakWh.Text) * (int.Parse(txtkWhsekarang.Text) - int.Parse(txtkWhsebelum.Text)) + int.Parse(txtBiayaAdmin.Text);
            txtTagihan.Text = $"{total}";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int kembalian = int.Parse(txtBayaran.Text) - int.Parse(txtTagihan.Text);
            txtKembalian.Text = $"{kembalian}";

            //memasukkan data ke database
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("host=localhost;uid=postgres;pwd=12345678;database=renaro");
                conn.Open();
                string query = $"SELECT * FROM add_transaksi ('{txtNoListrik.Text}', '{dateTglPembayaran.Text}', '{cmbVoltAmpere.Text}', {txtBiayakWh.Text}, {txtkWhsebelum.Text}, {txtkWhsekarang.Text}, {txtBiayaAdmin.Text}, {txtTagihan.Text}, {txtBayaran.Text}, {txtKembalian.Text})";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);

                int result = (int)comm.ExecuteScalar();
                if (result == 1)
                {
                    MessageBox.Show("Pembayaran berhasil", "Transaksi sedang berlangsung");
                }
                else
                {
                    MessageBox.Show("Transaksi gagal, cek kembali data yang anda masukkan", "Transaksi gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Invalid Database Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formPelanggan().Show();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formRiwayat().Show();
        }
    }
}