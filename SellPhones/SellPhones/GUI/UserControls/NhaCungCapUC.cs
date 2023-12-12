using Microsoft.VisualStudio.Shell.Interop;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SellPhones.BUS;
using SellPhones.DTO;
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

namespace SellPhones.GUI.UserControls
{
    public partial class NhaCungCapUC : UserControl
    {
        public NhaCungCapUC()
        {
            InitializeComponent();
        }

        private void tb_TimNCC_TextChanged(object sender, EventArgs e)
        {
            string searchText = tb_TimNCC.Text.Trim().ToLower(); // Lấy nội dung của TextBox và chuyển về chữ thường

            if (string.IsNullOrEmpty(searchText))
            {

                NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
                List<NhaCungCapDTO> danhSachNCC = nhaCungCapBUS.GetList();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_NhaCungCap.DataSource = danhSachNCC;
            }
            else
            {
                NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
                List<NhaCungCapDTO> danhSachNCC = nhaCungCapBUS.GetList();

                // Nếu TextBox có nội dung, tìm kiếm và lọc dữ liệu dựa trên nội dung
                var filteredRows = danhSachNCC.AsEnumerable()
                    .Where(row => row.maNhacungcap.ToString().ToLower().Contains(searchText)
                    || row.tenNhacungcap.ToString().ToLower().Contains(searchText))
                    .ToList();

                grid_NhaCungCap.DataSource = filteredRows;
            }
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
            List<NhaCungCapDTO> danhsachNCC = nhaCungCapBUS.GetList();

            grid_NhaCungCap.DataSource = danhsachNCC;
            grid_NhaCungCap.Columns["maNhacungcap"].HeaderText = "Mã nhà cung cấp";
            grid_NhaCungCap.Columns["tenNhacungcap"].HeaderText = "Tên nhà cung cấp";
            grid_NhaCungCap.Columns["diaChi"].HeaderText = "Địa Chỉ";
            grid_NhaCungCap.Columns["sdtNCC"].HeaderText = "Số điện thoại";

            grid_NhaCungCap.Columns["maNhacungcap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NhaCungCap.Columns["tenNhacungcap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NhaCungCap.Columns["diaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NhaCungCap.Columns["sdtNCC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_mancc.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 nhà cung cấp để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tb_tenncc.Enabled = true;
                tb_diachincc.Enabled = true;
                tb_sdtncc.Enabled = true;
                button_Huy.Visible = true;
                button_Save.Visible = true;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            ThemNCC themNCC = new ThemNCC();
            themNCC.ShowDialog();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string mancc = tb_mancc.Text;
            string tenncc = tb_tenncc.Text;
            string diachi = tb_diachincc.Text;
            string sdt = tb_sdtncc.Text;
            if (sdt.Count() != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 chữ số!", "Lỗi");
                return;
            }
            if (tenncc != "" && diachi != "" && sdt != "")
            {
                NhaCungCapDTO dto = new NhaCungCapDTO(mancc, tenncc, diachi, sdt);
                NhaCungCapBUS bus = new NhaCungCapBUS();
                bus.Update(dto);
                tb_tenncc.Enabled = false;
                tb_diachincc.Enabled = false;
                tb_sdtncc.Enabled = false;
                button_Save.Visible = false;
                button_Huy.Visible = false;
                MessageBox.Show("Sửa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<NhaCungCapDTO> danhSachNCC = bus.GetList();

                grid_NhaCungCap.DataSource = danhSachNCC;
            }
        }

        private void grid_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void grid_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_sdtncc.Enabled = false;
            tb_tenncc.Enabled = false;
            tb_diachincc.Enabled = false;
            tb_mancc.Enabled = false;
            button_Save.Visible = false;
            button_Huy.Visible = false;


            if (e.RowIndex == -1) return;
            DataGridViewRow row = new DataGridViewRow();

            row = grid_NhaCungCap.Rows[e.RowIndex];

            tb_mancc.Text = Convert.ToString(row.Cells["maNhacungcap"].Value);
            tb_tenncc.Text = Convert.ToString(row.Cells["tenNhacungcap"].Value);
            tb_diachincc.Text = Convert.ToString(row.Cells["diaChi"].Value);
            tb_sdtncc.Text = Convert.ToString(row.Cells["sdtNCC"].Value);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            tb_tenncc.Enabled = false;
            tb_mancc.Enabled = false;
            tb_diachincc.Enabled = false;
            tb_sdtncc.Enabled = false;
            button_Save.Visible = false;
            button_Huy.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (grid_NhaCungCap.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                {
                    int selectedRowIndex = grid_NhaCungCap.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = grid_NhaCungCap.Rows[selectedRowIndex];
                    string mancc = selectedRow.Cells["maNhacungcap"].Value.ToString();

                    NhaCungCapBUS.Instance.Delete(mancc);
                    List<NhaCungCapDTO> danhSachNCC = NhaCungCapBUS.Instance.GetList();

                    // Đặt nguồn dữ liệu cho DataGridView
                    grid_NhaCungCap.DataSource = danhSachNCC;
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xóa.");
            }
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại lựa chọn tệp
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu tệp Excel";
            saveFileDialog.FileName = "exported_data.xlsx"; // Tên mặc định của tệp

            // Hiển thị hộp thoại lựa chọn tệp và kiểm tra xem người dùng đã chọn đường dẫn lưu chưa
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Tạo một tệp Excel mới
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Sheet1");

                // Lấy dữ liệu từ DataGridView
                DataTable dt = new DataTable();

                // Thêm các cột tiêu đề vào DataTable
                foreach (DataGridViewColumn col in grid_NhaCungCap.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                // Thêm dữ liệu từ DataGridView vào DataTable
                foreach (DataGridViewRow row in grid_NhaCungCap.Rows)
                {
                    DataRow dataRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dataRow);
                }

                // Thêm dòng tiêu đề vào tệp Excel
                IRow headerRow = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    headerRow.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                }

                // Ghi dữ liệu từ DataTable vào Excel (bắt đầu từ dòng 2)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    IRow excelRow = sheet.CreateRow(i + 1); // +1 để bỏ qua dòng tiêu đề

                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ICell excelCell = excelRow.CreateCell(j);
                        excelCell.SetCellValue(dt.Rows[i][j].ToString());
                    }
                }

                // Lưu tệp Excel vào đĩa tại đường dẫn được chọn
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(stream);
                }

                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel và lưu tại đường dẫn: " + filePath);
            }
        }

        private void button_AddSP_Click(object sender, EventArgs e)
        {
            ThemSPNCC themSPNCC = new ThemSPNCC();
            themSPNCC.ShowDialog();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            NhaCungCap_Load(sender, e);
        }
    }
}