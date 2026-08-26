using System.Diagnostics.Eventing.Reader;

namespace kalkulator1
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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y;

            if (double.TryParse(txtAngka1.Text, out x) &&
                double.TryParse(txtAngka2.Text, out y))
            {
                txtHasil.Text = (x + y).ToString();
            }
            else
            {
                MessageBox.Show("Massukan angka yang valid!");
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtAngka1.Text);
            double y = double.Parse(txtAngka2.Text);
            txtHasil.Text = (x - y).ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            double x, y;

            if (double.TryParse(txtAngka1.Text, out x) &&
                double.TryParse(txtAngka2.Text, out y))
            {
                txtHasil.Text = (x * y).ToString();
            }
            else
            {
                MessageBox.Show("Massukan angka yang valid!");
            }
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            double x, y;

            if (double.TryParse(txtAngka1.Text, out x) &&
               double.TryParse(txtAngka2.Text, out y))
            {
                if (y == 0)
                {
                    MessageBox.Show("Pembagi tidak boleh 0!");
                    return;
                }
                txtHasil.Text = (x / y).ToString("F2");
            }
            else
            {
                MessageBox.Show("Massukan angka yang valid!");
            }
        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPangkat_Click(object sender, EventArgs e)
        {
            double x, y;

            if (double.TryParse(txtAngka1.Text, out x) &&
               double.TryParse(txtAngka2.Text, out y))
            {
                double hasil = Math.Pow(x, y);

                txtHasil.Text = hasil.ToString();

            }
            else
            {
                MessageBox.Show("Massukan angka yang valid!");
            }
        }
    }
}
