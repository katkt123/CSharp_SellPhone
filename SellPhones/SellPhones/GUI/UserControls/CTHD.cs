using SellPhones.BUS;
using SellPhones.DAO;
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
    public partial class CTHD : Form
    {
        public CTHD(string maHD)
        {
            InitializeComponent();
            loadflowpanel(maHD);
            loadCTHD(maHD);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadflowpanel(string maHD)
        {
            DataTable hoaDonDetail = HoaDonBUS.Instance.GetCTHoaDonByMaHD(maHD);

            if (hoaDonDetail.Rows.Count > 0)
            {
                foreach (DataRow row in hoaDonDetail.Rows)
                {
                    string maSP = row["MaSP"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    string soLuong = row["SoLuong"].ToString();
                    string giaTien = row["GiaTien"].ToString();

                    CTHDInfoUC cthdInfo = new CTHDInfoUC(maSP, tenSP, soLuong, giaTien);
                    flowLayoutPanel1.Controls.Add(cthdInfo);
                }
            }
        }

        public void loadCTHD(string maHD)
        {
            DataTable hoaDonDetail = HoaDonBUS.Instance.GetHoaDonDetailByMaHD(maHD);

            if (hoaDonDetail.Rows.Count > 0)
            {
                // Lấy thông tin từ DataTable dựa trên mã hóa đơn truyền vào
                DataRow row = hoaDonDetail.Rows[0];
                string maNV = row["MaNV"].ToString();
                string tenNV = row["TenNV"].ToString();
                string maKH = row["MaKH"].ToString();
                string tenKH = row["TenKH"].ToString();
                string ngayLap = row["NgayLap"].ToString();
                string ngayXuat = row["NgayXuat"].ToString();
                string tonggiagoc = row["TongGiaGoc"].ToString() + "  USD";
                string tonggiasaugiam = row["TongGiaSauGiam"].ToString() + "  USD";

                // Đặt giá trị cho các Label
                label4.Text = maNV;
                label5.Text = tenNV;
                label6.Text = maKH;
                label7.Text = tenKH;
                label10.Text = ngayLap;
                label12.Text = maHD;
                label19.Text = tonggiagoc;
                label20.Text = tonggiasaugiam;

                // Kiểm tra NgayLap để hiển thị hoặc ẩn nút thanh toán
                if (string.IsNullOrEmpty(ngayXuat))
                {
                    // Nếu NgayLap trống, hiển thị nút thanh toán
                    buttonthanhtoan.Visible = true;
                }
                else
                {
                    // Ngược lại, ẩn nút thanh toán
                    buttonthanhtoan.Visible = false;
                }
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string maHD = label12.Text;

            DialogResult confirmResult = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (HoaDonBUS.Instance.XoaChiTietHoaDonByMaHD(maHD))
                {
                    if (HoaDonBUS.Instance.XoaHoaDonByMaHD(maHD))
                    {
                        MessageBox.Show("Xóa hóa đơn thành công!");
                        HoadonDaXoa?.Invoke(this, EventArgs.Empty); // Thông báo rằng hóa đơn đã bị xóa
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa hóa đơn!");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa chi tiết hóa đơn!");
                }
            }
            else
            {
                // Người dùng chọn "No" hoặc đóng hộp thoại xác nhận
                // Không có hành động nào cần thực hiện ở đây
            }
        }


        public event EventHandler HoadonDaXoa;



        private void buttonthanhtoan_Click(object sender, EventArgs e)
        {
            string maHD = label12.Text;

            DialogResult confirmResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                HoaDonBUS.Instance.ThanhToanHoaDon(maHD);
                MessageBox.Show("Thanh toán thành công!");
            }
            else
            {

            }
        }

        private int GetSoLuongHienCo(string tenSP, DataTable sanPhamInfo)
        {
            foreach (DataRow row in sanPhamInfo.Rows)
            {
                if (row["TenSP"].ToString() == tenSP)
                {
                    int soLuongHienCo;
                    if (int.TryParse(row["SoLuong"].ToString(), out soLuongHienCo))
                    {
                        return soLuongHienCo;
                    }
                }
            }
            return 0;
        }
    }
}
