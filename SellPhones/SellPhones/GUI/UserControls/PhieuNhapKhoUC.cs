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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhones.GUI.UserControls
{
    public partial class PhieuNhapKhoUC : UserControl
    {
        public PhieuNhapKhoUC()
        {
            InitializeComponent();
        }

        private void Find_date_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = pickDate_start.Value.Date;
            DateTime ngayKetThuc = pickDate_end.Value.Date;

            PhieuNhapKhoBUS phieuNhapKhoBUS = new PhieuNhapKhoBUS();

            List<PhieuNhapKhoDTO> danhSachDonNhap = phieuNhapKhoBUS.GetList();

            if (ngayBatDau < ngayKetThuc)
            {
                var filteredRows = danhSachDonNhap
               .Where(row =>
                   (row.ngayNhap.Date >= ngayBatDau && row.ngayNhap.Date <= ngayKetThuc))
               .ToList();
                grid_PhieuNhap.DataSource = filteredRows;
            }
            else
            {
                MessageBox.Show("Không hợp lệ");
                grid_PhieuNhap.DataSource = danhSachDonNhap;
                text_DateStart.Text = "";
                text_DateEnd.Text = "";
            }
        }

        private void PhieuNhapKho_Load(object sender, EventArgs e)
        {
            PhieuNhapKhoBUS phieuNhapKhoBUS = new PhieuNhapKhoBUS();

            List<PhieuNhapKhoDTO> danhSachDonNhap = phieuNhapKhoBUS.GetList();

            grid_PhieuNhap.DataSource = danhSachDonNhap;

            grid_PhieuNhap.Columns["maPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
            grid_PhieuNhap.Columns["maKho"].HeaderText = "Mã Nhà Cung Cấp";
            grid_PhieuNhap.Columns["maNhanVien"].HeaderText = "Mã Nhân Viên";
            grid_PhieuNhap.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
            grid_PhieuNhap.Columns["tongTien"].HeaderText = "Tổng Tiền";

            grid_PhieuNhap.Columns["maPhieuNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_PhieuNhap.Columns["maKho"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_PhieuNhap.Columns["maNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grid_PhieuNhap.Columns["ngayNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_PhieuNhap.Columns["tongTien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void text_Find_TextChanged(object sender, EventArgs e)
        {
            string searchText = text_Find.Text.Trim().ToLower(); // Lấy nội dung của TextBox và chuyển về chữ thường

            if (string.IsNullOrEmpty(searchText))
            {

                PhieuNhapKhoBUS phieuNhapKhoBUS = new PhieuNhapKhoBUS();

                // Gọi phương thức để lấy danh sách nhập kho từ BLL
                List<PhieuNhapKhoDTO> danhSachNhapKho = phieuNhapKhoBUS.GetList();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_PhieuNhap.DataSource = danhSachNhapKho;
            }
            else
            {
                PhieuNhapKhoBUS phieuNhapKhoBUS = new PhieuNhapKhoBUS();

                // Gọi phương thức để lấy danh sách  nhập kho từ BLL
                List<PhieuNhapKhoDTO> danhSachNhapKho = phieuNhapKhoBUS.GetList();

                // Nếu TextBox có nội dung, tìm kiếm và lọc dữ liệu dựa trên nội dung
                var filteredRows = danhSachNhapKho.AsEnumerable()
                    .Where(row => row.maPhieuNhap.ToString().ToLower().Contains(searchText)
                    || row.maKho.ToString().ToLower().Contains(searchText))
                    .ToList();

                grid_PhieuNhap.DataSource = filteredRows;
            }
        }
        private void pickDate_start_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = pickDate_start.Value;
            DateTime selectedDateEnd = pickDate_end.Value;
            DateTime currentDate = DateTime.Now;
            if (selectedDate > currentDate)
            {
                MessageBox.Show("Vui lòng chọn ngày không lớn hơn ngày hiện tại.");
                // Đặt giá trị DateTimePicker thành ngày hiện tại
                pickDate_start.Value = currentDate;
                return;
            }


            // Hiển thị ngày đã chọn lên TextBox
            text_DateStart.Text = selectedDate.ToShortDateString();
        }
        private void pickDate_end_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedStartDate = pickDate_start.Value;
            DateTime selectedDate = pickDate_end.Value;
            DateTime currentDate = DateTime.Now;

            if (selectedDate > currentDate)
            {
                MessageBox.Show("Vui lòng chọn ngày không lớn hơn ngày hiện tại.");
                // Đặt giá trị DateTimePicker thành ngày hiện tại
                pickDate_end.Value = currentDate;

            }
            else if (selectedStartDate > selectedDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
                // Đặt giá trị DateTimePicker thành ngày bắt đầu
                pickDate_end.Value = selectedStartDate;
            }
            else if (text_DateStart.Text == "" || text_DateStart.Text.Contains(" "))
            {
                MessageBox.Show("Hãy chọn ngày bắt đầu trước");
            }
            else
            {
                // Hiển thị ngày đã chọn lên TextBox
                text_DateEnd.Text = selectedDate.ToShortDateString();
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (grid_PhieuNhap.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = grid_PhieuNhap.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = grid_PhieuNhap.Rows[selectedRowIndex];
                    string maPhieunh = selectedRow.Cells["maPhieuNhap"].Value.ToString();

                    PhieuNhapKhoBUS phieunhap = new PhieuNhapKhoBUS();
                    phieunhap.Delete(maPhieunh);
                    List<PhieuNhapKhoDTO> danhSachPhieuNhap = phieunhap.GetList();

                    // Đặt nguồn dữ liệu cho DataGridView
                    grid_PhieuNhap.DataSource = danhSachPhieuNhap;

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

        private void button3_Click(object sender, EventArgs e)
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
                foreach (DataGridViewColumn col in grid_PhieuNhap.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                // Thêm dữ liệu từ DataGridView vào DataTable
                foreach (DataGridViewRow row in grid_PhieuNhap.Rows)
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

        private void button_CTPhieuNhap_Click(object sender, EventArgs e)
        {
            if (grid_PhieuNhap.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_PhieuNhap.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_PhieuNhap.Rows[selectedRowIndex];
                string maPhieuNhap = selectedRow.Cells["maPhieuNhap"].Value.ToString();
                // Truyền thông tin từ dòng đã chọn trực tiếp cho form ChiTietDonNhap
                CTPhieuNhapKho formChiTiet = new CTPhieuNhapKho(maPhieuNhap);
                formChiTiet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            ThemPhieuNhapKho themPhieuNhapKho = new ThemPhieuNhapKho();
            themPhieuNhapKho.ShowDialog();
        }

        private void text_DateStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           PhieuNhapKho_Load(sender, e);
        }
    }
}
