using SellPhones.DAO;
using SellPhones.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class PhieuNhapKhoBUS
    {
        private PhieuNhapKhoDAO DAO;
        private List<PhieuNhapKhoDTO> listDTO;
        private static PhieuNhapKhoBUS instance;

        public static PhieuNhapKhoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuNhapKhoBUS();
                return PhieuNhapKhoBUS.instance;
            }
            private set { PhieuNhapKhoBUS.instance = value; }
        }

        public PhieuNhapKhoBUS()
        {
            this.DAO = new PhieuNhapKhoDAO();
        }

        public List<PhieuNhapKhoDTO> GetList()
        {
            listDTO = new List<PhieuNhapKhoDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }
        public int Insert(PhieuNhapKhoDTO dto)
        {
            return this.DAO.Insert(dto);
        }
        public int Delete(string id)
        {
            return this.DAO.Delete(id);
        }

        public PhieuNhapKhoDTO getDNHByMaDNH(string ma_don_nh)
        {
            return this.DAO.getDNHByMaDNH(ma_don_nh)[0];

        }
    }
}
