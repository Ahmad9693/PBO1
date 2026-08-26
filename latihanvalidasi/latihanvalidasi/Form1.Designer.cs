namespace latihanvalidasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNama = new TextBox();
            txtEmail = new TextBox();
            txtUmur = new TextBox();
            txtPassword = new TextBox();
            txtKonfirmasi = new TextBox();
            RBLK = new RadioButton();
            RBPR = new RadioButton();
            cbMasak = new CheckBox();
            cbProgram = new CheckBox();
            cbMenyanyi = new CheckBox();
            cbMenggambar = new CheckBox();
            cbTampilPassword = new CheckBox();
            btnSimpan = new Button();
            BtnReset = new Button();
            btnKeluar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 55);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 89);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Umur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 128);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 211);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Keahlian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 263);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 5;
            label6.Text = "Pasword";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 305);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 6;
            label7.Text = "Konfirmasi Password";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(170, 18);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(160, 23);
            txtNama.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 52);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtUmur
            // 
            txtUmur.Location = new Point(170, 86);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(160, 23);
            txtUmur.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(170, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(160, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtKonfirmasi
            // 
            txtKonfirmasi.Location = new Point(170, 302);
            txtKonfirmasi.Name = "txtKonfirmasi";
            txtKonfirmasi.PasswordChar = '*';
            txtKonfirmasi.Size = new Size(160, 23);
            txtKonfirmasi.TabIndex = 11;
            // 
            // RBLK
            // 
            RBLK.AutoSize = true;
            RBLK.Location = new Point(170, 124);
            RBLK.Name = "RBLK";
            RBLK.Size = new Size(72, 19);
            RBLK.TabIndex = 12;
            RBLK.TabStop = true;
            RBLK.Text = "Laki-Laki";
            RBLK.UseVisualStyleBackColor = true;
            // 
            // RBPR
            // 
            RBPR.AutoSize = true;
            RBPR.Location = new Point(170, 149);
            RBPR.Name = "RBPR";
            RBPR.Size = new Size(86, 19);
            RBPR.TabIndex = 13;
            RBPR.TabStop = true;
            RBPR.Text = "Perempuan";
            RBPR.UseVisualStyleBackColor = true;
            // 
            // cbMasak
            // 
            cbMasak.AutoSize = true;
            cbMasak.Location = new Point(170, 210);
            cbMasak.Name = "cbMasak";
            cbMasak.Size = new Size(77, 19);
            cbMasak.TabIndex = 14;
            cbMasak.Text = "Memasak";
            cbMasak.UseVisualStyleBackColor = true;
            // 
            // cbProgram
            // 
            cbProgram.AutoSize = true;
            cbProgram.Location = new Point(302, 211);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(89, 19);
            cbProgram.TabIndex = 15;
            cbProgram.Text = "Programing";
            cbProgram.UseVisualStyleBackColor = true;
            // 
            // cbMenyanyi
            // 
            cbMenyanyi.AutoSize = true;
            cbMenyanyi.Location = new Point(436, 211);
            cbMenyanyi.Name = "cbMenyanyi";
            cbMenyanyi.Size = new Size(78, 19);
            cbMenyanyi.TabIndex = 16;
            cbMenyanyi.Text = "Menyanyi";
            cbMenyanyi.UseVisualStyleBackColor = true;
            // 
            // cbMenggambar
            // 
            cbMenggambar.AutoSize = true;
            cbMenggambar.Location = new Point(568, 210);
            cbMenggambar.Name = "cbMenggambar";
            cbMenggambar.Size = new Size(98, 19);
            cbMenggambar.TabIndex = 17;
            cbMenggambar.Text = "Menggambar";
            cbMenggambar.UseVisualStyleBackColor = true;
            // 
            // cbTampilPassword
            // 
            cbTampilPassword.AutoSize = true;
            cbTampilPassword.Location = new Point(170, 347);
            cbTampilPassword.Name = "cbTampilPassword";
            cbTampilPassword.Size = new Size(134, 19);
            cbTampilPassword.TabIndex = 18;
            cbTampilPassword.Text = "Tampilkan Password";
            cbTampilPassword.UseVisualStyleBackColor = true;
            cbTampilPassword.CheckedChanged += cbTampilPassword_CheckedChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(51, 382);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(83, 33);
            btnSimpan.TabIndex = 19;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.Lime;
            BtnReset.ForeColor = SystemColors.ActiveCaptionText;
            BtnReset.Location = new Point(200, 382);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(83, 33);
            BtnReset.TabIndex = 20;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = false;
            BtnReset.Click += BtnReset_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Red;
            btnKeluar.Location = new Point(348, 382);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(84, 33);
            btnKeluar.TabIndex = 21;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKeluar);
            Controls.Add(BtnReset);
            Controls.Add(btnSimpan);
            Controls.Add(cbTampilPassword);
            Controls.Add(cbMenggambar);
            Controls.Add(cbMenyanyi);
            Controls.Add(cbProgram);
            Controls.Add(cbMasak);
            Controls.Add(RBPR);
            Controls.Add(RBLK);
            Controls.Add(txtKonfirmasi);
            Controls.Add(txtPassword);
            Controls.Add(txtUmur);
            Controls.Add(txtEmail);
            Controls.Add(txtNama);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNama;
        private TextBox txtEmail;
        private TextBox txtUmur;
        private TextBox txtPassword;
        private TextBox txtKonfirmasi;
        private RadioButton RBLK;
        private RadioButton RBPR;
        private CheckBox cbMasak;
        private CheckBox cbProgram;
        private CheckBox cbMenyanyi;
        private CheckBox cbMenggambar;
        private CheckBox cbTampilPassword;
        private Button btnSimpan;
        private Button BtnReset;
        private Button btnKeluar;
    }
}
