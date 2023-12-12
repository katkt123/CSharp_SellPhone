using Guna.Charts.Interfaces;
using Guna.Charts.WinForms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SellPhones.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhones.GUI.UserControls
{
    public partial class ThongKe1UC : UserControl
    {
        //Fields
        private DashboardDAO DAO;

        //Constructor
        public ThongKe1UC()
        {
            InitializeComponent();
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            DAO = new DashboardDAO();
            LoadData();
        }

        //private methods
        private void LoadData()
        {
            var refreshData = DAO.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData = true)
            {

                lblNumOrders.Text = DAO.NumOrders.ToString("N0");
                lblTotalRevenue.Text = DAO.TotalRevenue.ToString("N0") + "USD";
                lblTotalProfit.Text = DAO.TotalProfit.ToString("N0") + "USD";


                lblNumCustomers.Text = DAO.NumCustomers.ToString();
                lblNumSupplier.Text = DAO.NumSuppliers.ToString();
                lblNumProducts.Text = DAO.NumProducts.ToString();
                lblOnl.Text = DAO.NumOnl.ToString();

                Bar(gunaChartGrossRevenue);
                //PieChart(gunaChartTop5Products);
                DoughnutChart(gunaChartTop5Products);





                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOKCustomDate.Visible = false;
        }
        private void ThongKe1UC_Load(object sender, EventArgs e)
        {

        }

        //even methods
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOKCustomDate.Visible = true;
        }

        private void btnOKCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //
        public void Bar(GunaChart chart)
        {
            // Xóa dữ liệu hiện tại của biểu đồ
            chart.Datasets.Clear();

            //Chart configuration 
            chart.Title.Text = "Doanh Thu";
            chart.YAxes.Display = false;

            //Create a new dataset 
            var dataset = new GunaBarDataset();

            dataset.Label = "Tổng tiền";
            // Thêm dữ liệu mới từ GrossRevenueList
            foreach (var item in DAO.GrossRevenueList)
            {
                double convertedValue = (double)item.TongGiaSauGiam;
                // Thêm mỗi điểm dữ liệu vào gunaBarDataSet1
                dataset.DataPoints.Add(item.Date, convertedValue);
            }
            dataset.FillColors.Add(Color.FromArgb(255, 0, 120, 215));

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }

        public void DoughnutChart(GunaChart chart)
        {
            //Xóa dữ liệu hiện tại của biểu đồ
            chart.Datasets.Clear();

            //Chart configuration
            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chart.Legend.Display = false;  // Đảm bảo rằng hình chú thích được hiển thị
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;
            chart.Title.Text = "Top 5 Sản phẩm";
            //Tạo một doughnut dataset
            var dataset = new Guna.Charts.WinForms.GunaDoughnutDataset();

            var arrayData = DAO.TopProductsList.ToArray();
            string[] productNames = arrayData.Select(item => item.Key).ToArray();
            int[] valuesArray = arrayData.Select(item => item.Value).ToArray();
            //Thêm dữ liệu từ mảng productNames
            for (int i = 0; i < productNames.Length; i++)
            {
                dataset.DataPoints.Add(productNames[i], valuesArray[i]);
                
            }

            chart.Datasets.Add(dataset);
            chart.Update();
        }

        private void gunaChartTop5Products_Load(object sender, EventArgs e)
        {
        }

        private void btnTop5Products_Click(object sender, EventArgs e)
        {
            var arrayData = DAO.TopProductsList.ToArray();
            string message = "Top Sản Phẩm:\n";

            foreach (var item in arrayData)
            {
                message += $"{item.Key}: {item.Value}\n";
            }

            MessageBox.Show(message, "Top Products");

        }

     
    }
}
