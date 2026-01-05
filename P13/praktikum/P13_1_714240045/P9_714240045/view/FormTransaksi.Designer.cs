namespace P9_714240045.view
{
    partial class FormTransaksi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupTable = new System.Windows.Forms.GroupBox();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.lblIdBarang = new System.Windows.Forms.Label();
            this.cmbBarang = new System.Windows.Forms.ComboBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupCari = new System.Windows.Forms.GroupBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.groupAction = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.groupInput.SuspendLayout();
            this.groupCari.SuspendLayout();
            this.groupAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTable
            // 
            this.groupTable.Controls.Add(this.dgvTransaksi);
            this.groupTable.Location = new System.Drawing.Point(10, 10);
            this.groupTable.Name = "groupTable";
            this.groupTable.Size = new System.Drawing.Size(870, 220);
            this.groupTable.TabIndex = 0;
            this.groupTable.TabStop = false;
            this.groupTable.Text = "Table Transaksi Barang";
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AllowUserToAddRows = false;
            this.dgvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaksi.ColumnHeadersHeight = 34;
            this.dgvTransaksi.Location = new System.Drawing.Point(10, 25);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.ReadOnly = true;
            this.dgvTransaksi.RowHeadersWidth = 62;
            this.dgvTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaksi.Size = new System.Drawing.Size(850, 185);
            this.dgvTransaksi.TabIndex = 0;
            this.dgvTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaksi_CellClick);
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.lblIdBarang);
            this.groupInput.Controls.Add(this.cmbBarang);
            this.groupInput.Controls.Add(this.lblNama);
            this.groupInput.Controls.Add(this.txtNama);
            this.groupInput.Controls.Add(this.lblHarga);
            this.groupInput.Controls.Add(this.txtHarga);
            this.groupInput.Controls.Add(this.lblQty);
            this.groupInput.Controls.Add(this.txtQty);
            this.groupInput.Controls.Add(this.lblTotal);
            this.groupInput.Controls.Add(this.txtTotal);
            this.groupInput.Location = new System.Drawing.Point(10, 240);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(520, 260);
            this.groupInput.TabIndex = 1;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Form Transaksi Barang";
            // 
            // lblIdBarang
            // 
            this.lblIdBarang.Location = new System.Drawing.Point(20, 30);
            this.lblIdBarang.Name = "lblIdBarang";
            this.lblIdBarang.Size = new System.Drawing.Size(100, 23);
            this.lblIdBarang.TabIndex = 0;
            this.lblIdBarang.Text = "ID Barang";
            // 
            // cmbBarang
            // 
            this.cmbBarang.Location = new System.Drawing.Point(120, 27);
            this.cmbBarang.Name = "cmbBarang";
            this.cmbBarang.Size = new System.Drawing.Size(150, 28);
            this.cmbBarang.TabIndex = 1;
            this.cmbBarang.SelectedIndexChanged += new System.EventHandler(this.cmbBarang_SelectedIndexChanged_1);
            // 
            // lblNama
            // 
            this.lblNama.Location = new System.Drawing.Point(20, 82);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(100, 23);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Barang";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(120, 82);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(150, 26);
            this.txtNama.TabIndex = 3;
            // 
            // lblHarga
            // 
            this.lblHarga.Location = new System.Drawing.Point(289, 85);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(56, 23);
            this.lblHarga.TabIndex = 4;
            this.lblHarga.Text = "Harga Barang";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(351, 82);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(150, 26);
            this.txtHarga.TabIndex = 5;
            // 
            // lblQty
            // 
            this.lblQty.Location = new System.Drawing.Point(20, 140);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(100, 23);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(120, 137);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(150, 26);
            this.txtQty.TabIndex = 7;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged_1);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(20, 175);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(120, 172);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // groupCari
            // 
            this.groupCari.Controls.Add(this.lblCari);
            this.groupCari.Controls.Add(this.txtCari);
            this.groupCari.Location = new System.Drawing.Point(540, 240);
            this.groupCari.Name = "groupCari";
            this.groupCari.Size = new System.Drawing.Size(340, 90);
            this.groupCari.TabIndex = 2;
            this.groupCari.TabStop = false;
            this.groupCari.Text = "Form Pencarian";
            // 
            // lblCari
            // 
            this.lblCari.Location = new System.Drawing.Point(15, 35);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(77, 23);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "Cari Data";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(80, 32);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(240, 26);
            this.txtCari.TabIndex = 1;
            // 
            // groupAction
            // 
            this.groupAction.Controls.Add(this.btnRefresh);
            this.groupAction.Controls.Add(this.btnSimpan);
            this.groupAction.Controls.Add(this.btnUbah);
            this.groupAction.Controls.Add(this.btnHapus);
            this.groupAction.Location = new System.Drawing.Point(540, 340);
            this.groupAction.Name = "groupAction";
            this.groupAction.Size = new System.Drawing.Size(340, 160);
            this.groupAction.TabIndex = 3;
            this.groupAction.TabStop = false;
            this.groupAction.Text = "Tombol Action";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(20, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(300, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(20, 60);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(300, 30);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(20, 95);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(300, 30);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(20, 130);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(300, 30);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // FormTransaksi
            // 
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.groupTable);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.groupCari);
            this.Controls.Add(this.groupAction);
            this.Name = "FormTransaksi";
            this.Text = "Data Transaksi";
            this.groupTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.groupCari.ResumeLayout(false);
            this.groupCari.PerformLayout();
            this.groupAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTable;
        private System.Windows.Forms.DataGridView dgvTransaksi;

        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.Label lblIdBarang;
        private System.Windows.Forms.ComboBox cmbBarang;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;

        private System.Windows.Forms.GroupBox groupCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;

        private System.Windows.Forms.GroupBox groupAction;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
    }
}
