namespace P5_4_714240045
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Nama = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.TanggalLahir = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.PilihanKelas = new System.Windows.Forms.GroupBox();
            this.chkPanahan = new System.Windows.Forms.CheckBox();
            this.chkVoli = new System.Windows.Forms.CheckBox();
            this.chkBuluTangkis = new System.Windows.Forms.CheckBox();
            this.chkBasket = new System.Windows.Forms.CheckBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkTenis = new System.Windows.Forms.CheckBox();
            this.chkRenang = new System.Windows.Forms.CheckBox();
            this.chkSepakBola = new System.Windows.Forms.CheckBox();
            this.PilihanJadwal = new System.Windows.Forms.GroupBox();
            this.rdoSeninRabu = new System.Windows.Forms.RadioButton();
            this.rdoSelasaKamis = new System.Windows.Forms.RadioButton();
            this.rdoSabtuMinggu = new System.Windows.Forms.RadioButton();
            this.rdoMinggu = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PilihanKelas.SuspendLayout();
            this.PilihanJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(110, 68);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(51, 20);
            this.Nama.TabIndex = 0;
            this.Nama.Text = "Nama";
            this.Nama.Click += new System.EventHandler(this.label1_Click);
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Location = new System.Drawing.Point(110, 109);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(106, 20);
            this.JenisKelamin.TabIndex = 1;
            this.JenisKelamin.Text = "Jenis Kelamin";
            this.JenisKelamin.Click += new System.EventHandler(this.label2_Click);
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.AutoSize = true;
            this.TanggalLahir.Location = new System.Drawing.Point(110, 149);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(105, 20);
            this.TanggalLahir.TabIndex = 2;
            this.TanggalLahir.Text = "Tanggal Lahir";
            this.TanggalLahir.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(267, 68);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(381, 26);
            this.txtNama.TabIndex = 3;
            this.txtNama.TextChanged += new System.EventHandler(this.KolomIsiNama_TextChanged);
            // 
            // cmbJenisKelamin
            // 
            this.cmbJenisKelamin.FormattingEnabled = true;
            this.cmbJenisKelamin.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cmbJenisKelamin.Location = new System.Drawing.Point(267, 106);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(381, 28);
            this.cmbJenisKelamin.TabIndex = 4;
            this.cmbJenisKelamin.Text = "---Pilih Jenis Kelamin---";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(267, 144);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(381, 26);
            this.dtpTanggalLahir.TabIndex = 5;
            // 
            // PilihanKelas
            // 
            this.PilihanKelas.Controls.Add(this.chkPanahan);
            this.PilihanKelas.Controls.Add(this.chkVoli);
            this.PilihanKelas.Controls.Add(this.chkBuluTangkis);
            this.PilihanKelas.Controls.Add(this.chkBasket);
            this.PilihanKelas.Controls.Add(this.chkYoga);
            this.PilihanKelas.Controls.Add(this.chkTenis);
            this.PilihanKelas.Controls.Add(this.chkRenang);
            this.PilihanKelas.Controls.Add(this.chkSepakBola);
            this.PilihanKelas.Location = new System.Drawing.Point(73, 206);
            this.PilihanKelas.Name = "PilihanKelas";
            this.PilihanKelas.Size = new System.Drawing.Size(287, 184);
            this.PilihanKelas.TabIndex = 6;
            this.PilihanKelas.TabStop = false;
            this.PilihanKelas.Text = "Pilihan Kelas";
            // 
            // chkPanahan
            // 
            this.chkPanahan.AutoSize = true;
            this.chkPanahan.Location = new System.Drawing.Point(123, 136);
            this.chkPanahan.Name = "chkPanahan";
            this.chkPanahan.Size = new System.Drawing.Size(99, 24);
            this.chkPanahan.TabIndex = 14;
            this.chkPanahan.Text = "Panahan";
            this.chkPanahan.UseVisualStyleBackColor = true;
            // 
            // chkVoli
            // 
            this.chkVoli.AutoSize = true;
            this.chkVoli.Location = new System.Drawing.Point(123, 106);
            this.chkVoli.Name = "chkVoli";
            this.chkVoli.Size = new System.Drawing.Size(61, 24);
            this.chkVoli.TabIndex = 13;
            this.chkVoli.Text = "Voli";
            this.chkVoli.UseVisualStyleBackColor = true;
            // 
            // chkBuluTangkis
            // 
            this.chkBuluTangkis.AutoSize = true;
            this.chkBuluTangkis.Location = new System.Drawing.Point(123, 75);
            this.chkBuluTangkis.Name = "chkBuluTangkis";
            this.chkBuluTangkis.Size = new System.Drawing.Size(126, 24);
            this.chkBuluTangkis.TabIndex = 12;
            this.chkBuluTangkis.Text = "Bulu Tangkis";
            this.chkBuluTangkis.UseVisualStyleBackColor = true;
            // 
            // chkBasket
            // 
            this.chkBasket.AutoSize = true;
            this.chkBasket.Location = new System.Drawing.Point(123, 36);
            this.chkBasket.Name = "chkBasket";
            this.chkBasket.Size = new System.Drawing.Size(85, 24);
            this.chkBasket.TabIndex = 11;
            this.chkBasket.Text = "Basket";
            this.chkBasket.UseVisualStyleBackColor = true;
            this.chkBasket.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(0, 137);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(73, 24);
            this.chkYoga.TabIndex = 10;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            this.chkYoga.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkTenis
            // 
            this.chkTenis.AutoSize = true;
            this.chkTenis.Location = new System.Drawing.Point(0, 106);
            this.chkTenis.Name = "chkTenis";
            this.chkTenis.Size = new System.Drawing.Size(73, 24);
            this.chkTenis.TabIndex = 9;
            this.chkTenis.Text = "Tenis";
            this.chkTenis.UseVisualStyleBackColor = true;
            // 
            // chkRenang
            // 
            this.chkRenang.AutoSize = true;
            this.chkRenang.Location = new System.Drawing.Point(0, 75);
            this.chkRenang.Name = "chkRenang";
            this.chkRenang.Size = new System.Drawing.Size(92, 24);
            this.chkRenang.TabIndex = 8;
            this.chkRenang.Text = "Renang";
            this.chkRenang.UseVisualStyleBackColor = true;
            this.chkRenang.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkSepakBola
            // 
            this.chkSepakBola.AutoSize = true;
            this.chkSepakBola.Location = new System.Drawing.Point(0, 35);
            this.chkSepakBola.Name = "chkSepakBola";
            this.chkSepakBola.Size = new System.Drawing.Size(117, 24);
            this.chkSepakBola.TabIndex = 7;
            this.chkSepakBola.Text = "Sepak Bola";
            this.chkSepakBola.UseVisualStyleBackColor = true;
            this.chkSepakBola.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PilihanJadwal
            // 
            this.PilihanJadwal.Controls.Add(this.rdoSeninRabu);
            this.PilihanJadwal.Controls.Add(this.rdoSelasaKamis);
            this.PilihanJadwal.Controls.Add(this.rdoSabtuMinggu);
            this.PilihanJadwal.Controls.Add(this.rdoMinggu);
            this.PilihanJadwal.Location = new System.Drawing.Point(407, 206);
            this.PilihanJadwal.Name = "PilihanJadwal";
            this.PilihanJadwal.Size = new System.Drawing.Size(322, 184);
            this.PilihanJadwal.TabIndex = 0;
            this.PilihanJadwal.TabStop = false;
            this.PilihanJadwal.Text = "Pilihan Jadwal";
            // 
            // rdoSeninRabu
            // 
            this.rdoSeninRabu.AutoSize = true;
            this.rdoSeninRabu.Location = new System.Drawing.Point(6, 35);
            this.rdoSeninRabu.Name = "rdoSeninRabu";
            this.rdoSeninRabu.Size = new System.Drawing.Size(235, 24);
            this.rdoSeninRabu.TabIndex = 0;
            this.rdoSeninRabu.TabStop = true;
            this.rdoSeninRabu.Text = "Senin s/d Rabu, 14.00/16.00";
            this.rdoSeninRabu.UseVisualStyleBackColor = true;
            this.rdoSeninRabu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoSelasaKamis
            // 
            this.rdoSelasaKamis.AutoSize = true;
            this.rdoSelasaKamis.Location = new System.Drawing.Point(6, 74);
            this.rdoSelasaKamis.Name = "rdoSelasaKamis";
            this.rdoSelasaKamis.Size = new System.Drawing.Size(248, 24);
            this.rdoSelasaKamis.TabIndex = 1;
            this.rdoSelasaKamis.TabStop = true;
            this.rdoSelasaKamis.Text = "Selasa s/d Kamis, 14.00-16.00";
            this.rdoSelasaKamis.UseVisualStyleBackColor = true;
            this.rdoSelasaKamis.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoSabtuMinggu
            // 
            this.rdoSabtuMinggu.AutoSize = true;
            this.rdoSabtuMinggu.Location = new System.Drawing.Point(7, 106);
            this.rdoSabtuMinggu.Name = "rdoSabtuMinggu";
            this.rdoSabtuMinggu.Size = new System.Drawing.Size(247, 24);
            this.rdoSabtuMinggu.TabIndex = 2;
            this.rdoSabtuMinggu.TabStop = true;
            this.rdoSabtuMinggu.Text = "Sabtu s/d Minggu 09.00-11.00";
            this.rdoSabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // rdoMinggu
            // 
            this.rdoMinggu.AutoSize = true;
            this.rdoMinggu.Location = new System.Drawing.Point(7, 135);
            this.rdoMinggu.Name = "rdoMinggu";
            this.rdoMinggu.Size = new System.Drawing.Size(179, 24);
            this.rdoMinggu.TabIndex = 3;
            this.rdoMinggu.TabStop = true;
            this.rdoMinggu.Text = "Minggu, 13.00-20.00";
            this.rdoMinggu.UseVisualStyleBackColor = true;
            this.rdoMinggu.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(267, 415);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(106, 33);
            this.btnTampilkan.TabIndex = 15;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(407, 415);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(102, 33);
            this.btnSelesai.TabIndex = 16;
            this.btnSelesai.Text = "selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "FORM PENDAFTARAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.PilihanJadwal);
            this.Controls.Add(this.PilihanKelas);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Nama);
            this.Name = "Form1";
            this.Text = "ULBI SPORT SCHOOL";
            this.PilihanKelas.ResumeLayout(false);
            this.PilihanKelas.PerformLayout();
            this.PilihanJadwal.ResumeLayout(false);
            this.PilihanJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label TanggalLahir;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.GroupBox PilihanKelas;
        private System.Windows.Forms.RadioButton rdoMinggu;
        private System.Windows.Forms.RadioButton rdoSabtuMinggu;
        private System.Windows.Forms.RadioButton rdoSelasaKamis;
        private System.Windows.Forms.RadioButton rdoSeninRabu;
        private System.Windows.Forms.GroupBox PilihanJadwal;
        private System.Windows.Forms.CheckBox chkSepakBola;
        private System.Windows.Forms.CheckBox chkRenang;
        private System.Windows.Forms.CheckBox chkPanahan;
        private System.Windows.Forms.CheckBox chkVoli;
        private System.Windows.Forms.CheckBox chkBuluTangkis;
        private System.Windows.Forms.CheckBox chkBasket;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkTenis;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}

