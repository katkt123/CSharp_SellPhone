using Sellphone.DAO;
using SellPhones.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace SellPhones.GUI
{
    public partial class ForgotPassGUI : Form
    {
        string randomcode;
        public static string to;
        private Timer timer;
        private string[] words;
        private string[] words1;
        private int currentIndex;
        private int currentIndex1;
        public ForgotPassGUI()
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

        private void button_GiveCode_Click(object sender, EventArgs e)
        {
            if (LoginDAO.Instance.CheckEmail(textBox_EMail.Text)){
                string from, pass, messagebody;
                Random random = new Random();
                randomcode = (random.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (textBox_EMail.Text).ToString();
                from = "lamkiet0902741206@gmail.com";
                pass = "eqcz ebbh jpch fvdo";
                messagebody = $"Your Reset Code Is {randomcode}";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Password Reset Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code Successfully Send");
                    textBox_Code.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message} " + " Vui lòng coi lại lỗi và thực hiện!!!!!");
                }
            }
            else
            {
                MessageBox.Show("Gmail không tồn taji!!!!");
            }
            
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (randomcode == (textBox_Code.Text).ToString())
            {
                to = textBox_EMail.Text;
                ResetPasswordGUI rp = new ResetPasswordGUI();
                rp.StartPosition = FormStartPosition.CenterScreen;
                this.Close();
                rp.ShowDialog();


            }
            else
            {
                MessageBox.Show("Code bạn nhập đã sai !!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginGUI rp = new LoginGUI();
            rp.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
            rp.ShowDialog();
        }
    }
}
