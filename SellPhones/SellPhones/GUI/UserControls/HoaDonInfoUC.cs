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
    public partial class HoaDonInfoUC : UserControl
    {
        public event EventHandler UCClicked;
        public HoaDonInfoUC(string soHD, string tenKhachHang, string ngayXuat, string triGia)
        {
            InitializeComponent();

            // Các lệnh khởi tạo các control trong HoaDonInfoUC dựa trên các tham số được truyền vào
            label1.Text = soHD;
            label2.Text = tenKhachHang;
            label3.Text = ngayXuat;
            label4.Text = triGia;

            label1.Click += (sender, e) => OnUCClicked();
            label2.Click += (sender, e) => OnUCClicked();
            label3.Click += (sender, e) => OnUCClicked();
            label4.Click += (sender, e) => OnUCClicked();
            this.Click += (sender, e) => OnUCClicked();
        }

        protected virtual void OnUCClicked()
        {
            UCClicked?.Invoke(this, EventArgs.Empty);
        }

        private void HoaDonInfoUC_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;
        }

        private void HoaDonInfoUC_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLightLight;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLightLight;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLightLight;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLightLight;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLightLight;
        }
    }
}
