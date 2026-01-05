namespace P9_714240045
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.labelNpm = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAngkatan = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNohp = new System.Windows.Forms.Label();
            this.textboxNpm = new System.Windows.Forms.TextBox();
            this.textboxNama = new System.Windows.Forms.TextBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.textboxAlamat = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.textboxNohp = new System.Windows.Forms.TextBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxCariData = new System.Windows.Forms.TextBox();
            this.groupBoxTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.groupBoxForm.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.DataMahasiswa);
            this.groupBoxTable.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(860, 250);
            this.groupBoxTable.TabIndex = 0;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "Table Data Mahasiswa";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(0, 22);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.RowHeadersWidth = 62;
            this.DataMahasiswa.RowTemplate.Height = 28;
            this.DataMahasiswa.Size = new System.Drawing.Size(860, 228);
            this.DataMahasiswa.TabIndex = 0;
            this.DataMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellClick);
            this.DataMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellContentClick);
            this.DataMahasiswa.DoubleClick += new System.EventHandler(this.DataMahasiswa_DoubleClick);
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Controls.Add(this.labelNpm);
            this.groupBoxForm.Controls.Add(this.labelNama);
            this.groupBoxForm.Controls.Add(this.labelAngkatan);
            this.groupBoxForm.Controls.Add(this.labelAlamat);
            this.groupBoxForm.Controls.Add(this.labelEmail);
            this.groupBoxForm.Controls.Add(this.labelNohp);
            this.groupBoxForm.Controls.Add(this.textboxNpm);
            this.groupBoxForm.Controls.Add(this.textboxNama);
            this.groupBoxForm.Controls.Add(this.comboBoxAngkatan);
            this.groupBoxForm.Controls.Add(this.textboxAlamat);
            this.groupBoxForm.Controls.Add(this.textboxEmail);
            this.groupBoxForm.Controls.Add(this.textboxNohp);
            this.groupBoxForm.Location = new System.Drawing.Point(12, 270);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(560, 313);
            this.groupBoxForm.TabIndex = 1;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "Form Data Mahasiswa";
            // 
            // labelNpm
            // 
            this.labelNpm.Location = new System.Drawing.Point(10, 30);
            this.labelNpm.Name = "labelNpm";
            this.labelNpm.Size = new System.Drawing.Size(64, 23);
            this.labelNpm.TabIndex = 0;
            this.labelNpm.Text = "NPM";
            // 
            // labelNama
            // 
            this.labelNama.Location = new System.Drawing.Point(10, 60);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(74, 23);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama";
            // 
            // labelAngkatan
            // 
            this.labelAngkatan.Location = new System.Drawing.Point(10, 111);
            this.labelAngkatan.Name = "labelAngkatan";
            this.labelAngkatan.Size = new System.Drawing.Size(84, 23);
            this.labelAngkatan.TabIndex = 2;
            this.labelAngkatan.Text = "Angkatan";
            // 
            // labelAlamat
            // 
            this.labelAlamat.Location = new System.Drawing.Point(10, 163);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(64, 23);
            this.labelAlamat.TabIndex = 3;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(10, 217);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 23);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelNohp
            // 
            this.labelNohp.Location = new System.Drawing.Point(10, 265);
            this.labelNohp.Name = "labelNohp";
            this.labelNohp.Size = new System.Drawing.Size(64, 23);
            this.labelNohp.TabIndex = 5;
            this.labelNohp.Text = "No HP";
            // 
            // textboxNpm
            // 
            this.textboxNpm.Location = new System.Drawing.Point(100, 27);
            this.textboxNpm.Name = "textboxNpm";
            this.textboxNpm.Size = new System.Drawing.Size(430, 26);
            this.textboxNpm.TabIndex = 6;
            // 
            // textboxNama
            // 
            this.textboxNama.Location = new System.Drawing.Point(100, 60);
            this.textboxNama.Name = "textboxNama";
            this.textboxNama.Size = new System.Drawing.Size(430, 26);
            this.textboxNama.TabIndex = 7;
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBoxAngkatan.Location = new System.Drawing.Point(100, 106);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(430, 28);
            this.comboBoxAngkatan.TabIndex = 8;
            // 
            // textboxAlamat
            // 
            this.textboxAlamat.Location = new System.Drawing.Point(100, 160);
            this.textboxAlamat.Multiline = true;
            this.textboxAlamat.Name = "textboxAlamat";
            this.textboxAlamat.Size = new System.Drawing.Size(430, 45);
            this.textboxAlamat.TabIndex = 9;
            // 
            // textboxEmail
            // 
            this.textboxEmail.Location = new System.Drawing.Point(100, 217);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(430, 26);
            this.textboxEmail.TabIndex = 10;
            // 
            // textboxNohp
            // 
            this.textboxNohp.Location = new System.Drawing.Point(100, 262);
            this.textboxNohp.Name = "textboxNohp";
            this.textboxNohp.Size = new System.Drawing.Size(430, 26);
            this.textboxNohp.TabIndex = 11;
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.btnRefresh);
            this.groupBoxAction.Controls.Add(this.btnSimpan);
            this.groupBoxAction.Controls.Add(this.btnUbah);
            this.groupBoxAction.Controls.Add(this.btnHapus);
            this.groupBoxAction.Location = new System.Drawing.Point(578, 390);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(292, 193);
            this.groupBoxAction.TabIndex = 2;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Tombol Action";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(20, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(250, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(20, 70);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(250, 30);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(20, 110);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(250, 30);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(20, 150);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(250, 30);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textboxCariData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(589, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Pencarian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Data";
            // 
            // textboxCariData
            // 
            this.textboxCariData.Location = new System.Drawing.Point(87, 42);
            this.textboxCariData.Name = "textboxCariData";
            this.textboxCariData.Size = new System.Drawing.Size(188, 26);
            this.textboxCariData.TabIndex = 1;
            this.textboxCariData.TextChanged += new System.EventHandler(this.textboxCariData_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(884, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTable);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.groupBoxAction);
            this.Name = "Form1";
            this.Text = "ULBI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.GroupBox groupBoxAction;

        private System.Windows.Forms.Label labelNpm;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAngkatan;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNohp;

        private System.Windows.Forms.TextBox textboxNpm;
        private System.Windows.Forms.TextBox textboxNama;
        private System.Windows.Forms.TextBox textboxAlamat;
        private System.Windows.Forms.TextBox textboxEmail;
        private System.Windows.Forms.TextBox textboxNohp;

        private System.Windows.Forms.ComboBox comboBoxAngkatan;

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxCariData;
        private System.Windows.Forms.Label label1;
    }
}
