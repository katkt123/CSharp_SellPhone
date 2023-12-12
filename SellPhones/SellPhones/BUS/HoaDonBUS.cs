using SellPhones.DAO;
using SellPhones.DTO;
using SellPhones.GUI;
using SellPhones.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;


        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonBUS();
                return HoaDonBUS.instance;
            }
            private set { HoaDonBUS.instance = value; }
        }

        public HoaDonInfo[] GetHoaDonInfoArrayFromDAO()
        {
            DataTable dataTable = HoaDonDAO.Instance.GetHoaDonInfo();

            List<HoaDonInfo> hoaDonList = new List<HoaDonInfo>();
            foreach (DataRow row in dataTable.Rows)
            {
                string soHD = row["MaHoaDon"].ToString();
                string tenKhachHang = row["TenKH"].ToString();
                string ngayLap = row["NgayXuat"].ToString();
                string triGia = row["TongGiaSauGiam"].ToString();
                HoaDonInfo hoaDon = new HoaDonInfo(soHD, tenKhachHang, ngayLap, triGia);
                hoaDonList.Add(hoaDon);
            }

            return hoaDonList.ToArray();
        }

        public DataTable GetHoaDonDetailByMaHD(string maHD)
        {
            return HoaDonDAO.Instance.GetHoaDonDetailByMaHD(maHD);
        }

        public DataTable GetCTHoaDonByMaHD(string maHD)
        {
            return HoaDonDAO.Instance.GetCTHoaDonByMaHD(maHD);
        }

        public DataTable GetSanPhamInfoForComboBox()
        {
            return HoaDonDAO.Instance.GetSanPhamInfoForComboBox();
        }

        public DataTable GetGiaVaKhuyenMaiSanPham(string tenSP)
        {
            return HoaDonDAO.Instance.GetGiaVaKhuyenMaiSanPham(tenSP);
        }

        public DataTable GetGiaSanPham(string tenSP)
        {
            return HoaDonDAO.Instance.GetGiaSanPham(tenSP);
        }

        public DataTable GetKhuyenMaiSanPham(string tenSP)
        {
            return HoaDonDAO.Instance.GetKhuyenMaiSanPham(tenSP);
        }
        public string TaoHoaDon(string maKH, string maNV, double tongGiaGoc, double tongGiaSauGiam)
        {
            return HoaDonDAO.Instance.TaoHoaDon(maKH, maNV, tongGiaGoc, tongGiaSauGiam);
        }

        public void ThemChiTietHoaDon(string maHoaDon, string maSP, string tenSP, int soLuong, double giaTien)
        {
            HoaDonDAO.Instance.ThemChiTietHoaDon(maHoaDon, maSP, tenSP, soLuong, giaTien);

        }

        public bool KiemTraTonTaiKhachHang(string maKH)
        {
            return HoaDonDAO.Instance.KiemTraTonTaiKhachHang(maKH);
        }

        public bool XoaChiTietHoaDonByMaHD(string maHD)
        {
            return HoaDonDAO.Instance.XoaChiTietHoaDonByMaHD(maHD);
        }

        public bool XoaHoaDonByMaHD(string maHD)
        {
            return HoaDonDAO.Instance.XoaHoaDonByMaHD(maHD);
        }
        public void ThanhToanHoaDon(string maHD)
        {
            HoaDonDAO.Instance.ThanhToanHoaDon(maHD);
        }

        public DataTable GetHoaDonByHoTen(string hoTen)
        {
            return HoaDonDAO.Instance.GetHoaDonByHoTen(hoTen);
        }

        public DataTable GetHoaDonByMaHoaDon(string maHoaDon)
        {
            return HoaDonDAO.Instance.GetHoaDonByMaHoaDon(maHoaDon);
        }
    }
}
