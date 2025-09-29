using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LeThanhKhai_1150080020_lab2
{
    public class Form5 : Form
    {
        TextBox txtNhap;
        Button btnNhap, btnTang2, btnChonChanDau, btnChonSoLeCuoi, btnXoaChon, btnXoaDau, btnXoaCuoi, btnKetThuc, btnXoaDay;
        ListBox lsb;
        Label lblTitle;

        public Form5()
        {
            this.Text = "Ứng dụng xử lý dãy số";
            this.Font = new Font("Segoe UI", 9F);
            this.ClientSize = new Size(520, 420);

            lblTitle = new Label { Text = "Ứng dụng xử lý dãy số", BackColor = Color.Teal, ForeColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Location = new Point(0, 0), Size = new Size(520, 50), Font = new Font("Segoe UI", 16F, FontStyle.Bold) };
            var lblNhap = new Label { Text = "Nhập số nguyên:", Location = new Point(20, 65), AutoSize = true };
            txtNhap = new TextBox { Location = new Point(140, 62), Width = 180 };
            btnNhap = new Button { Text = "Nhập số", Location = new Point(330, 60), Size = new Size(90, 28) };
            var lblList = new Label { Text = "lsbDaySo", Location = new Point(20, 100), AutoSize = true };
            var lblFunc = new Label { Text = "Chức năng:", Location = new Point(300, 100), AutoSize = true };
            lsb = new ListBox { Location = new Point(20, 120), Size = new Size(240, 220) };

            btnTang2 = new Button { Text = "Tăng mỗi phần tử lên 2", Location = new Point(300, 120), Size = new Size(190, 28) };
            btnChonChanDau = new Button { Text = "Chọn số chẵn đầu", Location = new Point(300, 155), Size = new Size(190, 28) };
            btnChonSoLeCuoi = new Button { Text = "Chọn số lẻ cuối", Location = new Point(300, 190), Size = new Size(190, 28) };
            btnXoaChon = new Button { Text = "Xóa phần tử đang chọn", Location = new Point(300, 225), Size = new Size(190, 28) };
            btnXoaDau = new Button { Text = "Xóa phần tử đầu", Location = new Point(300, 260), Size = new Size(190, 28) };
            btnXoaCuoi = new Button { Text = "Xóa phần tử cuối", Location = new Point(300, 295), Size = new Size(190, 28) };

            btnKetThuc = new Button { Text = "Kết thúc ứng dụng", Location = new Point(20, 360), Size = new Size(200, 32), BackColor = Color.IndianRed, ForeColor = Color.White };
            btnXoaDay = new Button { Text = "Xóa dãy số", Location = new Point(300, 360), Size = new Size(190, 32), BackColor = Color.DimGray, ForeColor = Color.White };

            Controls.AddRange(new Control[] {
                lblTitle,lblNhap,txtNhap,btnNhap,lblList,lblFunc,lsb,
                btnTang2,btnChonChanDau,btnChonSoLeCuoi,btnXoaChon,btnXoaDau,btnXoaCuoi,
                btnKetThuc,btnXoaDay
            });

            this.AcceptButton = btnNhap;

            txtNhap.KeyPress += TxtNhap_KeyPress;
            btnNhap.Click += (_, __) => TryAdd();
            btnTang2.Click += (_, __) => Tang2();
            btnChonChanDau.Click += (_, __) => ChonChanDau();
            btnChonSoLeCuoi.Click += (_, __) => ChonLeCuoi();
            btnXoaChon.Click += (_, __) => XoaChon();
            btnXoaDau.Click += (_, __) => { if (lsb.Items.Count > 0) lsb.Items.RemoveAt(0); };
            btnXoaCuoi.Click += (_, __) => { if (lsb.Items.Count > 0) lsb.Items.RemoveAt(lsb.Items.Count - 1); };
            btnXoaDay.Click += (_, __) => lsb.Items.Clear();
            btnKetThuc.Click += (_, __) => Close();
        }

        void TxtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (e.KeyChar == '-' && txtNhap.SelectionStart == 0 && !txtNhap.Text.Contains("-")) return;
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        void TryAdd()
        {
            int v;
            if (int.TryParse(txtNhap.Text.Trim(), out v))
            {
                lsb.Items.Add(v.ToString());
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Nhập số nguyên hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.Focus();
                txtNhap.SelectAll();
            }
        }

        void Tang2()
        {
            var arr = lsb.Items.Cast<object>().Select(x => int.Parse(x.ToString()) + 2).ToArray();
            lsb.Items.Clear();
            foreach (var n in arr) lsb.Items.Add(n.ToString());
        }

        void ChonChanDau()
        {
            for (int i = 0; i < lsb.Items.Count; i++)
            {
                int n = int.Parse(lsb.Items[i].ToString());
                if (n % 2 == 0) { lsb.SelectedIndex = i; return; }
            }
            lsb.ClearSelected();
        }

        void ChonLeCuoi()
        {
            for (int i = lsb.Items.Count - 1; i >= 0; i--)
            {
                int n = int.Parse(lsb.Items[i].ToString());
                if (Math.Abs(n % 2) == 1) { lsb.SelectedIndex = i; return; }
            }
            lsb.ClearSelected();
        }

        void XoaChon()
        {
            if (lsb.SelectedIndex >= 0) lsb.Items.RemoveAt(lsb.SelectedIndex);
        }
    }
}
