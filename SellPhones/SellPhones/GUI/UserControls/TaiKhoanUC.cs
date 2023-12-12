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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SellPhones.GUI.UserControls
{
    public partial class TaiKhoanUC : UserControl
    {
        string user = LoginGUI.user;
        string password = LoginGUI.password;
        public TaiKhoanUC()
        {
            InitializeComponent();
            loadTaiKhoanlist();
            loadQuyenlist();
            setNull();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string user = textBox_TK.Text;
            string pass = textBox_MK.Text;
            TaiKhoanBUS.Instance.insertTaiKhoan(user, pass);
            loadTaiKhoanlist();
        }
        private void TaiKhoanUC_Load(object sender, EventArgs e)
        {
            loadTaiKhoanlist();
            loadQuyenlist();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (Grid_TaiKhoan.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa  tài khoản", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string maTK = Grid_TaiKhoan.SelectedRows[0].Cells["MaTK"].Value.ToString();
                    TaiKhoanBUS.Instance.DelTaiKhoan(maTK);
                    MessageBox.Show("Xóa Thành Công !!!!!");
                    Grid_TaiKhoan.Rows.Remove(Grid_TaiKhoan.SelectedRows[0]);
                    setNull();
                }
            }
            else MessageBox.Show("Bạn  phải  chọn  mẩu  tin  cần  xóa");

            loadTaiKhoanlist();
            loadQuyenlist();
        }

        private void tabPage_TK_Click(object sender, EventArgs e)
        {

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            setNull();
            loadTaiKhoanlist();
            loadQuyenlist();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void setNull()
        {
            if (comboBox1.Items.Count > 0)
            {
                // Chọn item đầu tiên
               comboBox1.SelectedIndex = 0;
            }
            textBox_TK.Text = "";
            textBox_MK.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
        public void loadTaiKhoanlist()
        {
            DataTable dt = TaiKhoanBUS.Instance.getAllTaiKhoan();

            if (Grid_TaiKhoan.Columns.Contains("Lock"))
            {
                Grid_TaiKhoan.Columns.Remove("Lock");
            }
            Grid_TaiKhoan.DataSource = dt;

            Grid_TaiKhoan.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            Grid_TaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            Grid_TaiKhoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            Grid_TaiKhoan.Columns["Email"].HeaderText = "E-Mail";
            Grid_TaiKhoan.Columns["TrangThai"].HeaderText = "Trạng Thái";


            Grid_TaiKhoan.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["TenDangNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["MatKhau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.Name = "Lock";
            deleteButtonColumn.HeaderText = "Khóa";
            string imagePath = @"C:\SGU\Nam3 HK1\C#\Backup_2\SellPhones\SellPhones\Comp\Lock.png"; // Thay đổi đường dẫn tới hình ảnh của bạn

            Image deleteImage = Image.FromFile(imagePath);
            deleteButtonColumn.Image = deleteImage;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Grid_TaiKhoan.Columns.Add(deleteButtonColumn);
            Grid_TaiKhoan.CellContentClick += Grid_TaiKhoan_CellContentClick;

        }
        public void loadQuyenlist()
        {
            DataTable dt = TaiKhoanBUS.Instance.getAllQuyen();


            Grid_Quyen.DataSource = dt;

            Grid_Quyen.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            Grid_Quyen.Columns["PhanQuyen"].HeaderText = "Quyền";



            Grid_Quyen.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_Quyen.Columns["PhanQuyen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void Grid_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Grid_TaiKhoan.Columns["Lock"].Index && e.RowIndex >= 0)
            {
            
                string matk = Grid_TaiKhoan.Rows[e.RowIndex].Cells["MaTK"].Value.ToString();
                string firstTwoChars = matk.Substring(0, 2);
                DialogResult result = MessageBox.Show("Bạn muốn khóa tài khoản này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (firstTwoChars == "AD")
                    {
                        MessageBox.Show("Tài Khoản ADMIN không thể bị khóa vui lòng chọn tài khoản khác !!!!!!!!");
                    }
                    else
                    {
                        TaiKhoanBUS.Instance.KhoaTaiKhoan(matk);
                        MessageBox.Show("Khóa Thành Công");
                        loadTaiKhoanlist();
                        loadQuyenlist();
                        setNull();
                    }
                }
                    
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (Grid_TaiKhoan.SelectedRows.Count > 0)
            {
                TaiKhoanBUS.Instance.UpdateTaiKhoan(Grid_TaiKhoan.SelectedRows[0].Cells["MaTK"].Value.ToString(), textBox_TK.Text, textBox_MK.Text,textBox3.Text);
                loadTaiKhoanlist();
                setNull();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi sửa !!!!!");
            }
        }



        private void button_CapQuyen_Click(object sender, EventArgs e)
        {
            if (Grid_Quyen.SelectedRows.Count > 0)
            {
                // Lấy ID từ dòng đã chọn trong DataGridView
                string id = Grid_Quyen.SelectedRows[0].Cells["MaTK"].Value.ToString();

                // Lấy quyền từ ComboBox
                string quyen = comboBox_Quyen.SelectedItem.ToString();

                // Gọi hàm để thêm quyền cho người dùng với thông tin đã lấy
                TaiKhoanBUS.Instance.addQuyen(id, quyen);

                MessageBox.Show("Cập Nhật Thành Công !!!");
                loadQuyenlist();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi cấp quyền !!!!!");
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
        }

        private void Grid_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Grid_TaiKhoan.Rows[e.RowIndex];

                // Hiển thị thông tin từ hàng được chọn lên TextBox
                textBox1.Text = row.Cells["MaTK"].Value.ToString();
                textBox_TK.Text = row.Cells["TenDangNhap"].Value.ToString();
                textBox_MK.Text = row.Cells["MatKhau"].Value.ToString();
                textBox2.Text = TaiKhoanDAO.Instance.getQuyen(row.Cells["MaTK"].Value.ToString());
                textBox3.Text = TaiKhoanBUS.Instance.getEmail(row.Cells["TenDangNhap"].Value.ToString(), row.Cells["MatKhau"].Value.ToString());
                // ... thêm các TextBox khác tương ứng với các cột trong DataGridView
            }
        }

        private void button_Khoa_Click(object sender, EventArgs e)
        {
            if (Grid_TaiKhoan.SelectedRows.Count > 0)
            {
                string matk = Grid_TaiKhoan.SelectedRows[0].Cells["MaTK"].Value.ToString();
                string firstTwoChars = matk.Substring(0, 2);

                if (firstTwoChars == "AD")
                {
                    MessageBox.Show("Tài Khoản ADMIN không thể bị khóa vui lòng chọn tài khoản khác !!!!!!!!");
                }
                else
                {
                    TaiKhoanBUS.Instance.KhoaTaiKhoan(matk);
                    MessageBox.Show("Khóa Thành Công");
                    loadTaiKhoanlist();
                    loadQuyenlist();
                    setNull();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi khoá !!!!!");
            }
        }

        private void Grid_TaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (Grid_TaiKhoan.SelectedCells.Count > 0)
            {
                int selectedRowIndex = Grid_TaiKhoan.SelectedCells[0].RowIndex;

                // Kiểm tra nếu người dùng đã chọn hàng đầu tiên
                if (selectedRowIndex == 0)
                {
                    // Bỏ chọn hàng đầu tiên
                    Grid_TaiKhoan.Rows[selectedRowIndex].Selected = false;
                }
            }
        }

        private void Grid_Quyen_SelectionChanged(object sender, EventArgs e)
        {
            if (Grid_Quyen.SelectedCells.Count > 0)
            {
                int selectedRowIndex = Grid_Quyen.SelectedCells[0].RowIndex;


                // Kiểm tra nếu người dùng đã chọn hàng đầu tiên
                if (selectedRowIndex == 0)
                {
                    // Bỏ chọn hàng đầu tiên
                    Grid_Quyen.Rows[selectedRowIndex].Selected = false;
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string data = textBox_Search.Text;


            DataTable dt = TaiKhoanDAO.Instance.SearchTK(data);
            Grid_TaiKhoan.DataSource = dt;

            Grid_TaiKhoan.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            Grid_TaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            Grid_TaiKhoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            Grid_TaiKhoan.Columns["Email"].HeaderText = "E-Mail";
            Grid_TaiKhoan.Columns["TrangThai"].HeaderText = "Trạng Thái";


            Grid_TaiKhoan.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["TenDangNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["MatKhau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_TaiKhoan.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string action = comboBox1.SelectedItem.ToString();
            DataTable dt = TaiKhoanDAO.Instance.getDS(action);
            Grid_Quyen.DataSource = dt;

            Grid_Quyen.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            Grid_Quyen.Columns["PhanQuyen"].HeaderText = "Quyền";



            Grid_Quyen.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_Quyen.Columns["PhanQuyen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
