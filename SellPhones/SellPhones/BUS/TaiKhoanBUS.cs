using Org.BouncyCastle.Bcpg.OpenPgp;
using SellPhones.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SellPhones.BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;


        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBUS();
                return TaiKhoanBUS.instance;
            }
            private set { TaiKhoanBUS.instance = value; }
        }

        public DataTable getAllTaiKhoan()
        {
            return TaiKhoanDAO.Instance.getAllTaiKhoan();
        }
        public DataTable getAllQuyen()
        {
            return TaiKhoanDAO.Instance.getAllQuyen();
        }

        public DataTable searchTaiKhoan(string data,string action)
        {
            return TaiKhoanDAO.Instance.searchTaiKhoan(data,action);
        }
        public string insertTaiKhoan(string user, string pass)
        {
            if (TaiKhoanDAO.Instance.isUserNameExist(user))
            {
                return "Tên Đăng Nhập Đã Được Tạo";
            }
            else if (TaiKhoanDAO.Instance.insertTaiKhoan(user, pass)) return "Thêm Tài Khoản Thành Công";
            else return "Thêm Tài Khoản Thất Bại";
        }

        public string DelTaiKhoan(string id)
        {
            if (TaiKhoanDAO.Instance.DelTaiKhoan(id))
            {
                return "Xóa Thành Công";
            }
            else return "Xóa Thất Bại";

        }
        public string UpdateTaiKhoan(string id,string user,string pass,string email)
        {
            if (TaiKhoanDAO.Instance.UpdateTaiKhoan(id,user, pass,email))
            {
                return "Cập nhật thành công";
            }
            else return "Cập nhật thất bại";
        }
        public string addQuyen(string id, string quyen)
        {
            if (TaiKhoanDAO.Instance.addQuyen(id, quyen))
            {
                return "Thêm quyền thành công";
            }
            else return "Thêm quyền thất bại";
        }
        public string KhoaTaiKhoan(string id)
        {
            if (TaiKhoanDAO.Instance.KhoaTaiKhoan(id))
            {
                return "Khóa Thành Công";
            }
            else return "Khóa Thất Bại";
        }
        public string getEmail(string user,string pass)
        {
            return TaiKhoanDAO.Instance.getEmail(user,pass);
        }
        public string getIDTK(string user,string pass)
        {
            return TaiKhoanDAO.Instance.getIDTK(user,pass);
        }
        public string getQuyen(string id)
        {
            return TaiKhoanDAO.Instance.getQuyen(id);
        }
    }
}
