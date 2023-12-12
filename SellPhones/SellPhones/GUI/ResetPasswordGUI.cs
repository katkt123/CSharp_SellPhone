using SellPhones.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace SellPhones.GUI
{
    public partial class ResetPasswordGUI : Form
    {
        string email = ForgotPassGUI.to;
        private Timer timer;
        private string[] words;
        private string[] words1;
        private int currentIndex;
        private int currentIndex1;
        public ResetPasswordGUI()
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
        private void button_Confirm_Click(object sender, EventArgs e)
        {
            ForgotPassGUI main = new ForgotPassGUI();
            main.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
            main.ShowDialog();

        }

        private void button_GiveCode_Click(object sender, EventArgs e)
        {
            if (textBox_Pass.Text == textBox_RePass.Text)
            {
                LoginBUS.Instance.RePassword(textBox_Pass.Text, email);
                MessageBox.Show("Thay đổi mật khẩu thành công");
                LoginGUI main = new LoginGUI();
                main.StartPosition = FormStartPosition.CenterScreen;
                this.Close();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thay đổi mật khẩu thất bại");

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_Pass.PasswordChar = '*';
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox_Pass.PasswordChar = '\0';
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_RePass.PasswordChar = '\0';
            pictureBox3.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox_RePass.PasswordChar = '*';
            pictureBox3.Visible = true;
            pictureBox6.Visible = false;
        }
    }
}
