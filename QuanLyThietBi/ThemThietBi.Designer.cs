namespace QuanLyThietBi
{
    partial class ThemThietBi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel5 = new Panel();
            btnHuy = new Button();
            btnThem = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelIP = new FlowLayoutPanel();
            cbIP = new CheckBox();
            notAss = new Label();
            tbIP = new TextBox();
            tbDonViTinh = new TextBox();
            label5 = new Label();
            cbTrangThai = new ComboBox();
            tbMaThietBi = new TextBox();
            cbPhongBan = new ComboBox();
            cbLoaiThietBi = new ComboBox();
            label6 = new Label();
            tbSeri = new TextBox();
            tbModel = new TextBox();
            label8 = new Label();
            tbHang = new TextBox();
            label9 = new Label();
            tbCauHinh = new TextBox();
            label10 = new Label();
            tbLoaiKetNoi = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            dateSuDung = new DateTimePicker();
            dateBaoHanh = new DateTimePicker();
            dateBaoTri = new DateTimePicker();
            dateMua = new DateTimePicker();
            label7 = new Label();
            label15 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tbGia = new TextBox();
            label16 = new Label();
            label17 = new Label();
            tbGhiChu = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label19 = new Label();
            label20 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label18 = new Label();
            label21 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label1 = new Label();
            label22 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label3 = new Label();
            label23 = new Label();
            panel1 = new Panel();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelIP.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(btnHuy);
            panel5.Controls.Add(btnThem);
            panel5.Controls.Add(tableLayoutPanel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(858, 579);
            panel5.TabIndex = 4;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.IndianRed;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = SystemColors.ButtonHighlight;
            btnHuy.Location = new Point(624, 532);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 35);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.CornflowerBlue;
            btnThem.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.Control;
            btnThem.Location = new Point(740, 532);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 35);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.54808F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.7241383F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.83908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.7259617F));
            tableLayoutPanel1.Controls.Add(panelIP, 0, 9);
            tableLayoutPanel1.Controls.Add(tbDonViTinh, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(cbTrangThai, 1, 1);
            tableLayoutPanel1.Controls.Add(tbMaThietBi, 1, 0);
            tableLayoutPanel1.Controls.Add(cbPhongBan, 3, 1);
            tableLayoutPanel1.Controls.Add(cbLoaiThietBi, 3, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(tbSeri, 1, 3);
            tableLayoutPanel1.Controls.Add(tbModel, 3, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(tbHang, 1, 4);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(tbCauHinh, 1, 5);
            tableLayoutPanel1.Controls.Add(label10, 0, 6);
            tableLayoutPanel1.Controls.Add(tbLoaiKetNoi, 1, 6);
            tableLayoutPanel1.Controls.Add(label11, 0, 7);
            tableLayoutPanel1.Controls.Add(label12, 0, 8);
            tableLayoutPanel1.Controls.Add(label13, 2, 7);
            tableLayoutPanel1.Controls.Add(label14, 2, 8);
            tableLayoutPanel1.Controls.Add(dateSuDung, 3, 7);
            tableLayoutPanel1.Controls.Add(dateBaoHanh, 3, 8);
            tableLayoutPanel1.Controls.Add(dateBaoTri, 1, 8);
            tableLayoutPanel1.Controls.Add(dateMua, 1, 7);
            tableLayoutPanel1.Controls.Add(label7, 2, 3);
            tableLayoutPanel1.Controls.Add(label15, 0, 10);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 10);
            tableLayoutPanel1.Controls.Add(label17, 0, 11);
            tableLayoutPanel1.Controls.Add(tbGhiChu, 1, 11);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 2, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel5, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel6, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(834, 526);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelIP
            // 
            tableLayoutPanel1.SetColumnSpan(panelIP, 13);
            panelIP.Controls.Add(cbIP);
            panelIP.Controls.Add(notAss);
            panelIP.Controls.Add(tbIP);
            panelIP.Dock = DockStyle.Fill;
            panelIP.Location = new Point(3, 363);
            panelIP.Name = "panelIP";
            panelIP.Size = new Size(828, 34);
            panelIP.TabIndex = 1;
            // 
            // cbIP
            // 
            cbIP.Anchor = AnchorStyles.Left;
            cbIP.AutoSize = true;
            cbIP.Location = new Point(3, 4);
            cbIP.Name = "cbIP";
            cbIP.Size = new Size(215, 24);
            cbIP.TabIndex = 1;
            cbIP.Text = "Thiết bị đã được cấu hình IP";
            cbIP.UseVisualStyleBackColor = true;
            cbIP.CheckedChanged += cbIP_CheckedChanged;
            // 
            // notAss
            // 
            notAss.Anchor = AnchorStyles.Left;
            notAss.AutoSize = true;
            notAss.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            notAss.ForeColor = Color.Red;
            notAss.Location = new Point(224, 6);
            notAss.Name = "notAss";
            notAss.Size = new Size(177, 20);
            notAss.TabIndex = 34;
            notAss.Text = "(Không thể đổi khi sửa)";
            // 
            // tbIP
            // 
            tbIP.BackColor = SystemColors.Info;
            tbIP.Font = new Font("Segoe UI", 9F);
            tbIP.Location = new Point(407, 3);
            tbIP.Name = "tbIP";
            tbIP.PlaceholderText = "Nhập cấu hình IP";
            tbIP.Size = new Size(318, 27);
            tbIP.TabIndex = 33;
            tbIP.Visible = false;
            // 
            // tbDonViTinh
            // 
            tbDonViTinh.Anchor = AnchorStyles.Left;
            tbDonViTinh.Font = new Font("Segoe UI", 10F);
            tbDonViTinh.Location = new Point(149, 85);
            tbDonViTinh.Name = "tbDonViTinh";
            tbDonViTinh.Size = new Size(113, 30);
            tbDonViTinh.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 90);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 10;
            label5.Text = "Đơn vị tính";
            // 
            // cbTrangThai
            // 
            cbTrangThai.Anchor = AnchorStyles.Left;
            cbTrangThai.Font = new Font("Segoe UI", 10F);
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Trong khoa", "Đang sử dụng", "Đang sửa", "Đã hư" });
            cbTrangThai.Location = new Point(149, 44);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(213, 31);
            cbTrangThai.TabIndex = 8;
            // 
            // tbMaThietBi
            // 
            tbMaThietBi.Anchor = AnchorStyles.Left;
            tbMaThietBi.Font = new Font("Segoe UI", 10F);
            tbMaThietBi.Location = new Point(149, 5);
            tbMaThietBi.Name = "tbMaThietBi";
            tbMaThietBi.PlaceholderText = "Mã sinh từ loại thiết bị!";
            tbMaThietBi.Size = new Size(213, 30);
            tbMaThietBi.TabIndex = 9;
            tbMaThietBi.MouseHover += tbMaThietBi_MouseHover;
            // 
            // cbPhongBan
            // 
            cbPhongBan.Anchor = AnchorStyles.Left;
            cbPhongBan.Font = new Font("Segoe UI", 10F);
            cbPhongBan.FormattingEnabled = true;
            cbPhongBan.Items.AddRange(new object[] { "Phong kinh doanh", "Phòng IT", "Phòng A", "Cấp cứu" });
            cbPhongBan.Location = new Point(596, 44);
            cbPhongBan.Name = "cbPhongBan";
            cbPhongBan.Size = new Size(216, 31);
            cbPhongBan.TabIndex = 7;
            // 
            // cbLoaiThietBi
            // 
            cbLoaiThietBi.Anchor = AnchorStyles.Left;
            cbLoaiThietBi.Font = new Font("Segoe UI", 10F);
            cbLoaiThietBi.FormattingEnabled = true;
            cbLoaiThietBi.Items.AddRange(new object[] { "Máy tính", "Máy in ", "Máy A", "May B" });
            cbLoaiThietBi.Location = new Point(596, 4);
            cbLoaiThietBi.Name = "cbLoaiThietBi";
            cbLoaiThietBi.Size = new Size(216, 31);
            cbLoaiThietBi.TabIndex = 6;
            cbLoaiThietBi.SelectedIndexChanged += cbLoaiThietBi_SelectedIndexChanged;
            cbLoaiThietBi.MouseHover += tbMaThietBi_MouseHover;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 130);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 12;
            label6.Text = "Số seri";
            // 
            // tbSeri
            // 
            tbSeri.Anchor = AnchorStyles.Left;
            tbSeri.Font = new Font("Segoe UI", 10F);
            tbSeri.Location = new Point(149, 125);
            tbSeri.Name = "tbSeri";
            tbSeri.Size = new Size(113, 30);
            tbSeri.TabIndex = 13;
            // 
            // tbModel
            // 
            tbModel.Anchor = AnchorStyles.Left;
            tbModel.Font = new Font("Segoe UI", 10F);
            tbModel.Location = new Point(596, 125);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(142, 30);
            tbModel.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 170);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 16;
            label8.Text = "Hãng";
            // 
            // tbHang
            // 
            tbHang.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(tbHang, 2);
            tbHang.Font = new Font("Segoe UI", 10F);
            tbHang.Location = new Point(149, 165);
            tbHang.Name = "tbHang";
            tbHang.Size = new Size(384, 30);
            tbHang.TabIndex = 17;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 210);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 18;
            label9.Text = "Cấu hình";
            // 
            // tbCauHinh
            // 
            tbCauHinh.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(tbCauHinh, 3);
            tbCauHinh.Font = new Font("Segoe UI", 10F);
            tbCauHinh.Location = new Point(149, 205);
            tbCauHinh.Name = "tbCauHinh";
            tbCauHinh.Size = new Size(613, 30);
            tbCauHinh.TabIndex = 19;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 250);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 20;
            label10.Text = "Loại kết nối";
            // 
            // tbLoaiKetNoi
            // 
            tbLoaiKetNoi.Anchor = AnchorStyles.Left;
            tbLoaiKetNoi.Font = new Font("Segoe UI", 10F);
            tbLoaiKetNoi.Location = new Point(149, 245);
            tbLoaiKetNoi.Name = "tbLoaiKetNoi";
            tbLoaiKetNoi.Size = new Size(113, 30);
            tbLoaiKetNoi.TabIndex = 21;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(3, 290);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 22;
            label11.Text = "Thời gian mua";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(3, 330);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 23;
            label12.Text = "Thời gian bảo trì";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(414, 290);
            label13.Name = "label13";
            label13.Size = new Size(128, 20);
            label13.TabIndex = 24;
            label13.Text = "Thời gian sử dụng";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(414, 330);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 25;
            label14.Text = "Hạn bảo hành";
            // 
            // dateSuDung
            // 
            dateSuDung.Anchor = AnchorStyles.Left;
            dateSuDung.Font = new Font("Segoe UI", 10F);
            dateSuDung.Format = DateTimePickerFormat.Custom;
            dateSuDung.Location = new Point(596, 285);
            dateSuDung.Name = "dateSuDung";
            dateSuDung.Size = new Size(211, 30);
            dateSuDung.TabIndex = 28;
            dateSuDung.Value = new DateTime(2025, 12, 11, 0, 0, 0, 0);
            // 
            // dateBaoHanh
            // 
            dateBaoHanh.Anchor = AnchorStyles.Left;
            dateBaoHanh.Font = new Font("Segoe UI", 10F);
            dateBaoHanh.Format = DateTimePickerFormat.Custom;
            dateBaoHanh.Location = new Point(596, 325);
            dateBaoHanh.Name = "dateBaoHanh";
            dateBaoHanh.Size = new Size(211, 30);
            dateBaoHanh.TabIndex = 29;
            // 
            // dateBaoTri
            // 
            dateBaoTri.Anchor = AnchorStyles.Left;
            dateBaoTri.Font = new Font("Segoe UI", 10F);
            dateBaoTri.Format = DateTimePickerFormat.Custom;
            dateBaoTri.Location = new Point(149, 325);
            dateBaoTri.Name = "dateBaoTri";
            dateBaoTri.Size = new Size(213, 30);
            dateBaoTri.TabIndex = 30;
            // 
            // dateMua
            // 
            dateMua.Anchor = AnchorStyles.Left;
            dateMua.Font = new Font("Segoe UI", 10F);
            dateMua.Format = DateTimePickerFormat.Custom;
            dateMua.Location = new Point(149, 285);
            dateMua.Name = "dateMua";
            dateMua.Size = new Size(213, 30);
            dateMua.TabIndex = 31;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(414, 130);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 14;
            label7.Text = "Model";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(3, 410);
            label15.Name = "label15";
            label15.Size = new Size(31, 20);
            label15.TabIndex = 33;
            label15.Text = "Giá";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel2, 2);
            flowLayoutPanel2.Controls.Add(tbGia);
            flowLayoutPanel2.Controls.Add(label16);
            flowLayoutPanel2.Location = new Point(149, 403);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(362, 34);
            flowLayoutPanel2.TabIndex = 35;
            // 
            // tbGia
            // 
            tbGia.Anchor = AnchorStyles.Left;
            tbGia.Font = new Font("Segoe UI", 10F);
            tbGia.Location = new Point(3, 3);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(192, 30);
            tbGia.TabIndex = 34;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(201, 8);
            label16.Name = "label16";
            label16.Size = new Size(42, 20);
            label16.TabIndex = 35;
            label16.Text = "VND";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Location = new Point(3, 450);
            label17.Name = "label17";
            label17.Size = new Size(58, 20);
            label17.TabIndex = 36;
            label17.Text = "Ghi chú";
            // 
            // tbGhiChu
            // 
            tableLayoutPanel1.SetColumnSpan(tbGhiChu, 3);
            tbGhiChu.Location = new Point(149, 443);
            tbGhiChu.Multiline = true;
            tbGhiChu.Name = "tbGhiChu";
            tableLayoutPanel1.SetRowSpan(tbGhiChu, 2);
            tbGhiChu.Size = new Size(682, 80);
            tbGhiChu.TabIndex = 37;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Left;
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(label19);
            flowLayoutPanel3.Controls.Add(label20);
            flowLayoutPanel3.Location = new Point(3, 10);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(121, 20);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(81, 20);
            label19.TabIndex = 39;
            label19.Text = "Mã thiết bị";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(90, 0);
            label20.Name = "label20";
            label20.Size = new Size(28, 20);
            label20.TabIndex = 40;
            label20.Text = "(*)";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Left;
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(label18);
            flowLayoutPanel4.Controls.Add(label21);
            flowLayoutPanel4.Location = new Point(414, 10);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(167, 20);
            flowLayoutPanel4.TabIndex = 41;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Location = new Point(3, 0);
            label18.Name = "label18";
            label18.Size = new Size(127, 20);
            label18.TabIndex = 39;
            label18.Text = "Loại trang thiết bị";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(136, 0);
            label21.Name = "label21";
            label21.Size = new Size(28, 20);
            label21.TabIndex = 40;
            label21.Text = "(*)";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Anchor = AnchorStyles.Left;
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(label1);
            flowLayoutPanel5.Controls.Add(label22);
            flowLayoutPanel5.Location = new Point(3, 50);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(115, 20);
            flowLayoutPanel5.TabIndex = 42;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 39;
            label1.Text = "Trạng thái";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(84, 0);
            label22.Name = "label22";
            label22.Size = new Size(28, 20);
            label22.TabIndex = 40;
            label22.Text = "(*)";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Anchor = AnchorStyles.Left;
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.Controls.Add(label3);
            flowLayoutPanel6.Controls.Add(label23);
            flowLayoutPanel6.Location = new Point(414, 43);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(143, 34);
            flowLayoutPanel6.TabIndex = 43;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 39;
            label3.Text = "Phòng ban sử dụng";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(3, 20);
            label23.Name = "label23";
            label23.Size = new Size(28, 20);
            label23.TabIndex = 40;
            label23.Text = "(*)";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 579);
            panel1.TabIndex = 2;
            // 
            // ThemThietBi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(858, 579);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThemThietBi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm mới Trang thiết bị";
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelIP.ResumeLayout(false);
            panelIP.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbDonViTinh;
        private Label label5;
        private ComboBox cbTrangThai;
        private TextBox tbMaThietBi;
        private ComboBox cbPhongBan;
        private ComboBox cbLoaiThietBi;
        private Label label6;
        private TextBox tbSeri;
        private TextBox tbModel;
        private Label label8;
        private TextBox tbHang;
        private Label label9;
        private TextBox tbCauHinh;
        private Label label10;
        private TextBox tbLoaiKetNoi;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DateTimePicker dateSuDung;
        private DateTimePicker dateBaoHanh;
        private DateTimePicker dateBaoTri;
        private DateTimePicker dateMua;
        private Label label7;
        private Panel panel1;
        private TextBox tbIP;
        private FlowLayoutPanel panelIP;
        private CheckBox cbIP;
        private Label label15;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox tbGia;
        private Label label16;
        private Label label17;
        private TextBox tbGhiChu;
        private Button btnHuy;
        private Button btnThem;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label19;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label3;
        private Label label23;
        private Label label20;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label18;
        private Label label21;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label1;
        private Label label22;
        private Label notAss;
    }
}