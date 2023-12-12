namespace SellPhones.GUI
{
    partial class ThemSPNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemSPNCC));
            grid_SanPham = new DataGridView();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button_XoaDon = new Button();
            button_ThemDon = new Button();
            groupBox1 = new GroupBox();
            cbo_ncc = new ComboBox();
            grid_SPNCC = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grid_SanPham).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_SPNCC).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            grid_SanPham.Location = new Point(547, 217);
            grid_SanPham.Margin = new Padding(5, 4, 5, 4);
            grid_SanPham.MultiSelect = false;
            grid_SanPham.Name = "grid_SanPham";
            grid_SanPham.ReadOnly = true;
            grid_SanPham.RowHeadersVisible = false;
            grid_SanPham.RowHeadersWidth = 51;
            grid_SanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_SanPham.Size = new Size(519, 608);
            grid_SanPham.TabIndex = 9;
            grid_SanPham.CellClick += grid_SanPham_CellClick;
            grid_SanPham.CellContentClick += grid_SanPham_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button_XoaDon);
            panel2.Controls.Add(button_ThemDon);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(547, 16);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 193);
            panel2.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(242, 11);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(166, 72);
            button3.TabIndex = 6;
            button3.Text = "Reload";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(242, 101);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(166, 72);
            button2.TabIndex = 5;
            button2.Text = "Tạo Sản Phẩm";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(418, 11);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 162);
            button1.TabIndex = 3;
            button1.Text = "Lưu";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button_XoaDon
            // 
            button_XoaDon.BackColor = Color.Navy;
            button_XoaDon.Cursor = Cursors.Hand;
            button_XoaDon.FlatStyle = FlatStyle.Popup;
            button_XoaDon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_XoaDon.ForeColor = Color.White;
            button_XoaDon.Image = (Image)resources.GetObject("button_XoaDon.Image");
            button_XoaDon.Location = new Point(126, 101);
            button_XoaDon.Margin = new Padding(5, 4, 5, 4);
            button_XoaDon.Name = "button_XoaDon";
            button_XoaDon.Size = new Size(106, 72);
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
            button_ThemDon.Location = new Point(5, 101);
            button_ThemDon.Margin = new Padding(5, 4, 5, 4);
            button_ThemDon.Name = "button_ThemDon";
            button_ThemDon.Size = new Size(111, 72);
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
            groupBox1.Location = new Point(24, 9);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(208, 84);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhà cung cấp";
            // 
            // cbo_ncc
            // 
            cbo_ncc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo_ncc.FormattingEnabled = true;
            cbo_ncc.Location = new Point(8, 28);
            cbo_ncc.Margin = new Padding(5, 4, 5, 4);
            cbo_ncc.Name = "cbo_ncc";
            cbo_ncc.Size = new Size(190, 26);
            cbo_ncc.TabIndex = 0;
            cbo_ncc.SelectedIndexChanged += cbo_ncc_SelectedIndexChanged;
            // 
            // grid_SPNCC
            // 
            grid_SPNCC.AllowUserToAddRows = false;
            grid_SPNCC.AllowUserToDeleteRows = false;
            grid_SPNCC.AllowUserToResizeColumns = false;
            grid_SPNCC.AllowUserToResizeRows = false;
            grid_SPNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_SPNCC.BackgroundColor = Color.Azure;
            grid_SPNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_SPNCC.Location = new Point(5, 75);
            grid_SPNCC.Margin = new Padding(5, 4, 5, 4);
            grid_SPNCC.MultiSelect = false;
            grid_SPNCC.Name = "grid_SPNCC";
            grid_SPNCC.RowHeadersVisible = false;
            grid_SPNCC.RowHeadersWidth = 51;
            grid_SPNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_SPNCC.Size = new Size(491, 728);
            grid_SPNCC.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(grid_SPNCC);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(15, 16);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 809);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(135, 4);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(278, 42);
            label2.TabIndex = 1;
            label2.Text = "Nhà Cung Cấp";
            // 
            // ThemSPNCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 848);
            Controls.Add(grid_SanPham);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ThemSPNCC";
            Text = "ThemSPNCC";
            Load += ThemSPNCC_Load;
            ((System.ComponentModel.ISupportInitialize)grid_SanPham).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_SPNCC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid_SanPham;
        private Panel panel2;
        private Button button_XoaDon;
        private Button button_ThemDon;
        private GroupBox groupBox1;
        private ComboBox cbo_ncc;
        private DataGridView grid_SPNCC;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}