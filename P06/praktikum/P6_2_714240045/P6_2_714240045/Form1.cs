using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_2_714240045
{
    public partial class Form1 : Form
    {
        private string filepath;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult userResponse = openFileDialog1.ShowDialog();

                if (userResponse == DialogResult.OK)
                {
                    filepath = openFileDialog1.FileName.ToString();
                    MessageBox.Show("You successfully Opened: ' " + filepath + "'", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("You cancelled the Open File Dialog", "Cancelled",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Erros",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
