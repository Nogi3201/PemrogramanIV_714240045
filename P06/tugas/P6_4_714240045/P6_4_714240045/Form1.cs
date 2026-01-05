using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace P6_4_714240045
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ========== VALIDASI HURUF SAJA ==========
        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // ========== VALIDASI ANGKA SAJA ==========
        private void txtNIM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ========== SUBMIT ==========
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // REQUIRED VALIDATOR
            if (txtNama.Text == "" || txtNIM.Text == "" || txtEmail.Text == "" ||
                txtUsia.Text == "" || txtKelas.Text == "" ||
                txtPassword.Text == "" || txtPassword2.Text == "")
            {
                MessageBox.Show("Semua field wajib diisi!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // REGEX VALIDATOR (EMAIL)
            var regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regexEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Format email tidak valid!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // COMPARISON : USIA >= 17
            if (int.Parse(txtUsia.Text) < 17)
            {
                MessageBox.Show("Usia minimal 17 tahun!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // LENGTH VALIDATOR : PASSWORD MINIMAL 6 KARAKTER
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // COMPARISON : PASSWORD == KONFIRMASI
            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Konfirmasi password tidak cocok!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ========== OUTPUT ==========
            string output =
                $"Nama: {txtNama.Text}\n" +
                $"NIM: {txtNIM.Text}\n" +
                $"Email: {txtEmail.Text}\n" +
                $"Usia: {txtUsia.Text}\n" +
                $"Kelas: {txtKelas.Text}";

            MessageBox.Show(output, "Data Berhasil Disubmit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
