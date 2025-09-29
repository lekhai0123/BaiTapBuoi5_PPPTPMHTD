using System.Drawing;
using System.Windows.Forms;

namespace LeThanhKhai_1150080020_lab2
{
    partial class Form2
    {
        private GroupBox grpNhap;
        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;

        private GroupBox grpChon;
        private RadioButton rdoUscln;
        private RadioButton rdoBscnn;

        private GroupBox grpKq;
        private Label lblKq;
        private TextBox txtKq;
        private Button btnTim;
        private Button btnThoat;

        private void InitializeComponent()
        {
            this.grpNhap = new GroupBox();
            this.lblA = new Label();
            this.lblB = new Label();
            this.txtA = new TextBox();
            this.txtB = new TextBox();

            this.grpChon = new GroupBox();
            this.rdoUscln = new RadioButton();
            this.rdoBscnn = new RadioButton();

            this.grpKq = new GroupBox();
            this.lblKq = new Label();
            this.txtKq = new TextBox();
            this.btnTim = new Button();
            this.btnThoat = new Button();

            this.SuspendLayout();
            // Form
            this.ClientSize = new Size(520, 260);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Tìm USCLN và BSCNN của a, b";

            // grpNhap
            this.grpNhap.Text = "Nhập dữ liệu:";
            this.grpNhap.BackColor = Color.Honeydew;
            this.grpNhap.Location = new Point(12, 12);
            this.grpNhap.Size = new Size(320, 120);

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new Point(18, 35);
            this.lblA.Text = "Số nguyên a:";
            // txtA
            this.txtA.Location = new Point(120, 32);
            this.txtA.Size = new Size(170, 20);

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location = new Point(18, 75);
            this.lblB.Text = "Số nguyên b:";
            // txtB
            this.txtB.Location = new Point(120, 72);
            this.txtB.Size = new Size(170, 20);

            this.grpNhap.Controls.AddRange(new Control[] { this.lblA, this.txtA, this.lblB, this.txtB });

            // grpChon
            this.grpChon.Text = "Tùy chọn:";
            this.grpChon.Location = new Point(350, 12);
            this.grpChon.Size = new Size(150, 120);

            // rdoUscln
            this.rdoUscln.AutoSize = true;
            this.rdoUscln.Location = new Point(20, 35);
            this.rdoUscln.Text = "USCLN";
            this.rdoUscln.Checked = true;

            // rdoBscnn
            this.rdoBscnn.AutoSize = true;
            this.rdoBscnn.Location = new Point(20, 75);
            this.rdoBscnn.Text = "BSCNN";

            this.grpChon.Controls.AddRange(new Control[] { this.rdoUscln, this.rdoBscnn });

            // grpKq
            this.grpKq.Text = "Kết quả:";
            this.grpKq.Location = new Point(12, 145);
            this.grpKq.Size = new Size(488, 95);

            // lblKq
            this.lblKq.AutoSize = true;
            this.lblKq.Location = new Point(18, 43);
            this.lblKq.Text = "";

            // txtKq
            this.txtKq.Location = new Point(21, 38);
            this.txtKq.Size = new Size(280, 20);
            this.txtKq.ReadOnly = true;

            // btnTim
            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new Point(330, 30);
            this.btnTim.Size = new Size(65, 32);
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            // btnThoat
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(405, 30);
            this.btnThoat.Size = new Size(65, 32);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.grpKq.Controls.AddRange(new Control[] { this.txtKq, this.btnTim, this.btnThoat });

            // add to form
            this.Controls.AddRange(new Control[] { this.grpNhap, this.grpChon, this.grpKq });

            this.ResumeLayout(false);
        }
    }
}
