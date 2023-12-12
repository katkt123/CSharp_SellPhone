namespace SellPhones.GUI.UserControls
{
    partial class CTPhieuNhapKho
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
            groupBox2 = new GroupBox();
            display_MaDN = new Label();
            groupBox1 = new GroupBox();
            display_Time = new Label();
            grid_CTPNK = new DataGridView();
            label_CTKM = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_CTPNK).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(display_MaDN);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(254, 24);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(126, 45);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mã phiếu nhập";
            // 
            // display_MaDN
            // 
            display_MaDN.AutoSize = true;
            display_MaDN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            display_MaDN.Location = new Point(4, 17);
            display_MaDN.Margin = new Padding(2, 0, 2, 0);
            display_MaDN.Name = "display_MaDN";
            display_MaDN.Size = new Size(18, 20);
            display_MaDN.TabIndex = 5;
            display_MaDN.Text = "2";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(display_Time);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(30, 24);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(219, 45);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngày xuất";
            // 
            // display_Time
            // 
            display_Time.AutoSize = true;
            display_Time.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            display_Time.Location = new Point(4, 21);
            display_Time.Margin = new Padding(2, 0, 2, 0);
            display_Time.Name = "display_Time";
            display_Time.Size = new Size(18, 20);
            display_Time.TabIndex = 6;
            display_Time.Text = "1";
            // 
            // grid_CTPNK
            // 
            grid_CTPNK.AllowUserToAddRows = false;
            grid_CTPNK.AllowUserToDeleteRows = false;
            grid_CTPNK.AllowUserToResizeColumns = false;
            grid_CTPNK.AllowUserToResizeRows = false;
            grid_CTPNK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_CTPNK.BackgroundColor = Color.Azure;
            grid_CTPNK.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grid_CTPNK.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid_CTPNK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_CTPNK.Enabled = false;
            grid_CTPNK.Location = new Point(29, 142);
            grid_CTPNK.Margin = new Padding(2);
            grid_CTPNK.Name = "grid_CTPNK";
            grid_CTPNK.ReadOnly = true;
            grid_CTPNK.RowHeadersVisible = false;
            grid_CTPNK.RowHeadersWidth = 51;
            grid_CTPNK.RowTemplate.Height = 24;
            grid_CTPNK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_CTPNK.ShowCellErrors = false;
            grid_CTPNK.ShowCellToolTips = false;
            grid_CTPNK.ShowEditingIcon = false;
            grid_CTPNK.ShowRowErrors = false;
            grid_CTPNK.Size = new Size(396, 424);
            grid_CTPNK.TabIndex = 18;
            // 
            // label_CTKM
            // 
            label_CTKM.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_CTKM.Location = new Point(24, 91);
            label_CTKM.Margin = new Padding(2, 0, 2, 0);
            label_CTKM.Name = "label_CTKM";
            label_CTKM.Size = new Size(401, 40);
            label_CTKM.TabIndex = 17;
            label_CTKM.Text = "CHI TIẾT PHIẾU NHẬP KHO";
            label_CTKM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CTPhieuNhapKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(463, 606);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grid_CTPNK);
            Controls.Add(label_CTKM);
            Name = "CTPhieuNhapKho";
            Text = "CTPhieuNhapKho";
            Load += CTPhieuNhapKho_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_CTPNK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label display_MaDN;
        private GroupBox groupBox1;
        private Label display_Time;
        private DataGridView grid_CTPNK;
        private Label label_CTKM;
    }
}