using Microsoft.VisualBasic.ApplicationServices;
using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DAO
{
    internal class KhuyenMaiDAO
    {
        private static KhuyenMaiDAO instance;

        public static KhuyenMaiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhuyenMaiDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private KhuyenMaiDAO() { }

        public DataTable getAllKhuyenMai()
        {
            string query = "Select MaCTKM, TenCTKM, MucGiamGia, LoaiSanPhamDuocApDung, ThoiGianBatDau, ThoiGianKetThuc, ThoiGianTaoKM from ChuongTrinhKhuyenMai";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool InsertKhuyenMai(string maCTKM, string tenCTKM, int mucGiamGia, string loaiSanPham, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, DateTime thoiGianTao)
        {
            string query = "INSERT INTO ChuongTrinhKhuyenMai (MaCTKM, TenCTKM, MucGiamGia, LoaiSanPhamDuocApDung, ThoiGianBatDau, ThoiGianKetThuc, ThoiGianTaoKM) " +
                           "VALUES ( @MaCTKM , @TenCTKM , @MucGiamGia , @LoaiSanPham , @ThoiGianBatDau , @ThoiGianKetThuc , @ThoiGianTao )";
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCTKM, tenCTKM, mucGiamGia, loaiSanPham, thoiGianBatDau, thoiGianKetThuc, thoiGianTao });

            return rowsAffected > 0;
        }
        public bool CheckMaCTKMExists(string maCTKM)
        {
            string query = "SELECT COUNT(*) FROM ChuongTrinhKhuyenMai WHERE MaCTKM = @MaCTKM";
            int count = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { maCTKM });

            return count > 0;
        }
        public bool DeleteKhuyenMai(string maCTKM)
        {
            string query = "DELETE FROM ChuongTrinhKhuyenMai WHERE MaCTKM = @MaCTKM";
            int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCTKM });

            return rowsAffected > 0;
        }

        public DataTable SearchKhuyenMai(string maCTKM)
        {
            string query;
            query = "SELECT MaCTKM, TenCTKM, MucGiamGia, LoaiSanPhamDuocApDung, ThoiGianBatDau, ThoiGianKetThuc, ThoiGianTaoKM  FROM ChuongTrinhKhuyenMai WHERE MaCTKM = @MaCTKM ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maCTKM });
        }

        public DataTable GetValidPromotions(DateTime currentDate)
        {
            string query = "SELECT MaCTKM, TenCTKM, MucGiamGia, LoaiSanPhamDuocApDung, ThoiGianBatDau, ThoiGianKetThuc, ThoiGianTaoKM FROM ChuongTrinhKhuyenMai WHERE ThoiGianKetThuc >= @CurrentDate ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { currentDate });
        }
        public DataTable GetExpiredPromotions(DateTime currentDate)
        {
            string query = "SELECT MaCTKM, TenCTKM, MucGiamGia, LoaiSanPhamDuocApDung, ThoiGianBatDau, ThoiGianKetThuc, ThoiGianTaoKM FROM ChuongTrinhKhuyenMai WHERE ThoiGianKetThuc < @CurrentDate ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { currentDate });
        }

        public string GetLastPromotionCode()
        {
            string query = "SELECT TOP 1 MaCTKM FROM ChuongTrinhKhuyenMai ORDER BY MaCTKM DESC";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                string lastCode = result.Rows[0]["MaCTKM"].ToString();
                return lastCode;
            }

            return ""; // Trả về rỗng nếu không có mã nào trong cơ sở dữ liệu
        }








    }
}
