using MySql.Data.MySqlClient;
using P9_714240045.controller;
using P9_714240045.lib;
using P9_714240045.model;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace P9_714240045.view
{
    public partial class FormTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        Transaksi transaksi = new Transaksi();

        int idBarang = 0;
        int harga = 0;
        int idTransaksi = 0;


        public FormTransaksi()
        {
            InitializeComponent();
            LoadBarang();
            Tampil();
            ResetForm();
        }

        // =====================
        // LOAD BARANG KE COMBOBOX
        // =====================
        void LoadBarang()
        {
            string query = "SELECT * FROM t_barang";
            DataTable dt = (DataTable)koneksi.ShowData(query);

            cmbBarang.DataSource = dt;
            cmbBarang.DisplayMember = "id_barang";
            cmbBarang.ValueMember = "id_barang";
            cmbBarang.SelectedIndex = -1;
        }

        // =====================
        // TAMPIL DATA TRANSAKSI
        // =====================
        void Tampil()
        {
            dgvTransaksi.DataSource = transaksi.Show();
            dgvTransaksi.ClearSelection();
        }

        // =====================
        // RESET FORM
        // =====================
        void ResetForm()
        {
            cmbBarang.SelectedIndex = -1;
            txtNama.Text = "";
            txtHarga.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";

            idTransaksi = 0;

            btnSimpan.Enabled = true;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (cmbBarang.SelectedIndex == -1 || txtQty.Text == "")
            {
                MessageBox.Show("Lengkapi data transaksi!");
                return;
            }

            transaksi.Insert(
                idBarang,
                int.Parse(txtQty.Text),
                int.Parse(txtTotal.Text)
            );

            MessageBox.Show("Transaksi berhasil disimpan");
            ResetForm();
            Tampil();

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idTransaksi == 0)
            {
                MessageBox.Show("Pilih data transaksi terlebih dahulu!");
                return;
            }

            transaksi.Update(
                idTransaksi,
                idBarang,
                int.Parse(txtQty.Text),
                int.Parse(txtTotal.Text)
            );

            MessageBox.Show("Transaksi berhasil diubah");
            ResetForm();
            Tampil();
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (idTransaksi == 0)
            {
                MessageBox.Show("Pilih data transaksi terlebih dahulu!");
                return;
            }

            if (MessageBox.Show("Hapus transaksi?", "Konfirmasi",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                transaksi.Delete(idTransaksi.ToString());
                ResetForm();
                Tampil();
            }
        }

        private void txtQty_TextChanged_1(object sender, EventArgs e)
        {
            if (txtQty.Text == "" || !int.TryParse(txtQty.Text, out int qty))
            {
                txtTotal.Text = "";
                return;
            }

            txtTotal.Text = (qty * harga).ToString();
        }

        private void cmbBarang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbBarang.SelectedIndex == -1) return;

            // ⬇️ CEK DULU JANGAN LANGSUNG CAST
            if (cmbBarang.SelectedValue is DataRowView drv)
            {
                idBarang = Convert.ToInt32(drv["id_barang"]);
            }
            else
            {
                idBarang = Convert.ToInt32(cmbBarang.SelectedValue);
            }

            string query = "SELECT * FROM t_barang WHERE id_barang=@id";
            MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConn());
            cmd.Parameters.AddWithValue("@id", idBarang);

            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtNama.Text = rd["nama_barang"].ToString();
                harga = Convert.ToInt32(rd["harga"]);
                txtHarga.Text = harga.ToString();
            }
            rd.Close();
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idTransaksi = Convert.ToInt32(dgvTransaksi.Rows[e.RowIndex].Cells[0].Value);
            idBarang = Convert.ToInt32(dgvTransaksi.Rows[e.RowIndex].Cells[1].Value);

            cmbBarang.SelectedValue = idBarang;
            txtNama.Text = dgvTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHarga.Text = dgvTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtQty.Text = dgvTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTotal.Text = dgvTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();

            // 🔥 AKTIFKAN TOMBOL
            btnSimpan.Enabled = false;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            save.FileName = "Report Transaksi.xlsx";
            save.OverwritePrompt = false;

            if (save.ShowDialog() == DialogResult.OK)
            {
                string filePath = save.FileName;

                if (File.Exists(filePath))
                    File.Delete(filePath);

                Excel excel_lib = new Excel();
                excel_lib.ExportToExcel(dgvTransaksi, filePath);

                MessageBox.Show(
                    "Data transaksi berhasil diexport ke Excel",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
