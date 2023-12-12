using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DTO
{
    public class NhaCungCapDTO
    {
        public string maNhacungcap { get; set; }
        public string tenNhacungcap { get; set; }
        public string diaChi { get; set; }
        public string sdtNCC { get; set; }

        public NhaCungCapDTO(string maNhacungcap, string tenNhacungcap, string diaChi, string sdtNCC)
        {
            this.maNhacungcap = maNhacungcap;
            this.tenNhacungcap = tenNhacungcap;
            this.diaChi = diaChi;
            this.sdtNCC = sdtNCC;
        }
    }
}
