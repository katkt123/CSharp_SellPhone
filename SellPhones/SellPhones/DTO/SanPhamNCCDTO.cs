using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DTO
{
    public class SanPhamNCCDTO
    {
        public string maNCC { get; set; }
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public int donGia {  get; set; }

        public SanPhamNCCDTO(string maNCC, string maSP, string tenSP, int donGia)
        {
            this.maNCC = maNCC;
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donGia = donGia;
        }
    }
}
