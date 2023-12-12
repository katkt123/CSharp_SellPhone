namespace SellPhones.GUI.UserControls
{
    partial class XemHoaDonKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Grid_HoaDonKH = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid_HoaDonKH).BeginInit();
            SuspendLayout();
            // 
            // Grid_HoaDonKH
            // 
            Grid_HoaDonKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_HoaDonKH.Dock = DockStyle.Bottom;
            Grid_HoaDonKH.Location = new Point(0, 88);
            Grid_HoaDonKH.Name = "Grid_HoaDonKH";
            Grid_HoaDonKH.RowHeadersWidth = 51;
            Grid_HoaDonKH.RowTemplate.Height = 29;
            Grid_HoaDonKH.Size = new Size(822, 326);
            Grid_HoaDonKH.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 19);
            label1.Name = "label1";
            label1.Size = new Size(366, 42);
            label1.TabIndex = 1;
            label1.Text = "Danh Sách Đơn Hàng";
            // 
            // XemHoaDonKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(822, 414);
            Controls.Add(label1);
            Controls.Add(Grid_HoaDonKH);
            Name = "XemHoaDonKhachHang";
            Text = "XemHoaDonKhachHang";
            ((System.ComponentModel.ISupportInitialize)Grid_HoaDonKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid_HoaDonKH;
        private Label label1;
    }
}