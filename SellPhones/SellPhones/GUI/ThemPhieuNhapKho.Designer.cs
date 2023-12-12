namespace SellPhones.GUI
{
    partial class ThemPhieuNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhieuNhapKho));
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            cbo_Kho = new ComboBox();
            button_ThanhToan = new Button();
            groupBox5 = new GroupBox();
            label_TT = new Label();
            grid_SanPham = new DataGridView();
            panel1 = new Panel();
            grid_PhieuNhapKho = new DataGridView();
            label2 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            ud_SoLuong = new NumericUpDown();
            button_XoaDon = new Button();
            button_ThemDon = new Button();
            groupBox1 = new GroupBox();
            cbo_ncc = new ComboBox();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_SanPham).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_PhieuNhapKho).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ud_SoLuong).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGoldenrod;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(button_ThanhToan);
            panel3.Controls.Add(groupBox5);
            panel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(591, 829);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(596, 129);
            panel3.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbo_Kho);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(5, 21);
            groupBox3.Margin = new Padding(5, 4, 5, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 4, 5, 4);
            groupBox3.Size = new Size(141, 91);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kho";
            // 
            // cbo_Kho
            // 
            cbo_Kho.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_Kho.FormattingEnabled = true;
            cbo_Kho.Location = new Point(8, 32);
            cbo_Kho.Margin = new Padding(5, 4, 5, 4);
            cbo_Kho.Name = "cbo_Kho";
            cbo_Kho.Size = new Size(117, 26);
            cbo_Kho.TabIndex = 0;
            // 
            // button_ThanhToan
            // 
            button_ThanhToan.BackColor = Color.Navy;
            button_ThanhToan.Cursor = Cursors.Hand;
            button_ThanhToan.FlatStyle = FlatStyle.Popup;
            button_ThanhToan.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_ThanhToan.ForeColor = Color.White;
            button_ThanhToan.Image = (Image)resources.GetObject("button_ThanhToan.Image");
            button_ThanhToan.Location = new Point(422, 21);
            button_ThanhToan.Margin = new Padding(5, 4, 5, 4);
            button_ThanhToan.Name = "button_ThanhToan";
            button_ThanhToan.Size = new Size(160, 91);
            button_ThanhToan.TabIndex = 3;
            button_ThanhToan.Text = "Thanh toán";
            button_ThanhToan.TextAlign = ContentAlignment.MiddleRight;
            button_ThanhToan.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_ThanhToan.UseVisualStyleBackColor = false;
            button_ThanhToan.Click += button_ThanhToan_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(label_TT);
            groupBox5.Location = new Point(153, 21);
            groupBox5.Margin = new Padding(5, 4, 5, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(5, 4, 5, 4);
            groupBox5.Size = new Size(259, 91);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tổng tiền cần thanh toán";
            // 
            // label_TT
            // 
            label_TT.AutoSize = true;
            label_TT.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_TT.Location = new Point(9, 33);
            label_TT.Margin = new Padding(5, 0, 5, 0);
            label_TT.Name = "label_TT";
            label_TT.Size = new Size(30, 32);
            label_TT.TabIndex = 0;
            label_TT.Text = "0";
            // 
            // grid_SanPham
            // 
            grid_SanPham.AllowUserToAddRows = false;
            grid_SanPham.AllowUserToDeleteRows = false;
            grid_SanPham.AllowUserToResizeColumns = false;
            grid_SanPham.AllowUserToResizeRows = false;
            grid_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_SanPham.BackgroundColor = Color.Azure;
            grid_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_SanPham.Location = new Point(593, 213);
            grid_SanPham.Margin = new Padding(5, 4, 5, 4);
            grid_SanPham.MultiSelect = false;
            grid_SanPham.Name = "grid_SanPham";
            grid_SanPham.ReadOnly = true;
            grid_SanPham.RowHeadersVisible = false;
            grid_SanPham.RowHeadersWidth = 51;
            grid_SanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_SanPham.Size = new Size(598, 603);
            grid_SanPham.TabIndex = 10;
            grid_SanPham.CellContentClick += grid_SanPham_CellContentClick;
            grid_SanPham.CellValidating += grid_SanPham_CellValidating;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(grid_PhieuNhapKho);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(15, 16);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 939);
            panel1.TabIndex = 8;
            // 
            // grid_PhieuNhapKho
            // 
            grid_PhieuNhapKho.AllowUserToAddRows = false;
            grid_PhieuNhapKho.AllowUserToDeleteRows = false;
            grid_PhieuNhapKho.AllowUserToResizeColumns = false;
            grid_PhieuNhapKho.AllowUserToResizeRows = false;
            grid_PhieuNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_PhieuNhapKho.BackgroundColor = Color.Azure;
            grid_PhieuNhapKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_PhieuNhapKho.Location = new Point(5, 63);
            grid_PhieuNhapKho.Margin = new Padding(5, 4, 5, 4);
            grid_PhieuNhapKho.MultiSelect = false;
            grid_PhieuNhapKho.Name = "grid_PhieuNhapKho";
            grid_PhieuNhapKho.RowHeadersVisible = false;
            grid_PhieuNhapKho.RowHeadersWidth = 51;
            grid_PhieuNhapKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_PhieuNhapKho.Size = new Size(559, 871);
            grid_PhieuNhapKho.TabIndex = 2;
            grid_PhieuNhapKho.CellValueChanged += grid_PhieuNhapKho_CellValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(135, 4);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(293, 42);
            label2.TabIndex = 1;
            label2.Text = "Phiếu nhập kho";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(button_XoaDon);
            panel2.Controls.Add(button_ThemDon);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(591, 16);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 189);
            panel2.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ud_SoLuong);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(351, 16);
            groupBox2.Margin = new Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 4, 5, 4);
            groupBox2.Size = new Size(106, 80);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Số lượng";
            // 
            // ud_SoLuong
            // 
            ud_SoLuong.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ud_SoLuong.Location = new Point(10, 33);
            ud_SoLuong.Margin = new Padding(5, 4, 5, 4);
            ud_SoLuong.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            ud_SoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ud_SoLuong.Name = "ud_SoLuong";
            ud_SoLuong.Size = new Size(90, 24);
            ud_SoLuong.TabIndex = 0;
            ud_SoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button_XoaDon
            // 
            button_XoaDon.BackColor = Color.Navy;
            button_XoaDon.Cursor = Cursors.Hand;
            button_XoaDon.FlatStyle = FlatStyle.Popup;
            button_XoaDon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_XoaDon.ForeColor = Color.White;
            button_XoaDon.Image = (Image)resources.GetObject("button_XoaDon.Image");
            button_XoaDon.Location = new Point(322, 104);
            button_XoaDon.Margin = new Padding(5, 4, 5, 4);
            button_XoaDon.Name = "button_XoaDon";
            button_XoaDon.Size = new Size(151, 72);
            button_XoaDon.TabIndex = 2;
            button_XoaDon.Text = " Xóa";
            button_XoaDon.TextAlign = ContentAlignment.MiddleRight;
            button_XoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_XoaDon.UseVisualStyleBackColor = false;
            button_XoaDon.Click += button_XoaDon_Click;
            // 
            // button_ThemDon
            // 
            button_ThemDon.BackColor = Color.Navy;
            button_ThemDon.Cursor = Cursors.Hand;
            button_ThemDon.FlatStyle = FlatStyle.Popup;
            button_ThemDon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_ThemDon.ForeColor = Color.White;
            button_ThemDon.Image = (Image)resources.GetObject("button_ThemDon.Image");
            button_ThemDon.Location = new Point(93, 104);
            button_ThemDon.Margin = new Padding(5, 4, 5, 4);
            button_ThemDon.Name = "button_ThemDon";
            button_ThemDon.Size = new Size(151, 72);
            button_ThemDon.TabIndex = 1;
            button_ThemDon.Text = " Thêm";
            button_ThemDon.TextAlign = ContentAlignment.MiddleRight;
            button_ThemDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_ThemDon.UseVisualStyleBackColor = false;
            button_ThemDon.Click += button_ThemDon_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbo_ncc);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(47, 15);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(261, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhà cung cấp";
            // 
            // cbo_ncc
            // 
            cbo_ncc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_ncc.FormattingEnabled = true;
            cbo_ncc.Location = new Point(8, 32);
            cbo_ncc.Margin = new Padding(5, 4, 5, 4);
            cbo_ncc.Name = "cbo_ncc";
            cbo_ncc.Size = new Size(231, 26);
            cbo_ncc.TabIndex = 0;
            cbo_ncc.SelectedIndexChanged += cbo_ncc_SelectedIndexChanged;
            // 
            // ThemPhieuNhapKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 971);
            Controls.Add(panel3);
            Controls.Add(grid_SanPham);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ThemPhieuNhapKho";
            Text = "ThemPhieuNhapKho";
            Load += ThemPhieuNhapKho_Load;
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_SanPham).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_PhieuNhapKho).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ud_SoLuong).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button_ThanhToan;
        private GroupBox groupBox5;
        private Label label_TT;
        private DataGridView grid_SanPham;
        private Panel panel1;
        private DataGridView grid_PhieuNhapKho;
        private Label label2;
        private Panel panel2;
        private GroupBox groupBox2;
        private NumericUpDown ud_SoLuong;
        private Button button_XoaDon;
        private Button button_ThemDon;
        private GroupBox groupBox1;
        private ComboBox cbo_ncc;
        private GroupBox groupBox3;
        private ComboBox cbo_Kho;
    }
}