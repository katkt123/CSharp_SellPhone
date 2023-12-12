using Sellphone.DAO;
using SellPhones.BUS;
using SellPhones.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DAO
{
    public class NhaCungCapDAO
    {
        public NhaCungCapDAO() { }
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                return NhaCungCapDAO.instance;
            }
            private set { NhaCungCapDAO.instance = value; }
        }
        public List<NhaCungCapDTO> SelectAll()
        {
            List<NhaCungCapDTO> dtoList = new List<NhaCungCapDTO>();

            string queryStr = "select * from NhaCungCap";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];

                string maNcc = datarow.ItemArray[0].ToString();
                string tenNcc = datarow.ItemArray[1].ToString();
                string diaChi = datarow.ItemArray[2].ToString();
                string sdtNCC = datarow.ItemArray[3].ToString();

                NhaCungCapDTO dto = new NhaCungCapDTO(maNcc, tenNcc, diaChi, sdtNCC);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public int Insert(NhaCungCapDTO target)
        {
            string getall = "select * from NhaCungCap";
            DataTable list = DataProvider.Instance.ExecuteQuery(getall);

            int row = list.Rows.Count + 1;
            String maNcc;

            if (row >= 100 && row <= 999) maNcc = "NCC" + row.ToString();
            else if (row >= 10 && row <= 99) maNcc = "NCC0" + row.ToString();
            else if (row >= 1 && row <= 9) maNcc = "NCC00" + row.ToString();
            else maNcc = "NCC" + row.ToString();

            string insertStr = $"insert into NhaCungCap values ('{maNcc}', '{target.tenNhacungcap}', '{target.diaChi}' , '{target.sdtNCC}')";

            return DataProvider.Instance.ExecuteNonQuery(insertStr);
        }

        public void Update(NhaCungCapDTO target)
        {
            string updateStr = "UPDATE NhaCungCap SET ";
            updateStr += $"TenNCC = '{target.tenNhacungcap}', ";
            updateStr += $"DiaChiNCC = '{target.diaChi}', ";
            updateStr += $"SDTNCC = '{target.sdtNCC}' ";
            updateStr += $"WHERE MaNCC = '{target.maNhacungcap}'";

            DataProvider.Instance.ExecuteNonQuery(updateStr);
        }

        public int Delete(string id)
        {
            string deleteStr = $"delete from NhaCungCap where MaNCC = '{id}'";

            return DataProvider.Instance.ExecuteNonQuery(deleteStr);
        }

        public List<NhaCungCapDTO> geNCCByMaNCC(string ma_ncc)
        {
            List<NhaCungCapDTO> dtoList = new List<NhaCungCapDTO>();


            string queryStr = $"select * from NhaCungCap where MaNCC='{ma_ncc}'";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                string maNcc = datarow.ItemArray[0].ToString();
                string tenNcc = datarow.ItemArray[1].ToString();
                string diaChi = datarow.ItemArray[2].ToString();
                string sdtNCC = datarow.ItemArray[3].ToString();

                NhaCungCapDTO dto = new NhaCungCapDTO(maNcc, tenNcc, diaChi, sdtNCC);
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public List<NhaCungCapDTO> getNCCByNameCC(string ten_ncc)
        {
            List<NhaCungCapDTO> dtoList = new List<NhaCungCapDTO>();

            string queryStr = $"select * from NhaCungCap where TenNCC like '%{ten_ncc}%'";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];

                string maNcc = datarow.ItemArray[0].ToString();
                string tenNcc = datarow.ItemArray[1].ToString();
                string diaChi = datarow.ItemArray[2].ToString();
                string sdtNCC = datarow.ItemArray[3].ToString();

                NhaCungCapDTO dto = new NhaCungCapDTO(maNcc, tenNcc, diaChi, sdtNCC);
                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}
