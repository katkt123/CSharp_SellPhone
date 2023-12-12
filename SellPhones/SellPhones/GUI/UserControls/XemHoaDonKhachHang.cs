using SellPhones.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhones.GUI.UserControls
{
    public partial class XemHoaDonKhachHang : Form
    {
        public XemHoaDonKhachHang()
        {
            InitializeComponent();
            LoadHoaDonKhachHang();
        }
        public void LoadHoaDonKhachHang()
        {
            DataTable dt = KhachHangBUS.Instance.getAllHoaDonKH(KhachHangUC.idkh);


            Grid_HoaDonKH.DataSource = dt;

            Grid_HoaDonKH.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            Grid_HoaDonKH.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            Grid_HoaDonKH.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            Grid_HoaDonKH.Columns["NgayLap"].HeaderText = "Ngày Lập";
            Grid_HoaDonKH.Columns["NgayXuat"].HeaderText = "Ngày Xuất";
            Grid_HoaDonKH.Columns["TongGiaGoc"].HeaderText = "Tổng Giá Gốc";
            Grid_HoaDonKH.Columns["TongGiaSauGiam"].HeaderText = "Tổng Giá Sau Giảm";



            Grid_HoaDonKH.Columns["MaHoaDon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_HoaDonKH.Columns["MaKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_HoaDonKH.Columns["MaNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_HoaDonKH.Columns["NgayLap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_HoaDonKH.Columns["NgayXuat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_HoaDonKH.Columns["TongGiaGoc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_HoaDonKH.Columns["TongGiaSauGiam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
