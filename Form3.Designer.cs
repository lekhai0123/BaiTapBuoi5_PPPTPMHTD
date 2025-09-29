using System.Windows.Forms;

namespace LeThanhKhai_1150080020_lab2
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtPwd;
        private Label lblPwd;
        private Label lblKb;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnClear;
        private Button btnEnter;
        private Button btnRing;
        private Label lblLog;
        private DataGridView dgvLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblKb = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(110, 10);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.ReadOnly = true;
            this.txtPwd.Size = new System.Drawing.Size(250, 20);
            this.txtPwd.TabIndex = 0;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(12, 13);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(56, 13);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "Password:";
            // 
            // lblKb
            // 
            this.lblKb.AutoSize = true;
            this.lblKb.Location = new System.Drawing.Point(12, 50);
            this.lblKb.Name = "lblKb";
            this.lblKb.Size = new System.Drawing.Size(55, 13);
            this.lblKb.TabIndex = 2;
            this.lblKb.Text = "Keyboard:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(60, 80);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 40);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(120, 80);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 40);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(180, 80);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 40);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(60, 130);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 40);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(120, 130);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 40);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(180, 130);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 40);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(60, 180);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 40);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(120, 180);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 40);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(180, 180);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 40);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Location = new System.Drawing.Point(270, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Lime;
            this.btnEnter.Location = new System.Drawing.Point(270, 130);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(90, 40);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnRing
            // 
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.Location = new System.Drawing.Point(270, 180);
            this.btnRing.Name = "btnRing";
            this.btnRing.Size = new System.Drawing.Size(90, 40);
            this.btnRing.TabIndex = 14;
            this.btnRing.Text = "RING";
            this.btnRing.UseVisualStyleBackColor = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 250);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(57, 13);
            this.lblLog.TabIndex = 15;
            this.lblLog.Text = "Login Log:";
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.Location = new System.Drawing.Point(15, 275);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.Size = new System.Drawing.Size(500, 170);
            this.dgvLog.TabIndex = 16;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(540, 460);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblKb);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRing);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.dgvLog);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
