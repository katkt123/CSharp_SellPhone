using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.GUI
{
    public class CTHoaDonInfo
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string SoLuong { get; set; }
        public string GiaTien { get; set; }

        public CTHoaDonInfo(string maSP, string tenSP, string soLuong, string giaTien)
        {
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
            GiaTien = giaTien;
        }
    }
    
}
