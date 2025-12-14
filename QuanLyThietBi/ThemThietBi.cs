using QuanLyThietBi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThietBi
{
    public partial class ThemThietBi : Form
    {
        bool isEdit = false;
        Helpers.db.TrangThietBi trangThietBi = new Helpers.db.TrangThietBi();
        Helpers.db.LookupDB bus = new Helpers.db.LookupDB();
        Helpers.db.PhongBan phongBanBus = new Helpers.db.PhongBan();
        ToolTip toolTip = new ToolTip();
        Model.PhongBanModel oldMaPhongBan;

        public ThemThietBi(string maThietBi)
        {
            InitializeComponent();
            tbMaThietBi.ReadOnly = true;
            tbMaThietBi.BackColor = SystemColors.Control;
            setToolTip();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.AcceptButton = btnThem;
            loadDataPhongBan();
            loadDataLoaiThietBi();
            loadDataTrangThai();

            roleAction(maThietBi);
        }


        private void setToolTip()
        {
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Ghi chú";
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;
        }


        private void roleAction(string maThietBi)
        {
            if (!string.IsNullOrWhiteSpace(maThietBi))
            {
                isEdit = true;
                this.Text = "Sửa thiết bị";
                btnThem.Text = "Sửa";
                cbIP.Enabled = false;
                tbIP.Enabled = false;
                var ttb = trangThietBi.GetTrangThietBi(maThietBi);
                oldMaPhongBan = phongBanBus.GetById(ttb.MaPhongBan);

                FillData(ttb);
            }
            else
            {
                btnThem.Text = "Thêm";
                notAss.Visible = false;
            }
        }

        void loadDataPhongBan()
        {
            var list = bus.GetAllPhongBan();

            cbPhongBan.DataSource = list;
            cbPhongBan.DisplayMember = "Ten_phong_ban";
            cbPhongBan.ValueMember = "Ma_phong_ban";
            cbPhongBan.SelectedIndex = -1;

            cbPhongBan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPhongBan.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            foreach (var pb in list)
                data.Add(pb.Ten_phong_ban);

            cbPhongBan.AutoCompleteCustomSource = data;
        }

        void loadDataLoaiThietBi()
        {
            var list = bus.GetAllLoaiThietBi();
            cbLoaiThietBi.DataSource = list;
            cbLoaiThietBi.DisplayMember = "Ten_loai_thiet_bi";
            cbLoaiThietBi.ValueMember = "Ma_loai_thiet_bi";
            cbLoaiThietBi.SelectedIndex = -1;

            cbLoaiThietBi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbLoaiThietBi.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (var lb in list)
                data.Add(lb.Ten_loai_thiet_bi);
            cbLoaiThietBi.AutoCompleteCustomSource = data;
        }

        void loadDataTrangThai()
        {
            var list = bus.GetAllTrangThaiSuDung();

            cbTrangThai.DataSource = list;
            cbTrangThai.DisplayMember = "Ten_trang_thai";
            cbTrangThai.ValueMember = "Ma_trang_thai";
            cbTrangThai.SelectedIndex = -1;

            cbTrangThai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTrangThai.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (var tt in list)
                data.Add(tt.Ten_trang_thai);
            cbTrangThai.AutoCompleteCustomSource = data;
        }

        private void cbIP_CheckedChanged(object sender, EventArgs e)
        {
            tbIP.Visible = cbIP.Checked;
        }

        private void cbLoaiThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiThietBi.SelectedIndex == -1) return;

            string tenLoai = cbLoaiThietBi.Text;


            if (isEdit) return;

            string newID = trangThietBi.GenerateNextMaThietBi(tenLoai);

            tbMaThietBi.Text = newID;
        }

        private bool ValidateForm()
        {
            if (!Helpers.Validate.ValidateTextBox(tbMaThietBi, "Mã thiết bị")) return false;

            if (!Helpers.Validate.ValidateComboBox(cbPhongBan, "Phòng ban")) return false;
            if (!Helpers.Validate.ValidateComboBox(cbLoaiThietBi, "Loại thiết bị")) return false;
            if (!Helpers.Validate.ValidateComboBox(cbTrangThai, "Trạng thái")) return false;

            if (cbIP.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbIP.Text))
                {
                    MessageBox.Show("IP không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbIP.Focus();
                    return false;
                }


                if (Helpers.Validate.HasSpecialChar(tbIP.Text))
                {
                    MessageBox.Show("IP không được chứa ký tự đặc biệt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbIP.Focus();
                    return false;
                }
            }

            if (dateSuDung.Value <= dateMua.Value)
            {
                MessageBox.Show("Ngày sử dụng không được trước ngày mua!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateSuDung.Focus();
                return false;
            }

            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn hủy và đóng form không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var model = GetFormData();
            if (model == null)
                return;
            bool success = false;

            if (!isEdit)
            {
                ThemThietBiAction(success, model);
                return;

            }

            SuaAction(success, model);
        }

        private void ThemThietBiAction(bool status, Model.TrangThietBiDTOModel model)
        {
            status = trangThietBi.AddNewThietBi(model);

            if (status)
            {
                MessageBox.Show("Thêm thiết bị thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thiết bị thất bại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SuaAction(bool status, Model.TrangThietBiDTOModel model)
        {
            if (model.MaPhongBan != oldMaPhongBan.Ma_phong_ban.ToString())
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn muốn đổi phòng ban từ \"{oldMaPhongBan.Ten_phong_ban}\" " +
                    $"sang \"{phongBanBus.GetById(model.MaPhongBan).Ten_phong_ban}\"?\n\n" +
                    $"Hãy chắc chắn bạn đã xuất giấy điều chuyển!",
                    "Xác nhận điều chuyển",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    cbPhongBan.SelectedValue = oldMaPhongBan.Ma_phong_ban;
                    return;
                }
            }

            status = trangThietBi.UpdateThietBi(model);

            if (status)
            {
                MessageBox.Show("Cập nhật thiết bị thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thiết bị thất bại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Model.TrangThietBiDTOModel GetFormData()
        {
            Model.TrangThietBiDTOModel model = new Model.TrangThietBiDTOModel();


            model.MaThietBi = tbMaThietBi.Text.Trim();
            model.DonViTinh = tbDonViTinh.Text.Trim();

            model.MaPhongBan = cbPhongBan.SelectedValue?.ToString();
            model.MaLoaiThietBi = cbLoaiThietBi.SelectedValue?.ToString();
            model.MaTrangThai = cbTrangThai.SelectedValue?.ToString();

            model.Seri = tbSeri.Text.Trim();
            model.Model = tbModel.Text.Trim();
            model.Hang = tbHang.Text.Trim();
            model.CauHinh = tbCauHinh.Text.Trim();
            model.LoaiKetNoi = tbLoaiKetNoi.Text.Trim();

            model.NgaySuDung = dateSuDung.Value;
            model.NgayBaoHanh = dateBaoHanh.Value;
            model.NgayBaoTri = dateBaoTri.Value;
            model.NgayMua = dateMua.Value;


            if (decimal.TryParse(tbGia.Text, out decimal gia))
                model.Gia = gia;


            model.DiaChiIP = null;

            if (cbIP.Checked)
            {
                string ip = tbIP.Text.Trim();

                if (string.IsNullOrWhiteSpace(ip))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ IP",
                        "Thiếu thông tin",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    tbIP.Focus();
                    return null;
                }

                if (!Helpers.Validate.IsValidIPv4(ip))
                {
                    MessageBox.Show("Địa chỉ IP không hợp lệ (vd: 192.168.1.7)",
                        "Sai định dạng IP",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    tbIP.Focus();
                    return null;
                }

                model.DiaChiIP = ip;
            }




            model.GhiChu = tbGhiChu.Text.Trim();

            return model;
        }

        public void FillData(TrangThietBiDTOModel ttb)
        {
            tbMaThietBi.Text = ttb.MaThietBi;
            tbDonViTinh.Text = ttb.DonViTinh;
            cbPhongBan.SelectedValue = int.Parse(ttb.MaPhongBan);
            cbLoaiThietBi.SelectedValue = int.Parse(ttb.MaLoaiThietBi);
            cbTrangThai.SelectedValue = int.Parse(ttb.MaTrangThai);
            tbSeri.Text = ttb.Seri;
            tbModel.Text = ttb.Model;
            tbHang.Text = ttb.Hang;
            tbCauHinh.Text = ttb.CauHinh;
            tbLoaiKetNoi.Text = ttb.LoaiKetNoi;
            dateSuDung.Value = ttb.NgaySuDung ?? DateTime.Now;
            dateBaoHanh.Value = ttb.NgayBaoHanh ?? DateTime.Now;
            dateBaoTri.Value = ttb.NgayBaoTri ?? DateTime.Now;
            dateMua.Value = ttb.NgayMua ?? DateTime.Now;
            tbGia.Text = ttb.Gia.ToString() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(ttb.DiaChiIP))
            {
                cbIP.Checked = true;
                tbIP.Text = ttb.DiaChiIP;
            }
            else
            {
                cbIP.Checked = false;
            }
            tbGhiChu.Text = ttb.GhiChu;
        }

        private void tbMaThietBi_MouseHover(object sender, EventArgs e)
        {
            if (isEdit)
            {
                toolTip.SetToolTip(tbMaThietBi,
         "Không thể đối mã khi CHỈNH SỬA!");
                toolTip.SetToolTip(cbLoaiThietBi, "Ở chỉnh sửa, thay đổi loại thiết bị không làm thay đổi Mã Thiết Bị!");
            }
            else toolTip.SetToolTip(tbMaThietBi,
        "Chọn Loại Thiết Bị tương ứng, Mã tự sinh");
        }
    }
}
