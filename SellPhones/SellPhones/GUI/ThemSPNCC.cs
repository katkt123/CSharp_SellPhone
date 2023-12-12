using Sellphone.DAO;
using SellPhones.BUS;
using SellPhones.DAO;
using SellPhones.DTO;
using SellPhones.GUI.UserControls;
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
    public partial class ThemSPNCC : Form
    {
        private DataTable dt;
        public ThemSPNCC()
        {
            InitializeComponent();
        }

        private void ThemSPNCC_Load(object sender, EventArgs e)
        {

            loadALl();
        }
        void loadSPlist()
        {
            dt = DataProvider.Instance.ExecuteQuery("SELECT MaSP, TenSP, DonGia FROM SanPham");
            grid_SanPham.DataSource = dt;
        }
        public void loadALl()
        {
            dt = DataProvider.Instance.ExecuteQuery("SELECT TenNCC FROM NhaCungCap");
            foreach (DataRow dr in dt.Rows)
                cbo_ncc.Items.Add(dr["TenNCC"].ToString());

            dt = DataProvider.Instance.ExecuteQuery("SELECT MaSP, TenSP, DonGia FROM SanPham");
            grid_SanPham.DataSource = dt;

            dt = DataProvider.Instance.ExecuteQuery("SELECT MaNCC,MaSP,TenSP,DonGia FROM SanPhamNCC");
            dt.Clear();
            grid_SPNCC.DataSource = dt;
        }
        private void button_ThemDon_Click(object sender, EventArgs e)
        {
            //if (ud_DonGia == null)
            //{
            //    MessageBox.Show("Vui lòng nhập đơn giá.");
            //    return;
            //}

            if (cbo_ncc.SelectedItem == null)
            {
                MessageBox.Show("Chọn nhà cung cấp để thêm.");
                return;
            }
            if (grid_SanPham.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm.");
                return;
            }

            dt = (DataTable)grid_SanPham.DataSource;
            DataGridViewRow selectedRow = grid_SanPham.Rows[grid_SanPham.CurrentRow.Index];

            foreach (DataGridViewRow dr in grid_SPNCC.Rows)
            {
                if (dr.Cells["MaSP"].Value.ToString() == selectedRow.Cells["MaSP"].Value.ToString())
                {
                    MessageBox.Show("Sản phẩm này đã được thêm!");
                    return;
                }
            }
            dt = (DataTable)grid_SPNCC.DataSource;
            string maSanPham = selectedRow.Cells["MaSP"].Value.ToString();
            string tenSanPham = selectedRow.Cells["TenSP"].Value.ToString();
            string gia = selectedRow.Cells["DonGia"].Value.ToString();
            //decimal donGia = ud_DonGia.Value;
            string Nhacungcap = null;
            string mancc = null;
            object selectedValue = cbo_ncc.SelectedItem;

            if (selectedValue != null)
            {
                Nhacungcap = selectedValue.ToString();
            }
            List<NhaCungCapDTO> dtoncc = NhaCungCapBUS.Instance.getNCCByNameCC(Nhacungcap);
            foreach (var ncc in dtoncc)
            {
                mancc = ncc.maNhacungcap;
            }

            dt.Rows.Add(mancc, maSanPham, tenSanPham, gia);
            grid_SPNCC.DataSource = dt;

            grid_SPNCC.CurrentRow.Selected = false;
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nhacungcap = null;
            string mancc = null;

            object selectedValue = cbo_ncc.SelectedItem;
            if (selectedValue != null)
            {
                Nhacungcap = selectedValue.ToString();
            }
            List<NhaCungCapDTO> dtoncc = NhaCungCapBUS.Instance.getNCCByNameCC(Nhacungcap);
            foreach (var ncc in dtoncc)
            {
                mancc = ncc.maNhacungcap;
            }
            foreach (DataGridViewRow dr in grid_SPNCC.Rows)
            {
                string maSP = dr.Cells["MaSP"].Value.ToString();
                if (!SanPhamNCCBUS.Instance.MaSPTonTai(maSP))
                {
                    SanPhamNCCDTO spnccdto = new SanPhamNCCDTO(mancc, dr.Cells["MaSP"].Value.ToString(), dr.Cells["TenSP"].Value.ToString(), Convert.ToInt32(dr.Cells["DonGia"].Value));
                    SanPhamNCCBUS.Instance.Insert(spnccdto);

                    if (HoaDonDAO.Instance.UpdateGiaSP(dr.Cells["MaSP"].Value.ToString(), Convert.ToInt32(dr.Cells["DonGia"].Value)))
                    {
                        MessageBox.Show("Thành công !!!");
                    }
                }
                else
                {
                    MessageBox.Show($" Mã sản phẩm {maSP} đã tồn tại.");
                }

            }

        }

        private void button_XoaDon_Click(object sender, EventArgs e)
        {
            if (grid_SPNCC.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn món để xóa.");
                return;
            }
            grid_SPNCC.Rows.Remove(grid_SPNCC.Rows[grid_SPNCC.CurrentRow.Index]);
            grid_SanPham.CurrentRow.Selected = false;
        }

        private void cbo_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grid_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = new DataGridViewRow();

            row = grid_SanPham.Rows[e.RowIndex];

            //ud_DonGia.Text = Convert.ToString(row.Cells["DonGia"].Value);
            DataGridViewRow selectedRow = grid_SanPham.Rows[grid_SanPham.CurrentRow.Index];
            //foreach (DataGridViewRow dr in grid_SanPham.Rows)
            //{
            //    int dongia = Convert.ToInt32(dr.Cells["DonGia"].Value.ToString());
            //    if (dongia != 0)
            //    {
            //        ud_DonGia.Enabled = false;
            //    }
            //    else ud_DonGia.Enabled = true;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaoSanPhamMoi lg = new TaoSanPhamMoi();
            lg.StartPosition = FormStartPosition.CenterScreen;
            lg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadSPlist();
        }
    }
}
