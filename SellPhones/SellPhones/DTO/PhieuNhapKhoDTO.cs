using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DTO
{
    public class PhieuNhapKhoDTO
    {
        public string maPhieuNhap { get; set; }
        public string maKho { get; set; }
        public string maNhanVien { get; set; }
        public DateTime ngayNhap { get; set; }
        public int tongTien { get; set; }

        public PhieuNhapKhoDTO(string maPhieuNhap, string maKho,string maNhanVien, DateTime ngayNhap, int tongTien)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maKho = maKho;
            this.ngayNhap = ngayNhap;
            this.tongTien = tongTien;
            this.maNhanVien = maNhanVien;
        }
    }
}
