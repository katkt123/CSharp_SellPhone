namespace SellPhones.GUI.UserControls
{
    partial class TaoKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoKhuyenMai));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 0;
            label1.Text = "TẠO KHUYẾN MÃI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 95);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã khuyến mãi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 150);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khuyến mãi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 203);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Mức giảm giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 262);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Hãng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 312);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 5;
            label6.Text = "Thời gian bắt đầu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 355);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 6;
            label7.Text = "Thời gian kết thúc:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 92);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%" });
            comboBox1.Location = new Point(206, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 28);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "IPHONE", "SAMSUNG", "XIAOMI", "OPPO", "NOKIA" });
            comboBox2.Location = new Point(206, 254);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(114, 28);
            comboBox2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(206, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(206, 350);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(186, 27);
            dateTimePicker2.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(490, 150);
            button1.Name = "button1";
            button1.Size = new Size(142, 50);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(490, 226);
            button2.Name = "button2";
            button2.Size = new Size(142, 50);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TaoKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(675, 407);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TaoKhuyenMai";
            Text = "TaoKhuyenMai";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Button button2;
    }
}