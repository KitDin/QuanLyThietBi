namespace QuanLyThietBi
{
    partial class ThongKeForm
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
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            label1 = new Label();
            plotTrangThai = new OxyPlot.WindowsForms.PlotView();
            panelTrangThai = new Panel();
            panelPhongBan = new Panel();
            plotPhongBan = new OxyPlot.WindowsForms.PlotView();
            panel1 = new Panel();
            plotThoiGian = new OxyPlot.WindowsForms.PlotView();
            panel2 = new Panel();
            nbYear = new NumericUpDown();
            panel5 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            lbThongKeTheoThang = new Label();
            panelTrangThai.SuspendLayout();
            panelPhongBan.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbYear).BeginInit();
            SuspendLayout();
            // 
            // plotView1
            // 
            plotView1.Location = new Point(177, 121);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(94, 29);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 27);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "TRANG THỐNG KÊ";
            // 
            // plotTrangThai
            // 
            plotTrangThai.BackColor = Color.FromArgb(34, 50, 50);
            plotTrangThai.Dock = DockStyle.Fill;
            plotTrangThai.ForeColor = SystemColors.ButtonHighlight;
            plotTrangThai.Location = new Point(0, 0);
            plotTrangThai.Name = "plotTrangThai";
            plotTrangThai.PanCursor = Cursors.Hand;
            plotTrangThai.Size = new Size(558, 495);
            plotTrangThai.TabIndex = 2;
            plotTrangThai.Text = "plotView2";
            plotTrangThai.ZoomHorizontalCursor = Cursors.SizeWE;
            plotTrangThai.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotTrangThai.ZoomVerticalCursor = Cursors.SizeNS;
            plotTrangThai.Click += plotTrangThai_Click;
            // 
            // panelTrangThai
            // 
            panelTrangThai.BackColor = SystemColors.ScrollBar;
            panelTrangThai.Controls.Add(plotTrangThai);
            panelTrangThai.Location = new Point(51, 67);
            panelTrangThai.Name = "panelTrangThai";
            panelTrangThai.Size = new Size(558, 495);
            panelTrangThai.TabIndex = 3;
            panelTrangThai.Paint += panel1_Paint;
            // 
            // panelPhongBan
            // 
            panelPhongBan.BorderStyle = BorderStyle.Fixed3D;
            panelPhongBan.Controls.Add(plotPhongBan);
            panelPhongBan.Location = new Point(631, 67);
            panelPhongBan.Name = "panelPhongBan";
            panelPhongBan.Size = new Size(988, 495);
            panelPhongBan.TabIndex = 4;
            // 
            // plotPhongBan
            // 
            plotPhongBan.Dock = DockStyle.Fill;
            plotPhongBan.Location = new Point(0, 0);
            plotPhongBan.Name = "plotPhongBan";
            plotPhongBan.PanCursor = Cursors.Hand;
            plotPhongBan.Size = new Size(984, 491);
            plotPhongBan.TabIndex = 0;
            plotPhongBan.Text = "plotView2";
            plotPhongBan.ZoomHorizontalCursor = Cursors.SizeWE;
            plotPhongBan.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotPhongBan.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panel1
            // 
            panel1.Controls.Add(plotThoiGian);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(51, 587);
            panel1.Name = "panel1";
            panel1.Size = new Size(1566, 322);
            panel1.TabIndex = 5;
            // 
            // plotThoiGian
            // 
            plotThoiGian.Dock = DockStyle.Fill;
            plotThoiGian.Location = new Point(0, 70);
            plotThoiGian.Name = "plotThoiGian";
            plotThoiGian.PanCursor = Cursors.Hand;
            plotThoiGian.Size = new Size(1566, 252);
            plotThoiGian.TabIndex = 1;
            plotThoiGian.Text = " ";
            plotThoiGian.ZoomHorizontalCursor = Cursors.SizeWE;
            plotThoiGian.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotThoiGian.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panel2
            // 
            panel2.Controls.Add(nbYear);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbThongKeTheoThang);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1566, 70);
            panel2.TabIndex = 0;
            // 
            // nbYear
            // 
            nbYear.Location = new Point(1384, 38);
            nbYear.Name = "nbYear";
            nbYear.Size = new Size(179, 27);
            nbYear.TabIndex = 8;
            nbYear.ValueChanged += nbYear_ValueChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Orange;
            panel5.Location = new Point(301, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(42, 29);
            panel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 40);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 6;
            label5.Text = "Thêm mới";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(126, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(42, 29);
            panel4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 40);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 4;
            label4.Text = "Đưa vào sử dụng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Location = new Point(5, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(42, 29);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 40);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Mua mới";
            // 
            // lbThongKeTheoThang
            // 
            lbThongKeTheoThang.Dock = DockStyle.Top;
            lbThongKeTheoThang.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThongKeTheoThang.Location = new Point(0, 0);
            lbThongKeTheoThang.Name = "lbThongKeTheoThang";
            lbThongKeTheoThang.Size = new Size(1566, 35);
            lbThongKeTheoThang.TabIndex = 0;
            lbThongKeTheoThang.Text = "THỐNG KÊ THIẾT BỊ THEO THÁNG (2025)";
            lbThongKeTheoThang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ThongKeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1620, 935);
            Controls.Add(panel1);
            Controls.Add(panelPhongBan);
            Controls.Add(panelTrangThai);
            Controls.Add(label1);
            Controls.Add(plotView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThongKeForm";
            Text = "ThongKeForm";
            WindowState = FormWindowState.Maximized;
            Load += ThongKeForm_Load;
            panelTrangThai.ResumeLayout(false);
            panelPhongBan.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label label1;
        private OxyPlot.WindowsForms.PlotView plotTrangThai;
        private Panel panelTrangThai;
        private Panel panelPhongBan;
        private OxyPlot.WindowsForms.PlotView plotPhongBan;
        private Panel panel1;
        private Panel panel2;
        private Label lbThongKeTheoThang;
        private OxyPlot.WindowsForms.PlotView plotThoiGian;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private NumericUpDown nbYear;
    }
}