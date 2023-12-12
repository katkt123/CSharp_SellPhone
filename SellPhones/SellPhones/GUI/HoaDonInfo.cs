using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.GUI
{
    public class HoaDonInfo
    {
        public string SoHD { get; set; }
        public string TenKhachHang { get; set; }
        public string NgayXuat { get; set; }
        public string TriGia { get; set; }

        public HoaDonInfo(string soHD, string tenKhachHang, string ngayXuat, string triGia)
        {
            SoHD = soHD;
            TenKhachHang = tenKhachHang;
            NgayXuat = ngayXuat;
            TriGia = triGia;
        }
    }
}
