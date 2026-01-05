namespace P9_714240045.view
{
    partial class FormNilai
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxAction;

        private System.Windows.Forms.DataGridView DataNilai;

        private System.Windows.Forms.Label labelMatkul;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Label labelNpm;
        private System.Windows.Forms.Label labelNilai;
        private System.Windows.Forms.Label labelCari;

        private System.Windows.Forms.ComboBox checkBoxMatkul;
        private System.Windows.Forms.ComboBox checkBoxKategori;
        private System.Windows.Forms.ComboBox checkBoxNpm;

        private System.Windows.Forms.TextBox textBoxNilai;
        private System.Windows.Forms.TextBox textBoxCariData;

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelMatkul = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.labelNpm = new System.Windows.Forms.Label();
            this.labelNilai = new System.Windows.Forms.Label();
            this.checkBoxMatkul = new System.Windows.Forms.ComboBox();
            this.checkBoxKategori = new System.Windows.Forms.ComboBox();
            this.checkBoxNpm = new System.Windows.Forms.ComboBox();
            this.textBoxNilai = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelCari = new System.Windows.Forms.Label();
            this.textBoxCariData = new System.Windows.Forms.TextBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.groupBoxTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.DataNilai);
            this.groupBoxTable.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(860, 250);
            this.groupBoxTable.TabIndex = 0;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "Table Data Nilai";
            // 
            // DataNilai
            // 
            this.DataNilai.ColumnHeadersHeight = 34;
            this.DataNilai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataNilai.Location = new System.Drawing.Point(3, 22);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.RowHeadersWidth = 62;
            this.DataNilai.Size = new System.Drawing.Size(854, 225);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick);
            this.DataNilai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellContentClick);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxNama);
            this.groupBoxInput.Controls.Add(this.labelMatkul);
            this.groupBoxInput.Controls.Add(this.labelKategori);
            this.groupBoxInput.Controls.Add(this.labelNpm);
            this.groupBoxInput.Controls.Add(this.labelNilai);
            this.groupBoxInput.Controls.Add(this.checkBoxMatkul);
            this.groupBoxInput.Controls.Add(this.checkBoxKategori);
            this.groupBoxInput.Controls.Add(this.checkBoxNpm);
            this.groupBoxInput.Controls.Add(this.textBoxNilai);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 270);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(520, 240);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Form Input Nilai";
            // 
            // labelMatkul
            // 
            this.labelMatkul.Location = new System.Drawing.Point(20, 30);
            this.labelMatkul.Name = "labelMatkul";
            this.labelMatkul.Size = new System.Drawing.Size(74, 23);
            this.labelMatkul.TabIndex = 0;
            this.labelMatkul.Text = "Matkul";
            // 
            // labelKategori
            // 
            this.labelKategori.Location = new System.Drawing.Point(20, 65);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(74, 23);
            this.labelKategori.TabIndex = 1;
            this.labelKategori.Text = "Kategori";
            // 
            // labelNpm
            // 
            this.labelNpm.Location = new System.Drawing.Point(20, 100);
            this.labelNpm.Name = "labelNpm";
            this.labelNpm.Size = new System.Drawing.Size(74, 23);
            this.labelNpm.TabIndex = 2;
            this.labelNpm.Text = "NPM";
            // 
            // labelNilai
            // 
            this.labelNilai.Location = new System.Drawing.Point(20, 164);
            this.labelNilai.Name = "labelNilai";
            this.labelNilai.Size = new System.Drawing.Size(74, 23);
            this.labelNilai.TabIndex = 3;
            this.labelNilai.Text = "Nilai";
            // 
            // checkBoxMatkul
            // 
            this.checkBoxMatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Pemrograman IV",
            "Literasi Data",
            "Sistem ERP",
            "RPL",
            "Metodologi Penelitian",
            "PKN",
            "General English I"});
            this.checkBoxMatkul.Location = new System.Drawing.Point(100, 27);
            this.checkBoxMatkul.Name = "checkBoxMatkul";
            this.checkBoxMatkul.Size = new System.Drawing.Size(380, 28);
            this.checkBoxMatkul.TabIndex = 4;
            // 
            // checkBoxKategori
            // 
            this.checkBoxKategori.Items.AddRange(new object[] {
            "ATS",
            "AAS"});
            this.checkBoxKategori.Location = new System.Drawing.Point(100, 62);
            this.checkBoxKategori.Name = "checkBoxKategori";
            this.checkBoxKategori.Size = new System.Drawing.Size(380, 28);
            this.checkBoxKategori.TabIndex = 5;
            // 
            // checkBoxNpm
            // 
            this.checkBoxNpm.Location = new System.Drawing.Point(100, 97);
            this.checkBoxNpm.Name = "checkBoxNpm";
            this.checkBoxNpm.Size = new System.Drawing.Size(380, 28);
            this.checkBoxNpm.TabIndex = 6;
            this.checkBoxNpm.SelectedIndexChanged += new System.EventHandler(this.checkBoxNpm_SelectedIndexChanged);
            // 
            // textBoxNilai
            // 
            this.textBoxNilai.Location = new System.Drawing.Point(100, 164);
            this.textBoxNilai.Name = "textBoxNilai";
            this.textBoxNilai.Size = new System.Drawing.Size(380, 26);
            this.textBoxNilai.TabIndex = 7;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelCari);
            this.groupBoxSearch.Controls.Add(this.textBoxCariData);
            this.groupBoxSearch.Location = new System.Drawing.Point(550, 270);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(322, 80);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Form Pencarian";
            // 
            // labelCari
            // 
            this.labelCari.Location = new System.Drawing.Point(6, 35);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(78, 23);
            this.labelCari.TabIndex = 0;
            this.labelCari.Text = "Cari Data";
            // 
            // textBoxCariData
            // 
            this.textBoxCariData.Location = new System.Drawing.Point(90, 32);
            this.textBoxCariData.Name = "textBoxCariData";
            this.textBoxCariData.Size = new System.Drawing.Size(210, 26);
            this.textBoxCariData.TabIndex = 1;
            this.textBoxCariData.TextChanged += new System.EventHandler(this.textBoxCariData_TextChanged);
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.btnRefresh);
            this.groupBoxAction.Controls.Add(this.btnSimpan);
            this.groupBoxAction.Controls.Add(this.btnUbah);
            this.groupBoxAction.Controls.Add(this.btnHapus);
            this.groupBoxAction.Location = new System.Drawing.Point(550, 360);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(322, 150);
            this.groupBoxAction.TabIndex = 3;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Tombol Action";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(20, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(280, 25);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(20, 55);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(280, 25);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(20, 85);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(280, 25);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(20, 115);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(280, 25);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(100, 132);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.ReadOnly = true;
            this.textBoxNama.Size = new System.Drawing.Size(380, 26);
            this.textBoxNama.TabIndex = 8;
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            // 
            // FormNilai
            // 
            this.ClientSize = new System.Drawing.Size(884, 530);
            this.Controls.Add(this.groupBoxTable);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxAction);
            this.Name = "FormNilai";
            this.Text = "Form Nilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            this.groupBoxTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox textBoxNama;
    }
}
