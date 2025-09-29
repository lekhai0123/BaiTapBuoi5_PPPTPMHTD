using System;
using System.Drawing;
using System.Windows.Forms;

namespace LeThanhKhai_1150080020_lab2
{
    public class Form5 : Form
    {
        TextBox txtUser, txtPass;
        Button btnOK, btnExit;
        ErrorProvider ep = new ErrorProvider();

        public Form5()
        {
            this.Text = "Đăng nhập";
            this.Font = new Font("Segoe UI", 9F);
            this.ClientSize = new Size(360, 160);
            var lblU = new Label { Text = "Username:", Location = new Point(20, 25), AutoSize = true };
            var lblP = new Label { Text = "Password:", Location = new Point(20, 65), AutoSize = true };
            txtUser = new TextBox { Location = new Point(110, 22), Width = 210 };
            txtPass = new TextBox { Location = new Point(110, 62), Width = 210, UseSystemPasswordChar = true };
            btnOK = new Button { Text = "Đăng nhập", Location = new Point(110, 105), Size = new Size(100, 28) };
            btnExit = new Button { Text = "Thoát", Location = new Point(220, 105), Size = new Size(100, 28) };
            btnOK.Click += BtnOK_Click;
            btnExit.Click += (_, __) => Close();
            this.AcceptButton = btnOK;
            Controls.AddRange(new Control[] { lblU, lblP, txtUser, txtPass, btnOK, btnExit });
        }

        void BtnOK_Click(object sender, EventArgs e)
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtUser.Text)) { ep.SetError(txtUser, "Không được để trống"); ok = false; } else ep.SetError(txtUser, null);
            if (string.IsNullOrWhiteSpace(txtPass.Text)) { ep.SetError(txtPass, "Không được để trống"); ok = false; } else ep.SetError(txtPass, null);
            if (!ok) return;
            Hide();
            var f = new Form5();
            f.FormClosed += (_, __) => Close();
            f.Show();
        }
    }
}
