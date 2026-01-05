using P9_714240045.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240045.view
{
    public partial class FormBarang : Form
    {
        Barang barang = new Barang();
        M_barang m_barang = new M_barang();
        string id_barang;

        public FormBarang()
        {
            InitializeComponent();
            Tampil();
        }


        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        // =====================
        // TAMPIL DATA
        // =====================
        public void Tampil()
        {
            dgvBarang.DataSource = barang.Show();

            dgvBarang.Columns[0].HeaderText = "ID";
            dgvBarang.Columns[1].HeaderText = "Nama Barang";
            dgvBarang.Columns[2].HeaderText = "Harga";

            // ⬇️ TAMBAHKAN INI
            dgvBarang.ClearSelection();
        }


        // =====================
        // RESET FORM
        // =====================
        void ResetForm()
        {
            txtNamaBarang.Text = "";
            txtHarga.Text = "";
            txtCari.Text = "";
            id_barang = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (txtNamaBarang.Text == "" || txtHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong");
                return;
            }

            m_barang.NamaBarang = txtNamaBarang.Text;
            m_barang.Harga = int.Parse(txtHarga.Text);

            barang.Insert(m_barang);
            MessageBox.Show("Data berhasil disimpan");

            ResetForm();
            Tampil();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            if (id_barang == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }

            m_barang.NamaBarang = txtNamaBarang.Text;
            m_barang.Harga = int.Parse(txtHarga.Text);

            barang.Update(m_barang, id_barang);
            ResetForm();
            Tampil();
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (id_barang == null) return;

            if (MessageBox.Show("Yakin hapus data?", "Konfirmasi",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                barang.Delete(id_barang);
                ResetForm();
                Tampil();
            }
        }

        private void txtCari_TextChanged_1(object sender, EventArgs e)
        {
            dgvBarang.DataSource = txtCari.Text == ""
                ? barang.Show()
                : barang.Search(txtCari.Text);
        }

        private void dgvBarang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id_barang = dgvBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaBarang.Text = dgvBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHarga.Text = dgvBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}