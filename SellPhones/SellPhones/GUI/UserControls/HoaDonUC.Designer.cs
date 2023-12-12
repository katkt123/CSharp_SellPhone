namespace SellPhones.GUI.UserControls
{
    partial class HoaDonUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonUC));
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            button_timkiem = new Button();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(32, 21);
            button1.Name = "button1";
            button1.Size = new Size(66, 52);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(105, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 50);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(630, 13);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 14;
            label4.Text = "TRỊ GIÁ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 13);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 13;
            label3.Text = "NGÀY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 13);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 12;
            label2.Text = "KHÁCH HÀNG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 11;
            label1.Text = "SỐ HD";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(105, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 326);
            panel2.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(797, 326);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(125, 21);
            button2.Name = "button2";
            button2.Size = new Size(66, 52);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(button_timkiem);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(105, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(389, 66);
            groupBox3.TabIndex = 26;
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
            // button_timkiem
            // 
            button_timkiem.Image = (Image)resources.GetObject("button_timkiem.Image");
            button_timkiem.Location = new Point(326, 14);
            button_timkiem.Name = "button_timkiem";
            button_timkiem.Size = new Size(57, 52);
            button_timkiem.TabIndex = 3;
            button_timkiem.UseVisualStyleBackColor = true;
            button_timkiem.Click += button_timkiem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(647, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 79);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // HoaDonUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HoaDonUC";
            Size = new Size(980, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private GroupBox groupBox3;
        private PictureBox pictureBox2;
        private Button button_timkiem;
        private GroupBox groupBox2;
    }
}
