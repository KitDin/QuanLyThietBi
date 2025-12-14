using QuanLyThietBi.Helpers.auth;
using QuanLyThietBi.Helpers.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyThietBi
{
    public partial class QuanLyThietBiForm : Form
    {
        private System.Windows.Forms.Timer searchTimer;

        ToolTip tip = new ToolTip();
        Helpers.db.TrangThietBi bus = new Helpers.db.TrangThietBi();
        Helpers.db.LookupDB lookupDB = new Helpers.db.LookupDB();
        private DataGridView dgvActions;
        private Panel containerPanel;
        public QuanLyThietBiForm()
        {
            InitializeComponent();

            loadDataPhongBan();
            loadDataLoaiThietBi();
            loadDataTrangThai();
            CreateSplitDataGridView();


            ApplyPermission();
            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 800;
            searchTimer.Tick += SearchTimer_Tick;
            dgvThietBi.CellClick += dgvThietBi_CellClick;
            dgvActions.CellClick += dgvThietBi_CellClick;
            cbPhongBan.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbLoaiThietBi.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbTrangThai.SelectedIndexChanged += ComboBox_SelectedIndexChanged;


        }

        private void CreateSplitDataGridView()
        {
            dgvThietBi.Visible = false;

            containerPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Location = dgvThietBi.Location,
                Size = dgvThietBi.Size
            };
            panel1.Controls.Add(containerPanel);
            containerPanel.BringToFront();

            dgvThietBi = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ScrollBars = ScrollBars.Horizontal,
                ReadOnly = true
            };

            dgvActions = new DataGridView
            {
                Dock = DockStyle.Right,
                Width = 280,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ScrollBars = ScrollBars.None,
                ReadOnly = true,
                AllowUserToResizeColumns = false,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            };

            containerPanel.Controls.Add(dgvThietBi);
            containerPanel.Controls.Add(dgvActions);

            // XÓA dòng này: styleDataGridView();
            styleActionsGridView();

            styleDataGridView(); // CHỈ GỌI 1 LẦN - tạo columns cho dgvThietBi
            AddActionButtons(); // Tạo columns cho dgvActions

            // THÊM EVENT HANDLER CHO dgvThietBi MỚI
            dgvThietBi.ColumnHeaderMouseClick += dgvThietBi_ColumnHeaderMouseClick;

            dgvThietBi.Scroll += (s, e) => SyncScroll();
            dgvActions.Scroll += (s, e) => SyncScroll();
        }

        private void AddActionButtons()
        {
            dgvActions.AutoGenerateColumns = false;
            dgvActions.Columns.Clear();

            int btnWidth = 90;

            AddButtonColumn(dgvActions, "btnEdit", " ✏ ", btnWidth);
            AddButtonColumn(dgvActions, "btnTransfer", " ⇄ ", btnWidth);
            AddButtonColumn(dgvActions, "btnDelete", " 🗑 ", btnWidth);
        }

        void AddButtonColumn(DataGridView dgv, string name, string text, int width)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn
            {
                Name = name,
                HeaderText = "",
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = width,
                MinimumWidth = width,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                FlatStyle = FlatStyle.Popup
            };
            dgv.Columns.Add(btn);
        }

        private void styleActionsGridView()
        {
            dgvActions.BorderStyle = BorderStyle.None;
            dgvActions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvActions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvActions.BackgroundColor = Color.White;
            dgvActions.EnableHeadersVisualStyles = false;

            dgvActions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvActions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvActions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvActions.ColumnHeadersHeight = 50;

            dgvActions.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvActions.DefaultCellStyle.BackColor = Color.White;
            dgvActions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dgvActions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250);

            dgvActions.RowTemplate.Height = 45;
            dgvActions.CellFormatting += dgvActions_CellFormatting;
        }

        private void SyncScroll()
        {
            if (dgvThietBi.FirstDisplayedScrollingRowIndex != dgvActions.FirstDisplayedScrollingRowIndex)
            {
                dgvActions.FirstDisplayedScrollingRowIndex = dgvThietBi.FirstDisplayedScrollingRowIndex;
            }
        }


        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void QuanLyThietBiForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();

            ApplyFilter();
        }

        private void LoadData()
        {
            var data = bus.GetAll();
            var bindingList = new BindingList<Model.TrangThietBiModel>(data);

            dgvThietBi.DataSource = bindingList;
            dgvActions.DataSource = bindingList;

            dgvActions.RowTemplate.Height = dgvThietBi.RowTemplate.Height;
        }


        void loadDataPhongBan()
        {
            var list = lookupDB.GetAllPhongBan();

            list.Insert(0, new Model.PhongBanModel
            {
                Ma_phong_ban = 0,
                Ten_phong_ban = "   -- Chọn phòng ban --"
            });

            cbPhongBan.DataSource = list;
            cbPhongBan.DisplayMember = "Ten_phong_ban";
            cbPhongBan.ValueMember = "Ma_phong_ban";
            cbPhongBan.SelectedIndex = 0;

            cbPhongBan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPhongBan.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            foreach (var pb in list)
                data.Add(pb.Ten_phong_ban);

            cbPhongBan.AutoCompleteCustomSource = data;
        }

        void loadDataLoaiThietBi()
        {
            var list = lookupDB.GetAllLoaiThietBi();

            list.Insert(0, new Model.LoaiThietBiModel
            {
                Ma_loai_thiet_bi = 0,
                Ten_loai_thiet_bi = "   -- Chọn loại --"
            });


            cbLoaiThietBi.DataSource = list;
            cbLoaiThietBi.DisplayMember = "Ten_loai_thiet_bi";
            cbLoaiThietBi.ValueMember = "Ma_loai_thiet_bi";
            cbLoaiThietBi.SelectedIndex = 0;

            cbLoaiThietBi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbLoaiThietBi.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (var lb in list)
                data.Add(lb.Ten_loai_thiet_bi);
            cbLoaiThietBi.AutoCompleteCustomSource = data;
        }

        void loadDataTrangThai()
        {
            var list = lookupDB.GetAllTrangThaiSuDung();

            list.Insert(0, new Model.TrangThaiSuDungModel
            {
                Ma_trang_thai = 0,
                Ten_trang_thai = "   -- Chọn trạng thái --"
            });

            cbTrangThai.DataSource = list;
            cbTrangThai.DisplayMember = "Ten_trang_thai";
            cbTrangThai.ValueMember = "Ma_trang_thai";
            cbTrangThai.SelectedIndex = 0;

            cbTrangThai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTrangThai.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (var tt in list)
                data.Add(tt.Ten_trang_thai);
            cbTrangThai.AutoCompleteCustomSource = data;
        }


        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemThietBi them = new ThemThietBi(null);
            them.FormClosed += (s, args) => LoadData();

            them.ShowDialog();
        }


        private void ApplyFilter()
        {
            int pb = cbPhongBan.SelectedIndex == 0 ? 0 : (int)cbPhongBan.SelectedValue;
            int loai = cbLoaiThietBi.SelectedIndex == 0 ? 0 : (int)cbLoaiThietBi.SelectedValue;
            int tt = cbTrangThai.SelectedIndex == 0 ? 0 : (int)cbTrangThai.SelectedValue;

            string keyword = textSearch.Text.Trim();

            var data = lookupDB.LookupThietBi(keyword, pb, loai, tt);
            var bindingList = new BindingList<Model.TrangThietBiModel>(data);

            dgvThietBi.DataSource = bindingList;
            dgvActions.DataSource = bindingList;

            dgvActions.RowTemplate.Height = dgvThietBi.RowTemplate.Height;
        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (!UserSession.IsAdmin)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này",
                    "Không đủ quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DataGridView clickedGrid = sender as DataGridView;
            string colName = clickedGrid.Columns[e.ColumnIndex].Name;

            string maThietBi = dgvThietBi.Rows[e.RowIndex].Cells["Ma_trang_thiet_bi"].Value.ToString();

            if (colName == "btnEdit")
            {
                ThemThietBi ttb = new ThemThietBi(maThietBi);
                ttb.FormClosed += (s, args) => LoadData();
                ttb.ShowDialog();
            }
            else if (colName == "btnTransfer")
            {
                MessageBox.Show("Tính năng đăng phát triển: " + maThietBi);
            }
            else if (colName == "btnDelete")
            {
                if (MessageBox.Show("Bạn chắc chắn xóa thiết bị này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool del = bus.Delete(maThietBi);

                    if (del)
                    {
                        MessageBox.Show("Xóa thiết bị thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
        }

        private void ApplyPermission()
        {
            if (!UserSession.IsAdmin)
            {
                btnAdd.Visible = false;

                if (dgvActions.Columns.Contains("btnEdit"))
                    dgvActions.Columns["btnEdit"].Visible = false;

                if (dgvActions.Columns.Contains("btnDelete"))
                    dgvActions.Columns["btnDelete"].Visible = false;

                if (dgvActions.Columns.Contains("btnTransfer"))
                    dgvActions.Columns["btnTransfer"].Visible = false;
            }
        }


    }
}
