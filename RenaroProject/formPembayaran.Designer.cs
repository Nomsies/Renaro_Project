namespace RenaroProject
{
    partial class formPembayaran
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
            this.txtNoListrik = new System.Windows.Forms.TextBox();
            this.dateTglPembayaran = new System.Windows.Forms.DateTimePicker();
            this.cmbVoltAmpere = new System.Windows.Forms.ComboBox();
            this.txtBiayakWh = new System.Windows.Forms.TextBox();
            this.txtkWhsebelum = new System.Windows.Forms.TextBox();
            this.txtkWhsekarang = new System.Windows.Forms.TextBox();
            this.txtBiayaAdmin = new System.Windows.Forms.TextBox();
            this.txtTagihan = new System.Windows.Forms.TextBox();
            this.txtBayaran = new System.Windows.Forms.TextBox();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPelanggan = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNoListrik
            // 
            this.txtNoListrik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoListrik.Location = new System.Drawing.Point(121, 30);
            this.txtNoListrik.MaxLength = 16;
            this.txtNoListrik.Name = "txtNoListrik";
            this.txtNoListrik.Size = new System.Drawing.Size(148, 20);
            this.txtNoListrik.TabIndex = 0;
            this.txtNoListrik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoListrik_KeyPress);
            // 
            // dateTglPembayaran
            // 
            this.dateTglPembayaran.CustomFormat = "yyyy-MM-dd";
            this.dateTglPembayaran.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTglPembayaran.Location = new System.Drawing.Point(121, 56);
            this.dateTglPembayaran.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.dateTglPembayaran.Name = "dateTglPembayaran";
            this.dateTglPembayaran.Size = new System.Drawing.Size(148, 20);
            this.dateTglPembayaran.TabIndex = 1;
            // 
            // cmbVoltAmpere
            // 
            this.cmbVoltAmpere.FormattingEnabled = true;
            this.cmbVoltAmpere.Location = new System.Drawing.Point(121, 82);
            this.cmbVoltAmpere.Name = "cmbVoltAmpere";
            this.cmbVoltAmpere.Size = new System.Drawing.Size(148, 21);
            this.cmbVoltAmpere.TabIndex = 2;
            // 
            // txtBiayakWh
            // 
            this.txtBiayakWh.Location = new System.Drawing.Point(121, 109);
            this.txtBiayakWh.MaxLength = 10;
            this.txtBiayakWh.Name = "txtBiayakWh";
            this.txtBiayakWh.Size = new System.Drawing.Size(148, 20);
            this.txtBiayakWh.TabIndex = 3;
            // 
            // txtkWhsebelum
            // 
            this.txtkWhsebelum.Location = new System.Drawing.Point(121, 135);
            this.txtkWhsebelum.MaxLength = 6;
            this.txtkWhsebelum.Name = "txtkWhsebelum";
            this.txtkWhsebelum.Size = new System.Drawing.Size(148, 20);
            this.txtkWhsebelum.TabIndex = 4;
            this.txtkWhsebelum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkWhsebelum_KeyPress);
            // 
            // txtkWhsekarang
            // 
            this.txtkWhsekarang.Location = new System.Drawing.Point(121, 161);
            this.txtkWhsekarang.MaxLength = 6;
            this.txtkWhsekarang.Name = "txtkWhsekarang";
            this.txtkWhsekarang.Size = new System.Drawing.Size(148, 20);
            this.txtkWhsekarang.TabIndex = 5;
            this.txtkWhsekarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkWhsekarang_KeyPress);
            // 
            // txtBiayaAdmin
            // 
            this.txtBiayaAdmin.Location = new System.Drawing.Point(121, 188);
            this.txtBiayaAdmin.Name = "txtBiayaAdmin";
            this.txtBiayaAdmin.Size = new System.Drawing.Size(148, 20);
            this.txtBiayaAdmin.TabIndex = 6;
            this.txtBiayaAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txtTagihan
            // 
            this.txtTagihan.Location = new System.Drawing.Point(121, 254);
            this.txtTagihan.MaxLength = 7;
            this.txtTagihan.Name = "txtTagihan";
            this.txtTagihan.ReadOnly = true;
            this.txtTagihan.Size = new System.Drawing.Size(148, 20);
            this.txtTagihan.TabIndex = 8;
            // 
            // txtBayaran
            // 
            this.txtBayaran.Location = new System.Drawing.Point(144, 30);
            this.txtBayaran.Name = "txtBayaran";
            this.txtBayaran.Size = new System.Drawing.Size(147, 20);
            this.txtBayaran.TabIndex = 0;
            // 
            // txtKembalian
            // 
            this.txtKembalian.Location = new System.Drawing.Point(144, 85);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.ReadOnly = true;
            this.txtKembalian.Size = new System.Drawing.Size(147, 20);
            this.txtKembalian.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nomor Lisrik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Volt Ampere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Biaya per kWh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Tagihan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tanggal Pembayaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "kWh Sebelum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "kWh Sekarang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Uang Muka";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Kembalian";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Biaya Admin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(150)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.button1.Location = new System.Drawing.Point(158, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(150)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.button2.Location = new System.Drawing.Point(144, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Bayar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBiayaAdmin);
            this.groupBox1.Controls.Add(this.txtNoListrik);
            this.groupBox1.Controls.Add(this.dateTglPembayaran);
            this.groupBox1.Controls.Add(this.cmbVoltAmpere);
            this.groupBox1.Controls.Add(this.txtBiayakWh);
            this.groupBox1.Controls.Add(this.txtkWhsebelum);
            this.groupBox1.Controls.Add(this.txtkWhsekarang);
            this.groupBox1.Controls.Add(this.txtTagihan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 284);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAGIHAN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtKembalian);
            this.groupBox2.Controls.Add(this.txtBayaran);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(330, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 125);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PEMBAYARAN";
            // 
            // btnPelanggan
            // 
            this.btnPelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(150)))));
            this.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.btnPelanggan.Location = new System.Drawing.Point(330, 308);
            this.btnPelanggan.Name = "btnPelanggan";
            this.btnPelanggan.Size = new System.Drawing.Size(96, 56);
            this.btnPelanggan.TabIndex = 20;
            this.btnPelanggan.Text = "Daftar Pelanggan";
            this.btnPelanggan.UseVisualStyleBackColor = false;
            this.btnPelanggan.Click += new System.EventHandler(this.btnPelanggan_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(150)))));
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.btnRiwayat.Location = new System.Drawing.Point(525, 308);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(96, 56);
            this.btnRiwayat.TabIndex = 21;
            this.btnRiwayat.Text = "Riwayat Transaksi";
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(91)))), ((int)(((byte)(160)))));
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 85);
            this.panel1.TabIndex = 22;
            // 
            // formPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(664, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnPelanggan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formPembayaran";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.formPembayaran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoListrik;
        private System.Windows.Forms.DateTimePicker dateTglPembayaran;
        private System.Windows.Forms.ComboBox cmbVoltAmpere;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBiayakWh;
        private System.Windows.Forms.TextBox txtkWhsebelum;
        private System.Windows.Forms.TextBox txtkWhsekarang;
        private System.Windows.Forms.TextBox txtTagihan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKembalian;
        private System.Windows.Forms.TextBox txtBayaran;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBiayaAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPelanggan;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Panel panel1;
    }
}