using Sellphone.DAO;
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
    public partial class SanPhamUC : UserControl
    {
        public event EventHandler DataUpdated;
        private DataGridViewRow selectedRow;
        string user = LoginGUI.user;
        string pass = LoginGUI.password;
        public SanPhamUC()
        {
            InitializeComponent();
            string id = TaiKhoanBUS.Instance.getIDTK(user, pass);
            string quyen = LoginDAO.Instance.getQuyen(id);
            if (string.Equals(quyen, "Quản Lý") || string.Equals(quyen, "Quản Trị Viên"))
            {
                button_delete.Enabled = true;
                guna2Button1.Enabled = true;
            }
            else
            {
                button_delete.Enabled = false;
                guna2Button1.Enabled= false;
            }
            LoadListSP();
        }
        public void LoadListSP()
        {
            DataTable dt = SanPhamBUS.Instance.getAllSanPham();


            dataGridView1.DataSource = dt;

            dataGridView1.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns["Hang"].HeaderText = "Hãng";
            dataGridView1.Columns["DungLuong"].HeaderText = "Dung lượng";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView1.Columns["DonGia"].HeaderText = "Đơn giá";
            dataGridView1.Columns["GiaBan"].HeaderText = "Giá Bán";
            dataGridView1.Columns["HinhAnh"].HeaderText = "Hình Ảnh";

            dataGridView1.Columns["MaSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["TenSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Hang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["DungLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["SoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["DonGia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["GiaBan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["HinhAnh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void OnDataUpdated()
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            TaoSanPham TSP = new TaoSanPham();
            TSP.StartPosition = FormStartPosition.CenterParent;
            TSP.ShowDialog();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                TaoSanPham TSP2 = new TaoSanPham();
                TSP2.StartPosition = FormStartPosition.CenterParent;

                // Truyền thông tin từ selectedRow sang form TaoSanPham
                TSP2.textbox_maSP.Text = selectedRow.Cells["MaSP"].Value.ToString();
                TSP2.textbox_tenSP.Text = selectedRow.Cells["TenSP"].Value.ToString();
                TSP2.ComboBox_Hang.Text = selectedRow.Cells["Hang"].Value.ToString();
                TSP2.textbox_dungluong.Text = selectedRow.Cells["DungLuong"].Value.ToString();
                TSP2.textbox_hinhanh.Text = selectedRow.Cells["HinhAnh"].Value.ToString();

                TSP2.button_Luu.Enabled = false;
                TSP2.button_capnhat.Enabled = true;
                TSP2.textbox_maSP.Enabled = false;

                TSP2.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                string maSP = selectedRow.Cells["MaSP"].Value.ToString();
                SanPhamBUS.Instance.DeleteSanPham(maSP);
                LoadListSP();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string data = guna2TextBox1.Text;


            DataTable dt = SanPhamDAO.Instance.SearchSP(data);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns["Hang"].HeaderText = "Hãng";
            dataGridView1.Columns["DungLuong"].HeaderText = "Dung lượng";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView1.Columns["DonGia"].HeaderText = "Đơn giá";
            dataGridView1.Columns["HinhAnh"].HeaderText = "Hình ảnh";

            dataGridView1.Columns["MaSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["TenSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Hang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["DungLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["SoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["DonGia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["HinhAnh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "Search")
            {
                guna2TextBox1.Text = "";
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                guna2TextBox1.Text = "Search";
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            LoadListSP();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SanPhamBiXoa lg = new SanPhamBiXoa();
            lg.StartPosition = FormStartPosition.CenterScreen;
            lg.ShowDialog();
        }
    }
}
