using P9_714240045.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240045
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formMhs = new Form1();
            formMhs.MdiParent = this;
            formMhs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void dataNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNilai formNilai = new FormNilai();
            formNilai.MdiParent = this;
            formNilai.Show();
        }

        private void dataMasterBarangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormBarang fb = new FormBarang();
            fb.MdiParent = this;
            fb.Show();
        }

        private void dataTransaksiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormTransaksi ft = new FormTransaksi();
            ft.MdiParent = this;
            ft.Show();
        }
    }
}
