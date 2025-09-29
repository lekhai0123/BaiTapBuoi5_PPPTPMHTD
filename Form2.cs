using System;
using System.Windows.Forms;

namespace LeThanhKhai_1150080020_lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private static long Gcd(long a, long b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            while (b != 0) { long t = a % b; a = b; b = t; }
            return a; // gcd(0,0) = 0
        }

        private static long Lcm(long a, long b)
        {
            if (a == 0 || b == 0) return 0;
            return Math.Abs(a / Gcd(a, b) * b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                long a = Convert.ToInt64(txtA.Text.Trim());
                long b = Convert.ToInt64(txtB.Text.Trim());

                long kq = rdoUscln.Checked ? Gcd(a, b) : Lcm(a, b);
                txtKq.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
