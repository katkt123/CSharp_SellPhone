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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SellPhones.GUI.UserControls
{

    public partial class TaoSanPham : Form
    {
        public SanPhamUC sanPhamUC;
        private int sanPhamCounter = 1;
        public TaoSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        public void resetText()
        {
            textbox_maSP.ResetText();
            textbox_tenSP.ResetText();
            ComboBox_Hang.ResetText();
            textbox_dungluong.ResetText();
            textbox_hinhanh.ResetText();
        }



        private string GenerateMaSP()
        {
            // Tạo mã sản phẩm tự động dựa trên biến đếm
            string maSP = "SP" + sanPhamCounter.ToString("D3"); // "D3" để đảm bảo có 3 chữ số
            return maSP;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đã chọn và đặt nó vào TextBox
                textbox_hinhanh.Text = openFileDialog.FileName;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            string maSP = textbox_maSP.Text;
            string tenSP = textbox_tenSP.Text;
            string hang = ComboBox_Hang.Text;
            string dungluong = textbox_dungluong.Text;

            string hinhanh = textbox_hinhanh.Text;
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(tenSP) || string.IsNullOrWhiteSpace(hang) || string.IsNullOrWhiteSpace(dungluong) || string.IsNullOrWhiteSpace(textbox_hinhanh.Text))
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
            //SanPhamBUS.Instance.AddSP(maSP, tenSP, hang, dungluong, hinhanh);

            // Đặt lại các trường nhập
            resetText();


        }

        private void button_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_capnhat_Click(object sender, EventArgs e)
        {
            string maSP = textbox_maSP.Text;
            string tenSP = textbox_tenSP.Text;
            string hang = ComboBox_Hang.Text;
            string dungluong = textbox_dungluong.Text;
             // Bạn có thể đặt một giá trị mặc định cho số lượng
            
            string hinhanh = textbox_hinhanh.Text;

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(tenSP) || string.IsNullOrWhiteSpace(hang) || string.IsNullOrWhiteSpace(dungluong) || string.IsNullOrWhiteSpace(hinhanh))
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

            SanPhamBUS.Instance.UpdateSanPham(maSP, tenSP, hang, dungluong, hinhanh);


        }

        private void textbox_dungluong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

