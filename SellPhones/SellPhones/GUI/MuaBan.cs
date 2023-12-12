using SellPhones.BUS;
using SellPhones.GUI.UserControls;
using stdole;
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
    public partial class MuaBan : Form
    {
        double giagoc;

        double giasau;


        public HoaDonBUS hoaDonBUS;

        double totalOriginalPrice = 0;
        double totalDiscountedPrice = 0;
        private CTHDInfoUC cthd;

        public DataGridView DataGridViewMuaban { get { return dataGridView_muaban; } }


        public MuaBan()
        {
            InitializeComponent();

            loadSP();
        }
        public void loadSP()
        {
            DataTable dt = SanPhamBUS.Instance.getAllSanPhamKhuyenMai();
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToDouble(dr[8]) == Convert.ToDouble(dr[9]))
                    AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[7]), dr[6].ToString(), false);
                if (Convert.ToDouble(dr[8]) < Convert.ToDouble(dr[9]))
                    AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[7]), dr[6].ToString(), true);
            }
        }

        public void AddItems(string tensp, string hang, string dungluong, double dongia, double giatruocgiam, double mucgiamgia, string hinhanh, bool sale)
        {
            string pathHA = hinhanh;

            // Tạo mới một control (Mau1) và thêm nó vào FlowLayoutPanel
            var mau1Control = new Mau1(sale)
            {
                name = tensp,
                hang = hang,
                dungluong = dungluong,
                dongia = dongia,
                giatruocgiam = giatruocgiam,
                mucgiamgia = mucgiamgia,
                hinhanh = Image.FromFile(pathHA)
            };

            // Định dạng giá trị tiền tệ cho dongia và giatruocgiam
            mau1Control.dongia = dongia;
            mau1Control.giatruocgiam = giatruocgiam;

            // Thêm control vào FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(mau1Control);
            giagoc = giatruocgiam;
            giasau = dongia;
            dataGridView_muaban.CellEndEdit += (sender, e) =>
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                if (columnIndex == 1) // Chỉ xử lý khi là cột số lượng
                {
                    DataGridViewCell cell = dataGridView_muaban.Rows[rowIndex].Cells[columnIndex];
                    int newQuantity;

                    // Kiểm tra giá trị mới của cột số lượng
                    if (int.TryParse(cell.Value?.ToString(), out newQuantity))
                    {
                        // Tính toán thành tiền theo giá gốc
                        dataGridView_muaban.Rows[rowIndex].Cells[2].Value = (newQuantity * giagoc).ToString("C2");

                        // Gọi hàm tính tổng cộng
                        Tinh();
                    }
                    else
                    {
                        // Nếu không phải là số nguyên, có thể hiển thị thông báo hoặc xử lý khác tùy ý
                        MessageBox.Show("Vui lòng nhập một số nguyên vào cột số lượng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            mau1Control.OnSelect += (ss, ee) =>
            {
                var wdg = (Mau1)ss;
                if (wdg.label_ten != null && !string.IsNullOrEmpty(wdg.label_ten.Text))
                {
                    try
                    {
                        foreach (DataGridViewRow item in dataGridView_muaban.Rows)
                        {
                            if (item.Cells[0].Value != null && item.Cells[0].Value.ToString() == wdg.label_ten.Text)
                            {
                                item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;

                                // Lấy giá trị đơn giá từ cột thứ 3 (index = 2)
                                double giasau = double.Parse(wdg.label_gia.Text.ToString().Replace("$", ""));

                                double giagoc = double.Parse(wdg.label_giatruocgiam.Text.ToString().Replace("$", ""));

                                // Tính toán thành tiền
                                item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * giasau).ToString("C2");

                                item.Cells[3].Value = (int.Parse(item.Cells[1].Value.ToString()) * giagoc).ToString("C2");

                                item.Cells[4].Value = double.Parse(wdg.label_mucgiamgia.Text.ToString().Replace("-", "").Replace("%", ""));
                                Tinh();
                                return;
                            }
                        }
                        dataGridView_muaban.Rows.Add(wdg.label_ten.Text, 1, wdg.label_gia.Text, wdg.label_giatruocgiam.Text, wdg.label_mucgiamgia.Text);
                        Tinh();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                }
            };
        }

        public void Tinh()
        {
            double tong = 0;
            foreach (DataGridViewRow item in dataGridView_muaban.Rows)
            {
                tong += double.Parse(item.Cells[2].Value.ToString().Replace("$", ""));
            }
            label_tongcong.Text = tong.ToString("C2");
        }


        private void MuaBan_Load(object sender, EventArgs e)
        {

        }

        private void MuaBan_Load_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel_muaban_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel_muaban_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView_muaban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            dataGridView_muaban.Rows.Clear();

            // Gọi hàm tính lại tổng cộng sau khi xóa
            Tinh();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            TaoHoaDon2 tao = new TaoHoaDon2();
            string tonggiakhuyenmai = TinhTongGiaGoc().ToString(); // Lấy tổng giá và chuyển sang chuỗi

            // Loại bỏ kí tự "$" từ chuỗi tổng giá
            tonggiakhuyenmai = tonggiakhuyenmai.Replace("$", "");

            string tonggiagoc = label_tongcong.Text;

            tonggiagoc = tonggiagoc.Replace("$", "");


            tao.setGia(tonggiagoc, tonggiakhuyenmai);
            // Lấy dữ liệu từ dataGridView_muaban và truyền vào tao
            foreach (DataGridViewRow row in dataGridView_muaban.Rows)
            {
                string tenSP = row.Cells[0].Value.ToString();
                string masp = GetMaSPTheoTenSP(tenSP);
                int soLuong = int.Parse(row.Cells[1].Value.ToString());
                double giaSauGiam = double.Parse(row.Cells[2].Value.ToString().Replace("$", ""));
                
           

                // Truyền dữ liệu vào tao thông qua phương thức SetData (cần tạo phương thức này trong TaoHoaDon2)
                tao.SetData(masp,tenSP, soLuong, giaSauGiam);
            }

            tao.StartPosition = FormStartPosition.CenterParent;
            tao.ShowDialog();
        }
        private string GetMaSPTheoTenSP(string tenSP)
        {
            DataTable sanPhamInfo = HoaDonBUS.Instance.GetSanPhamInfoForComboBox();

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
        private double TinhTongGiaGoc()
        {
            double tongGia = 0;

            foreach (DataGridViewRow row in dataGridView_muaban.Rows)
            {
                if (row.Cells[2].Value != null) // Kiểm tra xem ô cần tính có giá trị không
                {
                    double giaGoc = double.Parse(row.Cells[3].Value.ToString().Replace("$", "")); // Giả sử cột thứ 3 là cột chứa giá sản phẩm

                    tongGia += giaGoc; // Cộng giá sản phẩm vào tổng giá
                }
            }

            return tongGia;
        }


        private void LoadIPhoneProducts()
        {
            // Xóa các control hiện tại trong FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = SanPhamBUS.Instance.getAllSanPhamKhuyenMai();
            foreach (DataRow dr in dt.Rows)
            {
                // Thêm điều kiện kiểm tra hãng là "iPhone"
                if (dr[2].ToString().Equals("iPhone", StringComparison.OrdinalIgnoreCase))
                {
                    if (Convert.ToDouble(dr[8]) == Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[7]), dr[6].ToString(), false);
                    if (Convert.ToDouble(dr[8]) < Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[7]), dr[6].ToString(), true);
                }
            }
        }

        private void LoadSamSungProducts()
        {
            // Xóa các control hiện tại trong FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = SanPhamBUS.Instance.getAllSanPhamKhuyenMai();
            foreach (DataRow dr in dt.Rows)
            {
                // Thêm điều kiện kiểm tra hãng là "iPhone"
                if (dr[2].ToString().Equals("Samsung", StringComparison.OrdinalIgnoreCase))
                {
                    if (Convert.ToDouble(dr[8]) == Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[7]), dr[6].ToString(), false);
                    if (Convert.ToDouble(dr[8]) < Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[7]), dr[6].ToString(), true);
                }
            }
        }

        private void LoadNokiaProducts()
        {
            // Xóa các control hiện tại trong FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = SanPhamBUS.Instance.getAllSanPhamKhuyenMai();
            foreach (DataRow dr in dt.Rows)
            {
                // Thêm điều kiện kiểm tra hãng là "iPhone"
                if (dr[2].ToString().Equals("Nokia", StringComparison.OrdinalIgnoreCase))
                {
                    if (Convert.ToDouble(dr[8]) == Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[7]), dr[6].ToString(), false);
                    if (Convert.ToDouble(dr[8]) < Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[7]), dr[6].ToString(), true);
                }
            }
        }

        private void LoadOppoProducts()
        {
            // Xóa các control hiện tại trong FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = SanPhamBUS.Instance.getAllSanPhamKhuyenMai();
            foreach (DataRow dr in dt.Rows)
            {
                // Thêm điều kiện kiểm tra hãng là "iPhone"
                if (dr[2].ToString().Equals("OPPO", StringComparison.OrdinalIgnoreCase))
                {
                    if (Convert.ToDouble(dr[8]) == Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[7]), dr[6].ToString(), false);
                    if (Convert.ToDouble(dr[8]) < Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[7]), dr[6].ToString(), true);
                }
            }
        }

        private void LoadXiaomiProducts()
        {
            // Xóa các control hiện tại trong FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = SanPhamBUS.Instance.getAllSanPhamKhuyenMai();
            foreach (DataRow dr in dt.Rows)
            {
                // Thêm điều kiện kiểm tra hãng là "iPhone"
                if (dr[2].ToString().Equals("Xiaomi", StringComparison.OrdinalIgnoreCase))
                {
                    if (Convert.ToDouble(dr[8]) == Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[7]), dr[6].ToString(), false);
                    if (Convert.ToDouble(dr[8]) < Convert.ToDouble(dr[9]))
                        AddItems(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDouble(dr[8]), Convert.ToDouble(dr[9]), Convert.ToDouble(dr[7]), dr[6].ToString(), true);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadIPhoneProducts();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadSamSungProducts();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadNokiaProducts();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoadOppoProducts();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            LoadXiaomiProducts();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadSP();
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            foreach (var sp in flowLayoutPanel1.Controls)
            {
                var wdg = (Mau1)sp;
                wdg.Visible = wdg.label_ten.Text.ToLower().ToLower().Contains(textbox_search.Text.Trim().ToLower());
            }
        }
    }

}
