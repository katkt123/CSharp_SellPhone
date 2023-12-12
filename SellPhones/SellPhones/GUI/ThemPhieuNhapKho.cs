using NPOI.SS.Formula.Functions;
using Sellphone.DAO;
using SellPhones.BUS;
using SellPhones.DAO;
using SellPhones.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhones.GUI
{
    public partial class ThemPhieuNhapKho : Form
    {
        private DataTable dt;
        String user = LoginGUI.user;
        String password = LoginGUI.password;
        public ThemPhieuNhapKho()
        {
            InitializeComponent();
        }

        private void grid_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThemPhieuNhapKho_Load(object sender, EventArgs e)
        {
            dt = DataProvider.Instance.ExecuteQuery("SELECT MaKho FROM Kho");
            foreach (DataRow dr in dt.Rows)
                cbo_Kho.Items.Add(dr["MaKho"].ToString());

            dt = DataProvider.Instance.ExecuteQuery("SELECT TenNCC FROM NhaCungCap");
            foreach (DataRow dr in dt.Rows)
                cbo_ncc.Items.Add(dr["TenNCC"].ToString());
            dt = DataProvider.Instance.ExecuteQuery("SELECT spncc.MaSP,spncc.MaNCC,spncc.TenSP, spncc.DonGia FROM SanPham sp, SanPhamNCC spncc WHERE sp.MaSP = spncc.MaSP");
            dt.Clear();
            grid_SanPham.DataSource = dt;


            dt = DataProvider.Instance.ExecuteQuery("SELECT MaSP,spncc.MaNCC,spncc.TenSP, SLNhap, spncc.DonGia, Tamtinh FROM CTPhieuNhapKho ctpn, SanPhamNCC spncc WHERE ctpn.MaNCC = spncc.MaNCC");
            dt.Clear();
            grid_PhieuNhapKho.DataSource = dt;
        }

        private void button_ThemDon_Click(object sender, EventArgs e)
        {

            if (grid_SanPham.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm.");
                return;
            }

            dt = (DataTable)grid_SanPham.DataSource;
            DataGridViewRow selectedRow = grid_SanPham.Rows[grid_SanPham.CurrentRow.Index];
            string validatencc = selectedRow.Cells["MaNCC"].Value.ToString();
            foreach (DataGridViewRow dr in grid_PhieuNhapKho.Rows)
            {
                if (dr.Cells["MaSP"].Value.ToString() == selectedRow.Cells["MaSP"].Value.ToString())
                {
                    dr.Cells["SLNhap"].Value = Convert.ToInt32(dr.Cells["SLNhap"].Value) + ud_SoLuong.Value;
                    dr.Cells["Tamtinh"].Value = Convert.ToDecimal(dr.Cells["DonGia"].Value) * Convert.ToInt32(dr.Cells["SLNhap"].Value);
                    grid_SanPham.CurrentRow.Selected = false;
                    return;
                }
                if (validatencc != Convert.ToString(dr.Cells["MaNCC"].Value))
                {
                    MessageBox.Show("Chỉ được chọn 1 nhà cung cấp cho 1 phiếu nhập!");
                    return;
                }
            }
            dt = (DataTable)grid_PhieuNhapKho.DataSource;
            string masp = selectedRow.Cells["MaSP"].Value.ToString();
            string mancc = selectedRow.Cells["MaNCC"].Value.ToString();
            string tenSanPham = selectedRow.Cells["TenSP"].Value.ToString();
            int soLuong = Convert.ToInt32(ud_SoLuong.Value);
            decimal gianhap = Convert.ToDecimal(selectedRow.Cells["DonGia"].Value);
            decimal tamtinh = ud_SoLuong.Value * gianhap;
            dt.Rows.Add(masp, mancc, tenSanPham, soLuong, gianhap, tamtinh);
            grid_PhieuNhapKho.DataSource = dt;

            decimal totalGia = 0;
            foreach (DataGridViewRow dr in grid_PhieuNhapKho.Rows)
            {
                totalGia += Convert.ToDecimal(dr.Cells["Tamtinh"].Value);
            }
            //Cập nhật Label label_TT với tổng giá mới
            label_TT.Text = totalGia.ToString();

            grid_PhieuNhapKho.CurrentRow.Selected = false;
            return;
        }

        private void button_XoaDon_Click(object sender, EventArgs e)
        {
            if (grid_PhieuNhapKho.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
                return;
            }
            grid_PhieuNhapKho.Rows.Remove(grid_PhieuNhapKho.Rows[grid_PhieuNhapKho.CurrentRow.Index]);
            decimal totalGia = 0;
            foreach (DataGridViewRow dr in grid_PhieuNhapKho.Rows)
            {
                totalGia += Convert.ToDecimal(dr.Cells["Tamtinh"].Value);
            }
            //Cập nhật Label label_TT với tổng giá mới
            label_TT.Text = totalGia.ToString();

            grid_SanPham.CurrentRow.Selected = false;
        }

        private void cbo_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NhaCungCap = cbo_ncc.GetItemText(cbo_ncc.SelectedItem);
            dt = DataProvider.Instance.ExecuteQuery($"SELECT spncc.MaSP,spncc.MaNCC,spncc.TenSP,sp.DonGia " +
                    $"FROM SanPhamNCC spncc, NhaCungCap ncc,SanPham sp " +
                    $"WHERE ncc.MaNCC = spncc.MaNCC AND spncc.MaSP = sp.MaSP AND TenNCC = '" + NhaCungCap + "'");
            grid_SanPham.DataSource = dt;
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
            if (grid_PhieuNhapKho.Rows.Count == 0)
            {
                MessageBox.Show("Chọn sản phẩm vào để thanh toán.");
                return;
            }
            if (cbo_Kho.SelectedItem == null)
            {
                MessageBox.Show("Chọn kho để nhập vào.");
                return;
            }
            DateTime ngayNhap = DateTime.Now;

            CTPhieuNhapKhoBUS ctpnkBUS = new CTPhieuNhapKhoBUS();
            string makho = null;
            object selectedValue = cbo_Kho.SelectedItem;
            if (selectedValue != null)
            {
                makho = selectedValue.ToString();
            }
            string maNV = null;

            string id = LoginBUS.Instance.getMaTK(user, password);
           
            maNV = LoginBUS.Instance.getMaNV(id);
            if (maNV != null)
            {
                PhieuNhapKhoDTO pnkDTO = new PhieuNhapKhoDTO("", makho, maNV, ngayNhap, Convert.ToInt32(label_TT.Text));
                PhieuNhapKhoBUS.Instance.Insert(pnkDTO);
            }
            else
            {
                MessageBox.Show("Tài khoản chưa được đặt mã nhân viên!");
                return;
            }    
            PhieuNhapKhoBUS phieuNhapKhoBUS = new PhieuNhapKhoBUS();

            List<PhieuNhapKhoDTO> pnkDTO1 = phieuNhapKhoBUS.GetList();
            PhieuNhapKhoDTO pnkDTO_l = pnkDTO1[pnkDTO1.Count - 1];
            string maPhieuNhap = pnkDTO_l.maPhieuNhap;

            foreach (DataGridViewRow dr in grid_PhieuNhapKho.Rows)
            {
                CTPhieuNhapKhoDTO ctpnkDTO = new CTPhieuNhapKhoDTO(maPhieuNhap, dr.Cells["MaNCC"].Value.ToString(), Convert.ToInt32(dr.Cells["SLNhap"].Value), Convert.ToInt32(dr.Cells["Tamtinh"].Value), Convert.ToInt32(dr.Cells["DonGia"].Value), dr.Cells["TenSP"].Value.ToString());
                SanPhamDTO spDTO = ctpnkBUS.getSPByMaSp(dr.Cells["MaSP"].Value.ToString());
                int soluong = TaiKhoanDAO.Instance.getSLSP(dr.Cells["MaSP"].Value.ToString());
                int soluongsaukhitang = soluong + Convert.ToInt32(dr.Cells["SLNhap"].Value);
                if (TaiKhoanDAO.Instance.UpdateSoLuong(dr.Cells["MaSP"].Value.ToString(), soluongsaukhitang))
                {
                    ctpnkBUS.Insert(ctpnkDTO);
                    

                }
                //ctpnkBUS.UpdateSoLuong(dr.Cells["MaSP"].Value.ToString(), spDTO.soLuong + Convert.ToInt32(dr.Cells["SLNhap"].Value));
                //ctpnkBUS.Insert(ctpnkDTO);
            }
            dt = DataProvider.Instance.ExecuteQuery("SELECT spncc.MaSP,spncc.MaNCC,spncc.TenSP, spncc.DonGia FROM SanPham sp, SanPhamNCC spncc WHERE sp.MaSP = spncc.MaSP");
            dt.Clear();
            grid_SanPham.DataSource = dt;


            dt = DataProvider.Instance.ExecuteQuery("SELECT MaSP,spncc.MaNCC,spncc.TenSP, SLNhap, spncc.DonGia, Tamtinh FROM CTPhieuNhapKho ctpn, SanPhamNCC spncc WHERE ctpn.MaNCC = spncc.MaNCC");
            dt.Clear();
            grid_PhieuNhapKho.DataSource = dt;

            MessageBox.Show("Thanh toán thành công.");
        }

        private void grid_SanPham_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void grid_PhieuNhapKho_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == grid_PhieuNhapKho.Columns["Tamtinh"].Index)
            {
                decimal totalGia = 0;
                foreach (DataGridViewRow dr in grid_PhieuNhapKho.Rows)
                {
                    totalGia += Convert.ToDecimal(dr.Cells["Tamtinh"].Value);
                }
                label_TT.Text = totalGia.ToString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
