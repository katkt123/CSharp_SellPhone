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
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualStudio.Shell.Interop;

namespace SellPhones.GUI.UserControls
{
    public partial class TaoHoaDon : Form
    {
        private String manvLogined;
        public HoaDonBUS hoaDonBUS;

        double totalOriginalPrice = 0;
        double totalDiscountedPrice = 0;

        private CTHDInfoUC selectedUC = null;

        public TaoHoaDon()
        {
            InitializeComponent();
            hoaDonBUS = new HoaDonBUS();
            LoadSanPhamToComboBox();


            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
        }

        public void getThongTin()
        {
            string id = LoginGUI.user;
            string pass = LoginGUI.password;
            MessageBox.Show(id + "   00000" + pass);
            string matk = LoginBUS.Instance.getMaTK(id, pass);
            MessageBox.Show(matk);
            string manv = LoginBUS.Instance.getMaNV(matk);
            manvLogined = manv;
            label4.Text = manvLogined;
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd/MM/yyyy"); 

            label10.Text = formattedDate;
        }

        public void LoadSanPhamToComboBox()
        {
            DataTable sanPhamInfo = hoaDonBUS.GetSanPhamInfoForComboBox();

            if (sanPhamInfo != null && sanPhamInfo.Rows.Count > 0)
            {
                foreach (DataRow row in sanPhamInfo.Rows)
                {
                    string tenSP = row["TenSP"].ToString();
                    string soLuong = row["SoLuong"].ToString();
                    string item = $"{tenSP} |    {soLuong}";

                    comboBox2.Items.Add(item);
                }
            }
            else
            {

            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string selectedItem = comboBox2.SelectedItem.ToString();
                string tenSP = selectedItem.Split('|')[0].Trim();

                DataTable giaVaHinhAnh = hoaDonBUS.GetGiaSanPham(tenSP);
                DataTable khuyenMai = hoaDonBUS.GetKhuyenMaiSanPham(tenSP);

                string gia = "0";
                string hinhAnhPath = string.Empty;
                string khuyenMaiValue = "0";

                if (giaVaHinhAnh != null && giaVaHinhAnh.Rows.Count > 0)
                {
                    gia = giaVaHinhAnh.Rows[0]["DonGia"].ToString();
                    hinhAnhPath = giaVaHinhAnh.Rows[0]["HinhAnh"].ToString();
                }

                if (khuyenMai != null && khuyenMai.Rows.Count > 0)
                {
                    khuyenMaiValue = khuyenMai.Rows[0]["MucGiamGia"].ToString();
                }

                label15.Text = $"{gia}";
                label25.Text = $"{khuyenMaiValue}%";

                if (!string.IsNullOrEmpty(hinhAnhPath))
                {
                    pictureBox1.Image = Image.FromFile(hinhAnhPath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {

                }
            }
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string selectedItem = comboBox2.SelectedItem.ToString();
                string tenSP = selectedItem.Split('|')[0].Trim();

                string maSP = GetMaSPTheoTenSP(tenSP);
                string soLuong = textBox2.Text;

                if (IsValidSoLuong(tenSP, soLuong))
                {
                    string gia = label15.Text;
                    string khuyenMai = label25.Text.Replace("%", ""); 

                    double giaDouble = Convert.ToDouble(gia);
                    double khuyenMaiDouble = Convert.ToDouble(khuyenMai);
                    int soLuongInt = Convert.ToInt32(soLuong);

                    double thanhTien = giaDouble * soLuongInt * (1 - khuyenMaiDouble / 100);

                    bool found = false;

                    // Duyệt qua các UC hiện có trong flowLayoutPanel
                    foreach (Control control in flowLayoutPanel1.Controls)
                    {
                        if (control is CTHDInfoUC cthdInfoUC && cthdInfoUC.TenSP == tenSP)
                        {
                            // Nếu sản phẩm đã tồn tại, cập nhật số lượng
                            int currentQuantity = int.Parse(cthdInfoUC.SoLuong);
                            currentQuantity += soLuongInt;
                            cthdInfoUC.label14.Text = currentQuantity.ToString(); // Cập nhật số lượng mới
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        CTHDInfoUC cthdInfoUC = new CTHDInfoUC(maSP, tenSP, soLuong, thanhTien.ToString());

                        cthdInfoUC.Click += CthdInfoUC_Click;

                        flowLayoutPanel1.Controls.Add(cthdInfoUC);
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }
            UpdateTotalPrices();
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

        private bool IsValidSoLuong(string tenSP, string soLuong)
        {
            int parsedSoLuong;

            DataTable sanPhamInfo = hoaDonBUS.GetSanPhamInfoForComboBox();

            if (int.TryParse(soLuong, out parsedSoLuong) && parsedSoLuong > 0)
            {
                int soLuongHienCo = GetSoLuongHienCo(tenSP, sanPhamInfo);

                int tongSoLuongDaThem = GetTongSoLuongDaThem(tenSP);

                if (parsedSoLuong + tongSoLuongDaThem <= soLuongHienCo)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Tổng số lượng đã thêm vượt quá số lượng hiện có.");
                }
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ!");
            }

            return false;
        }

        private int GetTongSoLuongDaThem(string tenSP)
        {
            int tongSoLuongDaThem = 0;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is CTHDInfoUC cthdInfoUC)
                {
                    if (cthdInfoUC.TenSP == tenSP)
                    {
                        tongSoLuongDaThem += int.Parse(cthdInfoUC.SoLuong);
                    }
                }
            }

            return tongSoLuongDaThem;
        }

        private void UpdateTotalPrices()
        {
            totalOriginalPrice = 0;
            totalDiscountedPrice = 0;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is CTHDInfoUC cthdInfoUC)
                {
                    double discountedPrice = double.Parse(cthdInfoUC.GiaTien);
                    int quantity = int.Parse(cthdInfoUC.SoLuong);

                    double originalPrice = discountedPrice / (1 - double.Parse(label25.Text.Replace("%", "")) / 100);

                    totalOriginalPrice += originalPrice * quantity;
                    totalDiscountedPrice += discountedPrice * quantity;
                }
            }


            label21.Text = totalOriginalPrice.ToString();
            label20.Text = totalDiscountedPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedUC != null)
            {
                flowLayoutPanel1.Controls.Remove(selectedUC);
                selectedUC = null; 
            }
            UpdateTotalPrices();
        }


        private void CthdInfoUC_Click(object sender, EventArgs e)
        {
            if (sender is CTHDInfoUC clickedUC && clickedUC != selectedUC)
            {

                clickedUC.BackColor = Color.LightGray;

                if (selectedUC != null)
                {
                    selectedUC.BackColor = SystemColors.ControlLightLight;
                }

                selectedUC = clickedUC;
            }
        }

        private void buttonthanhtoan_Click(object sender, EventArgs e)
        {
            string maKH = textBox1.Text;
            string maNV = label4.Text;
            double tongGiaGoc = double.Parse(label21.Text);
            double tongGiaSauGiam = double.Parse(label20.Text);

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn tạo hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (hoaDonBUS.KiemTraTonTaiKhachHang(maKH))
                {
                    string maHoaDon = hoaDonBUS.TaoHoaDon(maKH, maNV, tongGiaGoc, tongGiaSauGiam);

                    bool coSanPhamDuocThem = false; // Biến kiểm tra xem có sản phẩm nào được thêm vào hóa đơn hay không

                    foreach (Control control in flowLayoutPanel1.Controls)
                    {
                        if (control is CTHDInfoUC cthdInfoUC)
                        {
                            string maSP = cthdInfoUC.MaSP;
                            string tenSP = cthdInfoUC.TenSP;
                            int soLuong = int.Parse(cthdInfoUC.SoLuong);
                            double giaTien = double.Parse(cthdInfoUC.GiaTien);

                            hoaDonBUS.ThemChiTietHoaDon(maHoaDon, maSP, tenSP, soLuong, giaTien);

                            coSanPhamDuocThem = true; // Đánh dấu là có ít nhất một sản phẩm được thêm vào hóa đơn
                        }
                    }

                    if (coSanPhamDuocThem)
                    {
                        MessageBox.Show("Tạo hóa đơn thành công!");
                        LoadSanPhamToComboBox();
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


        public void KiemTraTonTaiKhachHang(string maKH)
        {
            HoaDonBUS.Instance.KiemTraTonTaiKhachHang(maKH);
        }
    }
}
