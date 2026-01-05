namespace P6_4_714240045
{
    partial class Form1
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsia = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();

            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsia = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();

            this.btnSubmit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(100, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(290, 32);
            this.lblJudul.Text = "Form Validasi Mahasiswa";

            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(20, 70);
            this.lblNama.Name = "lblNama";
            this.lblNama.Text = "Nama (Huruf saja):";

            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Location = new System.Drawing.Point(20, 110);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Text = "NIM (Angka saja):";

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email (Regex):";

            // 
            // lblUsia
            // 
            this.lblUsia.AutoSize = true;
            this.lblUsia.Location = new System.Drawing.Point(20, 190);
            this.lblUsia.Name = "lblUsia";
            this.lblUsia.Text = "Usia (>= 17):";

            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(20, 230);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Text = "Kelas (Huruf Kapital):";

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 270);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Password (min 6 karakter):";

            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(20, 310);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Text = "Konfirmasi Password:";

            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(200, 67);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(230, 27);
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);

            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(200, 107);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(230, 27);
            this.txtNIM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIM_KeyPress);

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 27);

            // 
            // txtUsia
            // 
            this.txtUsia.Location = new System.Drawing.Point(200, 187);
            this.txtUsia.Name = "txtUsia";
            this.txtUsia.Size = new System.Drawing.Size(230, 27);
            this.txtUsia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIM_KeyPress);

            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(200, 227);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(230, 27);
            this.txtKelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(200, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 27);
            this.txtPassword.PasswordChar = '*';

            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(200, 307);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(230, 27);
            this.txtPassword2.PasswordChar = '*';

            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(200, 350);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 35);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(470, 420);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNIM);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsia);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPassword2);

            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsia);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPassword2);

            this.Controls.Add(this.btnSubmit);

            this.Name = "Form1";
            this.Text = "P6_4_714240045";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsia;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPassword2;

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsia;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword2;

        private System.Windows.Forms.Button btnSubmit;
    }
}
