using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LeThanhKhai_1150080020_lab2
{
    public partial class Form3 : Form
    {
        private readonly Dictionary<string, string[]> _groupPwds =
            new Dictionary<string, string[]>
            {
                { "Phát triển công nghệ", new[] { "1496", "2673" } },
                { "Nghiên cứu viên",      new[] { "7462" } },
                { "Thiết kế mô hình",     new[] { "8884", "3842", "3383" } }
            };

        private readonly Dictionary<string, string> _pwdToGroup;

        public Form3()
        {
            InitializeComponent();

            var map = new Dictionary<string, string>();
            foreach (var kv in _groupPwds)
                foreach (var p in kv.Value)
                    map[p] = kv.Key;
            _pwdToGroup = map;

            dgvLog.AutoGenerateColumns = false;
            if (dgvLog.Columns.Count == 0)
            {
                dgvLog.Columns.Add("TimeCol", "Ngày giờ");
                dgvLog.Columns.Add("GroupCol", "Nhóm");
                dgvLog.Columns.Add("ResultCol", "Kết quả");
                dgvLog.Columns["TimeCol"].Width = 170;
                dgvLog.Columns["GroupCol"].Width = 180;
                dgvLog.Columns["ResultCol"].Width = 120;
            }

            foreach (var b in new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 })
                b.Click += Digit_Click;

            btnClear.Click += delegate { txtPwd.Text = string.Empty; };
            btnEnter.Click += delegate { DoEnter(); };
            btnRing.Click += delegate { SystemSounds.Beep.Play(); };
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            if (b != null && txtPwd.Text.Length < 4) txtPwd.Text += b.Text;
        }

        private void DoEnter()
        {
            var pwd = txtPwd.Text.Trim();
            txtPwd.Text = string.Empty;
            string grp;
            var ok = _pwdToGroup.TryGetValue(pwd, out grp);
            dgvLog.Rows.Insert(0,
                DateTime.Now.ToString("M/d/yyyy h:mm:ss tt"),
                ok ? grp : "Không có",
                ok ? "Chấp nhận!" : "Từ chối!");
            if (!ok) SystemSounds.Hand.Play();
        }
    }
}
