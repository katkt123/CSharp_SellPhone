using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class NhanVienUC : UserControl
    {
        public NhanVienUC()
        {
            InitializeComponent();
            loadnhanvien();
        }

        public void loadnhanvien()
        {
            DataTable dt = NhanVienBUS.Instance.getAllNhanVien();


            Grid_NhanVien.DataSource = dt;

            Grid_NhanVien.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            Grid_NhanVien.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
            Grid_NhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            Grid_NhanVien.Columns["DiaChiNV"].HeaderText = "Địa Chỉ";
            Grid_NhanVien.Columns["SDTNV"].HeaderText = "Số Điện Thoại";
            Grid_NhanVien.Columns["MaTK"].HeaderText = "Mã Tài Khoản";



            Grid_NhanVien.Columns["MaNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_NhanVien.Columns["TenNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_NhanVien.Columns["GioiTinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_NhanVien.Columns["DiaChiNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_NhanVien.Columns["SDTNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_NhanVien.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox_TK.Text == "" || textBox_MK.Text == "" || groupBox1.Text == "")

            {

            }
            else
            {
                string taikhoan = textBox_TK.Text;
                string matkhau = textBox_MK.Text;
                string name = textBox1.Text;
                string gioitinh = "";

                foreach (Control control in groupBox1.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radioButton = (RadioButton)control;

                        if (radioButton.Checked)
                        {
                            gioitinh = radioButton.Text;
                            break;
                        }
                    }
                }
                string diachi = textBox2.Text;
                string sdt = textBox3.Text;

                NhanVienBUS.Instance.Register(taikhoan, matkhau, name, gioitinh, diachi, sdt);

                loadnhanvien();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_TK.Text = "";
            textBox_MK.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    // Đặt thuộc tính Checked của RadioButton về false
                    radioButton.Checked = false;
                }
            }
            loadnhanvien();
        }

        private void Sửa_Click(object sender, EventArgs e)
        {
            if (Grid_NhanVien.SelectedRows.Count > 0)
            {
                String id = textBox4.Text;
                string ten = textBox1.Text;
                string gioitinh = "";

                foreach (Control control in groupBox1.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radioButton = (RadioButton)control;

                        if (radioButton.Checked)
                        {
                            gioitinh = radioButton.Text;
                            break;
                        }
                    }
                }
                string diachi = textBox2.Text;
                string sdt = textBox3.Text;

                NhanVienBUS.Instance.UpdateNhanVien(id, ten, gioitinh, diachi, sdt);
                MessageBox.Show("Cập nhật thành công !!!");
                loadnhanvien();
            }
            else MessageBox.Show("Vui lòng chọn một dòng trước khi sửa !!!!!");
        }
        private void Grid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Grid_NhanVien.Rows[e.RowIndex];

                textBox4.Text = row.Cells["MaNV"].Value.ToString();
                textBox1.Text = row.Cells["TenNV"].Value.ToString();
                textBox3.Text = row.Cells["SDTNV"].Value.ToString();
                textBox2.Text = row.Cells["DiaChiNV"].Value.ToString();
                textBox_TK.Text = TaiKhoanDAO.Instance.getUser(row.Cells["MaTK"].Value.ToString());
                textBox_MK.Text = TaiKhoanDAO.Instance.getPass(row.Cells["MaTK"].Value.ToString());

                // Giả sử cột GioiTinh trong DataGridView chứa giá trị "Nam" hoặc "Nữ"
                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();

                // Xác định và chọn RadioButton tương ứng với giới tính
                if (gioiTinh == "Nam")
                {
                    radioButton1.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    radioButton2.Checked = true;
                }
            }
        }


        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string data = textBox_Search.Text;

            if (data == "")
            {
                loadnhanvien();
            }
            else
            {
                DataTable dt = NhanVienBUS.Instance.searchNhanVien(data);

                // Cập nhật dữ liệu lên Grid_NhanVien
                Grid_NhanVien.DataSource = dt;
                // Cấu hình cột nếu cần

                // Tự động điều chỉnh kích thước cột
                foreach (DataGridViewColumn column in Grid_NhanVien.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            textBox_Search.Clear();
        }
    }
}
