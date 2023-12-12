namespace SellPhones.GUI.UserControls
{
    partial class KhachHangUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangUC));
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            label2 = new Label();
            textBox_MaKH = new TextBox();
            textBox_Address = new TextBox();
            label4 = new Label();
            textBox_Name = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBox_Phone = new TextBox();
            button1 = new Button();
            button_Refresh = new Button();
            button_Sua = new Button();
            panel2 = new Panel();
            Grid_KhachHang = new DataGridView();
            textBox_Search = new TextBox();
            button_Search = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_KhachHang).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 180);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox_MaKH);
            groupBox3.Controls.Add(textBox_Address);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox_Name);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox_Phone);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(974, 174);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin chung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(552, 35);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 2;
            label2.Text = "Địa Chỉ";
            label2.Click += label2_Click;
            // 
            // textBox_MaKH
            // 
            textBox_MaKH.Enabled = false;
            textBox_MaKH.Location = new Point(21, 60);
            textBox_MaKH.Name = "textBox_MaKH";
            textBox_MaKH.Size = new Size(288, 27);
            textBox_MaKH.TabIndex = 7;
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(552, 60);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(288, 27);
            textBox_Address.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 35);
            label4.Name = "label4";
            label4.Size = new Size(137, 22);
            label4.TabIndex = 6;
            label4.Text = "Mã Khách Hàng";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(21, 128);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(288, 27);
            textBox_Name.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(552, 103);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 4;
            label3.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 103);
            label1.Name = "label1";
            label1.Size = new Size(69, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên";
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(552, 128);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(290, 27);
            textBox_Phone.TabIndex = 5;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(330, 22);
            button1.Name = "button1";
            button1.Size = new Size(66, 52);
            button1.TabIndex = 8;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_Refresh
            // 
            button_Refresh.Image = (Image)resources.GetObject("button_Refresh.Image");
            button_Refresh.Location = new Point(74, 22);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(66, 52);
            button_Refresh.TabIndex = 6;
            button_Refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // button_Sua
            // 
            button_Sua.Image = (Image)resources.GetObject("button_Sua.Image");
            button_Sua.Location = new Point(202, 22);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(66, 52);
            button_Sua.TabIndex = 3;
            button_Sua.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Sua.UseVisualStyleBackColor = true;
            button_Sua.Click += button_Sua_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Grid_KhachHang);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 218);
            panel2.TabIndex = 1;
            // 
            // Grid_KhachHang
            // 
            Grid_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_KhachHang.Dock = DockStyle.Fill;
            Grid_KhachHang.Location = new Point(0, 0);
            Grid_KhachHang.Name = "Grid_KhachHang";
            Grid_KhachHang.RowHeadersWidth = 51;
            Grid_KhachHang.RowTemplate.Height = 29;
            Grid_KhachHang.Size = new Size(980, 218);
            Grid_KhachHang.TabIndex = 0;
            Grid_KhachHang.CellClick += Grid_KhachHang_CellClick;
            Grid_KhachHang.CellContentClick += Grid_KhachHang_CellContentClick;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(6, 34);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(258, 27);
            textBox_Search.TabIndex = 6;
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            // 
            // button_Search
            // 
            button_Search.Image = (Image)resources.GetObject("button_Search.Image");
            button_Search.Location = new Point(270, 22);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(57, 48);
            button_Search.TabIndex = 7;
            button_Search.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox_Search);
            groupBox1.Controls.Add(button_Search);
            groupBox1.Location = new Point(3, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 80);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(224, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 27);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button_Refresh);
            groupBox2.Controls.Add(button_Sua);
            groupBox2.Location = new Point(508, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(469, 80);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // KhachHangUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "KhachHangUC";
            Size = new Size(980, 500);
            Load += KhachHangUC_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_KhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox_Name;
        private Label label1;
        private TextBox textBox_Address;
        private Label label2;
        private Label label3;
        private Button button_Refresh;
        private TextBox textBox_Phone;
        private Button button_Sua;
        private TextBox textBox_Search;
        private Button button_Search;
        private DataGridView Grid_KhachHang;
        private TextBox textBox_MaKH;
        private Label label4;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
    }
}
