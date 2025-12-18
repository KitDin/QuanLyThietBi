using System.Drawing.Drawing2D;

namespace QuanLyThietBi
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new TableLayoutPanel();
            titleLabel = new Label();
            subtitleLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            supportLabel = new Label();
            panel1 = new Panel();
            passwordTextBox = new TextBox();
            panel2 = new Panel();
            usernameTextBox = new TextBox();
            logoBox = new PictureBox();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ButtonHighlight;
            mainPanel.ColumnCount = 2;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainPanel.Controls.Add(titleLabel, 1, 0);
            mainPanel.Controls.Add(subtitleLabel, 0, 2);
            mainPanel.Controls.Add(usernameLabel, 0, 4);
            mainPanel.Controls.Add(passwordLabel, 0, 7);
            mainPanel.Controls.Add(loginButton, 0, 13);
            mainPanel.Controls.Add(supportLabel, 0, 19);
            mainPanel.Controls.Add(panel1, 0, 8);
            mainPanel.Controls.Add(panel2, 0, 5);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(50, 20, 50, 20);
            mainPanel.RowCount = 20;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainPanel.RowStyles.Add(new RowStyle());
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainPanel.RowStyles.Add(new RowStyle());
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.RowStyles.Add(new RowStyle());
            mainPanel.RowStyles.Add(new RowStyle());
            mainPanel.RowStyles.Add(new RowStyle());
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainPanel.Size = new Size(532, 574);
            mainPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.AutoSize = true;
            mainPanel.SetColumnSpan(titleLabel, 2);
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(17, 20, 24);
            titleLabel.Location = new Point(53, 70);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(426, 64);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Hệ thống Quản lý Thiết bị";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            subtitleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            subtitleLabel.AutoSize = true;
            mainPanel.SetColumnSpan(subtitleLabel, 2);
            subtitleLabel.Font = new Font("Segoe UI", 10F);
            subtitleLabel.ForeColor = Color.FromArgb(97, 117, 137);
            subtitleLabel.Location = new Point(53, 134);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(426, 20);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Đăng nhập để truy cập hệ thống nội bộ";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            mainPanel.SetColumnSpan(usernameLabel, 2);
            usernameLabel.Font = new Font("Segoe UI", 10F);
            usernameLabel.ForeColor = Color.FromArgb(17, 20, 24);
            usernameLabel.Location = new Point(53, 188);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(245, 23);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Tên đăng nhập / Mã nhân viên";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            mainPanel.SetColumnSpan(passwordLabel, 2);
            passwordLabel.Font = new Font("Segoe UI", 10F);
            passwordLabel.ForeColor = Color.FromArgb(17, 20, 24);
            passwordLabel.Location = new Point(53, 270);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(82, 23);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Mật khẩu";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(19, 127, 236);
            mainPanel.SetColumnSpan(loginButton, 2);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(53, 375);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(426, 48);
            loginButton.TabIndex = 6;
            loginButton.Text = "Đăng nhập →";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // supportLabel
            // 
            supportLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            supportLabel.AutoSize = true;
            supportLabel.BackColor = Color.FromArgb(248, 250, 252);
            mainPanel.SetColumnSpan(supportLabel, 2);
            supportLabel.Font = new Font("Segoe UI", 8.5F);
            supportLabel.ForeColor = Color.FromArgb(97, 117, 137);
            supportLabel.Location = new Point(53, 526);
            supportLabel.Name = "supportLabel";
            supportLabel.Size = new Size(426, 28);
            supportLabel.TabIndex = 7;
            supportLabel.Text = "Hỗ trợ kỹ thuật: IT Dept (Ext: 102)";
            supportLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(passwordTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(50, 300);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 0, 0);
            panel1.Size = new Size(432, 32);
            panel1.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Segoe UI", 11F);
            passwordTextBox.Location = new Point(23, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Nhập mật khẩu";
            passwordTextBox.Size = new Size(404, 25);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(usernameTextBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(50, 218);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 0, 0, 0);
            panel2.Size = new Size(432, 32);
            panel2.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Segoe UI", 11F);
            usernameTextBox.Location = new Point(20, 2);
            usernameTextBox.Margin = new Padding(0, 5, 0, 0);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Ví dụ: NV12345";
            usernameTextBox.Size = new Size(410, 25);
            usernameTextBox.TabIndex = 3;
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.FromArgb(230, 240, 252);
            logoBox.Location = new Point(532, 40);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(64, 64);
            logoBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 574);
            Controls.Add(mainPanel);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Form1_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        private void ApplyModernStyling()
        {
            logoBox.Paint += (s, e) =>
            {
                using (GraphicsPath path = GetRoundedRectangle(logoBox.ClientRectangle, 32))
                {
                    logoBox.Region = new Region(path);
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    // Draw medical cross icon
                    using (Brush brush = new SolidBrush(Color.FromArgb(19, 127, 236)))
                    {
                        // Vertical bar
                        e.Graphics.FillRectangle(brush, 24, 16, 16, 32);
                        // Horizontal bar
                        e.Graphics.FillRectangle(brush, 16, 24, 32, 16);
                    }
                }
            };
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        #endregion

        private TableLayoutPanel mainPanel;
        private Label titleLabel;
        private PictureBox logoBox;
        private Label subtitleLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label supportLabel;
        private Panel panel1;
        private Panel panel2;
        private TextBox usernameTextBox;
    }
}
