using Microsoft.VisualStudio.Shell.Interop;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SellPhones.BUS;
using SellPhones.DAO;
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
    public partial class KhachHangUC : UserControl
    {
        public static string idkh;
        public KhachHangUC()
        {
            InitializeComponent();
            loadKhachHanglist();
            setNull();
        }

        private void KhachHangUC_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool IsValid(string sdt, string tenKH)
        {

            int parsedSdt;
            if (!int.TryParse(sdt, out parsedSdt) || sdt.Length != 10)
            {
                MessageBox.Show("Số Điện Thoại không hợp lệ. Vui lòng nhập đúng 10 số và không chứa ký tự.");
                return false;
            }



            if (System.Text.RegularExpressions.Regex.IsMatch(tenKH, @"\d"))
            {
                MessageBox.Show("Tên Khách Hàng không hợp lệ. Vui lòng không nhập số.");
                return false;
            }

            return true;
        }

        void setNull()
        {
            //if (comboBox_Type.Items.Count > 0)
            //{
            //    // Chọn item đầu tiên
            //    comboBox_Type.SelectedIndex = 0;
            //}
            textBox_MaKH.Text = "";
            textBox_Name.Text = "";
            textBox_Address.Text = "";
            textBox_Phone.Text = "";
        }
        public void loadKhachHanglist()
        {
            DataTable dt = KhachHangBUS.Instance.getAllKhachHang();
            if (Grid_KhachHang.Columns.Contains("Look"))
            {
                Grid_KhachHang.Columns.Remove("Look");
            }
            Grid_KhachHang.DataSource = dt;

            Grid_KhachHang.DataSource = dt;

            Grid_KhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            Grid_KhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            Grid_KhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            Grid_KhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            Grid_KhachHang.Columns["MaTK"].HeaderText = "Mã Tài Khoản";



            Grid_KhachHang.Columns["MaKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["TenKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["SDT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.Name = "Look";
            deleteButtonColumn.HeaderText = "Xem Thông Tin Chi Tiết";
            string imagePath = @"C:\SGU\Nam3 HK1\C#\Backup_2\SellPhones\SellPhones\Comp\Search.png"; // Thay đổi đường dẫn tới hình ảnh của bạn

            Image deleteImage = Image.FromFile(imagePath);
            deleteButtonColumn.Image = deleteImage;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Grid_KhachHang.Columns.Add(deleteButtonColumn);
            Grid_KhachHang.CellContentClick += Grid_KhachHang_CellContentClick;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            setNull();
            loadKhachHanglist();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string address = textBox_Address.Text;
            string phone = textBox_Phone.Text;
            if (IsValid(phone, name))
            {
                KhachHangBUS.Instance.insertKhachHang(name, address, phone);
                MessageBox.Show("Thêm Thành Công !!!");
                loadKhachHanglist();
            }

        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (Grid_KhachHang.SelectedRows.Count > 0)
            {
                if (IsValid(textBox_Phone.Text, textBox_Name.Text))
                {
                    KhachHangBUS.Instance.UpdateKhachHang(Grid_KhachHang.SelectedRows[0].Cells["MaKH"].Value.ToString(), textBox_Name.Text, textBox_Address.Text, textBox_Phone.Text);
                    MessageBox.Show("Cập nhật thành công !!!");
                    loadKhachHanglist();
                    setNull();
                }

            }
            else MessageBox.Show("Vui lòng chọn một dòng trước khi sửa !!!!!");
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (Grid_KhachHang.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa  tài khoản", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string maKH = Grid_KhachHang.SelectedRows[0].Cells["MaKH"].Value.ToString();
                    string maTK = Grid_KhachHang.SelectedRows[0].Cells["MaTK"].Value.ToString();
                    KhachHangBUS.Instance.DelKhachHang(maKH, maTK);
                    Grid_KhachHang.Rows.Remove(Grid_KhachHang.SelectedRows[0]);
                    setNull();
                }
            }
            else MessageBox.Show("Vui lòng chọn một dòng trước khi xóa !!!");

            loadKhachHanglist();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            //if (comboBox_Type.SelectedIndex.ToString() == "") MessageBox.Show("Vui lòng chọn kiểu dữ liệu để tìm kiếm !!");
            //else
            //{
            //    string action = comboBox_Type.SelectedItem.ToString();
            //    string data = textBox_Search.Text;



            //    DataTable dt = KhachHangDAO.Instance.SearchKH(data);


            //        Grid_KhachHang.DataSource = dt;

            //        Grid_KhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            //        Grid_KhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            //        Grid_KhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            //        Grid_KhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            //        Grid_KhachHang.Columns["MaTK"].HeaderText = "Mã Tài Khoản";



            //        Grid_KhachHang.Columns["MaKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        Grid_KhachHang.Columns["TenKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        Grid_KhachHang.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        Grid_KhachHang.Columns["SDT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //        Grid_KhachHang.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //}
            textBox_Search.Text = "";
        }

        private void Grid_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Grid_KhachHang.Rows[e.RowIndex];


                // Hiển thị thông tin từ hàng được chọn lên TextBox
                textBox_MaKH.Text = row.Cells["MaKH"].Value.ToString();
                textBox_Name.Text = row.Cells["TenKH"].Value.ToString();
                textBox_Phone.Text = row.Cells["SDT"].Value.ToString();
                textBox_Address.Text = row.Cells["DiaChi"].Value.ToString();

                // ... thêm các TextBox khác tương ứng với các cột trong DataGridView
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string data = textBox_Search.Text;
            //DataTable dt = KhachHangDAO.Instance.SearchKH(data);


            //Grid_KhachHang.DataSource = dt;

            //Grid_KhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            //Grid_KhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            //Grid_KhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            //Grid_KhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            //Grid_KhachHang.Columns["MaTK"].HeaderText = "Mã Tài Khoản";



            //Grid_KhachHang.Columns["MaKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Grid_KhachHang.Columns["TenKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Grid_KhachHang.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Grid_KhachHang.Columns["SDT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Grid_KhachHang.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string data = textBox_Search.Text;
            DataTable dt = KhachHangDAO.Instance.SearchKH(data);


            Grid_KhachHang.DataSource = dt;

            Grid_KhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            Grid_KhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            Grid_KhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            Grid_KhachHang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            Grid_KhachHang.Columns["MaTK"].HeaderText = "Mã Tài Khoản";



            Grid_KhachHang.Columns["MaKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["TenKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["SDT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grid_KhachHang.Columns["MaTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
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

                //// Thêm các cột tiêu đề vào DataTable
                //foreach (DataGridViewColumn col in Grid_KhachHang.Columns)
                //{
                //    dt.Columns.Add(col.HeaderText);
                //}

                //// Thêm dữ liệu từ DataGridView vào DataTable
                //foreach (DataGridViewRow row in Grid_KhachHang.Rows)
                //{
                //    DataRow dataRow = dt.NewRow();
                //    foreach (DataGridViewCell cell in row.Cells)
                //    {
                //        dataRow[cell.ColumnIndex] = cell.Value;
                //    }
                //    dt.Rows.Add(dataRow);
                //}
                foreach (DataGridViewColumn col in Grid_KhachHang.Columns)
                {
                    if (col.Name != "Look") // Kiểm tra tên cột
                    {
                        dt.Columns.Add(col.HeaderText);
                    }
                }

                // Thêm dữ liệu từ DataGridView vào DataTable (loại bỏ cột "Delete")
                foreach (DataGridViewRow row in Grid_KhachHang.Rows)
                {
                    DataRow dataRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (Grid_KhachHang.Columns[cell.ColumnIndex].Name != "Look") // Kiểm tra tên cột
                        {
                            dataRow[Grid_KhachHang.Columns[cell.ColumnIndex].HeaderText] = cell.Value;
                        }
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

        private void button_XemChiTiet_Click(object sender, EventArgs e)
        {
            if (Grid_KhachHang.SelectedRows.Count > 0)
            {
                idkh = textBox_MaKH.Text;
                XemHoaDonKhachHang lg = new XemHoaDonKhachHang();
                lg.StartPosition = FormStartPosition.CenterScreen;
                lg.ShowDialog();
            }
            else MessageBox.Show("Vui lòng chọn một dòng trước khi xem chi tiết hóa đơn !!!!!");
        }

        private void Grid_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Grid_KhachHang.Columns["Look"].Index && e.RowIndex >= 0)
            {

                idkh = textBox_MaKH.Text;
                XemHoaDonKhachHang lg = new XemHoaDonKhachHang();
                lg.StartPosition = FormStartPosition.CenterScreen;
                lg.ShowDialog();

            }
        }
    }

}
