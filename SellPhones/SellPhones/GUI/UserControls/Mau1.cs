using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace SellPhones.GUI.UserControls
{
    public partial class Mau1 : UserControl
    {
        public event EventHandler OnSelect = null;
        bool saleoff = false;
        public Mau1(bool x)
        {
            InitializeComponent();
            HienSale(x);
        }
        public string id
        { get; set; }

        public string name
        {
            get { return label_ten.Text; }

            set { label_ten.Text = value; }
        }

        public string hang
        {
            get { return label_hang.Text; }

            set { label_hang.Text = value; }
        }

        public string dungluong
        {
            get { return label_dungluong.Text; }

            set { label_dungluong.Text = value; }
        }

        public double dongia
        {
            get { return Convert.ToDouble(label_gia.Text.Replace("$", "")); }

            set { label_gia.Text = $"{value:C}"; } // Sử dụng định dạng "C" để hiển thị biểu tượng đồng
        }

        public double giatruocgiam
        {
            get { return Convert.ToDouble(label_giatruocgiam.Text.Replace("$", "")); }

            set { label_giatruocgiam.Text = $"{value:C}"; } // Sử dụng định dạng "C" để hiển thị biểu tượng đồng
        }

        public double mucgiamgia
        {
            get { return Convert.ToDouble(label_mucgiamgia.Text.Replace("-", "").Replace("%", "")); }

            set { label_mucgiamgia.Text = $"-{value}%"; }
        }


        public Image hinhanh
        {
            get { return PictureBox_hinhanh.Image; }

            set { PictureBox_hinhanh.Image = value; }
        }

        public bool sale
        {
            get { return true; }

            set
            {
            }
        }


        public void HienSale(bool x)
        {
            if (x) { PictureBox_Sale.Visible = true; label_giatruocgiam.Visible = true; label_mucgiamgia.Visible = true; }
            else
            {
                label_mucgiamgia.Visible = false;
                PictureBox_Sale.Visible = false;
                label_giatruocgiam.Visible = false;
            }
        }



        private void label_ten_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox_hinhanh_Click(object sender, EventArgs e)
        {

        }

        private void Mau1_Load(object sender, EventArgs e)
        {

        }

        private void label_gia_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, EventArgs e)
        {
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
