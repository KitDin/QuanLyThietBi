namespace QuanLyThietBi
{
    partial class home
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            timeCurrent = new Label();
            btnThongKe = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            username2 = new Label();
            quanLyThietBiButton = new Button();
            panelDanhMucConQL = new TableLayoutPanel();
            btnThietBiCoCauHinh = new Button();
            btnThietBi = new Button();
            btnQuanLyDanhMuc = new Button();
            button5 = new Button();
            panelContent = new Panel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panelDanhMucConQL.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 611);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1294, 50);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(23, 24, 29);
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1294, 50);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 31);
            label1.TabIndex = 0;
            label1.Text = "🖥️ Phần mềm Quản lý trang thiết bị";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(876, 11);
            label3.Name = "label3";
            label3.Size = new Size(415, 28);
            label3.TabIndex = 1;
            label3.Text = "Đơn vị: Bệnh viện Đa Khoa Tâm Trí Cao Lãnh";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(23, 24, 29);
            tableLayoutPanel3.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel3.Controls.Add(btnThongKe, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 8);
            tableLayoutPanel3.Controls.Add(quanLyThietBiButton, 0, 2);
            tableLayoutPanel3.Controls.Add(panelDanhMucConQL, 0, 3);
            tableLayoutPanel3.Controls.Add(btnQuanLyDanhMuc, 0, 5);
            tableLayoutPanel3.Controls.Add(button5, 0, 7);
            tableLayoutPanel3.Dock = DockStyle.Left;
            tableLayoutPanel3.ForeColor = SystemColors.ButtonHighlight;
            tableLayoutPanel3.Location = new Point(0, 50);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 9;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(257, 561);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.IndianRed;
            flowLayoutPanel1.Controls.Add(timeCurrent);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 40);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // timeCurrent
            // 
            timeCurrent.Anchor = AnchorStyles.None;
            timeCurrent.BackColor = Color.FromArgb(30, 30, 30);
            timeCurrent.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            timeCurrent.Location = new Point(3, 0);
            timeCurrent.Name = "timeCurrent";
            timeCurrent.Size = new Size(248, 40);
            timeCurrent.TabIndex = 6;
            timeCurrent.Text = "label3";
            timeCurrent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnThongKe
            // 
            btnThongKe.AutoSize = true;
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(3, 49);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(251, 45);
            btnThongKe.TabIndex = 1;
            btnThongKe.Text = "📊   Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(username2, 0, 1);
            tableLayoutPanel4.Location = new Point(3, 355);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(251, 62);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 0;
            label2.Text = "👤  Người đăng nhập";
            // 
            // username2
            // 
            username2.AutoSize = true;
            username2.Dock = DockStyle.Fill;
            username2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            username2.Location = new Point(3, 31);
            username2.Name = "username2";
            username2.Size = new Size(245, 31);
            username2.TabIndex = 1;
            username2.Text = "Đinh Tuấn Kiệt";
            username2.TextAlign = ContentAlignment.TopCenter;
            // 
            // quanLyThietBiButton
            // 
            quanLyThietBiButton.Cursor = Cursors.Hand;
            quanLyThietBiButton.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            quanLyThietBiButton.FlatStyle = FlatStyle.Flat;
            quanLyThietBiButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            quanLyThietBiButton.ImageAlign = ContentAlignment.MiddleLeft;
            quanLyThietBiButton.Location = new Point(3, 100);
            quanLyThietBiButton.Name = "quanLyThietBiButton";
            quanLyThietBiButton.Size = new Size(251, 45);
            quanLyThietBiButton.TabIndex = 2;
            quanLyThietBiButton.Text = "🖥️   Quản lý trang thiết bị";
            quanLyThietBiButton.TextAlign = ContentAlignment.MiddleLeft;
            quanLyThietBiButton.UseVisualStyleBackColor = true;
            quanLyThietBiButton.Click += quanLyThietBiButton_Click;
            // 
            // panelDanhMucConQL
            // 
            panelDanhMucConQL.AutoSize = true;
            panelDanhMucConQL.BackColor = SystemColors.ControlLightLight;
            panelDanhMucConQL.ColumnCount = 1;
            panelDanhMucConQL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelDanhMucConQL.Controls.Add(btnThietBiCoCauHinh, 0, 1);
            panelDanhMucConQL.Controls.Add(btnThietBi, 0, 0);
            panelDanhMucConQL.ForeColor = SystemColors.ActiveCaptionText;
            panelDanhMucConQL.Location = new Point(0, 148);
            panelDanhMucConQL.Margin = new Padding(0);
            panelDanhMucConQL.Name = "panelDanhMucConQL";
            panelDanhMucConQL.RowCount = 2;
            panelDanhMucConQL.RowStyles.Add(new RowStyle());
            panelDanhMucConQL.RowStyles.Add(new RowStyle());
            panelDanhMucConQL.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelDanhMucConQL.Size = new Size(257, 102);
            panelDanhMucConQL.TabIndex = 0;
            panelDanhMucConQL.Visible = false;
            // 
            // btnThietBiCoCauHinh
            // 
            btnThietBiCoCauHinh.Cursor = Cursors.Hand;
            btnThietBiCoCauHinh.FlatAppearance.BorderColor = Color.White;
            btnThietBiCoCauHinh.FlatStyle = FlatStyle.Flat;
            btnThietBiCoCauHinh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThietBiCoCauHinh.ImageAlign = ContentAlignment.MiddleLeft;
            btnThietBiCoCauHinh.Location = new Point(3, 54);
            btnThietBiCoCauHinh.Name = "btnThietBiCoCauHinh";
            btnThietBiCoCauHinh.Size = new Size(251, 45);
            btnThietBiCoCauHinh.TabIndex = 9;
            btnThietBiCoCauHinh.Text = "Thiết bị có cấu hình";
            btnThietBiCoCauHinh.TextAlign = ContentAlignment.MiddleLeft;
            btnThietBiCoCauHinh.UseVisualStyleBackColor = true;
            btnThietBiCoCauHinh.Click += btnThietBiCoCauHinh_Click;
            // 
            // btnThietBi
            // 
            btnThietBi.Cursor = Cursors.Hand;
            btnThietBi.FlatAppearance.BorderColor = Color.White;
            btnThietBi.FlatStyle = FlatStyle.Flat;
            btnThietBi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThietBi.ImageAlign = ContentAlignment.MiddleLeft;
            btnThietBi.Location = new Point(3, 3);
            btnThietBi.Name = "btnThietBi";
            btnThietBi.Size = new Size(251, 45);
            btnThietBi.TabIndex = 8;
            btnThietBi.Text = "Thiết bị";
            btnThietBi.TextAlign = ContentAlignment.MiddleLeft;
            btnThietBi.UseVisualStyleBackColor = true;
            btnThietBi.Click += btnThietBi_Click;
            // 
            // btnQuanLyDanhMuc
            // 
            btnQuanLyDanhMuc.Cursor = Cursors.Hand;
            btnQuanLyDanhMuc.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            btnQuanLyDanhMuc.FlatStyle = FlatStyle.Flat;
            btnQuanLyDanhMuc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnQuanLyDanhMuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLyDanhMuc.Location = new Point(3, 253);
            btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            btnQuanLyDanhMuc.Size = new Size(251, 45);
            btnQuanLyDanhMuc.TabIndex = 3;
            btnQuanLyDanhMuc.Text = "🏢  Quản lý danh mục";
            btnQuanLyDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyDanhMuc.UseVisualStyleBackColor = true;
            btnQuanLyDanhMuc.Click += btnQuanLyDanhMuc_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 304);
            button5.Name = "button5";
            button5.Size = new Size(251, 45);
            button5.TabIndex = 4;
            button5.Text = "📜  Lịch sử thiết bị";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(257, 50);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1037, 561);
            panelContent.TabIndex = 3;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 661);
            Controls.Add(panelContent);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "home";
            Text = "Quản Lý Thiết Bị";
            WindowState = FormWindowState.Maximized;
            Load += home_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panelDanhMucConQL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button quanLyThietBiButton;
        private Button btnThongKe;
        private Button button5;
        private Button btnQuanLyDanhMuc;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private Label username2;
        private Label timeCurrent;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelContent;
        private TableLayoutPanel panelDanhMucConQL;
        private Button btnThietBiCoCauHinh;
        private Button btnThietBi;
        private Label label1;
        private Label label3;
    }
}