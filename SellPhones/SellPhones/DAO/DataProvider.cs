using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellphone.DAO
{
    public class DataProvider
    {
        /// --------------------Luu Y ---------------------------------///
        ///  Hàm ExecuteQuery(string query, object[] parameter = null):
        ///  Hàm này được sử dụng để thực hiện truy vấn đến cơ sở dữ liệu.Hàm nhận một truy vấn SQL(câu lệnh SELECT) và một mảng tham số nếu cần.



        ///  Hàm ExecuteNonQuery(string query, object[] parameter = null):
        ///  Hàm này được sử dụng để thực hiện các truy vấn không trả về dữ liệu (câu lệnh INSERT, UPDATE hoặc DELETE).


        ///  Hàm ExecuteScalar(string query, object[] parameter = null):
        ///  Hàm này được sử dụng khi bạn muốn lấy một giá trị duy nhất từ cơ sở dữ liệu, ví dụ như lấy tổng hoặc số lượng dựa trên truy vấn.




        string strCnn = "Data source= LAPTOP-021AUJCB\\SQLEXPRESS02 ;database= CSharpSellphone ;User ID=sa;Password=123;";
        private static DataProvider instance;

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(strCnn);
        }
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }

        protected DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(strCnn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(strCnn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(strCnn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;
        }
    }
}
