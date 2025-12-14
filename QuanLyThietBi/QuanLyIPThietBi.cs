using QuanLyThietBi.Helpers.auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThietBi
{
    public partial class QuanLyIPThietBi : Form
    {
        private System.Windows.Forms.Timer searchTimer;

        ToolTip tip = new ToolTip();
        Helpers.db.TrangThietBi bus = new Helpers.db.TrangThietBi();
        Helpers.db.LookupDB lookupDB = new Helpers.db.LookupDB();
        public QuanLyIPThietBi()
        {
            InitializeComponent();
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.RowHeadersVisible = false;
            dgvThietBi.AllowUserToAddRows = false;
            dgvThietBi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            styleDataGridView();
            loadDataPhongBan();
            loadDataLoaiThietBi();
            loadDataTrangThai();
            AddActionButtons();
            ApplyPermission();
            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 800;
            searchTimer.Tick += SearchTimer_Tick;
            dgvThietBi.CellClick += dgvThietBi_CellClick;
            cbPhongBan.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbLoaiThietBi.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbTrangThai.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }



        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
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


            string colName = dgvThietBi.Columns[e.ColumnIndex].Name;

            string maThietBi = dgvThietBi.Rows[e.RowIndex].Cells["Ma_trang_thiet_bi"].Value.ToString();

            if (colName == "btnEdit")
            {
                ThemDiaChiIP ttb = new ThemDiaChiIP(maThietBi);
                ttb.FormClosed += (s, args) => LoadData();
                ttb.ShowDialog();
            }
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
            var data = bus.GetAllTrangThietBi_IPModel();
            dgvThietBi.DataSource = new BindingList<Model.TrangThietBi_IPModel>(data);
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

        private void ApplyFilter()
        {
            int pb = cbPhongBan.SelectedIndex == 0 ? 0 : (int)cbPhongBan.SelectedValue;
            int loai = cbLoaiThietBi.SelectedIndex == 0 ? 0 : (int)cbLoaiThietBi.SelectedValue;
            int tt = cbTrangThai.SelectedIndex == 0 ? 0 : (int)cbTrangThai.SelectedValue;

            string keyword = textSearch.Text.Trim();

            var data = lookupDB.LookupThietBi(keyword, pb, loai, tt);
            dgvThietBi.DataSource = new BindingList<Model.TrangThietBiModel>(data);
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


        private void ApplyPermission()
        {
            // Nhân viên
            if (!UserSession.IsAdmin)
            {
                // Ẩn nút thêm

                // Ẩn các cột hành động
                if (dgvThietBi.Columns.Contains("btnEdit"))
                    dgvThietBi.Columns["btnEdit"].Visible = false;

                if (dgvThietBi.Columns.Contains("btnDelete"))
                    dgvThietBi.Columns["btnDelete"].Visible = false;

                if (dgvThietBi.Columns.Contains("btnTransfer"))
                    dgvThietBi.Columns["btnTransfer"].Visible = false;
            }
        }


    }
}
