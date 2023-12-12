namespace SellPhones.GUI.UserControls
{
    partial class SanPhamBiXoa
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
            panel1 = new Panel();
            Grid_SanPhamBiXoa = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_SanPhamBiXoa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Grid_SanPhamBiXoa);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 339);
            panel1.TabIndex = 0;
            // 
            // Grid_SanPhamBiXoa
            // 
            Grid_SanPhamBiXoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_SanPhamBiXoa.Dock = DockStyle.Fill;
            Grid_SanPhamBiXoa.Location = new Point(0, 0);
            Grid_SanPhamBiXoa.Name = "Grid_SanPhamBiXoa";
            Grid_SanPhamBiXoa.RowHeadersWidth = 51;
            Grid_SanPhamBiXoa.RowTemplate.Height = 29;
            Grid_SanPhamBiXoa.Size = new Size(856, 339);
            Grid_SanPhamBiXoa.TabIndex = 0;
            Grid_SanPhamBiXoa.CellContentClick += Grid_SanPhamBiXoa_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(193, 25);
            label1.Name = "label1";
            label1.Size = new Size(480, 42);
            label1.TabIndex = 1;
            label1.Text = "Danh Sách Sản Phẩm Bị Xóa";
            // 
            // SanPhamBiXoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(856, 481);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "SanPhamBiXoa";
            Text = "SanPhamBiXoa";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_SanPhamBiXoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView Grid_SanPhamBiXoa;
        private Label label1;
    }
}