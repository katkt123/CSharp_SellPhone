using Microsoft.VisualBasic.ApplicationServices;
using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SellPhones.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private KhachHangDAO() { }

        public DataTable getAllKhachHang()
        {
            string query = "Select * from KhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getAllHoaDonKH(string idkh)
        {
            string query = "Select * from HoaDon where MaKH = @MaKH ";
            DataTable list = DataProvider.Instance.ExecuteQuery(query, new object[] {idkh });
            return list;
        }
        public bool insertKhachHang(string name, string address, string phone)
        {
            string getall = "select * from KhachHang";
            DataTable list = DataProvider.Instance.ExecuteQuery(getall, new object[] { });
            int row = list.Rows.Count + 1;
            String id;
            if (row >= 100 && row <= 999) id = "KH" + row.ToString();
            else if (row >= 10 && row <= 99) id = "KH0" + row.ToString();
            else if (row >= 1 && row <= 9) id = "KH00" + row.ToString();
            else id = "KH" + row.ToString();

            string getall1 = "select * from TaiKhoan";
            DataTable list1 = DataProvider.Instance.ExecuteQuery(getall, new object[] { });
            int row1 = list1.Rows.Count + 1;
            String id1;
            if (row1 >= 100 && row1 <= 999) id1 = "TK" + row1.ToString();
            else if (row1 >= 10 && row1 <= 99) id1 = "TK0" + row1.ToString();
            else if (row1 >= 1 && row1 <= 9) id1 = "TK00" + row1.ToString();
            else id1 = "TK" + row1.ToString();
            
            string query = "insert into TaiKhoan (MaTK,TrangThai) values ( @id , 0 )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id1 });
            string quyen = "Khách Hàng";
            string query2 = "insert into Quyen (MaTK,PhanQuyen) values( @id , @quyen )";
            result += DataProvider.Instance.ExecuteNonQuery(query2, new object[] { id1, quyen });

            string query1 = "insert into KhachHang (MaKH,TenKH,DiaChi,SDT,MaTK) values( @id , @ten , @diachi , @sdt , @matk )";
            result += DataProvider.Instance.ExecuteNonQuery(query1, new object[] { id, name,address,phone,id1 });


            
            return result == 3;
        }
        public bool UpdateKhachHang(string id,string name, string address, string phone)
        {
            string query = "update KhachHang set TenKH = @TenKH , DiaChi = @diachi , SDT = @sdt where MaKH = @makh";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name,address,phone,id });
            return result == 1;
        }
        public bool DelKhachHang(string id,string idtk)
        {
            int result = 0;
            string query = "delete from KhachHang where MaKH = @MaKH ";
            string query1 = "delete from TaiKhoan where MaTK = @MaTK ";
            string query2 = "delete from Quyen where MaTK = @MaTK ";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            result = result + DataProvider.Instance.ExecuteNonQuery(query2, new object[] { idtk });
            result = result + DataProvider.Instance.ExecuteNonQuery(query1, new object[] { idtk });
            return result == 3;
        }
        public DataTable searchKhachHang(String data, String action)
        {
            string query = "";
            if (action == "Mã Khách Hàng")
                query = "select * from KhachHang where MaKH like '%" + data + "%'";
            else if (action == "Tên Khách Hàng")
                query = "select * from KhachHang where TenKH like N'%" + data + "%'";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SearchKH(string data)
        {
            string sql = "select * from KhachHang where concat(MaKH,TenKH,DiaChi,SDT,MaTK) COLLATE Latin1_General_CI_AI like '%" + data + "%'";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
    }
}
