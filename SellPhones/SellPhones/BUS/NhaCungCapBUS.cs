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
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO DAO;
        private List<NhaCungCapDTO> listDTO;
        private static NhaCungCapBUS instance;


        public static NhaCungCapBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapBUS();
                return NhaCungCapBUS.instance;
            }
            private set { NhaCungCapBUS.instance = value; }
        }


        public NhaCungCapBUS()
        {
            this.DAO = new NhaCungCapDAO();
        }

        public List<NhaCungCapDTO> GetList()
        {
            listDTO = new List<NhaCungCapDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public int Insert(NhaCungCapDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(NhaCungCapDTO dto)
        {
            this.DAO.Update(dto);
        }

        public int Delete(string dtoId)
        {
            return this.DAO.Delete(dtoId);
        }

        public NhaCungCapDTO geNCCByMaNCC(string ma_ncc)
        {
            return this.DAO.geNCCByMaNCC(ma_ncc)[0];
        }

        public List<NhaCungCapDTO> getNCCByNameCC(string ten_ncc)
        {
            return this.DAO.getNCCByNameCC(ten_ncc);
        }
    }
}
