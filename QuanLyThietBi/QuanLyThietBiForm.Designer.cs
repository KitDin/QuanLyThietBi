using System.ComponentModel;
using System.Data;

namespace QuanLyThietBi
{
    partial class QuanLyThietBiForm
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
            label1 = new Label();
            btnAdd = new Button();
            textSearch = new TextBox();
            dgvThietBi = new DataGridView();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cbTrangThai = new ComboBox();
            cbLoaiThietBi = new ComboBox();
            cbPhongBan = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)dgvThietBi).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAdd, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1142, 69);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(214, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC TRANG THIẾT BỊ";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(128, 128, 255);
            btnAdd.FlatAppearance.BorderColor = Color.Blue;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(1019, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 33);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textSearch
            // 
            textSearch.Anchor = AnchorStyles.None;
            textSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearch.Location = new Point(869, 3);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Tìm kiếm thiết bị ...";
            textSearch.Size = new Size(270, 30);
            textSearch.TabIndex = 2;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // dgvThietBi
            // 
            dgvThietBi.AllowUserToOrderColumns = true;
            dgvThietBi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvThietBi.BackgroundColor = Color.White;
            dgvThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietBi.Dock = DockStyle.Fill;
            dgvThietBi.Location = new Point(0, 45);
            dgvThietBi.Name = "dgvThietBi";
            dgvThietBi.ReadOnly = true;
            dgvThietBi.RowHeadersWidth = 51;
            dgvThietBi.Size = new Size(1142, 456);
            dgvThietBi.TabIndex = 2;
            dgvThietBi.CellFormatting += dgvThietBi_CellFormatting;
            dgvThietBi.ColumnHeaderMouseClick += dgvThietBi_ColumnHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvThietBi);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 501);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textSearch);
            flowLayoutPanel1.Controls.Add(cbTrangThai);
            flowLayoutPanel1.Controls.Add(cbLoaiThietBi);
            flowLayoutPanel1.Controls.Add(cbPhongBan);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1142, 45);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // cbTrangThai
            // 
            cbTrangThai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(663, 4);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(200, 28);
            cbTrangThai.TabIndex = 2;
            // 
            // cbLoaiThietBi
            // 
            cbLoaiThietBi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbLoaiThietBi.FormattingEnabled = true;
            cbLoaiThietBi.Location = new Point(457, 3);
            cbLoaiThietBi.Name = "cbLoaiThietBi";
            cbLoaiThietBi.Size = new Size(200, 28);
            cbLoaiThietBi.TabIndex = 0;
            // 
            // cbPhongBan
            // 
            cbPhongBan.FormattingEnabled = true;
            cbPhongBan.Location = new Point(251, 3);
            cbPhongBan.Name = "cbPhongBan";
            cbPhongBan.Size = new Size(200, 28);
            cbPhongBan.TabIndex = 1;
            // 
            // QuanLyThietBiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1142, 570);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuanLyThietBiForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "QuanLyThietBiForm";
            WindowState = FormWindowState.Maximized;
            Load += QuanLyThietBiForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)dgvThietBi).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }


        private SortOrder currentSortOrder = SortOrder.None;
        private string currentSortColumn = "";

        private void dgvThietBi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvThietBi.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                return;

            DataGridViewColumn newColumn = dgvThietBi.Columns[e.ColumnIndex];
            ListSortDirection direction;

            // Kiểm tra nếu click vào cùng cột
            if (currentSortColumn == newColumn.Name && currentSortOrder == SortOrder.Ascending)
            {
                direction = ListSortDirection.Descending;
                currentSortOrder = SortOrder.Descending;
            }
            else
            {
                direction = ListSortDirection.Ascending;
                currentSortOrder = SortOrder.Ascending;
            }

            currentSortColumn = newColumn.Name;

            var bindingList = dgvThietBi.DataSource as BindingList<Model.TrangThietBiModel>;
            if (bindingList != null)
            {
                var sorted = direction == ListSortDirection.Ascending
                    ? bindingList.OrderBy(x => GetPropertyValue(x, newColumn.DataPropertyName)).ToList()
                    : bindingList.OrderByDescending(x => GetPropertyValue(x, newColumn.DataPropertyName)).ToList();

                dgvThietBi.DataSource = null;
                dgvThietBi.DataSource = new BindingList<Model.TrangThietBiModel>(sorted);
                dgvThietBi.Refresh();
            }
        }

        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName)?.GetValue(obj, null);
        }
        #endregion
        private void styleDataGridView()
        {

            dgvThietBi.BorderStyle = BorderStyle.None;
            dgvThietBi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvThietBi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvThietBi.BackgroundColor = Color.White;

            dgvThietBi.EnableHeadersVisualStyles = false;

            // Header
            dgvThietBi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvThietBi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvThietBi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvThietBi.ColumnHeadersHeight = 50;

            // Row
            dgvThietBi.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvThietBi.DefaultCellStyle.BackColor = Color.White;
            dgvThietBi.DefaultCellStyle.ForeColor = Color.Black;
            dgvThietBi.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dgvThietBi.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Xen kẽ màu dòng
            dgvThietBi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250);

            // Tự giãn cột
            //dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.ScrollBars = ScrollBars.Both;
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvThietBi.AllowUserToResizeColumns = true;

            // Không cho sửa trực tiếp
            dgvThietBi.ReadOnly = true;

            // Tắt dòng trống cuối
            dgvThietBi.AllowUserToAddRows = false;

            // Chọn nguyên dòng
            dgvThietBi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvThietBi.RowTemplate.Height = 45;

            dgvThietBi.AutoGenerateColumns = false;
            dgvThietBi.Columns.Clear();

            dgvThietBi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThietBi.MultiSelect = false;
            dgvThietBi.AllowUserToAddRows = false;
            dgvThietBi.ReadOnly = true;



            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ma_trang_thiet_bi",
                DataPropertyName = "Ma_trang_thiet_bi",
                HeaderText = "Mã TB"
            });
            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ten_trang_thiet_bi",
                DataPropertyName = "Ten_trang_thiet_bi",
                HeaderText = "Tên TB"
            });

            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ten_loai_thiet_bi",
                DataPropertyName = "Ten_loai_thiet_bi",
                HeaderText = "Loại"
            });

            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ten_phong_ban",
                DataPropertyName = "Ten_phong_ban",
                HeaderText = "Phòng"
            });

            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ten_trang_thai",
                DataPropertyName = "Ten_trang_thai",
                HeaderText = "Trạng thái"
            });

            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "So_seri",
                DataPropertyName = "So_seri",
                HeaderText = "Số seri"
            });

            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Brand",
                DataPropertyName = "Brand",
                HeaderText = "Hãng"
            });

            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Model",
                DataPropertyName = "Model",
                HeaderText = "Model"
            });

            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cau_hinh",
                DataPropertyName = "Cau_hinh",
                HeaderText = "Cấu hình"
            });

            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Loai_ket_noi",
                DataPropertyName = "Loai_ket_noi",
                HeaderText = "Kết nối"
            });

            dgvThietBi.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Thoi_gian_mua",
                DataPropertyName = "Thoi_gian_mua",
                HeaderText = "Ngày mua",
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            // In your styleDataGridView() method, after adding all columns:
            foreach (DataGridViewColumn col in dgvThietBi.Columns)
            {
                if (col is DataGridViewButtonColumn)
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                else
                    col.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        void AddActionButtons()
        {
            int btnWidth = 90;
            int btnHeight = 32;

            dgvThietBi.RowTemplate.Height = btnHeight + 6;
            dgvThietBi.AllowUserToResizeRows = false;

            AddButtonColumn("btnEdit", " ✏ ", btnWidth);
            AddButtonColumn("btnTransfer", " ⇄ ", btnWidth);
            AddButtonColumn("btnDelete", " 🗑 ", btnWidth);

        }


        void AddButtonColumn(string name, string text, int width)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = name;
            btn.HeaderText = "";
            btn.Text = text;
            btn.UseColumnTextForButtonValue = true;

            btn.Width = width;
            btn.MinimumWidth = width;
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btn.FlatStyle = FlatStyle.Popup;
            //btn.Frozen = true;
            dgvThietBi.Columns.Add(btn);
        }

        private void dgvThietBi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string colName = dgvThietBi.Columns[e.ColumnIndex].Name;

            if (colName == "btnEdit")
                StyleButton(e, Color.White, Color.FromArgb(255, 193, 7));
            else if (colName == "btnTransfer")
                StyleButton(e, Color.White, Color.FromArgb(13, 110, 253));
            else if (colName == "btnDelete")
                StyleButton(e, Color.White, Color.FromArgb(220, 53, 69));
        }

        void StyleButton(DataGridViewCellFormattingEventArgs e, Color fore, Color back)
        {
            e.CellStyle.ForeColor = fore;
            e.CellStyle.BackColor = back;
            e.CellStyle.SelectionBackColor = back;
            e.CellStyle.SelectionForeColor = Color.White;
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //e.CellStyle.Padding = new Padding(4);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Label label1;
        private TextBox textSearch;
        private DataGridView dgvThietBi;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cbLoaiThietBi;
        private ComboBox cbPhongBan;
        private ComboBox cbTrangThai;
    }
}