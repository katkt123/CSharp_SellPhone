using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Sellphone.DAO;
namespace SellPhones.DAO
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public int TongGiaSauGiam { get; set; }
    }
    public class DashboardDAO : DataProvider
    {
        private static DashboardDAO instance;


        public static DashboardDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DashboardDAO();
                return DashboardDAO.instance;
            }
            private set { DashboardDAO.instance = value; }
        }
        
        //string strCnn = "Data source= LAPTOP-1BR2IU57\\SQLEXPRESS ;database= SellPhone2 ;User ID=sa;Password=1234;";
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumSuppliers { get; private set; }
        public int NumProducts { get; private set; }
        public int NumOnl { get; private set; }
        public List<KeyValuePair<String, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<String, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        //Constructor
        public DashboardDAO() { }
        //Private methods
        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get Total Number of Customers
                    command.CommandText = "select count(MaKH) from KhachHang";
                    NumCustomers = (int)command.ExecuteScalar();

                    //Get Total Number of Suppliers
                    command.CommandText = "select count(MaNCC) from NhaCungCap";
                    NumSuppliers = (int)command.ExecuteScalar();

                    //Get Total Number of Products
                    command.CommandText = "select count(MaSP) from SanPham";
                    NumProducts = (int)command.ExecuteScalar();

                    //Get Total Number of Orders
                    command.CommandText = @"select count(MaHoaDon) from HoaDon " +
                                            "where NgayLap between @fromDate and @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumOrders = (int)command.ExecuteScalar();

                    //Get Cus Onl
                    command.CommandText = "select count(TaiKhoan.MaTK) from TaiKhoan, Quyen " +
                                            "where TrangThai = 1 and PhanQuyen = 'Khách Hàng' ";
                    NumOnl = (int)command.ExecuteScalar();

                }
            }
        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;


            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    double Total_GiaNhap = 0;
                    command.Connection = connection;
                    command.CommandText = @"select NgayXuat, sum(TongGiaSauGiam) as GiaSauGiam,sum(TongGiaGoc) as GiaGoc from HoaDon
                                            where NgayXuat between @fromDate and @toDate
                                            group by NgayXuat";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTbale = new List<KeyValuePair<DateTime, int>>();
                    while (reader.Read())
                    {
                        resultTbale.Add(
                           new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1]));
                        
                        TotalRevenue += (int)reader[1];
                        Total_GiaNhap += (int)reader[2];

                    }
                    Total_GiaNhap = Total_GiaNhap/1.1;
                    TotalProfit = TotalRevenue - Convert.ToInt32(Total_GiaNhap) ;//20%
                    reader.Close();

                    //Group by Days
                    if (numberDays <= 30)
                    {
                        foreach (var item in resultTbale)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TongGiaSauGiam = item.Value
                            });
                        }
                    }

                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTbale
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                            orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TongGiaSauGiam = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Month
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTbale
                                            group orderList by orderList.Key.ToString("MMM YYYY")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TongGiaSauGiam = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Year
                    else
                    {
                        GrossRevenueList = (from orderList in resultTbale
                                            group orderList by orderList.Key.ToString("YYYY")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TongGiaSauGiam = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 Products
                    command.CommandText = @"select top 5 S.TenSP, sum(CTHoaDon.SoLuong) as C
                                            from CTHoaDon
                                            inner join SanPham S on S.MaSP = CTHoaDon.MaSP
                                            inner join [HoaDon] H on H.MaHoaDon = CTHoaDon.MaHoaDon
                                            where NgayXuat between @fromDate and @toDate
                                            group by S.TenSP
                                            order by C desc ";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get Understock
                    command.CommandText = @"select TenSP, Soluong
                                            from SanPham
                                            Where Soluong <= 10";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderstockList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }

        //public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
