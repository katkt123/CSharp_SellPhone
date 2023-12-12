namespace SellPhones.GUI.UserControls
{
    partial class KhuyenMaiUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMaiUC));
            panel1 = new Panel();
            Grid_KhuyenMai = new DataGridView();
            textBox_search = new TextBox();
            button_timkiem = new Button();
            button_tao = new Button();
            button_xoa = new Button();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_KhuyenMai).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Grid_KhuyenMai);
            panel1.Location = new Point(24, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 320);
            panel1.TabIndex = 0;
            // 
            // Grid_KhuyenMai
            // 
            Grid_KhuyenMai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_KhuyenMai.Dock = DockStyle.Fill;
            Grid_KhuyenMai.Location = new Point(0, 0);
            Grid_KhuyenMai.Name = "Grid_KhuyenMai";
            Grid_KhuyenMai.RowHeadersWidth = 51;
            Grid_KhuyenMai.RowTemplate.Height = 29;
            Grid_KhuyenMai.Size = new Size(929, 318);
            Grid_KhuyenMai.TabIndex = 0;
            Grid_KhuyenMai.CellClick += Grid_KhuyenMai_CellClick;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(6, 33);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(274, 27);
            textBox_search.TabIndex = 2;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // button_timkiem
            // 
            button_timkiem.Image = (Image)resources.GetObject("button_timkiem.Image");
            button_timkiem.Location = new Point(326, 17);
            button_timkiem.Name = "button_timkiem";
            button_timkiem.Size = new Size(57, 52);
            button_timkiem.TabIndex = 3;
            button_timkiem.UseVisualStyleBackColor = true;
            button_timkiem.Click += button_timkiem_Click;
            // 
            // button_tao
            // 
            button_tao.Image = (Image)resources.GetObject("button_tao.Image");
            button_tao.Location = new Point(25, 33);
            button_tao.Name = "button_tao";
            button_tao.Size = new Size(66, 52);
            button_tao.TabIndex = 4;
            button_tao.UseVisualStyleBackColor = true;
            button_tao.Click += button_tao_Click;
            // 
            // button_xoa
            // 
            button_xoa.Image = (Image)resources.GetObject("button_xoa.Image");
            button_xoa.Location = new Point(133, 33);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(66, 52);
            button_xoa.TabIndex = 5;
            button_xoa.UseVisualStyleBackColor = true;
            button_xoa.Click += button_xoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(24, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 139);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạng thái";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 98);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 24);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tất cả";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 68);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 24);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hết hạn";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 24);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Còn hạn";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(241, 33);
            button1.Name = "button1";
            button1.Size = new Size(66, 52);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_tao);
            groupBox2.Controls.Add(button_xoa);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(624, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 98);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(textBox_search);
            groupBox3.Controls.Add(button_timkiem);
            groupBox3.Location = new Point(194, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(389, 85);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(280, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 35);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // KhuyenMaiUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "KhuyenMaiUC";
            Size = new Size(980, 500);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_KhuyenMai).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView Grid_KhuyenMai;
        private TextBox textBox_search;
        private Button button_timkiem;
        private Button button_tao;
        private Button button_xoa;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox2;
    }
}
