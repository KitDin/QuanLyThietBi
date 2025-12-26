using Microsoft.IdentityModel.Tokens;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using QuanLyThietBi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuanLyThietBi
{
    public partial class ThongKeForm : Form
    {

        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            LoadChartTrangThai();
            LoadChartPhongBan();
            LoadChartThang(2025);
            LoadNumberOfYears();
        }

        private void LoadChartTrangThai()
        {
            var bus = new Helpers.db.LookupDB();
            List<Model.TrangThaiSuDungModel> trangThaiCount = bus.So_luong();
            var model = new PlotModel
            {
                Title = "Thống kê trạng thái thiết bị",
                TextColor = OxyColors.White,
                TitleColor = OxyColors.White,
                TitleFontSize = 15,
                TitlePadding = 10,
            };

            var pie = new PieSeries
            {
                InsideLabelPosition = 0.8,
                StrokeThickness = 1,
                AngleSpan = 360,
                StartAngle = 0,
            };

            foreach (Model.TrangThaiSuDungModel item in trangThaiCount)
            {
                if (item.So_luong <= 0) continue;

                pie.Slices.Add(new PieSlice(item.Ten_trang_thai, item.So_luong)
                {


                    Fill = item.Ten_trang_thai switch
                    {
                        "Đã cấp" => OxyColors.Green,
                        "Đang sử dụng" => OxyColors.Blue,
                        "Trong kho" => OxyColors.Orange,
                        "Hỏng" => OxyColors.Red,
                        _ => OxyColors.LightGray
                    }
                });
            }

            model.Series.Add(pie);
            plotTrangThai.Model = model;
        }

        private void LoadChartPhongBan()
        {
            var bus = new Helpers.db.PhongBan();
            List<PhongBanModel> phongBans = bus.GetSoLuong();

            var model = new PlotModel
            {
                Title = "Thống kê số lượng thiết bị theo phòng ban",
                TextColor = OxyColors.Black,
                TitleColor = OxyColors.Black,
                TitleFontSize = 15
            };

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "CategoryAxis",
                IsZoomEnabled = false,
                IsPanEnabled = false,
            };

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Số lượng thiết bị",
                TextColor = OxyColors.Black,
                TitleColor = OxyColors.Black,
                Minimum = 0,
                MajorStep = 1,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                MinorStep = 1
            };

            var barSeries = new BarSeries
            {
                Title = "Số lượng",
                FillColor = OxyColors.SkyBlue,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:0}"

            };

            foreach (PhongBanModel item in phongBans)
            {
                if (item.So_luong <= 0)
                {
                    categoryAxis.Labels.Add(item.Ten_phong_ban);
                    continue;
                }

                categoryAxis.Labels.Add(item.Ten_phong_ban);
                barSeries.Items.Add(new BarItem { Value = item.So_luong });
            }

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);
            model.Series.Add(barSeries);

            plotPhongBan.Model = model;
        }

        private void LoadChartThang(int year)
        {
            var bus = new Helpers.db.LookupDB();
            List<Model.ThongKeThangModel> thang = bus.GetThongKeThang(year);

            var model = new PlotModel
            {

            };


            var xAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Tháng",
                TextColor = OxyColors.Black,
                TitleColor = OxyColors.Black,
                AxislineColor = OxyColors.Black,
                TicklineColor = OxyColors.Black,
                Minimum = 0.5,
                Maximum = 12.5,
                MajorStep = 1,
                MinorStep = 1,
                StringFormat = "0",
                IsZoomEnabled = false,
                IsPanEnabled = false

            };

            var yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Số lượng thiết bị",
                TextColor = OxyColors.Black,
                TitleColor = OxyColors.Black,
                AxislineColor = OxyColors.Black,
                TicklineColor = OxyColors.Black,
                Minimum = 0,
                MajorStep = 1,
                MinorStep = 1,
                StringFormat = "0",
                MajorGridlineStyle = LineStyle.Solid,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                MajorGridlineColor = OxyColor.FromArgb(40, 0, 0, 0)
            };

            var seriesMuaMoi = new RectangleBarSeries
            {
                Title = "Mua mới",
                FillColor = OxyColors.SkyBlue,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            var seriesDuaVaoSuDung = new RectangleBarSeries
            {
                Title = "Đưa vào sử dụng",
                FillColor = OxyColors.Green,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            var seriesThemMoi = new RectangleBarSeries
            {
                Title = "Thêm mới",
                FillColor = OxyColors.Orange,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            double barWidth = 0.25;

            foreach (var item in thang)
            {
                double x = item.Thang;

                seriesMuaMoi.Items.Add(new RectangleBarItem
                {
                    X0 = x - barWidth * 1.2,
                    X1 = x - barWidth * 0.2,
                    Y0 = 0,
                    Y1 = item.SoThietBiMuaMoi
                });

                seriesDuaVaoSuDung.Items.Add(new RectangleBarItem
                {
                    X0 = x - barWidth * 0.5,
                    X1 = x + barWidth * 0.5,
                    Y0 = 0,
                    Y1 = item.SoThietBiDuaVaoSuDung
                });

                seriesThemMoi.Items.Add(new RectangleBarItem
                {
                    X0 = x + barWidth * 0.2,
                    X1 = x + barWidth * 1.2,
                    Y0 = 0,
                    Y1 = item.SoThietBiThemMoi
                });
            }

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            model.Series.Add(seriesMuaMoi);
            model.Series.Add(seriesDuaVaoSuDung);
            model.Series.Add(seriesThemMoi);

            plotThoiGian.Model = model;
        }

        private void LoadNumberOfYears()
        {
            int currentYear = DateTime.Now.Year;
            nbYear.Minimum = currentYear - 10;
            nbYear.Maximum = currentYear;
            nbYear.Value = currentYear;

        }

        private void plotTrangThai_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nbYear_ValueChanged(object sender, EventArgs e)
        {
            int selectedYear = (int)nbYear.Value;
            LoadChartThang(selectedYear);
            lbThongKeTheoThang.Text = $"THỐNG KÊ THIẾT BỊ THEO THÁNG ({selectedYear})";
        }
    }
}
