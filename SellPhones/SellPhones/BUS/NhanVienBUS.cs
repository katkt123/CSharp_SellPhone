using SellPhones.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;


        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return NhanVienBUS.instance;
            }
            private set { NhanVienBUS.instance = value; }
        }

        public DataTable getAllNhanVien()
        {
            return NhanVienDAO.Instance.getAllNhanVien();
        }
        public string Register(string user, string pass, string name, string gender, string address, string phone)
        {
            if (NhanVienDAO.Instance.isUserNameExist(user))
            {
                return "Tên Đăng Nhập Đã Được Tạo";
            }
            else if (NhanVienDAO.Instance.Register(user, pass, name, gender, address, phone)) return "Đăng Ký Thành Công";
            else return "Đăng Ký Thất Bại";
        }
        public string UpdateNhanVien(string id, string name, string gender, string address, string phone)
        {
            if (NhanVienDAO.Instance.UpdateNhanVien(id, name, gender, address, phone))
            {
                return "Cập Nhật Thành Công !!";

            }
            else return "Cập Nhật Thất Bại !!";
        }
        public DataTable searchNhanVien(string data)
        {
            return NhanVienDAO.Instance.searchNhanVien(data);
        }

    }
}
