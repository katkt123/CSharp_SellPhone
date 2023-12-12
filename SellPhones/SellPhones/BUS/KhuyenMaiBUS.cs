using Sellphone.DAO;
using SellPhones.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SellPhones.BUS
{
    public class KhuyenMaiBUS
    {
        private static KhuyenMaiBUS instance;


        public static KhuyenMaiBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhuyenMaiBUS();
                return KhuyenMaiBUS.instance;
            }
            private set { KhuyenMaiBUS.instance = value; }
        }

        public DataTable getAllKhuyenMai()
        {
            return KhuyenMaiDAO.Instance.getAllKhuyenMai();
        }
        public bool InsertKhuyenMai(string maCTKM, string tenCTKM, int mucGiamGia, string loaiSanPham, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, DateTime thoiGianTao)
        {
            if (KhuyenMaiDAO.Instance.CheckMaCTKMExists(maCTKM))
            {
                MessageBox.Show("Mã khuyến mãi đã tồn tại");
                return false;
            }

            if (thoiGianBatDau > thoiGianKetThuc)
            {
                MessageBox.Show("Thời gian bắt đầu phải trước thời gian kết thúc!");
                return false;
            }

            MessageBox.Show("Thêm khuyến mãi thành công!");
            return KhuyenMaiDAO.Instance.InsertKhuyenMai(maCTKM, tenCTKM, mucGiamGia, loaiSanPham, thoiGianBatDau, thoiGianKetThuc, thoiGianTao);
        }


        public bool DeleteKhuyenMai(string maCTKM)
        {
            if (!KhuyenMaiDAO.Instance.CheckMaCTKMExists(maCTKM))
            {
                MessageBox.Show("Không tồn tại mã khuyến mãi cần xóa!");
                return false;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khuyến mãi này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (KhuyenMaiDAO.Instance.DeleteKhuyenMai(maCTKM))
                {
                    MessageBox.Show("Xóa khuyến mãi thành công!");
                    return true;
                }
                MessageBox.Show("Có lỗi xảy ra khi xóa khuyến mãi!");
                return false;
            }

            // Người dùng không xác nhận xóa
            MessageBox.Show("Không xóa khuyến mãi!");
            return false;
        }

        public DataTable SearchKhuyenMai(string maCTKM)
        {
            return KhuyenMaiDAO.Instance.SearchKhuyenMai(maCTKM);
        }

        public DataTable GetValidPromotions(DateTime currentDate)
        {
            return KhuyenMaiDAO.Instance.GetValidPromotions(currentDate);
        }

        public DataTable GetExpiredPromotions(DateTime currentDate)
        {
            return KhuyenMaiDAO.Instance.GetExpiredPromotions(currentDate) ;
        }

    }
}
