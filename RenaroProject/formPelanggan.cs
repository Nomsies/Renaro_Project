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
    public partial class formPelanggan : Form
    {
        public formPelanggan()
        {
            InitializeComponent();
        }

        private void formPelanggan_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("host=localhost;uid=postgres;pwd=12345678;database=renaro");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM pelanggan";
            NpgsqlDataReader read = comm.ExecuteReader();

            if(read.HasRows)
            {
                DataTable dtab = new DataTable();
                dtab.Load(read);
                dataGridView1.DataSource = dtab;
            }

            comm.CommandText = "SELECT daya FROM daya";
            NpgsqlDataReader rd1 = comm.ExecuteReader();

            if (rd1.HasRows)
            {
                DataTable dtab = new DataTable();
                dtab.Load(rd1);
                cmbDaya1.DataSource = dtab;
                cmbDaya1.DisplayMember = "daya";
            }

            NpgsqlDataReader rd2 = comm.ExecuteReader();
            if (rd2.HasRows)
            {
                DataTable dtab = new DataTable();
                dtab.Load(rd2);
                cmbDaya2.DataSource = dtab;
                cmbDaya2.DisplayMember = "daya";
            }

            comm.Dispose();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNama1.Text.Length < 5)
            {
                MessageBox.Show("Nama terlalu pendek");
                txtNama1.Focus();
            }

            if (txtAlamat.Text.Length < 10)
            {
                MessageBox.Show("Alamat kurang jelas");
                txtAlamat.Focus();
            }

            if (txtNoListrik1.Text.Length < 7)
            {
                MessageBox.Show("Nomor Listrik tidak valid");
                txtNoListrik1.Focus();
            }

            if (txtNama1.Text.Length > 5 && txtAlamat.Text.Length > 10 && txtNoListrik1.Text.Length > 7)
            {
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection("host=localhost;uid=postgres;pwd=12345678;database=renaro");
                    conn.Open();

                    NpgsqlCommand comm = new NpgsqlCommand($"select * from add_pelanggan('{txtNoListrik1.Text}', '{txtNama1.Text}', '{txtAlamat.Text}', {id_daya1})", conn);
                    int result = (int)comm.ExecuteScalar();

                    if (result == 1)
                    {
                        MessageBox.Show("Data ditambahkan ke dalam database", "Input berhasil");
                        comm.CommandText = "SELECT * FROM pelanggan";
                        NpgsqlDataReader read = comm.ExecuteReader();

                        if (read.HasRows)
                        {
                            DataTable dtab = new DataTable();
                            dtab.Load(read);
                            dataGridView1.DataSource = dtab;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan data ke dalam database", "Input gagal");
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex.Message, "Invalid database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("host=localhost;uid=postgres;pwd=12345678;database=renaro");
                conn.Open();

                NpgsqlCommand comm = new NpgsqlCommand($"DELETE FROM pelanggan WHERE no_listrik = '{txtNoListrik3.Text}'", conn);
                comm.ExecuteNonQuery();

                comm.CommandText = " SELECT * FROM pelanggan";
                NpgsqlDataReader read = comm.ExecuteReader();

                if (read.HasRows)
                {
                    DataTable dtab = new DataTable();
                    dtab.Load(read);
                    dataGridView1.DataSource = dtab;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("host=localhost;uid=postgres;pwd=12345678;database=renaro");
                conn.Open();

                NpgsqlCommand comm = new NpgsqlCommand($"SELECT * FROM up_pelanggan('{txtNoListrik2.Text}', '{txtNama2.Text}', {id_daya2})", conn);

                int result = (int)comm.ExecuteScalar();

                if (result == 1)
                {
                    MessageBox.Show("Data telah di-update dari database", "Berhasil Update", MessageBoxButtons.OK);
                    
                    //Meng-update data yang terdapat dalam Data Grid View
                    comm.CommandText = "SELECT * FROM pelanggan";
                    NpgsqlDataReader read = comm.ExecuteReader();

                    if (read.HasRows)
                    {
                        DataTable dtab = new DataTable();
                        dtab.Load(read);
                        dataGridView1.DataSource = dtab;
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak dapat di-update", "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            new formPembayaran().Show();
            this.Hide();
        }

        //Memilih nilai id_daya user baru
        internal int id_daya1;
        private void cmbDaya1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDaya1.Text == "450 VA")
            {
                id_daya1 = 1;
            }
            else if (cmbDaya1.Text == "900 VA")
            {
                id_daya1 = 2;
            }
            else
            {
                id_daya1 = 3;
            }
        }

        //Memilih id_daya user yang ingin di-update datanya
        internal int id_daya2;
        private void cmbDaya2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDaya2.Text == "450 VA")
            {
                id_daya2 = 1;
            }
            else if (cmbDaya2.Text == "900 VA")
            {
                id_daya2 = 2;
            }
            else
            {
                id_daya2 = 3;
            }
        }
    }
}