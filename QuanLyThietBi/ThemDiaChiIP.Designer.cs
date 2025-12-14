namespace QuanLyThietBi
{
    partial class ThemDiaChiIP
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
            infoIp = new Label();
            Ip1 = new TextBox();
            label2 = new Label();
            Ip2 = new TextBox();
            label3 = new Label();
            Ip3 = new TextBox();
            label4 = new Label();
            Ip4 = new TextBox();
            btnThem = new Button();
            btnHuy = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.99999F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel1.Controls.Add(infoIp, 0, 0);
            tableLayoutPanel1.Controls.Add(Ip1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(Ip2, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 3, 1);
            tableLayoutPanel1.Controls.Add(Ip3, 4, 1);
            tableLayoutPanel1.Controls.Add(label4, 5, 1);
            tableLayoutPanel1.Controls.Add(Ip4, 6, 1);
            tableLayoutPanel1.Controls.Add(btnThem, 6, 3);
            tableLayoutPanel1.Controls.Add(btnHuy, 4, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.34146F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.65854F));
            tableLayoutPanel1.Size = new Size(441, 190);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // infoIp
            // 
            infoIp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            infoIp.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(infoIp, 7);
            infoIp.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            infoIp.Location = new Point(13, 10);
            infoIp.Name = "infoIp";
            infoIp.RightToLeft = RightToLeft.No;
            infoIp.Size = new Size(91, 80);
            infoIp.TabIndex = 0;
            infoIp.Text = "Cấu hình IP";
            // 
            // Ip1
            // 
            Ip1.Location = new Point(13, 93);
            Ip1.Name = "Ip1";
            Ip1.Size = new Size(84, 27);
            Ip1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label2.Location = new Point(103, 90);
            label2.Name = "label2";
            label2.Size = new Size(14, 37);
            label2.TabIndex = 2;
            label2.Text = ".";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ip2
            // 
            Ip2.Dock = DockStyle.Fill;
            Ip2.Location = new Point(123, 93);
            Ip2.Name = "Ip2";
            Ip2.Size = new Size(84, 27);
            Ip2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label3.Location = new Point(213, 90);
            label3.Name = "label3";
            label3.Size = new Size(14, 37);
            label3.TabIndex = 4;
            label3.Text = ".";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ip3
            // 
            Ip3.Dock = DockStyle.Fill;
            Ip3.Location = new Point(233, 93);
            Ip3.Name = "Ip3";
            Ip3.Size = new Size(84, 27);
            Ip3.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label4.Location = new Point(323, 90);
            label4.Name = "label4";
            label4.Size = new Size(14, 37);
            label4.TabIndex = 6;
            label4.Text = ".";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ip4
            // 
            Ip4.Dock = DockStyle.Fill;
            Ip4.Location = new Point(343, 93);
            Ip4.Name = "Ip4";
            Ip4.Size = new Size(85, 27);
            Ip4.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.HotTrack;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(343, 138);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 36);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(233, 138);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(84, 36);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // ThemDiaChiIP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 190);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThemDiaChiIP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Địa chỉ IP";
            Load += ThemDiaChiIP_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label infoIp;
        private TextBox Ip1;
        private TextBox Ip3;
        private Label label2;
        private TextBox Ip2;
        private Label label3;
        private Label label4;
        private TextBox Ip4;
        private Button btnThem;
        private Button btnHuy;
    }
}