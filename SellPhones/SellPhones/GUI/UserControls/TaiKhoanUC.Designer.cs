namespace SellPhones.GUI.UserControls
{
    partial class TaiKhoanUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoanUC));
            tabControl1 = new TabControl();
            tabPage_TK = new TabPage();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox_TK = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox_MK = new TextBox();
            groupBox2 = new GroupBox();
            button_Refresh = new Button();
            button_Sua = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox_Search = new TextBox();
            button_Search = new Button();
            panel1 = new Panel();
            Grid_TaiKhoan = new DataGridView();
            tabPage_Quyen = new TabPage();
            groupBox5 = new GroupBox();
            comboBox_Quyen = new ComboBox();
            button_CapQuyen = new Button();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            Grid_Quyen = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage_TK.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_TaiKhoan).BeginInit();
            tabPage_Quyen.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Quyen).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_TK);
            tabControl1.Controls.Add(tabPage_Quyen);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(980, 500);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_TK
            // 
            tabPage_TK.Controls.Add(groupBox3);
            tabPage_TK.Controls.Add(groupBox2);
            tabPage_TK.Controls.Add(groupBox1);
            tabPage_TK.Controls.Add(panel1);
            tabPage_TK.Location = new Point(4, 29);
            tabPage_TK.Name = "tabPage_TK";
            tabPage_TK.Padding = new Padding(3);
            tabPage_TK.Size = new Size(972, 467);
            tabPage_TK.TabIndex = 0;
            tabPage_TK.Text = "Tài Khoản";
            tabPage_TK.UseVisualStyleBackColor = true;
            tabPage_TK.Click += tabPage_TK_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBox_TK);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox_MK);
            groupBox3.Location = new Point(0, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(966, 163);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin chung";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(381, 52);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(381, 23);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(381, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 23);
            label1.Name = "label1";
            label1.Size = new Size(128, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên Tài Khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(381, 102);
            label4.Name = "label4";
            label4.Size = new Size(60, 22);
            label4.TabIndex = 14;
            label4.Text = "Quyền";
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(18, 48);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(250, 27);
            textBox_TK.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(670, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 102);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(670, 65);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 11;
            label3.Text = "Mã Tài Khoản";
            // 
            // textBox_MK
            // 
            textBox_MK.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MK.Location = new Point(18, 127);
            textBox_MK.Name = "textBox_MK";
            textBox_MK.Size = new Size(250, 23);
            textBox_MK.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_Refresh);
            groupBox2.Controls.Add(button_Sua);
            groupBox2.Location = new Point(502, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 89);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // button_Refresh
            // 
            button_Refresh.Image = (Image)resources.GetObject("button_Refresh.Image");
            button_Refresh.Location = new Point(97, 26);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(66, 52);
            button_Refresh.TabIndex = 15;
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // button_Sua
            // 
            button_Sua.Image = (Image)resources.GetObject("button_Sua.Image");
            button_Sua.Location = new Point(274, 26);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(66, 52);
            button_Sua.TabIndex = 10;
            button_Sua.UseVisualStyleBackColor = true;
            button_Sua.Click += button_Sua_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox_Search);
            groupBox1.Controls.Add(button_Search);
            groupBox1.Location = new Point(3, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 91);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 35);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(15, 34);
            textBox_Search.Multiline = true;
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(250, 35);
            textBox_Search.TabIndex = 13;
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            // 
            // button_Search
            // 
            button_Search.Image = (Image)resources.GetObject("button_Search.Image");
            button_Search.Location = new Point(271, 25);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(54, 55);
            button_Search.TabIndex = 14;
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Grid_TaiKhoan);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 197);
            panel1.TabIndex = 1;
            // 
            // Grid_TaiKhoan
            // 
            Grid_TaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_TaiKhoan.Dock = DockStyle.Fill;
            Grid_TaiKhoan.Location = new Point(0, 0);
            Grid_TaiKhoan.Name = "Grid_TaiKhoan";
            Grid_TaiKhoan.RowHeadersWidth = 51;
            Grid_TaiKhoan.RowTemplate.Height = 29;
            Grid_TaiKhoan.Size = new Size(966, 197);
            Grid_TaiKhoan.TabIndex = 0;
            Grid_TaiKhoan.CellClick += Grid_TaiKhoan_CellClick;
            Grid_TaiKhoan.CellContentClick += Grid_TaiKhoan_CellContentClick;
            Grid_TaiKhoan.SelectionChanged += Grid_TaiKhoan_SelectionChanged;
            // 
            // tabPage_Quyen
            // 
            tabPage_Quyen.Controls.Add(groupBox5);
            tabPage_Quyen.Controls.Add(groupBox4);
            tabPage_Quyen.Controls.Add(panel3);
            tabPage_Quyen.Location = new Point(4, 29);
            tabPage_Quyen.Name = "tabPage_Quyen";
            tabPage_Quyen.Padding = new Padding(3);
            tabPage_Quyen.Size = new Size(972, 467);
            tabPage_Quyen.TabIndex = 1;
            tabPage_Quyen.Text = "Quyền";
            tabPage_Quyen.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox_Quyen);
            groupBox5.Controls.Add(button_CapQuyen);
            groupBox5.Location = new Point(483, 7);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(489, 90);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Cấp Quyền";
            // 
            // comboBox_Quyen
            // 
            comboBox_Quyen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Quyen.FormattingEnabled = true;
            comboBox_Quyen.Items.AddRange(new object[] { "Quản Lý", "Nhân Viên", "Khách Hàng" });
            comboBox_Quyen.Location = new Point(47, 31);
            comboBox_Quyen.Name = "comboBox_Quyen";
            comboBox_Quyen.Size = new Size(211, 28);
            comboBox_Quyen.TabIndex = 1;
            // 
            // button_CapQuyen
            // 
            button_CapQuyen.Image = (Image)resources.GetObject("button_CapQuyen.Image");
            button_CapQuyen.Location = new Point(277, 17);
            button_CapQuyen.Name = "button_CapQuyen";
            button_CapQuyen.Size = new Size(64, 54);
            button_CapQuyen.TabIndex = 2;
            button_CapQuyen.UseVisualStyleBackColor = true;
            button_CapQuyen.Click += button_CapQuyen_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Location = new Point(6, 7);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(264, 90);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lọc";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả", "Khóa", "Không khóa" });
            comboBox1.Location = new Point(19, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(Grid_Quyen);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(966, 361);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // Grid_Quyen
            // 
            Grid_Quyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Quyen.Dock = DockStyle.Fill;
            Grid_Quyen.Location = new Point(0, 0);
            Grid_Quyen.Name = "Grid_Quyen";
            Grid_Quyen.RowHeadersWidth = 51;
            Grid_Quyen.RowTemplate.Height = 29;
            Grid_Quyen.Size = new Size(966, 361);
            Grid_Quyen.TabIndex = 0;
            Grid_Quyen.SelectionChanged += Grid_Quyen_SelectionChanged;
            // 
            // TaiKhoanUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "TaiKhoanUC";
            Size = new Size(980, 500);
            tabControl1.ResumeLayout(false);
            tabPage_TK.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_TaiKhoan).EndInit();
            tabPage_Quyen.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Quyen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage_TK;
        private TabPage tabPage_Quyen;
        private Panel panel1;
        private DataGridView Grid_TaiKhoan;
        private Label label1;
        private Button button_Them;
        private TextBox textBox_MK;
        private Label label2;
        private TextBox textBox_TK;
        private Button button_Sua;
        private Button button_Search;
        private TextBox textBox_Search;
        private Button button_Refresh;
        private Panel panel3;
        private DataGridView Grid_Quyen;
        private Button button_CapQuyen;
        private ComboBox comboBox_Quyen;
        private TextBox textBox1;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label4;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label5;
    }
}
