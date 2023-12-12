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
    public partial class KhuyenMaiUC : UserControl
    {
        public KhuyenMaiUC()
        {
            InitializeComponent();
            loadKhuyenMailist();
        }
        public void loadKhuyenMailist()
        {
            DataTable dt = KhuyenMaiBUS.Instance.getAllKhuyenMai();


            Grid_KhuyenMai.DataSource = dt;

            Grid_KhuyenMai.Columns["MaCTKM"].HeaderText = "Mã Khuyến Mãi";
            Grid_KhuyenMai.Columns["TenCTKM"].HeaderText = "Tên Khuyến Mãi";
            Grid_KhuyenMai.Columns["MucGiamGia"].HeaderText = "Mức Giảm giá";
            Grid_KhuyenMai.Columns["LoaiSanPhamDuocApDung"].HeaderText = "Hãng";
            Grid_KhuyenMai.Columns["ThoiGianBatDau"].HeaderText = "Thời Gia Bắt Đầu";
            Grid_KhuyenMai.Columns["ThoiGianKetThuc"].HeaderText = "Thời Gian Kết Thúc";
            Grid_KhuyenMai.Columns["ThoiGianTaoKM"].HeaderText = "Thời Gian Tạo";
            //Grid_KhuyenMai.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";

            Grid_KhuyenMai.Columns["MaCTKM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhuyenMai.Columns["TenCTKM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhuyenMai.Columns["MucGiamGia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhuyenMai.Columns["LoaiSanPhamDuocApDung"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhuyenMai.Columns["ThoiGianBatDau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhuyenMai.Columns["ThoiGianKetThuc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhuyenMai.Columns["ThoiGianTaoKM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Grid_KhuyenMai.Columns["MaSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Grid_KhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Grid_KhuyenMai.Rows[e.RowIndex];
                textBox_search.Text = row.Cells[0].Value.ToString();
            }
        }

        private void button_tao_Click(object sender, EventArgs e)
        {
            TaoKhuyenMai tao = new TaoKhuyenMai();
            tao.StartPosition = FormStartPosition.CenterParent;
            tao.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadKhuyenMailist();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            string makm = textBox_search.Text;

            KhuyenMaiBUS.Instance.DeleteKhuyenMai(makm);
            loadKhuyenMailist();
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            textBox_search.ResetText();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now; // Ngày hiện tại
            DataTable validPromotions = KhuyenMaiBUS.Instance.GetValidPromotions(currentDate);

            // Gán kết quả vào Grid_KhuyenMai hoặc thành phần giao diện khác
            Grid_KhuyenMai.DataSource = validPromotions;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now; // Ngày hiện tại
            DataTable expiredPromotions = KhuyenMaiBUS.Instance.GetExpiredPromotions(currentDate);

            // Gán kết quả vào Grid_KhuyenMai hoặc thành phần giao diện khác
            Grid_KhuyenMai.DataSource = expiredPromotions;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            loadKhuyenMailist();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string makm = textBox_search.Text;
            //DateTime ngaybatdau = dateTimePicker1.Value;
            //DateTime ngayketthuc = dateTimePicker2.Value;


            DataTable searchResult = KhuyenMaiBUS.Instance.SearchKhuyenMai(makm);

            // Gán kết quả vào Grid_KhuyenMai
            Grid_KhuyenMai.DataSource = searchResult;
        }
    }
}
