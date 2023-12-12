using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private NhanVienDAO() { }

        public DataTable getAllNhanVien()
        {
            string query = "Select * from NhanVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool Register(string user, string pass, string name, string gender, string address, string phone)
        {
            int result = 0;

            string getall = "select * from TaiKhoan";
            DataTable list = DataProvider.Instance.ExecuteQuery(getall, new object[] { });
            int row = list.Rows.Count + 1;
            String id;
            if (row >= 100 && row <= 999) id = "TK" + row.ToString();
            else if (row >= 10 && row <= 99) id = "TK0" + row.ToString();
            else if (row >= 1 && row <= 9) id = "TK00" + row.ToString();
            else id = "TK" + row.ToString();

            string getall2 = "select * from NhanVien";
            DataTable list2 = DataProvider.Instance.ExecuteQuery(getall2, new object[] { });
            int row2 = list2.Rows.Count + 1;
            String id2;
            if (row2 >= 100 && row2 <= 999) id2 = "NV" + row2.ToString();
            else if (row2 >= 10 && row2 <= 99) id2 = "NV0" + row2.ToString();
            else if (row2 >= 1 && row2 <= 9) id2 = "NV00" + row2.ToString();
            else id2 = "NV" + row2.ToString();

            string query = "insert into TaiKhoan(MaTK,TenDangNhap,MatKhau,TrangThai) values( @MaTK , @TenDangNhap , @MatKhau , 0 )";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, user, pass });

            string query2 = "insert into NhanVien(MaNV,TenNV,GioiTinh,DiaChiNV,SDTNV,MaTK) values( @MaKH , @TenKH , @GioiTinh , @DiaChiNV , @SDTNV , @MaTK )";
            result = result + DataProvider.Instance.ExecuteNonQuery(query2, new object[] { id2, name, gender, address, phone, id });

            string quyen = "Nhân Viên";
            string query3 = "insert into Quyen(MaTK,PhanQuyen) values( @MaTK , @Quyen ) ";
            result += DataProvider.Instance.ExecuteNonQuery(query3, new object[] { id, quyen });
            return result == 3;

        }
        public bool isUserNameExist(string username)
        {
            string query = "Select * from TaiKhoan where TenDangNhap = @TenDangNhap ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return dt.Rows.Count > 0;
        }
        public bool UpdateNhanVien(string id, string name, string gender, string address, string phone)
        {
            string query = "update NhanVien set TenNV = @TenNV , GioiTinh = @GioiTinh , DiaChiNV = @diachinv , SDTNV = @sdtnv where MaNV = @manv";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, gender, address, phone, id });
            return result == 1;
        }
        public DataTable searchNhanVien(string data)
        {
            string query = "select * from NhanVien where MaNV like '%" + data + "%' or TenNV like N'%" + data + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
