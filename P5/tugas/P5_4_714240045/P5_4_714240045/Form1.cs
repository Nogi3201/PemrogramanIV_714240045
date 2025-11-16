using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714240045
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- Event Handler Tombol Tampilkan (button1_Click) ---
        private void button1_Click(object sender, EventArgs e)
        {
            // PENTING: GANTI NAMA VARIABEL INI JIKA TIDAK SESUAI DENGAN DESIGNER ANDA

            // --- 1. Validasi Pilihan Kelas (CheckBox) ---
            bool kelasDipilih = chkSepakBola.Checked || chkBasket.Checked || chkRenang.Checked ||
                                chkBuluTangkis.Checked || chkTenis.Checked || chkVoli.Checked ||
                                chkYoga.Checked || chkPanahan.Checked;

            if (!kelasDipilih)
            {
                // Tampilkan pesan error jika tidak ada kelas yang dipilih
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hentikan proses
            }

            // --- 2. Validasi Pilihan Jadwal (RadioButton) ---
            bool jadwalDipilih = rdoSeninRabu.Checked || rdoSelasaKamis.Checked ||
                                 rdoSabtuMinggu.Checked || rdoMinggu.Checked;

            if (!jadwalDipilih)
            {
                // Tampilkan pesan error jika tidak ada jadwal yang dipilih
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hentikan proses
            }

            // Jika semua validasi lolos, lanjutkan ke tahap menampilkan hasil.
            TampilkanInformasiPendaftaran();
        }

        // --- Event Handler Tombol Selesai (btnSelesai_Click) ---
        private void btnSelesai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- Metode Pengumpulan dan Tampilan Informasi ---
        private void TampilkanInformasiPendaftaran()
        {
            // PENTING: GANTI NAMA VARIABEL INI JIKA TIDAK SESUAI DENGAN DESIGNER ANDA

            // --- 1. Ambil Data Dasar ---
            string nama = Nama.Text;
            string jenisKelamin = cmbJenisKelamin.Text;
            string tanggalLahir = dtpTanggalLahir.Value.ToString("dd MMMM yyyy");

            // --- 2. Kumpulkan Pilihan Kelas (CheckBox) ---
            List<string> pilihanKelas = new List<string>();

            if (chkSepakBola.Checked) pilihanKelas.Add("Sepak Bola");
            if (chkBasket.Checked) pilihanKelas.Add("Basket");
            if (chkRenang.Checked) pilihanKelas.Add("Renang");
            if (chkBuluTangkis.Checked) pilihanKelas.Add("Bulu Tangkis");
            if (chkTenis.Checked) pilihanKelas.Add("Tenis");
            if (chkVoli.Checked) pilihanKelas.Add("Voli");
            if (chkYoga.Checked) pilihanKelas.Add("Yoga");
            if (chkPanahan.Checked) pilihanKelas.Add("Panahan");

            string kelasString = string.Join(", ", pilihanKelas);

            // --- 3. Ambil Pilihan Jadwal (RadioButton) ---
            string jadwalDipilih = "";

            if (rdoSeninRabu.Checked)
                jadwalDipilih = "Senin s/d Rabu, 14.00 - 16.00";
            else if (rdoSelasaKamis.Checked)
                jadwalDipilih = "Selasa s/d Kamis, 14.00 - 16.00";
            else if (rdoSabtuMinggu.Checked)
                // Menggunakan label yang muncul di output contoh: Jum'at s/d Minggu
                jadwalDipilih = "Jum'at s/d Minggu, 09.00 - 11.00";
            else if (rdoMinggu.Checked)
                jadwalDipilih = "Minggu, 13.00 - 20.00";

            // --- 4. Susun dan Tampilkan Pesan ---
            string informasi = $"Nama: {nama}\n" +
                               $"Jenis Kelamin: {jenisKelamin}\n" +
                               $"Tanggal Lahir: {tanggalLahir}\n" +
                               $"Pilihan Kelas: {kelasString}\n" +
                               $"Pilihan Jadwal: {jadwalDipilih}";

            MessageBox.Show(informasi, "Informasi Pendaftaran",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Event Handlers Kosong Anda yang lain (biarkan kosong atau hapus jika tidak terpakai) ---
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void KolomIsiNama_TextChanged(object sender, EventArgs e) { }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton7_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox5_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
    }
}