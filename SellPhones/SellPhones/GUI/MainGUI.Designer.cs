namespace SellPhones.GUI
{
    partial class MainGUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            fileSystemWatcher1 = new FileSystemWatcher();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            panel_UC = new Panel();
            PanelTools = new FlowLayoutPanel();
            label_MaNV = new Label();
            panel2 = new Panel();
            label_QuanLi = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox = new PictureBox();
            button_MuaBan = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel_UC
            // 
            panel_UC.Location = new Point(235, 89);
            panel_UC.Name = "panel_UC";
            panel_UC.Size = new Size(980, 500);
            panel_UC.TabIndex = 3;
            // 
            // PanelTools
            // 
            PanelTools.AutoScroll = true;
            PanelTools.BackColor = Color.PaleGoldenrod;
            PanelTools.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PanelTools.Location = new Point(0, 150);
            PanelTools.MaximumSize = new Size(229, 439);
            PanelTools.MinimumSize = new Size(229, 319);
            PanelTools.Name = "PanelTools";
            PanelTools.Size = new Size(229, 376);
            PanelTools.TabIndex = 7;
            // 
            // label_MaNV
            // 
            label_MaNV.AutoSize = true;
            label_MaNV.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_MaNV.Location = new Point(552, 18);
            label_MaNV.Name = "label_MaNV";
            label_MaNV.Size = new Size(0, 42);
            label_MaNV.TabIndex = 1;
            label_MaNV.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.Controls.Add(label_MaNV);
            panel2.Controls.Add(label_QuanLi);
            panel2.Location = new Point(235, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 80);
            panel2.TabIndex = 2;
            // 
            // label_QuanLi
            // 
            label_QuanLi.AutoSize = true;
            label_QuanLi.Font = new Font("Times New Roman", 34.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_QuanLi.Location = new Point(3, 6);
            label_QuanLi.Name = "label_QuanLi";
            label_QuanLi.Size = new Size(269, 65);
            label_QuanLi.TabIndex = 3;
            label_QuanLi.Text = "Trang Chủ";
            label_QuanLi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.PaleGoldenrod;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(1138, 3);
            flowLayoutPanel1.MaximumSize = new Size(259, 188);
            flowLayoutPanel1.MinimumSize = new Size(77, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(77, 84);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGoldenrod;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(253, 81);
            button1.TabIndex = 6;
            button1.Text = "THIẾT LẬP";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.BackColor = Color.PaleGoldenrod;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 90);
            button2.Name = "button2";
            button2.Size = new Size(253, 45);
            button2.TabIndex = 8;
            button2.Text = "Chỉnh sửa tài khoản";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AllowDrop = true;
            button3.BackColor = Color.PaleGoldenrod;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 141);
            button3.Name = "button3";
            button3.Size = new Size(253, 45);
            button3.TabIndex = 10;
            button3.Text = "Đăng xuất";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(0, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(229, 141);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 8;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click_1;
            // 
            // button_MuaBan
            // 
            button_MuaBan.BackColor = Color.PaleGoldenrod;
            button_MuaBan.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_MuaBan.Image = (Image)resources.GetObject("button_MuaBan.Image");
            button_MuaBan.ImageAlign = ContentAlignment.MiddleLeft;
            button_MuaBan.Location = new Point(0, 532);
            button_MuaBan.Name = "button_MuaBan";
            button_MuaBan.Size = new Size(229, 57);
            button_MuaBan.TabIndex = 9;
            button_MuaBan.Text = "Mua Bán";
            button_MuaBan.UseVisualStyleBackColor = false;
            button_MuaBan.Click += button_MuaBan_Click;
            // 
            // MainGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 595);
            Controls.Add(button_MuaBan);
            Controls.Add(pictureBox);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(PanelTools);
            Controls.Add(panel_UC);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1220, 595);
            MinimumSize = new Size(1220, 595);
            Name = "MainGUI";
            Text = "MainGUI";
            Load += MainGUI_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox;
        private FlowLayoutPanel PanelTools;
        private Panel panel_UC;
        private Panel panel2;
        private Label label_MaNV;
        private Label label_QuanLi;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button_MuaBan;
    }
}