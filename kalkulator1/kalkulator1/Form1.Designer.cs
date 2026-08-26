namespace kalkulator1
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
            txtAngka1 = new TextBox();
            txtAngka2 = new TextBox();
            txtHasil = new TextBox();
            btnPangkat = new Button();
            btnKali = new Button();
            btnTambah = new Button();
            btnMod = new Button();
            btnBagi = new Button();
            btnKurang = new Button();
            btnBatal = new Button();
            btnKeluar = new Button();
            label4 = new Label();
            kalkulator = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 112);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Angka 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 168);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Angka2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 225);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Hasil";
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(147, 109);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(60, 23);
            txtAngka1.TabIndex = 3;
            txtAngka1.Text = "5";
            txtAngka1.TextChanged += txtAngka1_TextChanged;
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(147, 160);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(60, 23);
            txtAngka2.TabIndex = 4;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(135, 222);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(100, 23);
            txtHasil.TabIndex = 5;
            // 
            // btnPangkat
            // 
            btnPangkat.BackColor = Color.Cyan;
            btnPangkat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPangkat.Location = new Point(269, 216);
            btnPangkat.Name = "btnPangkat";
            btnPangkat.Size = new Size(49, 33);
            btnPangkat.TabIndex = 6;
            btnPangkat.Text = "^";
            btnPangkat.UseVisualStyleBackColor = false;
            btnPangkat.Click += btnPangkat_Click;
            // 
            // btnKali
            // 
            btnKali.BackColor = Color.Cyan;
            btnKali.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKali.Location = new Point(269, 154);
            btnKali.Name = "btnKali";
            btnKali.Size = new Size(49, 33);
            btnKali.TabIndex = 7;
            btnKali.Text = "x";
            btnKali.UseVisualStyleBackColor = false;
            btnKali.Click += btnKali_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Cyan;
            btnTambah.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.Location = new Point(269, 103);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(49, 33);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += button3_Click;
            // 
            // btnMod
            // 
            btnMod.BackColor = Color.Cyan;
            btnMod.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMod.Location = new Point(353, 216);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(48, 33);
            btnMod.TabIndex = 9;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = false;
            // 
            // btnBagi
            // 
            btnBagi.BackColor = Color.Cyan;
            btnBagi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBagi.Location = new Point(353, 154);
            btnBagi.Name = "btnBagi";
            btnBagi.Size = new Size(48, 33);
            btnBagi.TabIndex = 10;
            btnBagi.Text = "/";
            btnBagi.UseVisualStyleBackColor = false;
            btnBagi.Click += btnBagi_Click;
            // 
            // btnKurang
            // 
            btnKurang.BackColor = Color.Cyan;
            btnKurang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKurang.Location = new Point(353, 103);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(48, 33);
            btnKurang.TabIndex = 11;
            btnKurang.Text = "-";
            btnKurang.UseVisualStyleBackColor = false;
            btnKurang.Click += btnKurang_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Cyan;
            btnBatal.Location = new Point(46, 337);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(67, 38);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += button7_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Cyan;
            btnKeluar.Location = new Point(353, 337);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(76, 38);
            btnKeluar.TabIndex = 13;
            btnKeluar.Text = "keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Cyan;
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(46, 279);
            label4.Name = "label4";
            label4.Size = new Size(397, 15);
            label4.TabIndex = 14;
            label4.Text = "                                                                                                                                  ";
            label4.Click += label4_Click;
            // 
            // kalkulator
            // 
            kalkulator.AutoSize = true;
            kalkulator.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kalkulator.Location = new Point(135, 29);
            kalkulator.Name = "kalkulator";
            kalkulator.Size = new Size(191, 37);
            kalkulator.TabIndex = 15;
            kalkulator.Text = "KALKULATOR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Cyan;
            label6.Location = new Point(28, 9);
            label6.Name = "label6";
            label6.Size = new Size(415, 15);
            label6.TabIndex = 16;
            label6.Text = "                                                                                                                                        ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Cyan;
            label7.Location = new Point(31, 76);
            label7.Name = "label7";
            label7.Size = new Size(412, 15);
            label7.TabIndex = 17;
            label7.Text = "                                                                                                                                       ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(kalkulator);
            Controls.Add(label4);
            Controls.Add(btnKeluar);
            Controls.Add(btnBatal);
            Controls.Add(btnKurang);
            Controls.Add(btnBagi);
            Controls.Add(btnMod);
            Controls.Add(btnTambah);
            Controls.Add(btnKali);
            Controls.Add(btnPangkat);
            Controls.Add(txtHasil);
            Controls.Add(txtAngka2);
            Controls.Add(txtAngka1);
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
        private TextBox txtAngka1;
        private TextBox txtAngka2;
        private TextBox txtHasil;
        private Button btnPangkat;
        private Button btnKali;
        private Button btnTambah;
        private Button btnMod;
        private Button btnBagi;
        private Button btnKurang;
        private Button btnBatal;
        private Button btnKeluar;
        private Label label4;
        private Label kalkulator;
        private Label label6;
        private Label label7;
    }
}
