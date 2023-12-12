using Sellphone.DAO;
using SellPhones.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;


namespace SellPhones.GUI
{
    public partial class LoginGUI : Form
    {
        public static string user;
        public static string password;
        private Timer timer;
        private string[] words;
        private string[] words1;
        private int currentIndex;
        private int currentIndex1;
        public LoginGUI()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Tick += Timer_Tick1;

            // Chuỗi cần hiển thị
            string labelText = label5.Text;
            string labelText1 = label6.Text;

            // Chia chuỗi thành các từ
            words = labelText.Split(' ');
            words1 = labelText1.Split(' ');
            // Bắt đầu Timer khi Form khởi tạo
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Kiểm tra xem currentIndex có vượt quá số lượng từ không
            if (currentIndex < words.Length)
            {
                // Hiển thị từng cụm từ
                label5.Text = string.Join(" ", words.Take(currentIndex + 1));

                // Tăng currentIndex để chuẩn bị cho lần kế tiếp
                currentIndex++;

                // Kiểm tra xem currentIndex có vượt quá số lượng từ không
                if (currentIndex >= words.Length)
                {
                    // Nếu currentIndex vượt quá, đặt lại nó về 0
                    currentIndex = 0;
                }
            }

        }
        private void Timer_Tick1(object sender, EventArgs e)
        {
            // Kiểm tra xem currentIndex có vượt quá số lượng từ không
            if (currentIndex < words.Length)
            {
                // Hiển thị từng cụm từ
                label6.Text = string.Join(" ", words1.Take(currentIndex1 + 1));

                // Tăng currentIndex để chuẩn bị cho lần kế tiếp
                currentIndex1++;

                // Kiểm tra xem currentIndex có vượt quá số lượng từ không
                if (currentIndex1 >= words1.Length)
                {
                    // Nếu currentIndex vượt quá, đặt lại nó về 0
                    currentIndex1 = 0;
                }
            }

        }
        public Boolean valid()
        {
            string name = textBox_TK.Text;
            string pass = textBox_MK.Text;
            if (name == "")
            {
                label_Error.Text = "Lỗi: Bạn Chưa Nhập Tài Khoản";
                return false;
            }
            if (pass == "")
            {
                label_Error.Text = "Lỗi: Bạn Chưa Nhập Mật Khẩu";
                return false;
            }

            label_Error.Text = "";
            return true;
        }

        private Boolean login()
        {
            string name = textBox_TK.Text;
            string pass = textBox_MK.Text;

            DataTable dt = LoginBUS.Instance.Login(name, pass);

            if (dt.Rows.Count <= 0)
            {
                label_Error.Text = "Lỗi: Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng";
                return false;
            }
            else
            {
                string id = Convert.ToString(dt.Rows[0][0]);
                MessageBox.Show(LoginDAO.Instance.getQuyen(id));
                string quyen = LoginDAO.Instance.getQuyen(id);
                string subs = id.Substring(0, 2);

                if (string.Equals(quyen, "Quản Lý") || string.Equals(quyen, "Quản Trị Viên"))
                {
                    user = textBox_TK.Text;
                    password = textBox_MK.Text;
                    this.Hide();
                    MainGUI rf = new MainGUI();
                    rf.StartPosition = FormStartPosition.CenterScreen;
                    rf.ShowDialog();
                    this.Close();
                    LoginBUS.Instance.active(id);
                    return true;
                }
                else if (string.Equals(quyen,"Nhân Viên"))
                {
                    user = textBox_TK.Text;
                    password = textBox_MK.Text;
                    this.Hide();
                    SubGUI rf = new SubGUI();
                    rf.StartPosition = FormStartPosition.CenterScreen;
                    rf.ShowDialog();
                    this.Close();
                    LoginBUS.Instance.active(id);
                    return true;
                }
                else if (string.Equals(quyen, "Khóa"))
                {
                    MessageBox.Show("Tài khoản này hiện tại đang bị khóa !!!!");
                    return false;
                }
                else return false;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_TK_Enter(object sender, EventArgs e)
        {
            if (textBox_TK.Text == "UserName")
            {
                textBox_TK.ForeColor = System.Drawing.Color.Black;
                textBox_TK.Text = "";
            }
        }

        private void textBox_TK_Leave(object sender, EventArgs e)
        {
            if (textBox_TK.Text == "")
            {
                textBox_TK.ForeColor = System.Drawing.Color.Gray;
                textBox_TK.Text = "UserName";
            }

        }

        private void textBox_MK_Enter(object sender, EventArgs e)
        {

            if (textBox_MK.Text == "PassWord")
            {
                textBox_MK.ForeColor = System.Drawing.Color.Black;
                textBox_MK.Text = "";
            }
        }

        private void textBox_MK_Leave(object sender, EventArgs e)
        {
            if (textBox_MK.Text == "")
            {
                textBox_MK.ForeColor = System.Drawing.Color.Gray;
                textBox_MK.Text = "PassWord";
            }
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {

            if (valid() && login())
            {
                
                MessageBox.Show("Dang Nhap Thanh Cong!!!");
                //this.Hide();
                //MainGUI main = new MainGUI();
                //main.StartPosition = FormStartPosition.CenterScreen;
                //main.ShowDialog();
                //this.Close();
            }
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterGUI rf = new RegisterGUI();
            rf.StartPosition = FormStartPosition.CenterScreen;
            rf.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassGUI rf = new ForgotPassGUI();
            rf.StartPosition = FormStartPosition.CenterScreen;
            rf.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox_MK.PasswordChar = '*';
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_MK.PasswordChar = '\0';
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }
    }
}
