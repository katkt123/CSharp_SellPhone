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
    public partial class TaoKhuyenMai : Form
    {
        KhuyenMaiUC khuyenMaiUC; // Khai báo biến khuyenMaiUC ở đây

        public TaoKhuyenMai()
        {
            InitializeComponent();
            AutoGeneratePromotionCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loaiSanPham = comboBox2.Text;

            // Kiểm tra xem hãng này có mã khuyến mãi còn hạn không
            DateTime currentDate = DateTime.Now; // Ngày hiện tại
            DataTable validPromotions = KhuyenMaiBUS.Instance.GetValidPromotions(currentDate);

            // Kiểm tra xem loại sản phẩm đã có mã khuyến mãi còn hạn hay không
            bool hasValidPromotion = CheckValidPromotionForBrand(validPromotions, loaiSanPham);

            if (hasValidPromotion)
            {
                MessageBox.Show("Hãng này đang có mã khuyến mãi còn hạn, không thể tạo mới!");
            }
            else
            {
                // Tiến hành tạo mã khuyến mãi mới
                string maCTKM = textBox1.Text;
                string tenCTKM = textBox2.Text;
                // Lấy chuỗi từ comboBox1.Text
                string mucGiamGiaStr = comboBox1.Text;

                // Loại bỏ ký tự '%' từ chuỗi
                mucGiamGiaStr = mucGiamGiaStr.Replace("%", "");

                // Chuyển đổi chuỗi sang kiểu int
                int mucGiamGia = int.Parse(mucGiamGiaStr);
                DateTime thoiGianBatDau = dateTimePicker1.Value;
                DateTime thoiGianKetThuc = dateTimePicker2.Value;
                DateTime thoiGianTao = DateTime.Now; // Thời gian tạo hiện tại

                KhuyenMaiBUS.Instance.InsertKhuyenMai(maCTKM, tenCTKM, mucGiamGia, loaiSanPham, thoiGianBatDau, thoiGianKetThuc, thoiGianTao);
                AutoGeneratePromotionCode();

                if (thoiGianBatDau > thoiGianKetThuc)
                {
                    // Xử lý khi thời gian bắt đầu lớn hơn thời gian kết thúc
                }
                else
                {
                    resetText();
                }
            }
        }

        // Phương thức kiểm tra xem loại sản phẩm đã có mã khuyến mãi còn hạn hay không
        private bool CheckValidPromotionForBrand(DataTable validPromotions, string loaiSanPham)
        {
            foreach (DataRow row in validPromotions.Rows)
            {
                string brand = row["LoaiSanPhamDuocApDung"].ToString();
                if (brand == loaiSanPham)
                {
                    return true; // Hãng này có mã khuyến mãi còn hạn
                }
            }
            return false; // Không có mã khuyến mãi còn hạn cho hãng này
        }

        private void AutoGeneratePromotionCode()
        {
            string lastCode = KhuyenMaiDAO.Instance.GetLastPromotionCode();
            if (!string.IsNullOrEmpty(lastCode))
            {
                // Lấy số thứ tự từ mã khuyến mãi cuối cùng, ví dụ: "KM001" sẽ lấy "001"
                string numberPart = lastCode.Substring(2);

                // Chuyển phần số sang kiểu int để tăng giá trị lên 1
                int number = int.Parse(numberPart) + 1;

                // Tạo mã mới với độ dài cố định (ví dụ: "KM" + số được format thành 3 ký tự)
                string newCode = string.Format("KM{0:000}", number);

                // Gán mã mới vào TextBox
                textBox1.Text = newCode;
            }
            else
            {
                // Nếu không có mã nào trong cơ sở dữ liệu, gán mã đầu tiên
                textBox1.Text = "KM001";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetText();
        }

        public void resetText()
        {
            //textBox1.ResetText();
            textBox2.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }
    }
}
