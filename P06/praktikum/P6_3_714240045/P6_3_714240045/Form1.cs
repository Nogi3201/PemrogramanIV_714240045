using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714240045
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessages(TextBox textBox, string warningMessagge, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessagge);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void PerformComparisonValidation()
        {
            bool isAngka1Valid = int.TryParse(txtAngka1.Text, out int angka1);
            bool isAngka2Valid = int.TryParse(txtAngka2.Text, out int angka2);

            epWarning.SetError(txtAngka1, "");
            epWrong.SetError(txtAngka1, "");
            epCorrect.SetError(txtAngka1, "");
            epWarning.SetError(txtAngka2, "");
            epWrong.SetError(txtAngka2, "");
            epCorrect.SetError(txtAngka2, "");

            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtAngka1, "Angka 1 wajib diisi untuk perbandingan!", "", "");
                SetErrorMessages(txtAngka2, "", "", "Betul!"); 
                return;
            }

            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Angka 2 wajib diisi untuk perbandingan!", "", "");
                SetErrorMessages(txtAngka1, "", "", "Betul!"); 
                return;
            }

            if (!isAngka1Valid)
            {
                SetErrorMessages(txtAngka1, "", "Inputan Salah, Hanya Boleh Angka!", "");
                SetErrorMessages(txtAngka2, "", "", "Betul!");
                return;
            }
            if (!isAngka2Valid)
            {
                SetErrorMessages(txtAngka2, "", "Inputan Salah, Hanya Boleh Angka!", "");
                SetErrorMessages(txtAngka1, "", "", "Betul!");
                return;
            }

            if (angka1 > angka2)
            {
                SetErrorMessages(txtAngka1, "", "", "Angka 1 lebih besar (BENAR)");
                SetErrorMessages(txtAngka2, "", "", "Angka 2 lebih kecil (BENAR)");
            }
            else
            {
                SetErrorMessages(txtAngka1, "", "Angka 1 harus lebih besar dari Angka 2!", "");
                SetErrorMessages(txtAngka2, "", "Angka 2 harus lebih kecil dari Angka 1!", "");
            }
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text.Length == 0)
            {
                SetErrorMessages(txtHuruf, "TextBox Huruf Tidak Boleh Kosong!", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtHuruf, "", "Inputan Salah, Hanya Boleh Huruf", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessages(txtAngka, "TextBox Angka Tidak Boleh Kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka, "", "Inputan Salah, Hanya Boleh angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtAngka1, "TextBox Angka1 wajib diisi!", "", "");
                return;
            }

            if (!txtAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka1, "", "Inputan Salah, Hanya Boleh Angka!", "");
                return;
            }

            SetErrorMessages(txtAngka1, "", "", "Betul!");

            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Angka 2 belum diisi, mohon lengkapi.");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }

            PerformComparisonValidation();
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "TextBox Angka2 wajib diisi!", "", "");
                epWarning.SetError(txtAngka2, "");
                return;
            }

            if (!txtAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka2, "", "Inputan Salah, Hanya Boleh Angka!", "");
                epWarning.SetError(txtAngka2, "");
                return;
            }

            SetErrorMessages(txtAngka2, "", "", "Betul!");

            PerformComparisonValidation();
        }
    }
}
