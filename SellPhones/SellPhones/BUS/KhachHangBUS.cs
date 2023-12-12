using SellPhones.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;


        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return KhachHangBUS.instance;
            }
            private set { KhachHangBUS.instance = value; }
        }

        public DataTable getAllKhachHang()
        {
            return KhachHangDAO.Instance.getAllKhachHang();
        }
        public DataTable getAllHoaDonKH(string idkh)
        {
            return KhachHangDAO.Instance.getAllHoaDonKH(idkh);
        }
        public string insertKhachHang(string name, string address, string phone)
        {
            if (KhachHangDAO.Instance.insertKhachHang(name, address, phone))
            {
                return "Thêm Thành Công !!";
            }
            else return "Thêm Thất Bại";
        }
        public string UpdateKhachHang(string id, string name, string address, string phone)
        {
            if (KhachHangDAO.Instance.UpdateKhachHang(id, name, address, phone))
            {
                return "Cập Nhật Thành Công !!";

            }
            else return "Cập Nhật Thất Bại !!";
        }
        public string DelKhachHang(string id,string idtk)
        {
            if (KhachHangDAO.Instance.DelKhachHang(id, idtk))
            {
                return "Xóa Thành Công! !";

            }
            else return "Xóa Thất Bại !!";
        }
        public DataTable searchKhachHang(string data,string action)
        {
            return KhachHangDAO.Instance.searchKhachHang(data,action);
        }
    }
}
