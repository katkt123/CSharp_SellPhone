using SellPhones.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class RegisterBUS
    {
        private static RegisterBUS instance;


        public static RegisterBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new RegisterBUS();
                return RegisterBUS.instance;
            }
            private set { RegisterBUS.instance = value; }
        }
        

        public string Register(string user, string pass,string email, string name, string address, string phone)
        {
            if (RegisterDAO.Instance.isUserNameExist(user))
            {
                return "Tên Đăng Nhập Đã Được Tạo";
            }
            else if (RegisterDAO.Instance.Register(user, pass,email, name, address, phone)) return "Đăng Ký Thành Công";
            else return "Đăng Ký Thất Bại";
            
        } 
    }
}
