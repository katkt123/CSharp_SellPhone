using Sellphone.DAO;
using SellPhones.DTO;
using SellPhones.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DAO
{
    public class PhieuNhapKhoDAO
    {
        public PhieuNhapKhoDAO() { }
        public List<PhieuNhapKhoDTO> SelectAll()
        {
            List<PhieuNhapKhoDTO> dtoList = new List<PhieuNhapKhoDTO>();


            string queryStr = "select * from PhieuNhapKho";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];
                string maPhieuNhap = datarow.ItemArray[0].ToString();
                string maKho = datarow.ItemArray[1].ToString();
                string maNhanVien = datarow.ItemArray[2].ToString();
                DateTime ngayNhap = (DateTime)datarow.ItemArray[3];
                int tongTien = int.Parse(datarow.ItemArray[4].ToString());
                PhieuNhapKhoDTO dto = new PhieuNhapKhoDTO(maPhieuNhap, maKho, maNhanVien, ngayNhap, tongTien);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public int Insert(PhieuNhapKhoDTO target)
        {
            string getall = "select * from PhieuNhapKho";
            DataTable list = DataProvider.Instance.ExecuteQuery(getall);

            int row = list.Rows.Count + 1;
            String mapn;

            if (row >= 100 && row <= 999) mapn = "PN" + row.ToString();
            else if (row >= 10 && row <= 99) mapn = "PN0" + row.ToString();
            else if (row >= 1 && row <= 9) mapn = "PN00" + row.ToString();
            else mapn = "PN" + row.ToString();

            string ngayNhap = target.ngayNhap.ToString("yyyy-MM-dd");
            string insertStr = $"insert into PhieuNhapKho values ('{mapn}','{target.maKho}','{target.maNhanVien}','{ngayNhap}','{target.tongTien}')";

            return DataProvider.Instance.ExecuteNonQuery(insertStr);
        }
        public int Delete(string id)
        {
            string deleteStr = $"delete from PhieuNhapKho where MaPhieuNhap = '{id}'";

            return DataProvider.Instance.ExecuteNonQuery(deleteStr);
        }
        public List<PhieuNhapKhoDTO> getDNHByMaDNH(string phieunhap)
        {
            List<PhieuNhapKhoDTO> dtoList = new List<PhieuNhapKhoDTO>();

            string queryStr = $"select * from PhieuNhapKho where MaPhieuNhap='{phieunhap}'";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];
                string maPhieuNhap = datarow.ItemArray[0].ToString();
                string maKho = datarow.ItemArray[1].ToString();
                string maNhanVien = datarow.ItemArray[2].ToString();
                DateTime ngayNhap = (DateTime)datarow.ItemArray[3];
                int tongTien = int.Parse(datarow.ItemArray[4].ToString());
                PhieuNhapKhoDTO dto = new PhieuNhapKhoDTO(maPhieuNhap, maKho, maNhanVien, ngayNhap, tongTien);
                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}
