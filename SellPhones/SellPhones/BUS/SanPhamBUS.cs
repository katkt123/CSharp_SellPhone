using SellPhones.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;


        public static SanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamBUS();
                return SanPhamBUS.instance;
            }
            private set { SanPhamBUS.instance = value; }
        }

        public DataTable getAllSanPham()
        {
            return SanPhamDAO.Instance.getAllSanPham();
        }

        public DataTable getAllSanPhamKhuyenMai()
        {
            // Gọi hàm GetAllSanPhamKhuyenMai từ DataAccessObject (DAO)
            return SanPhamDAO.Instance.getAllSanPhamKhuyenMai();
        }
        public bool AddSP(string maSP, string tenSP, string hang, string dungluong,int dongia, string hinhanh)
        {
            if (SanPhamDAO.Instance.CheckMaSPExists(maSP))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại");
                return false;
            }

            MessageBox.Show("Thêm sản phẩm thành công!");
            return SanPhamDAO.Instance.AddSP(maSP, tenSP, hang, dungluong,dongia, hinhanh);
        }


        public bool DeleteSanPham(string maSP)
        {
            if (!SanPhamDAO.Instance.CheckMaSPExists(maSP))
            {
                MessageBox.Show("Không tồn tại mã khuyến mãi cần xóa!");
                return false;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (SanPhamDAO.Instance.DeleteSP(maSP))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    return true;
                }
                MessageBox.Show("Có lỗi xảy ra khi xóa sản phẩm!");
                return false;
            }

            // Người dùng không xác nhận xóa
            MessageBox.Show("Không xóa sản phẩm!");
            return false;
        }
        public bool UpdateSanPham(string maSP, string tenSP, string hang, string dungluong, string hinhanh)
        {
            if (!SanPhamDAO.Instance.CheckMaSPExists(maSP))
            {
                MessageBox.Show("Không tồn tại sản phẩm cần cập nhật!");
                return false;
            }

            // Gọi hàm cập nhật từ DAO
            if (SanPhamDAO.Instance.UpdateSP(maSP, tenSP, hang, dungluong, hinhanh))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                return true;
            }

            MessageBox.Show("Có lỗi xảy ra khi cập nhật sản phẩm!");
            return false;
        }

    }
}
