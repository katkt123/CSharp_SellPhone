using Microsoft.VisualStudio.Shell.Interop;
using Sellphone.DAO;
using SellPhones.BUS;
using SellPhones.DTO;
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
    public partial class ThemNCC : Form
    {
        public ThemNCC()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            String sdtncc = tb_sdtncc.Text;
            String tenncc = tb_tenncc.Text;
            String diachi = tb_diachincc.Text;

            if (sdtncc.Count() != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 chữ số!", "Lỗi");
                return;
            }
            if (tenncc != "" && diachi != "" && sdtncc != "")
            {
                NhaCungCapDTO dto = new NhaCungCapDTO("", tenncc, diachi, sdtncc);
                NhaCungCapBUS bus = new NhaCungCapBUS();

                bus.Insert(dto);

                this.Close();
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemNCC_Load(object sender, EventArgs e)
        {

        }
    }
}
