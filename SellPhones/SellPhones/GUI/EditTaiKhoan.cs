using Sellphone.DAO;
using SellPhones.BUS;
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

namespace SellPhones.GUI
{
    public partial class EditTaiKhoan : Form
    {
        string user = LoginGUI.user;
        string password = LoginGUI.password;
        public EditTaiKhoan()
        {
            InitializeComponent();
            textBox_TK.Text = user;
            textBox_MK.Text = password;
            textBox1.Text = TaiKhoanBUS.Instance.getEmail(user, password);
            string id = TaiKhoanBUS.Instance.getIDTK(user, password);
            textBox3.Text = id;
            textBox2.Text = TaiKhoanBUS.Instance.getQuyen(id);
        }

        private bool IsValidGmailAddress(string emailAddress)
        {
            if (LoginDAO.Instance.CheckEmail(emailAddress))
            {
                string gmail = TaiKhoanBUS.Instance.getEmail(user, password);
                if (emailAddress == gmail)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Gmail đã tồn tại !!!!");
                    return false;
                }
            }
            else
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
                return Regex.IsMatch(emailAddress, pattern);
            }

        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            string tendangnhap = textBox_TK.Text;
            string matkhau = textBox_MK.Text;
            string id = textBox3.Text;
            string email = textBox1.Text;

            if(IsValidGmailAddress(email))
            {

                TaiKhoanBUS.Instance.UpdateTaiKhoan(id, tendangnhap, matkhau, email);
                MessageBox.Show("Đã cập nhật thông tin thành công !!!");
                this.Close();
                LoginGUI.user = tendangnhap;
                LoginGUI.password = matkhau;
            }
            

        }
    }
}
