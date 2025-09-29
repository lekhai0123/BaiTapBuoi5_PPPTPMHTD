using System;
using System.Globalization;
using System.Windows.Forms;

namespace LeThanhKhai_1150080020_lab2
{
    public partial class Form4 : Form
    {
        readonly decimal G_LayCao = 50000m;
        readonly decimal G_TayTrang = 100000m;
        readonly decimal G_Han = 100000m;
        readonly decimal G_Be = 10000m;
        readonly decimal G_Boc = 1000000m;
        readonly ErrorProvider ep = new ErrorProvider();

        public Form4()
        {
            InitializeComponent();
            nudHan.Enabled = false;
            nudBe.Enabled = false;
            nudBoc.Enabled = false;
            chkHan.CheckedChanged += (_, __) => nudHan.Enabled = chkHan.Checked;
            chkBe.CheckedChanged += (_, __) => nudBe.Enabled = chkBe.Checked;
            chkBoc.CheckedChanged += (_, __) => nudBoc.Enabled = chkBoc.Checked;
            btnTinh.Click += (_, __) => Tinh();
            btnThoat.Click += (_, __) => Close();
        }

        void Tinh()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                ep.SetError(txtTen, "Không được để trống");
                txtTen.Focus();
                return;
            }
            ep.SetError(txtTen, null);

            decimal sum = 0;
            if (chkLayCao.Checked) sum += G_LayCao;
            if (chkTayTrang.Checked) sum += G_TayTrang;
            if (chkHan.Checked) sum += G_Han * nudHan.Value;
            if (chkBe.Checked) sum += G_Be * nudBe.Value;
            if (chkBoc.Checked) sum += G_Boc * nudBoc.Value;

            txtTong.Text = string.Format(new CultureInfo("vi-VN"), "{0:n0} đ", sum);
        }
    }
}
