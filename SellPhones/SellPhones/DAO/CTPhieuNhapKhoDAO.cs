using Sellphone.DAO;
using SellPhones.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DAO
{
    public class CTPhieuNhapKhoDAO
    {
        public List<CTPhieuNhapKhoDTO> SelectAll()
        {
            List<CTPhieuNhapKhoDTO> dtoList = new List<CTPhieuNhapKhoDTO>();


            string queryStr = "select * from CTPhieuNhapKho";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];
                string maPhieunhap = datarow.ItemArray[0].ToString();
                string maNCC = datarow.ItemArray[1].ToString();
                int SLNhap = int.Parse(datarow.ItemArray[2].ToString());
                int tamTinh = int.Parse(datarow.ItemArray[3].ToString());
                int donGia = int.Parse(datarow.ItemArray[4].ToString());
                string tenSP = datarow.ItemArray[5].ToString();

                CTPhieuNhapKhoDTO dto = new CTPhieuNhapKhoDTO(maPhieunhap, maNCC, SLNhap, tamTinh, donGia, tenSP);
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public int Insert(CTPhieuNhapKhoDTO target)
        {
            string insertStr = $"insert into CTPhieuNhapKho values ('{target.maPhieuNhap}', '{target.maNCC}', '{target.SLNhap}', " +
                                                            $"'{target.tamtinh}','{target.dongia}','{target.tenSP}')";

            return DataProvider.Instance.ExecuteNonQuery(insertStr);
        }

        public List<CTPhieuNhapKhoDTO> getCTDNHByMaDNH(string phieunhap)
        {
            List<CTPhieuNhapKhoDTO> dtoList = new List<CTPhieuNhapKhoDTO>();

            string queryStr = $"select * from CTPhieuNhapKho where MaPhieuNhap='{phieunhap}'";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                string maPhieunhap = datarow.ItemArray[0].ToString();
                string maNCC = datarow.ItemArray[1].ToString();
                int SLNhap = int.Parse(datarow.ItemArray[2].ToString());
                int tamTinh = int.Parse(datarow.ItemArray[3].ToString());
                int donGia = int.Parse(datarow.ItemArray[4].ToString());
                string tenSP = datarow.ItemArray[5].ToString();

                CTPhieuNhapKhoDTO dto = new CTPhieuNhapKhoDTO(maPhieunhap, maNCC, SLNhap, tamTinh, donGia, tenSP);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public void UpdateSoLuong(string maSanpham, int soLuong)
        {
            string updateStr = "update SanPham set ";
            updateStr += $"SoLuong = '{soLuong}' ";
            updateStr += $"where MaSP='{maSanpham}'";

            DataProvider.Instance.ExecuteNonQuery(updateStr);
        }
        public List<SanPhamDTO> getSPByMaSp(string MaSP)
        {
            List<SanPhamDTO> dtoList = new List<SanPhamDTO>();

            string queryStr = $"select MaSP,TenSP,Hang,DungLuong,DonGia,SoLuong,HinhAnh from SanPham where MaSP='{MaSP}'";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];

                string maSanpham = datarow.ItemArray[0].ToString();
                string tenSanpham = datarow.ItemArray[1].ToString();
                string Hang = datarow.ItemArray[2].ToString();
                string dungLuong = datarow.ItemArray[3].ToString();
                int donGia = int.Parse(datarow.ItemArray[4].ToString());
                int SoLuong = int.Parse(datarow.ItemArray[5].ToString());
                string hinhAnh = datarow.ItemArray[6].ToString();
                
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, Hang, dungLuong, donGia, SoLuong, hinhAnh);
                dtoList.Add(dto);
            }
            return dtoList;
        }
    }
}
