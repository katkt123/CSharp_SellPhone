using Microsoft.VisualBasic.Logging;
using Sellphone.DAO;
using SellPhones.BUS;
using SellPhones.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using SellPhones.DTO;
//using SellPhones.BUS;

namespace SellPhones.GUI
{
    public partial class MainGUI : Form
    {
        private int working = -1;
        private String manvLogined;
        public MainGUI()
        {
            InitializeComponent();
            //label1.Text = DateTime.Now.ToLongTimeString();
            ////timer1.Start();
            //PanelTools.HorizontalScroll.Enabled = false;
            //PanelTools.HorizontalScroll.Visible = false;
            AddComponent("Trang Chủ", new TrangChuUC(), "Home.png");
            AddComponent("Tài Khoản", new TaiKhoanUC(), "Account.png");
            AddComponent("Nhân Viên", new NhanVienUC(), "Staff.png");
            AddComponent("Khách Hàng", new KhachHangUC(), "Customer.png");
            AddComponent("Khuyến Mãi", new KhuyenMaiUC(), "Sale.png");
            AddComponent("Hóa Đơn", new HoaDonUC(), "Bill.png");
            AddComponent("Thống kê", new ThongKe1UC(), "Statistics.png");
            AddComponent("Sản phẩm", new SanPhamUC(), "phone.png");
            AddComponent("Nhập Hàng", new PhieuNhapKhoUC(), "supplier.png");
            AddComponent("Nhà Cung Cấp", new NhaCungCapUC(), "Logo.png");
            AddComponent("Nhà Cung Cấp", new NhaCungCapUC(), "Logo.png");

            SolveEvent();

        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            panel_UC.Controls.Clear();
            panel_UC.Controls.Add(new TrangChuUC());
            panel_UC.Invalidate();
            panel_UC.PerformLayout();
        }
        private void AddComponent(string buttonName, UserControl userControlname, string path = null)
        {
            int compQuantity = PanelTools.Controls.Count;
            PanelTools.Height = 50 * (compQuantity + 1);

            Button btn = new Button();
            btn.Text = buttonName;
            btn.Size = new Size(200, 50);
            btn.Padding = new Padding(5, 0, 0, 0);
            btn.BackColor = Color.FromArgb(238, 232, 170);
            btn.ForeColor = Color.Black;
            btn.Font = new Font(btn.Font.Name, 11, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Popup;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Image = null;

            if (path != null)
            {

                String imagePath = @"C:\SGU\Nam3 HK1\C#\Backup_2\SellPhones\SellPhones\Comp\" + path;

                if (System.IO.File.Exists(imagePath))
                {
                    // Tạo hình ảnh từ đường dẫn
                    Image image = Image.FromFile(imagePath);

                    // Đặt hình ảnh cho Button
                    btn.Image = new Bitmap(image, new Size(40, 40));
                }
            }

            btn.Click += (sender, e) =>
            {
                panel_UC.Controls.Clear();
                panel_UC.Controls.Add(userControlname);
                panel_UC.Invalidate();
                panel_UC.PerformLayout();
                if (buttonName == "Trang Chủ")
                {
                    label_QuanLi.Text = buttonName;
                }
                else
                    label_QuanLi.Text = "Quản Lý " + buttonName;
            };

            PanelTools.Controls.Add(btn);
            pictureBox.Focus();
        }

        private void AddComponent(string buttonName, Panel panelName)
        {
            AddComponent(buttonName, panelName);
        }

        private void SolveEvent()
        {
            // Lấy mã nhân viên đã đăng nhập và thêm vào màn hình chính
            string user = LoginGUI.user;
            string pass = LoginGUI.password;
            string id = LoginBUS.Instance.getMaTK(user, pass);

            manvLogined = id; // Đổi thành phương thức để lấy mã nhân viên
            label_MaNV.Text = "Mã:" + manvLogined;

            // Sửa nút button_Thoat
            //button_Thoat.Size = new Size(72, 72);
            //button_Thoat.ForeColor = Color.White;
            //button_Thoat.Font = new Font(button_Thoat.Font.Name, 14, FontStyle.Bold);
            //button_Thoat.FlatStyle = FlatStyle.Flat;

            //button_Thoat.Click += (sender, e) =>
            //{
            //    //(pictureBox.TopLevelControl as Form).Close();
            //    this.Hide();
            //    LoginGUI login = new LoginGUI();
            //    login.StartPosition = FormStartPosition.CenterScreen;
            //    login.ShowDialog();
            //    this.Close();

            //};

            // Xử lý hoạt ảnh đang hoạt động trên thanh công cụ
            int working = -1;
            for (int i = 0; i < PanelTools.Controls.Count; i++)
            {
                int tmp = i;
                PanelTools.Controls[i].GotFocus += (sender, e) =>
                {
                    if (working >= 0)
                    {
                        (PanelTools.Controls[working] as Button).FlatAppearance.BorderSize = 0;
                    }
                    working = tmp;
                    (PanelTools.Controls[tmp] as Button).FlatAppearance.BorderSize = 5;
                };
            }

            // Sự kiện Phiếu Nhập
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Picture_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //DataTable dt = LoginBUS.Instance.id_active();
                //string id = Convert.ToString(dt.Rows[0][0]);
                //LoginBUS.Instance.unactive(id);
                string user = LoginGUI.user;
                string pass = LoginGUI.password;
                if (LoginBUS.Instance.unactive1(user, pass))
                {
                    this.Hide();
                    LoginGUI lg = new LoginGUI();
                    lg.StartPosition = FormStartPosition.CenterScreen;
                    lg.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng xuất thất bại !!!");
                }
                //this.Hide();
                //LoginGUI lg = new LoginGUI();
                //lg.StartPosition = FormStartPosition.CenterScreen;
                //lg.ShowDialog();
                //this.Close();
            }

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            panel_UC.Controls.Clear();
            panel_UC.Controls.Add(new TrangChuUC());
            panel_UC.Invalidate();
            panel_UC.PerformLayout();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToLongTimeString();

        }

        private void pictureBox_Click_1(object sender, EventArgs e)
        {
            panel_UC.Controls.Clear();
            panel_UC.Controls.Add(new TrangChuUC());
            panel_UC.Invalidate();
            panel_UC.PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Size.Width == 77 && flowLayoutPanel1.Size.Height == 84)
            {
                flowLayoutPanel1.Size = new Size(259, 188);
                flowLayoutPanel1.Location = new Point(956, 3);
                panel2.Size = new Size(735, 80);
            }
            else
            {
                flowLayoutPanel1.Size = new Size(77, 84);
                flowLayoutPanel1.Location = new Point(1138, 3);
                panel2.Size = new Size(900, 80);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //DataTable dt = LoginBUS.Instance.id_active();
                //string id = Convert.ToString(dt.Rows[0][0]);
                //LoginBUS.Instance.unactive(id);
                string user = LoginGUI.user;
                string pass = LoginGUI.password;
                if (LoginBUS.Instance.unactive1(user, pass))
                {
                    this.Hide();
                    LoginGUI lg = new LoginGUI();
                    lg.StartPosition = FormStartPosition.CenterScreen;
                    lg.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng xuất thất bại !!!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditTaiKhoan lg = new EditTaiKhoan();
            lg.StartPosition = FormStartPosition.CenterScreen;
            lg.ShowDialog();
        }

        private void button_MuaBan_Click(object sender, EventArgs e)
        {
            MuaBan lg = new MuaBan();
            lg.StartPosition = FormStartPosition.CenterScreen;
            lg.ShowDialog();
        }
    }
}
