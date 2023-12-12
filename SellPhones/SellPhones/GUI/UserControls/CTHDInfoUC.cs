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
    public partial class CTHDInfoUC : UserControl
    {
        public string MaSP { get { return label16.Text; } }
        public string TenSP { get { return label15.Text; } }
        public string SoLuong { get { return label14.Text; } }
        public string GiaTien { get { return label13.Text; } }
        public CTHDInfoUC(string masp, string tensp, string soluong, string giatien)
        {
            InitializeComponent();

            label16.Text = masp;
            label15.Text = tensp;
            label14.Text = soluong;
            label13.Text = giatien;
        }
    }
}
