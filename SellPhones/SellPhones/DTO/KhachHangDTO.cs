using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DTO
{
    public class KhachHangDTO
    {
        private string MaKH;
        private string TenKH;
        private string DiaChi;
        private string SDT;
        private string MaTK;

        public KhachHangDTO() { }

        public KhachHangDTO(string maKH, string tenKH, string diaChi, string sDT, string maTK)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SDT = sDT;
            MaTK = maTK;
        }

        public string maKH { get => MaKH; set=>MaKH = value; }

        public string tenKH { get => TenKH; set=>TenKH = value; }

        public string diachi { get => DiaChi; set=>DiaChi = value; }

        public string sdt {  get => SDT; set=>SDT = value; }

        public string maTK { get => MaTK; set=>MaTK = value; }
    }
}
