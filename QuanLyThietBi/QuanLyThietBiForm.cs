using QuanLyThietBi.Helpers.auth;
using QuanLyThietBi.Helpers.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ClosedXML.Excel;
using System.IO;



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
        private List<Model.TrangThietBiModel> listTTB = new List<Model.TrangThietBiModel>();
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

            styleActionsGridView();

            styleDataGridView();
            AddActionButtons();

            dgvThietBi.ColumnHeaderMouseClick += dgvThietBi_ColumnHeaderMouseClick;
            dgvThietBi.CellDoubleClick += dgvThietBi_CellDoubleClick;

            dgvThietBi.Scroll += (s, e) => SyncScroll();
            dgvActions.Scroll += (s, e) => SyncScroll();
        }


        private void dgvThietBi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvThietBi.Rows[e.RowIndex];
            var cell = row.Cells["Checked"];

            var model = row.DataBoundItem as Model.TrangThietBiModel;

            if (model != null)
            {
                listTTB.Add(model);
            }

            bool current = cell.Value != null && (bool)cell.Value;


            cell.Value = !current;
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

        private void linkChosse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var selectedList = GetCheckedItems();

            if (selectedList.Count == 0)
            {
                MessageBox.Show("Chưa chọn thiết bị nào!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            Form frm = new Form
            {
                Text = "Danh sách thiết bị đã chọn",
                Width = 900,
                Height = 500,
                StartPosition = FormStartPosition.CenterParent
            };

            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoGenerateColumns = true
            };

            dgv.DataSource = new BindingList<Model.TrangThietBiModel>(selectedList);

            if (dgv.Columns.Contains("Dia_chi_IP"))
            {
                dgv.Columns["Dia_chi_IP"].Visible = false;
            }

            frm.Controls.Add(dgv);
            frm.ShowDialog();
        }


        private List<Model.TrangThietBiModel> GetCheckedItems()
        {
            dgvThietBi.EndEdit();

            listTTB = dgvThietBi.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Checked"].Value != null &&
                            r.Cells["Checked"].Value != DBNull.Value &&
                            (bool)r.Cells["Checked"].Value)
                .Select(r => r.DataBoundItem as Model.TrangThietBiModel)
                .Where(m => m != null)
                .ToList();
            return listTTB;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var selectedList = GetCheckedItems();

            if (selectedList.Count == 0)
            {
                MessageBox.Show("Chưa chọn thiết bị nào để xuất Excel!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ExportToExcel(selectedList);
        }

        private void ExportToExcel(List<Model.TrangThietBiModel> data)
        {
            if (data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                FileName = $"DanhSachThietBi_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Thiết bị");

                    worksheet.Cell(1, 1).Value = "Mã thiết bị";
                    worksheet.Cell(1, 2).Value = "Model";
                    worksheet.Cell(1, 3).Value = "Số Seri";
                    worksheet.Cell(1, 4).Value = "Loại thiết bị";
                    worksheet.Cell(1, 5).Value = "Phòng ban";
                    worksheet.Cell(1, 6).Value = "Trạng thái";
                    worksheet.Cell(1, 7).Value = "Thời gian mua";


                    worksheet.Cell(1, 1).Value = "Mã thiết bị";
                    worksheet.Cell(1, 2).Value = "Tên thiết bị";
                    worksheet.Cell(1, 3).Value = "Loại thiết bị";
                    worksheet.Cell(1, 4).Value = "Tên phòng ban";
                    worksheet.Cell(1, 5).Value = "Tên trạng thái";

                    worksheet.Cell(1, 6).Value = "Đơn vị tính";
                    worksheet.Cell(1, 7).Value = "Model";
                    worksheet.Cell(1, 8).Value = "Số seri";

                    worksheet.Cell(1, 9).Value = "Thời gian mua";
                    worksheet.Cell(1, 10).Value = "Cấu hình";
                    worksheet.Cell(1, 11).Value = "Loại kết nối";
                    worksheet.Cell(1, 12).Value = "Đơn giá";
                    worksheet.Cell(1, 13).Value = "Thời gian được sử dụng";
                    worksheet.Cell(1, 14).Value = "Thời gian bảo chì";
                    worksheet.Cell(1, 15).Value = "Hạng bảo hành";
                    worksheet.Cell(1, 16).Value = "Ghi chú";


                    var headerRange = worksheet.Range(1, 1, 1, 16);
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.FromHtml("#007ACC");
                    headerRange.Style.Font.FontColor = XLColor.White;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    int row = 2;
                    foreach (var item in data)
                    {
                        worksheet.Cell(row, 1).Value = item.Ma_trang_thiet_bi;
                        worksheet.Cell(row, 2).Value = item.Ten_trang_thiet_bi;
                        worksheet.Cell(row, 3).Value = item.Ten_loai_thiet_bi;
                        worksheet.Cell(row, 4).Value = item.Ten_phong_ban;
                        worksheet.Cell(row, 5).Value = item.Ten_trang_thai;

                        worksheet.Cell(row, 6).Value = item.Don_vi_tinh;
                        worksheet.Cell(row, 7).Value = item.Model;
                        worksheet.Cell(row, 8).Value = item.So_seri;

                        worksheet.Cell(row, 9).Value = item.Thoi_gian_mua;
                        worksheet.Cell(row, 9).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheet.Cell(row, 10).Value = item.Cau_hinh;
                        worksheet.Cell(row, 11).Value = item.Loai_ket_noi;
                        worksheet.Cell(row, 12).Value = item.Don_gia;
                        worksheet.Cell(row, 12).Style.NumberFormat.Format = "#,##0.00";
                        worksheet.Cell(row, 13).Value = item.Thoi_gian_dua_vao_su_dung;
                        worksheet.Cell(row, 13).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheet.Cell(row, 14).Value = item.Thoi_gian_bao_tri;
                        worksheet.Cell(row, 14).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheet.Cell(row, 15).Value = item.Hang_bao_hanh;
                        worksheet.Cell(row, 15).Style.DateFormat.Format = "dd/MM/yyyy";
                        worksheet.Cell(row, 16).Value = item.Ghi_chu;
                        row++;
                    }

                    worksheet.Columns().AdjustToContents();

                    var dataRange = worksheet.Range(1, 1, row - 1, 16);
                    dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    workbook.SaveAs(sfd.FileName);
                }
                ShowExportSuccessDialog(sfd.FileName, data.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowExportSuccessDialog(string filePath, int count)
        {
            int seconds = 5;

            Form frm = new Form
            {
                Width = 420,
                Height = 200,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Text = "Xác nhận",
                TopMost = true
            };

            Label lbl = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10),
                Text = $"Xuất Excel thành công!\n" +
                       $"Đã xuất {count} thiết bị.\n" +
                       $"File sẽ tự động mở trong {seconds}s."
            };

            Button btnOk = new Button
            {
                Text = $"OK ({seconds})",
                Dock = DockStyle.Bottom,
                Height = 45
            };

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1000 };

            timer.Tick += (s, e) =>
            {
                seconds--;
                btnOk.Text = $"OK ({seconds})";
                lbl.Text = $"Xuất thành công!\n" +
                           $"Đã xuất {count} thiết bị.\n" +
                           $"File sẽ tự động mở trong {seconds}s.";

                if (seconds <= 0)
                {
                    timer.Stop();
                    frm.Close();
                }
            };

            btnOk.Click += (s, e) =>
            {
                timer.Stop();
                frm.Close();
            };

            frm.FormClosed += (s, e) =>
            {
                try
                {
                    if (System.IO.File.Exists(filePath))
                    {
                        System.Diagnostics.Process.Start(
                            new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });
                    }
                }
                catch (Exception openEx)
                {
                    MessageBox.Show($"File đã được lưu nhưng không thể tự động mở.\nVui lòng mở thủ công tại:\n{filePath}",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            };

            frm.Controls.Add(lbl);
            frm.Controls.Add(btnOk);

            timer.Start();
            frm.ShowDialog();
        }


    }
}
