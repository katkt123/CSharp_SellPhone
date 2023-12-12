using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DTO
{
    public class TaiKhoanDTO
    {
        private string matk;
        private string user;
        private string pass;
        private int trangthai;
        private string quyen;

       public TaiKhoanDTO () 
       {
            matk = "";
            user = "";
            pass = "";
            trangthai = 0;
            quyen = "";
       }

       public TaiKhoanDTO (string maTK,string User,string Pass,int Trangthai,string Quyen)
        {
            matk = maTK;
            user = User;
            pass = Pass;
            trangthai = Trangthai;
            quyen = Quyen;
        }

        public string Matk { get => matk; set => matk = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public string Quyen { get => quyen; set => quyen = value; }
    }

    
}
