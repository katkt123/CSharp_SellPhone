using SellPhones.DAO;
using SellPhones.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class SanPhamNCCBUS
    {
        private SanPhamNCCDAO DAO;
        private List<SanPhamNCCDTO> listDTO;
        private static SanPhamNCCBUS instance;


        public static SanPhamNCCBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamNCCBUS();
                return SanPhamNCCBUS.instance;
            }
            private set { SanPhamNCCBUS.instance = value; }
        }


        public SanPhamNCCBUS()
        {
            this.DAO = new SanPhamNCCDAO();
        }

        public List<SanPhamNCCDTO> GetList()
        {
            listDTO = new List<SanPhamNCCDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public int Insert(SanPhamNCCDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public bool MaSPTonTai(string masp)
        {
            return this.DAO.MaSPTonTai(masp);
        }
    }
}
