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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;

namespace SellPhones.GUI
{
    public partial class RegisterGUI : Form
    {
        private Timer timer;
        private string[] words;
        private string[] words1;
        private int currentIndex;
        private int currentIndex1;
        public RegisterGUI()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Tick += Timer_Tick1;

            // Chuỗi cần hiển thị
            string labelText = label9.Text;
            string labelText1 = label8.Text;

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
                label9.Text = string.Join(" ", words.Take(currentIndex + 1));

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
                label8.Text = string.Join(" ", words1.Take(currentIndex1 + 1));

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
        private void RegisterGUI_Load(object sender, EventArgs e)
        {

        }
        void setNull()
        {
            label_TK.Text = "";
            label_ReMK.Text = "";
            label_MK.Text = "";
            label_Address.Text = "";
            label_Phone.Text = "";
            label_Name.Text = "";
        }
        private void button_Register_Click(object sender, EventArgs e)
        {
            setNull();
            if (valid())
            {
                
                string user = textBox_TK.Text;
                string pass = textBox_MK.Text;
                string name = textBox_Name.Text;
                string diachi = textBox_DiaChi.Text;
                string sdt = textBox_SDT.Text;
                string email = textBox_Email.Text;

                RegisterBUS.Instance.Register(user, pass,email, name, diachi, sdt);
                MessageBox.Show("Đăng Ký Thành Công !!!!!");
                this.Hide();
                LoginGUI lg = new LoginGUI();
                lg.StartPosition = FormStartPosition.CenterScreen;
                lg.ShowDialog();
                this.Close();
            }
        }
        private bool IsValidGmailAddress(string emailAddress)
        {
            if(LoginDAO.Instance.CheckEmail(emailAddress))
            {
                MessageBox.Show("Gmail đã tồn tại !!!!");
                return false;
            }
            else
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
                return Regex.IsMatch(emailAddress, pattern);
            }
            
        }
        private Boolean valid()
        {
            int emptyFieldCount = 0; // Số trường đang trống

            if (textBox_TK.Text == "")
            {
                emptyFieldCount++;
                label_TK.Text = "X";

            }

            if (textBox_MK.Text == "")
            {
                emptyFieldCount++;
                label_MK.Text = "X";

            }

            if (textBox_Name.Text == "")
            {
                emptyFieldCount++;
                label_Name.Text = "X";

            }
            if (!IsValidGmailAddress(textBox_Email.Text))
            {
                emptyFieldCount++;
                label11.Text = "X";
                txtError.Text = "Địa chỉ email không phải là Gmail.";
            }

            if (textBox_SDT.Text == "")
            {
                emptyFieldCount++;
                label_Phone.Text = "X";

            }

            if (textBox_DiaChi.Text == "")
            {
                emptyFieldCount++;
                label_Address.Text = "X";

            }

            if (textBox_MK.Text != textBox_ReMK.Text)
            {
                emptyFieldCount++;
                label_ReMK.Text = "X";
                txtError.Text = "Mật khẩu không khớp. ";

            }
            if (TaiKhoanDAO.Instance.isUserNameExist(textBox_TK.Text))
            {
                emptyFieldCount++;
                txtError.Text = "Tên đăng nhập đã tồn tại. ";

            }
            if (label_Address.Text == "X" || label_MK.Text == "X" || label_Name.Text == "X" || label_Phone.Text == "X" || label_ReMK.Text == "X" || label_TK.Text == "X")
            {
                return false;
            }

            // Kiểm tra số lượng trường trống

            else if (emptyFieldCount > 0)
            {
                txtError.Text = "Thông tin chưa được nhập.";
                return false;
            }

            txtError.Text = "";
            return true;

        }

        private void textBox_TK_Enter(object sender, EventArgs e)
        {
            //if (textBox_TK.Text == "UserName")
            //{
            //    textBox_TK.ForeColor = System.Drawing.Color.Black;
            //    textBox_TK.Text = "";
            //}
        }

        private void textBox_TK_Leave(object sender, EventArgs e)
        {
            //if (textBox_TK.Text == "")
            //{
            //    textBox_TK.ForeColor = System.Drawing.Color.Gray;
            //    textBox_TK.Text = "UserName";
            //}

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
            //if (textBox_MK.Text == "")
            //{
            //    textBox_MK.ForeColor = System.Drawing.Color.Gray;
            //    textBox_MK.Text = "PassWord";
            //}
        }

        private void textBox_ReMK_Enter(object sender, EventArgs e)
        {
            //if (textBox_ReMK.Text == "Re-PassWord")
            //{
            //    textBox_ReMK.ForeColor = System.Drawing.Color.Black;
            //    textBox_ReMK.Text = "";
            //}
        }

        private void textBox_ReMK_Leave(object sender, EventArgs e)
        {
            //if (textBox_ReMK.Text == "")
            //{
            //    textBox_ReMK.ForeColor = System.Drawing.Color.Gray;
            //    textBox_ReMK.Text = "Re-PassWord";
            //}
        }

        private void textBox_Name_Enter(object sender, EventArgs e)
        {
            //if (textBox_Name.Text == "FullName")
            //{
            //    textBox_Name.ForeColor = System.Drawing.Color.Black;
            //    textBox_Name.Text = "";
            //}
        }

        private void textBox_Name_Leave(object sender, EventArgs e)
        {
            //if (textBox_Name.Text == "")
            //{
            //    textBox_Name.ForeColor = System.Drawing.Color.Gray;
            //    textBox_Name.Text = "FullName";
            //}
        }

        private void textBox_DiaChi_Enter(object sender, EventArgs e)
        {
            //if (textBox_DiaChi.Text == "Address")
            //{
            //    textBox_DiaChi.ForeColor = System.Drawing.Color.Black;
            //    textBox_DiaChi.Text = "";
            //}
        }

        private void textBox_DiaChi_Leave(object sender, EventArgs e)
        {
            //if (textBox_DiaChi.Text == "")
            //{
            //    textBox_DiaChi.ForeColor = System.Drawing.Color.Gray;
            //    textBox_DiaChi.Text = "Address";
            //}
        }

        private void textBox_SDT_Enter(object sender, EventArgs e)
        {
            //if (textBox_SDT.Text == "Phone-Number")
            //{
            //    textBox_SDT.ForeColor = System.Drawing.Color.Black;
            //    textBox_SDT.Text = "";
            //}
        }

        private void textBox_SDT_Leave(object sender, EventArgs e)
        {
            //if (textBox_SDT.Text == "")
            //{
            //    textBox_SDT.ForeColor = System.Drawing.Color.Gray;
            //    textBox_SDT.Text = "Phone-Number";
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginGUI lg = new LoginGUI();
            lg.StartPosition = FormStartPosition.CenterScreen;
            lg.ShowDialog();
            this.Close();
        }
    }
}
