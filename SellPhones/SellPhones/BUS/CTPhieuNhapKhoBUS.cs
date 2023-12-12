using SellPhones.DAO;
using SellPhones.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class CTPhieuNhapKhoBUS
    {
        private CTPhieuNhapKhoDAO DAO;
        private List<CTPhieuNhapKhoDTO> listDTO;


        public CTPhieuNhapKhoBUS()
        {
            this.DAO = new CTPhieuNhapKhoDAO();
        }

        public List<CTPhieuNhapKhoDTO> GetList()
        {
            listDTO = new List<CTPhieuNhapKhoDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public int Insert(CTPhieuNhapKhoDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public List<CTPhieuNhapKhoDTO> getCTDNHByMaDNH(string phieunhap)
        {
            return this.DAO.getCTDNHByMaDNH(phieunhap);

        }
        public void UpdateSoLuong(string maSanpham, int soLuong)
        {
            this.DAO.UpdateSoLuong(maSanpham, soLuong);
        }
        public SanPhamDTO getSPByMaSp(string maSP)
        {
            return this.DAO.getSPByMaSp(maSP)[0];
        }
    }
}
