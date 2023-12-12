using NPOI.POIFS.Crypt.Dsig;
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
    public partial class SanPhamBiXoa : Form
    {
        public SanPhamBiXoa()
        {
            InitializeComponent();
            loadSPDelete();
        }
        public void loadSPDelete()
        {
            DataTable dt = SanPhamDAO.Instance.getAllSanPhamBiXoa();


            if (Grid_SanPhamBiXoa.Columns.Contains("Delete"))
            {
                Grid_SanPhamBiXoa.Columns.Remove("Delete");
            }



            Grid_SanPhamBiXoa.DataSource = dt;

            Grid_SanPhamBiXoa.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            Grid_SanPhamBiXoa.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            Grid_SanPhamBiXoa.Columns["Hang"].HeaderText = "Hãng";
            Grid_SanPhamBiXoa.Columns["DungLuong"].HeaderText = "Dung lượng";
            Grid_SanPhamBiXoa.Columns["SoLuong"].HeaderText = "Số lượng";
            Grid_SanPhamBiXoa.Columns["DonGia"].HeaderText = "Đơn giá";
            Grid_SanPhamBiXoa.Columns["GiaBan"].HeaderText = "Giá Bán";
           

            Grid_SanPhamBiXoa.Columns["MaSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_SanPhamBiXoa.Columns["TenSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_SanPhamBiXoa.Columns["Hang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_SanPhamBiXoa.Columns["DungLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_SanPhamBiXoa.Columns["SoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_SanPhamBiXoa.Columns["DonGia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_SanPhamBiXoa.Columns["GiaBan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            string imagePath = @"C:\SGU\Nam3 HK1\C#\Backup_2\SellPhones\SellPhones\Comp\recovery.png"; // Thay đổi đường dẫn tới hình ảnh của bạn

            Image deleteImage = Image.FromFile(imagePath);
            deleteButtonColumn.Image = deleteImage;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Grid_SanPhamBiXoa.Columns.Add(deleteButtonColumn);
            Grid_SanPhamBiXoa.CellContentClick += Grid_SanPhamBiXoa_CellContentClick;
        }

        private void Grid_SanPhamBiXoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Grid_SanPhamBiXoa.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                object cellValue = Grid_SanPhamBiXoa.Rows[e.RowIndex].Cells["MaSP"].Value;
                if (cellValue != null)
                {
                    string maSP = cellValue.ToString();
                    DialogResult result = MessageBox.Show("Bạn muốn khôi phục sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SanPhamDAO.Instance.KhoiPhucSP(maSP);
                        loadSPDelete();
                        MessageBox.Show("Bạn đã khôi phục sản phẩm thành công !!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị của ô MaSP là null.");
                }
            }
        }
    }
}
