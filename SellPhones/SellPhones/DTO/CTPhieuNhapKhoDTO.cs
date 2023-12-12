using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DTO
{
    public class CTPhieuNhapKhoDTO
    {
        public string maPhieuNhap { get; set; }
        public string maNCC { get; set; }
        public int SLNhap { get; set; }
        public int tamtinh { get; set; }
     
        public int dongia { get; set; }
        public string tenSP {  get; set; }

        public CTPhieuNhapKhoDTO(string maPhieuNhap, string maNCC, int SLNhap, int tamtinh, int dongia, string tenSP)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maNCC = maNCC;
            this.SLNhap = SLNhap;
            this.tamtinh = tamtinh;
            this.dongia = dongia;
            this.tenSP = tenSP;
        }
    }
}
