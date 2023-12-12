using NPOI.SS.Formula.Functions;
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

namespace SellPhones.GUI.UserControls
{
    public partial class CTPhieuNhapKho : Form
    {
        private string maPhieuNhap;
        public CTPhieuNhapKho(string maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
        }

        private void CTPhieuNhapKho_Load(object sender, EventArgs e)
        {
            PhieuNhapKhoBUS phieuNhapKhoBUS = new PhieuNhapKhoBUS();
            PhieuNhapKhoDTO phieuNhap = phieuNhapKhoBUS.getDNHByMaDNH(maPhieuNhap);

            display_Time.Text = phieuNhap.ngayNhap.ToString();
            display_MaDN.Text = phieuNhap.maPhieuNhap.ToString();

            grid_CTPNK.Columns.Add("TenSP", "Tên Sản Phẩm");
            this.Controls.Add(grid_CTPNK);

            CTPhieuNhapKhoBUS ctpnkBLL = new CTPhieuNhapKhoBUS();

            List<CTPhieuNhapKhoDTO> ctpnkList = ctpnkBLL.getCTDNHByMaDNH(maPhieuNhap);

            // Tạo một DataTable mới chỉ với các cột cần hiển thị
            DataTable dt = new DataTable();
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SLNhap", typeof(int));
            dt.Columns.Add("gia", typeof(double));
            dt.Columns.Add("Tamtinh", typeof(double)); 

            dt.Columns["TenSP"].ColumnName = "Tên sản phẩm";
            dt.Columns["SLNhap"].ColumnName = "Số lượng";
            dt.Columns["gia"].ColumnName = "Giá tiền";
            dt.Columns["Tamtinh"].ColumnName = "Thành tiền";

            double tongTien = 0;
            string ppn = null;

            foreach (var ctdnh in ctpnkList)
            {
                dt.Rows.Add(ctdnh.tenSP, ctdnh.SLNhap, ctdnh.dongia,ctdnh.tamtinh);
                tongTien += ctdnh.tamtinh;
                ppn = ctdnh.maPhieuNhap;
            }
            display_MaDN.Text = ppn.ToString();
            // Thêm dòng tổng tiền vào DataTable
            dt.Rows.Add("Tổng Tiền", DBNull.Value, DBNull.Value, tongTien);

            // Xóa các cột dư thừa trong DataGridView
            grid_CTPNK.Columns.Remove("TenSP");

            // Gán DataTable cho DataGridView
            grid_CTPNK.DataSource = dt;
        }
    }

}
