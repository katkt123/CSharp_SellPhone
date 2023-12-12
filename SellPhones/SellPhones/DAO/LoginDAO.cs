using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sellphone.DAO
{
    public class LoginDAO
    {
        private static LoginDAO instance;

        public static LoginDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private LoginDAO() { }
        public DataTable Login(string name, string password)
        {
            string query = "Select * from TaiKhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name, password });
        }

        public DataTable id_active()
        {
            string query = "Select * from TaiKhoan where TrangThai = 1";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { });
        }

        public bool unactive(string id)
        {
            int result = 0;
            string query = "update TaiKhoan set TrangThai = 0 where MaTK = @id";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
        
        public bool active(string id)
        {
            int result = 0;
            string query = "update TaiKhoan set TrangThai = 1 where MaTK = @id";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
        public string getQuyen(string id)
        {
            string quyen = "";
            string query = "SELECT * FROM Quyen WHERE MaTK = @Matk";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            if (dt.Rows.Count > 0)
            {
                quyen = dt.Rows[0]["PhanQuyen"].ToString(); // Thay "TenCot" bằng tên thực của cột quyền trong bảng Quyen
            }

            return quyen;
        }
        public bool RePassword(string pass,string email)
        {
            int result = 0;
            string sql = "Update TaiKhoan set MatKhau = @pass where Email = @email ";
            result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] {pass,email });
            return result > 0;
        }
        public bool CheckEmail(string email)
        {
            string sql = "Select * from TaiKhoan where Email = @email";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql, new object[] { email });
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        public bool unactive1(string user,string pass)
        {
            int result = 0;
            string query = "UPDATE TaiKhoan SET TrangThai = 0 WHERE TenDangNhap = @TenDangNhap AND MatKhau = @pass";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { user,pass });
            return result > 0;
        }
        public string getMaTK(string user,string pass)
        {
            string id="";
            string query = "Select MaTK from TaiKhoan where TenDangNhap = @TenDangNhap AND MatKhau = @pass";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { user,pass });
            foreach (DataRow row in dt.Rows)
            {
                id = row[0].ToString();
            }
            return id;
        }
        public string getMaNV(string id)
        {
            string id1 = "";
            string query = "Select MaNV from NhanVien where MaTK = @MaTK";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id});
            foreach (DataRow row in dt.Rows)
            {
                id1 = row[0].ToString();
            }
            return id1;
        }
    }
}
