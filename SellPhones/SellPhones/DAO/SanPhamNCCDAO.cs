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
    public class SanPhamNCCDAO
    {
        public SanPhamNCCDAO() { }
        private static SanPhamNCCDAO instance;

        public static SanPhamNCCDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamNCCDAO();
                return SanPhamNCCDAO.instance;
            }
            private set { SanPhamNCCDAO.instance = value; }
        }
        public List<SanPhamNCCDTO> SelectAll()
        {
            List<SanPhamNCCDTO> dtoList = new List<SanPhamNCCDTO>();

            string queryStr = "select * from SanPhamNCC";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];

                string maNcc = datarow.ItemArray[0].ToString();
                string maSP = datarow.ItemArray[1].ToString();
                string tenSP = datarow.ItemArray[2].ToString();
                int donGia = Convert.ToInt32(datarow.ItemArray[2].ToString());

                SanPhamNCCDTO dto = new SanPhamNCCDTO(maNcc, maSP, tenSP, donGia);
                dtoList.Add(dto);
            }
            return dtoList;
        }
        public int Insert(SanPhamNCCDTO target)
        {
            string insertStr = $"insert into SanPhamNCC values ('{target.maNCC}', '{target.maSP}' , '{target.tenSP}', '{target.donGia}')";
            return DataProvider.Instance.ExecuteNonQuery(insertStr);
        }
        public bool MaSPTonTai(string maSP)
        {
            string queryStr = $"SELECT COUNT(*) FROM SanPhamNCC WHERE MaSP = '{maSP}'";
            int count = (int)DataProvider.Instance.ExecuteScalar(queryStr);
            return count > 0;
        }
    }
}
