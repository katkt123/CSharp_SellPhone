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

namespace SellPhones.GUI
{
    public partial class TaoSanPhamMoi : Form
    {
        public TaoSanPhamMoi()
        {
            InitializeComponent();
        }
        public void resetText()
        {
            textbox_maSP.ResetText();
            textBox_TenSP.ResetText();
            ComboBox_Hang.ResetText();
            textBox_DungLuong.ResetText();
            textBox_HinhAnh.ResetText();
        }
        private void button_Luu_Click(object sender, EventArgs e)
        {
            string maSP = textbox_maSP.Text;
            string tenSP = textBox_TenSP.Text;
            string hang = ComboBox_Hang.Text;
            string dungluong = textBox_DungLuong.Text;
            int DonGia = Convert.ToInt32(ud_DonGia.Value);

            string hinhanh = textBox_HinhAnh.Text;
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(tenSP) || string.IsNullOrWhiteSpace(hang) || string.IsNullOrWhiteSpace(dungluong) || string.IsNullOrWhiteSpace(textBox_HinhAnh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Thoát khỏi phương thức nếu có bất kỳ trường nào trống
            }

            // Kiểm tra định dạng mã sản phẩm
            if (!maSP.StartsWith("SP") || !int.TryParse(maSP.Substring(2), out int maSPNumber))
            {
                MessageBox.Show("Định dạng mã sản phẩm không hợp lệ. Nó phải ở định dạng SP001.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra giá


            // Tại điểm này, bạn có thể giả định rằng tất cả các đầu vào đều hợp lệ và bạn có thể tiến hành thêm sản phẩm
            SanPhamBUS.Instance.AddSP(maSP, tenSP, hang, dungluong,DonGia, hinhanh);

            // Đặt lại các trường nhập
            resetText();
        }

        private void Button_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đã chọn và đặt nó vào TextBox
                textBox_HinhAnh.Text = openFileDialog.FileName;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
