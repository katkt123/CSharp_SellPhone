using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DAO
{
    internal class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private SanPhamDAO() { }

        public DataTable getAllSanPham()
        {
            string query = "Select MaSP, TenSP, Hang, DungLuong, SoLuong,DonGia,GiaBan,HinhAnh from SanPham where TrangThaiTonTai = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getAllSanPhamBiXoa()
        {
            string query = "Select MaSP, TenSP, Hang, DungLuong, SoLuong,DonGia,GiaBan,HinhAnh from SanPham where TrangThaiTonTai = 0";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getAllSanPhamKhuyenMai()
        {
            //string query = $"SELECT sp.MaSP, sp.TenSP, sp.Hang, sp.DungLuong, sp.SoLuong, sp.DonGia, sp.HinhAnh, " +
            //               $"COALESCE(ctkm.MucGiamGia, 0) AS MucGiamGia, " +
            //               $"(CASE WHEN ctkm.MucGiamGia IS NOT NULL THEN sp.DonGia - sp.DonGia * ctkm.MucGiamGia / 100 ELSE sp.DonGia END) AS GiaSauGiam, " +
            //               $"sp.DonGia AS GiaTruocGiam " +
            //               $"FROM SanPham sp " +
            //               $"LEFT JOIN ChuongTrinhKhuyenMai ctkm ON sp.Hang = ctkm.LoaiSanPhamDuocApDung " +
            //               $"WHERE ((ctkm.ThoiGianBatDau IS NULL OR ctkm.ThoiGianBatDau <= GETDATE()) AND (ctkm.ThoiGianKetThuc IS NULL OR ctkm.ThoiGianKetThuc >= GETDATE())) AND sp.TrangThaiTonTai=1";
            string query = "SELECT \r\n    sp.MaSP, \r\n    sp.TenSP, \r\n    sp.Hang, \r\n    sp.DungLuong, \r\n    sp.SoLuong, \r\n    sp.GiaBan, \r\n    sp.HinhAnh,\r\n    COALESCE(ctkm.MucGiamGia, 0) AS MucGiamGia,\r\n    CASE \r\n        WHEN ctkm.MucGiamGia IS NOT NULL THEN sp.GiaBan - sp.GiaBan * ctkm.MucGiamGia / 100 \r\n        ELSE sp.GiaBan \r\n    END AS GiaSauGiam,\r\n    sp.GiaBan AS GiaTruocGiam\r\nFROM \r\n    SanPham sp\r\nLEFT JOIN \r\n    ChuongTrinhKhuyenMai ctkm ON sp.Hang = ctkm.LoaiSanPhamDuocApDung\r\nWHERE \r\n    (ctkm.ThoiGianBatDau IS NULL OR ctkm.ThoiGianBatDau <= GETDATE()) AND \r\n    (ctkm.ThoiGianKetThuc IS NULL OR ctkm.ThoiGianKetThuc >= GETDATE()) AND \r\n    sp.TrangThaiTonTai = 1;\r\n";
            //string query = "SELECT \r\n    sp.MaSP,\r\n    sp.TenSP,\r\n    sp.Hang,\r\n    sp.DungLuong,\r\n    sp.SoLuong,\r\n    sp.GiaBan,\r\n    sp.HinhAnh,\r\n    COALESCE(ctkm.MucGiamGia, 0) AS MucGiamGia,\r\n    CASE \r\n        WHEN ctkm.MucGiamGia IS NOT NULL THEN sp.DonGia - sp.DonGia * ctkm.MucGiamGia / 100 \r\n        ELSE sp.DonGia \r\n    END AS GiaSauGiam,\r\n    sp.DonGia AS GiaTruocGiam\r\nFROM \r\n    SanPham sp\r\nLEFT JOIN \r\n    ChuongTrinhKhuyenMai ctkm ON sp.Hang = ctkm.LoaiSanPhamDuocApDung\r\nWHERE \r\n    (ctkm.ThoiGianBatDau IS NULL OR ctkm.ThoiGianBatDau <= GETDATE())\r\n    AND (ctkm.ThoiGianKetThuc IS NULL OR ctkm.ThoiGianKetThuc >= GETDATE())\r\n    AND sp.TrangThaiTonTai = 1;\r\n";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddSP(string maSP, string tenSP, string hang, string dungluong, int dongia , string hinhanh)
        {
            int giaban = ((dongia * 10) / 100) + dongia;
            string query = "INSERT INTO SanPham (MaSP, TenSP, Hang, DungLuong, DonGia, GiaBan, SoLuong, HinhAnh, TrangThaiTonTai) " +
                           "VALUES ( @MaSP , @TenSP , @Hang , @DungLuong , @DonGia , @GiaBan , @SoLuong , @HinhAnh , 1)";
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maSP, tenSP, hang , dungluong, dongia , giaban, 0 , hinhanh });

            return rowsAffected > 0;
        }
        public bool DeleteSP(string maSP)
        {
            string query = "update SanPham set TrangThaiTonTai = 0 where MaSP = @id";
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maSP });

            return rowsAffected > 0;
        }
        public bool CheckMaSPExists(string maSP)
        {
            string query = "SELECT COUNT(*) FROM SanPham WHERE MaSP = @MaSP";
            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { maSP });

            return count > 0;
        }

        public bool UpdateSP(string maSP, string tenSP, string hang, string dungluong, string hinhanh)
        {
            string query = "update SanPham set TenSP = @tenSP , Hang = @hang , DungLuong = @dungluong , HinhAnh = @hinhanh where MaSP = @masp";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenSP, hang, dungluong, hinhanh, maSP });
            return result>0;
        }

        public DataTable searchSanPham(String data, String action)
        {
            string query = "";
            if (action == "Mã sản phẩm")
                query = "select * from SanPham where MaSP like '%" + data + "%'";
            else if (action == "Tên sản phẩm")
                query = "select * from SanPham where TenSP like N'%" + data + "%'";
            else if (action == "Hãng")
                query = "select * from Hang where Hang like N'%" + data + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchSP(string data)
        {
            if (string.Equals(data, "search", StringComparison.OrdinalIgnoreCase))
            {
                // Nếu người dùng nhập "search", trả về tất cả sản phẩm
                string sqlAllProducts = "SELECT * FROM SanPham";
                return DataProvider.Instance.ExecuteQuery(sqlAllProducts);
            }
            else
            {
                // Nếu người dùng nhập một từ khác, thực hiện tìm kiếm chi tiết
                string sqlSearch = "SELECT MaSP, TenSP, Hang, DungLuong, SoLuong,DonGia,HinhAnh FROM SanPham WHERE " +
                                   "CONCAT(MaSP, TenSP, Hang, DungLuong, SoLuong, DonGia, HinhAnh) COLLATE Latin1_General_CI_AI LIKE '%" + data + "%' and TrangThaiTonTai = 1";
                return DataProvider.Instance.ExecuteQuery(sqlSearch);
            }
        }
        public bool KhoiPhucSP(string id)
        {
            
            string query = "Update SanPham set TrangThaiTonTai = 1 where MaSP = @MaSP ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });


            return result > 0;
        }

        public int GetSoLuongTrongCuaHang(string maSP)
        {
            string query = "SELECT SoLuong FROM SanPham WHERE MaSP = @MaSP";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maSP });

            // If the result is not null, parse it to an integer; otherwise, return 0
            return result != null ? Convert.ToInt32(result) : 0;
        }

    }
}
