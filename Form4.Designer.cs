using System.Windows.Forms;
using System.Drawing;

namespace LeThanhKhai_1150080020_lab2
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblHeader;
        private Label lblTen;
        private TextBox txtTen;
        private CheckBox chkLayCao;
        private CheckBox chkTayTrang;
        private CheckBox chkHan;
        private CheckBox chkBe;
        private CheckBox chkBoc;
        private Label lblLayCaoGia;
        private Label lblTayTrangGia;
        private Label lblHanGia;
        private Label lblBeGia;
        private Label lblBocGia;
        private NumericUpDown nudHan;
        private NumericUpDown nudBe;
        private NumericUpDown nudBoc;
        private Button btnTinh;
        private Button btnThoat;
        private TextBox txtTong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.chkLayCao = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkHan = new System.Windows.Forms.CheckBox();
            this.chkBe = new System.Windows.Forms.CheckBox();
            this.chkBoc = new System.Windows.Forms.CheckBox();
            this.lblLayCaoGia = new System.Windows.Forms.Label();
            this.lblTayTrangGia = new System.Windows.Forms.Label();
            this.lblHanGia = new System.Windows.Forms.Label();
            this.lblBeGia = new System.Windows.Forms.Label();
            this.lblBocGia = new System.Windows.Forms.Label();
            this.nudHan = new System.Windows.Forms.NumericUpDown();
            this.nudBe = new System.Windows.Forms.NumericUpDown();
            this.nudBoc = new System.Windows.Forms.NumericUpDown();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.LimeGreen;
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(520, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(20, 65);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(110, 22);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên khách hàng:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(140, 65);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(300, 23);
            this.txtTen.TabIndex = 2;
            // 
            // chkLayCao
            // 
            this.chkLayCao.Location = new System.Drawing.Point(40, 110);
            this.chkLayCao.Name = "chkLayCao";
            this.chkLayCao.Size = new System.Drawing.Size(104, 24);
            this.chkLayCao.TabIndex = 3;
            this.chkLayCao.Text = "Lấy cao răng";
            // 
            // chkTayTrang
            // 
            this.chkTayTrang.Location = new System.Drawing.Point(40, 140);
            this.chkTayTrang.Name = "chkTayTrang";
            this.chkTayTrang.Size = new System.Drawing.Size(104, 24);
            this.chkTayTrang.TabIndex = 4;
            this.chkTayTrang.Text = "Tẩy trắng răng";
            // 
            // chkHan
            // 
            this.chkHan.Location = new System.Drawing.Point(40, 170);
            this.chkHan.Name = "chkHan";
            this.chkHan.Size = new System.Drawing.Size(104, 24);
            this.chkHan.TabIndex = 5;
            this.chkHan.Text = "Hàn răng";
            // 
            // chkBe
            // 
            this.chkBe.Location = new System.Drawing.Point(40, 200);
            this.chkBe.Name = "chkBe";
            this.chkBe.Size = new System.Drawing.Size(104, 24);
            this.chkBe.TabIndex = 6;
            this.chkBe.Text = "Bẻ răng";
            // 
            // chkBoc
            // 
            this.chkBoc.Location = new System.Drawing.Point(40, 230);
            this.chkBoc.Name = "chkBoc";
            this.chkBoc.Size = new System.Drawing.Size(104, 24);
            this.chkBoc.TabIndex = 7;
            this.chkBoc.Text = "Bọc răng";
            // 
            // lblLayCaoGia
            // 
            this.lblLayCaoGia.Location = new System.Drawing.Point(166, 110);
            this.lblLayCaoGia.Name = "lblLayCaoGia";
            this.lblLayCaoGia.Size = new System.Drawing.Size(200, 22);
            this.lblLayCaoGia.TabIndex = 8;
            this.lblLayCaoGia.Text = "50.000đ";
            // 
            // lblTayTrangGia
            // 
            this.lblTayTrangGia.Location = new System.Drawing.Point(166, 140);
            this.lblTayTrangGia.Name = "lblTayTrangGia";
            this.lblTayTrangGia.Size = new System.Drawing.Size(200, 22);
            this.lblTayTrangGia.TabIndex = 9;
            this.lblTayTrangGia.Text = "100.000đ";
            // 
            // lblHanGia
            // 
            this.lblHanGia.Location = new System.Drawing.Point(166, 170);
            this.lblHanGia.Name = "lblHanGia";
            this.lblHanGia.Size = new System.Drawing.Size(157, 22);
            this.lblHanGia.TabIndex = 10;
            this.lblHanGia.Text = "100.000đ/1 răng";
            // 
            // lblBeGia
            // 
            this.lblBeGia.Location = new System.Drawing.Point(166, 200);
            this.lblBeGia.Name = "lblBeGia";
            this.lblBeGia.Size = new System.Drawing.Size(145, 22);
            this.lblBeGia.TabIndex = 11;
            this.lblBeGia.Text = "10.000đ/1 răng";
            // 
            // lblBocGia
            // 
            this.lblBocGia.Location = new System.Drawing.Point(166, 230);
            this.lblBocGia.Name = "lblBocGia";
            this.lblBocGia.Size = new System.Drawing.Size(145, 22);
            this.lblBocGia.TabIndex = 12;
            this.lblBocGia.Text = "1.000.000đ/1 răng";
            // 
            // nudHan
            // 
            this.nudHan.Location = new System.Drawing.Point(349, 170);
            this.nudHan.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudHan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHan.Name = "nudHan";
            this.nudHan.Size = new System.Drawing.Size(120, 23);
            this.nudHan.TabIndex = 13;
            this.nudHan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBe
            // 
            this.nudBe.Location = new System.Drawing.Point(349, 200);
            this.nudBe.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudBe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBe.Name = "nudBe";
            this.nudBe.Size = new System.Drawing.Size(120, 23);
            this.nudBe.TabIndex = 14;
            this.nudBe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBoc
            // 
            this.nudBoc.Location = new System.Drawing.Point(349, 230);
            this.nudBoc.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudBoc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBoc.Name = "nudBoc";
            this.nudBoc.Size = new System.Drawing.Size(120, 23);
            this.nudBoc.TabIndex = 15;
            this.nudBoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(109, 285);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(90, 30);
            this.btnTinh.TabIndex = 16;
            this.btnTinh.Text = "Tính tiền";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(369, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(209, 287);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(150, 23);
            this.txtTong.TabIndex = 17;
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(517, 360);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.chkLayCao);
            this.Controls.Add(this.chkTayTrang);
            this.Controls.Add(this.chkHan);
            this.Controls.Add(this.chkBe);
            this.Controls.Add(this.chkBoc);
            this.Controls.Add(this.lblLayCaoGia);
            this.Controls.Add(this.lblTayTrangGia);
            this.Controls.Add(this.lblHanGia);
            this.Controls.Add(this.lblBeGia);
            this.Controls.Add(this.lblBocGia);
            this.Controls.Add(this.nudHan);
            this.Controls.Add(this.nudBe);
            this.Controls.Add(this.nudBoc);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form4";
            this.Text = "PHÒNG KHÁM NHA KHOA";
            ((System.ComponentModel.ISupportInitialize)(this.nudHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
