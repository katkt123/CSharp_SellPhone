using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DTO
{
    public class SanPhamDTO
    {
        public string maSanpham { get; set; }
        public string tenSanpham { get; set; }
        public string Hang { get; set; }
        public string dungLuong { get; set; }
        public int DonGia { get; set; }
        public int soLuong { get; set; }
        public string hinhAnh { get; set; }

        public SanPhamDTO(string maSanpham, string tenSanpham, string Hang, string dungLuong, int DonGia, int soLuong, string hinhAnh)
        {
            this.maSanpham = maSanpham;
            this.tenSanpham = tenSanpham;
            this.soLuong = soLuong;
            this.Hang = Hang;
            this.DonGia = DonGia;
            this.hinhAnh = hinhAnh;
            this.dungLuong = dungLuong;
        }
    }
}
