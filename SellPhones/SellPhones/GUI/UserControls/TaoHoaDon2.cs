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
    public partial class TaoHoaDon2 : Form
    {
        public HoaDonBUS hoaDonBUS;

        public TaoHoaDon2()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd/MM/yyyy");
            string user = LoginGUI.user;
            string pass = LoginGUI.password;
            string id = TaiKhoanDAO.Instance.getIDTK(user, pass);
            string idnv = LoginDAO.Instance.getMaNV(id);
            textBox2.Text = idnv;
            label10.Text = formattedDate;
        }

        private void buttonthanhtoan_Click(object sender, EventArgs e)
        {
            string maKH = textBox1.Text;
            string maNV = textBox2.Text;
            double tongGiaGoc = double.Parse(label21.Text);
            double tongGiaSauGiam = double.Parse(label20.Text);

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn tạo hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (HoaDonBUS.Instance.KiemTraTonTaiKhachHang(maKH))
                {
                    string maHoaDon = HoaDonBUS.Instance.TaoHoaDon(maKH, maNV, tongGiaGoc, tongGiaSauGiam);
                    bool coSanPhamDuocThem = false; // Biến kiểm tra xem có sản phẩm nào được thêm vào hóa đơn hay không

                    foreach (Control control in flowLayoutPanel1.Controls)
                    {
                        if (control is CTHDInfoUC cthdInfoUC)
                        {
                            string maSP = cthdInfoUC.MaSP;
                            string tenSP = cthdInfoUC.TenSP;
                            int soLuong = int.Parse(cthdInfoUC.SoLuong);
                            string giaTienWithDollarSign = cthdInfoUC.GiaTien; // Giả sử giaTien là một chuỗi có dạng "$123.45"
                            giaTienWithDollarSign = giaTienWithDollarSign.Substring(1); // Loại bỏ ký tự đầu tiên ('$')
                            double giaTien = double.Parse(giaTienWithDollarSign); // Chuyển đổi thành số thực


                            HoaDonBUS.Instance.ThemChiTietHoaDon(maHoaDon, maSP, tenSP, soLuong, giaTien);

                            coSanPhamDuocThem = true; // Đánh dấu là có ít nhất một sản phẩm được thêm vào hóa đơn
                        }
                    }

                    if (coSanPhamDuocThem)
                    {
                        MessageBox.Show("Tạo hóa đơn thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có sản phẩm nào được thêm vào hóa đơn. Vui lòng thêm sản phẩm trước khi tạo hóa đơn.");
                        HoaDonBUS.Instance.XoaHoaDonByMaHD(maHoaDon);
                    }
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ!");
                }
            }
            else
            {

            }
            HoadonDaTao?.Invoke(this, EventArgs.Empty); // Thông báo rằng hóa đơn đã tạo
        }

        public event EventHandler HoadonDaTao;

        public void SetData(string masp, string tenSP, int soLuong, double giaSauGiam)
        {

            // Tạo mới một đối tượng CTHDInfoUC và thêm vào flowLayoutPanel1
            CTHDInfoUC cthdInfoUC = new CTHDInfoUC(masp, tenSP, soLuong.ToString(), giaSauGiam.ToString("C2"));
            flowLayoutPanel1.Controls.Add(cthdInfoUC);
        }

        private string GetMaSPTheoTenSP(string tenSP)
        {
            DataTable sanPhamInfo = hoaDonBUS.GetSanPhamInfoForComboBox();

            if (sanPhamInfo != null && sanPhamInfo.Rows.Count > 0)
            {
                foreach (DataRow row in sanPhamInfo.Rows)
                {
                    if (row["TenSP"].ToString() == tenSP)
                    {
                        return row["MaSP"].ToString();
                    }
                }
            }

            return "Không có mã sản phẩm";
        }
        public void setGia(string giagoc, string giakhuyenmai)
        {
            label21.Text = giakhuyenmai;
            label20.Text = giagoc;
        }

        
    }
}
