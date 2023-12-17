using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DAO
{

    internal class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private HoaDonDAO() { }

        public DataTable GetHoaDonInfo()
        {
            string query = "SELECT HoaDon.MaHoaDon, KhachHang.TenKH, HoaDon.NgayXuat, HoaDon.TongGiaSauGiam " +
                           "FROM HoaDon INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetHoaDonDetailByMaHD(string maHD)
        {
            string query = $"SELECT HoaDon.MaNV, NhanVien.TenNV, HoaDon.MaKH, KhachHang.TenKH, HoaDon.NgayLap, HoaDon.NgayXuat, HoaDon.TongGiaGoc , HoaDon.TongGiaSauGiam " +
                           $"FROM HoaDon " +
                           $"LEFT JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV " +
                           $"INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH " +
                           $"WHERE HoaDon.MaHoaDon = '{maHD}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetCTHoaDonByMaHD(string maHD)
        {
            string query = $"SELECT CTHoaDon.MaSP, CTHoaDon.TenSP, CTHoaDon.SoLuong, CTHoaDon.GiaTien " +
                           $"FROM CTHoaDon " +
                           $"WHERE CTHoaDon.MaHoaDon = '{maHD}'";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetSanPhamInfoForComboBox()
        {
            string query = "SELECT * FROM SanPham";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetGiaVaKhuyenMaiSanPham(string tenSP)
        {
            string query = $"SELECT SP.MaSP, SP.TenSP, SP.DonGia, " +
                           $"CASE WHEN CT.MaCTKM IS NULL THEN '' ELSE CT.MaCTKM END AS MaCTKM, " +
                           $"CASE WHEN CT.TenCTKM IS NULL THEN '' ELSE CT.TenCTKM END AS TenCTKM, " +
                           $"CASE WHEN CT.MucGiamGia IS NULL THEN '' ELSE CAST(CT.MucGiamGia AS NVARCHAR(50)) END AS MucGiamGia " +
                           $"FROM SanPham SP " +
                           $"LEFT JOIN ChuongTrinhKhuyenMai CT ON SP.Hang = CT.LoaiSanPhamDuocApDung " +
                           $"WHERE SP.TenSP = '{tenSP}' " +
                           $"AND CT.ThoiGianBatDau <= GETDATE() " +
                           $"AND CT.ThoiGianKetThuc >= GETDATE()";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetGiaSanPham(string tenSP)
        {
            string query = $"SELECT GiaBan, HinhAnh " +
                           $"FROM SanPham " +
                           $"WHERE TenSP = '{tenSP}'";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetKhuyenMaiSanPham(string tenSP)
        {
            string query = $"SELECT CT.MucGiamGia " +
                           $"FROM SanPham SP " +
                           $"LEFT JOIN ChuongTrinhKhuyenMai CT ON SP.Hang = CT.LoaiSanPhamDuocApDung " +
                           $"WHERE SP.TenSP = '{tenSP}' " +
                           $"AND CT.ThoiGianBatDau <= GETDATE() " +
                           $"AND CT.ThoiGianKetThuc >= GETDATE()";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public string TaoHoaDon(string maKH, string maNV, double tongGiaGoc, double tongGiaSauGiam)
        {
            string maHoaDon = TaoMaHoaDonMoi(); 

            DateTime ngayLap = DateTime.Now;
            DateTime ngayXuat = DateTime.Now;

            string query = "INSERT INTO HoaDon (MaHoaDon , MaKH , MaNV , NgayLap , NgayXuat , TongGiaGoc , TongGiaSauGiam ) " +
                           "VALUES ( @MaHoaDon , @MaKH , @MaNV , @NgayLap , @NgayXuat , @TongGiaGoc , @TongGiaSauGiam )";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                maHoaDon, maKH, maNV, ngayLap, ngayXuat, tongGiaGoc, tongGiaSauGiam
            });

            if (result > 0)
            {
                return maHoaDon; 
            }

            return ""; 
        }

        private string TaoMaHoaDonMoi()
        {
            string query = "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result != null && result.Rows.Count > 0)
            {
                string maHoaDonCuoiCung = result.Rows[0]["MaHoaDon"].ToString();
                int soThuTu = int.Parse(maHoaDonCuoiCung.Substring(2)) + 1; 


                string maHoaDonMoi = soThuTu.ToString().PadLeft(3, '0');
                return "HD" + maHoaDonMoi;
            }

            return "HD001"; 
        }

        public void ThemChiTietHoaDon(string maHoaDon, string maSP, string tenSP, int soLuong, double giaTien)
        {
            string query = "INSERT INTO CTHoaDon ( MaHoaDon , MaSP , TenSP , SoLuong , GiaTien ) " +
                           "VALUES ( @MaHoaDon , @MaSP , @TenSP , @SoLuong , @GiaTien )";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {
                maHoaDon, maSP, tenSP, soLuong, giaTien
            });

            if (result > 0)
            {
                // Giảm số lượng sản phẩm trong bảng SanPham
                string updateQuery = "UPDATE SanPham SET SoLuong = SoLuong - @SoLuong WHERE MaSP = @MaSP";
                int updateResult = DataProvider.Instance.ExecuteNonQuery(updateQuery, new object[] { soLuong, maSP });

                if (updateResult <= 0)
                {
                    
                }
            }
            else
            {

            }
        }

        public bool KiemTraTonTaiKhachHang(string maKH)
        {
            string query = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH";

            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { maKH });

            return count > 0; 
        }

        public bool XoaChiTietHoaDonByMaHD(string maHD)
        {
            string query = "DELETE FROM CTHoaDon WHERE MaHoaDon = @maHD";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD });

            return result > 0; 
        }

        public bool XoaHoaDonByMaHD(string maHD)
        {
            string query = "DELETE FROM HoaDon WHERE MaHoaDon = @maHD";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD });

            return result > 0;
        }

        public void ThanhToanHoaDon(string maHD)
        {
            // Lấy thông tin chi tiết hóa đơn dựa trên mã hóa đơn
            DataTable hoaDonDetail = GetCTHoaDonByMaHD(maHD);

            foreach (DataRow row in hoaDonDetail.Rows)
            {
                string maSP = row["MaSP"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);

                // Giảm số lượng sản phẩm trong kho
                GiuSoLuongSanPham(maSP, soLuong);
            }

            // Cập nhật NgayXuat cho hóa đơn
            CapNhatNgayXuatHoaDon(maHD);
        }

        private void CapNhatNgayXuatHoaDon(string maHD)
        {
            string query = "UPDATE HoaDon SET NgayXuat = GETDATE() WHERE MaHoaDon = @MaHoaDon";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD });
        }

        private void GiuSoLuongSanPham(string maSP, int soLuong)
        {
            string query = "UPDATE SanPham SET SoLuong = SoLuong - @SoLuong WHERE MaSP = @MaSP";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { soLuong, maSP });
        }

        public DataTable GetHoaDonByHoTen(string hoTen)
        {
            string query = $"SELECT HoaDon.MaHoaDon, KhachHang.TenKH, HoaDon.NgayXuat, HoaDon.TongGiaSauGiam " +
                           $"FROM HoaDon INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH " +
                           $"WHERE KhachHang.TenKH LIKE N'%{hoTen}%'";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetHoaDonByMaHoaDon(string maHoaDon)
        {
            string query = $"SELECT HoaDon.MaHoaDon, KhachHang.TenKH, HoaDon.NgayXuat, HoaDon.TongGiaSauGiam " +
                           $"FROM HoaDon INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH " +
                           $"WHERE HoaDon.MaHoaDon = '{maHoaDon}'";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool UpdateGiaSP(string id,int gia)
        {
            string query = "Update SanPham set DonGia = @DonGia where MaSP = @MaSP";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { gia,id });
            return result == 1;
        }

    }

}
