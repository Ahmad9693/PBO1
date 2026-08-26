namespace latihanvalidasi
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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtNama.Clear();
            txtUmur.Clear();
            txtPassword.Clear();
            txtKonfirmasi.Clear();

            //Reset RadioButton
            RBLK.Checked = false;
            RBPR.Checked = false;

            // Reset Checkbox
            cbMasak.Checked = false;
            cbMenggambar.Checked = false;
            cbMenyanyi.Checked = false;
            cbProgram.Checked = false;
            cbTampilPassword.Checked = false;
        }

        private void cbTampilPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTampilPassword.Checked)
            {
                // tampilkan password
                txtPassword.PasswordChar = '\0';  // '\0' Artinya karakter kosong
                txtKonfirmasi.PasswordChar = '\0';
            }
            else
            {
                // sembunyikan password dengan bintang
                txtPassword.PasswordChar = '*';
                txtKonfirmasi.PasswordChar = '*';
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string email = txtEmail.Text.Trim();
            int umur;
            string password = txtPassword.Text;
            string konfirmasi = txtKonfirmasi.Text;

            // validasi Nama
            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }
            // validasi Email
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;

            }
            else if (!email.Contains("@") || !email.Contains(""))
            {
                MessageBox.Show("Format email tidak valid!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUmur.Focus();
                return;

            }
            // validasi Umur

            if (string.IsNullOrWhiteSpace(txtUmur.Text))
            {
                MessageBox.Show("Umur tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUmur.Focus();
                return;
            }
            else if (!int.TryParse(txtUmur.Text.Trim(), out umur))
            {
                MessageBox.Show("Umur harus berupa angka!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUmur.Focus();
                return;
            }
            else if (umur < 17)
            {
                MessageBox.Show("Umur minimal 17 tahun!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUmur.Focus();
                return;
            }
            //Validasi RadfioButton (Jenis Kelamin)

            string jk = "";
            if (RBLK.Checked)
                jk = "Laki-laki";
            else if (RBPR.Checked)
                jk = "Perempuan";
            else
            {
                MessageBox.Show("Jenis kelamin harus dipilih!", "peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //validasi Chrckbox (Keahlian)

            string keahlian = "";
            if (cbMasak.Checked) keahlian += "Memasak, ";
            if (cbProgram.Checked) keahlian += "Programing, ";
            if (cbMenyanyi.Checked) keahlian += "Menyanyi, ";
            if (cbMenggambar.Checked) keahlian += "Menggambar, ";

            if (string.IsNullOrEmpty(keahlian))
            {
                MessageBox.Show("Pilih minimal satu hobi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // hapus koma terakhir
            if (keahlian.EndsWith(", ")) keahlian = keahlian.Substring(0,
                keahlian.Length - 2);

            //kalau semua valid
            MessageBox.Show("Data berhasil di simpan:" +
                "\nNama: " + nama +
                "\nEmail: " + email +
                "\nUmur: " + umur +
                "\nJenis kelamin: " + jk +
                "\nKeahlian: " + keahlian,
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //validasi password
            if (password.Length < 6)
            {
                MessageBox.Show("Password dan konfirmasi tidak sama!", "peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            //validasi konfirmasi
            if (password != konfirmasi)
            {
                MessageBox.Show("password dan konfirmasi tidak sama!", "peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKonfirmasi.Focus();
                return;
            }

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Apakah anda yakin ingin keluar?", "konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}