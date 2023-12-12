namespace SellPhones.GUI
{
    partial class ForgotPassGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassGUI));
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label_Error = new Label();
            button_Confirm = new Button();
            button_GiveCode = new Button();
            textBox_Code = new TextBox();
            label3 = new Label();
            textBox_EMail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 603);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 408);
            label6.Name = "label6";
            label6.Size = new Size(528, 41);
            label6.TabIndex = 9;
            label6.Text = "Kết nối Groive Store, trải nghiệm mua sắm không giới hạn.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 83);
            label5.Name = "label5";
            label5.Size = new Size(311, 31);
            label5.TabIndex = 8;
            label5.Text = "BẠN ĐẾN VỚI GROIVE STORE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(308, 62);
            label4.TabIndex = 3;
            label4.Text = "CHÀO MỪNG";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGoldenrod;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(546, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 603);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(button1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label_Error);
            panel3.Controls.Add(button_Confirm);
            panel3.Controls.Add(button_GiveCode);
            panel3.Controls.Add(textBox_Code);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox_EMail);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(75, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 481);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(369, 304);
            button1.Name = "button1";
            button1.Size = new Size(150, 44);
            button1.TabIndex = 10;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 34);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 34);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label_Error
            // 
            label_Error.AutoSize = true;
            label_Error.BackColor = Color.PaleGoldenrod;
            label_Error.ForeColor = Color.Red;
            label_Error.Location = new Point(24, 281);
            label_Error.Name = "label_Error";
            label_Error.Size = new Size(0, 20);
            label_Error.TabIndex = 7;
            // 
            // button_Confirm
            // 
            button_Confirm.Location = new Point(180, 304);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(183, 44);
            button_Confirm.TabIndex = 5;
            button_Confirm.Text = "Xác nhận";
            button_Confirm.UseVisualStyleBackColor = true;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // button_GiveCode
            // 
            button_GiveCode.BackColor = Color.Gold;
            button_GiveCode.ForeColor = SystemColors.ControlText;
            button_GiveCode.Location = new Point(24, 304);
            button_GiveCode.Name = "button_GiveCode";
            button_GiveCode.Size = new Size(150, 44);
            button_GiveCode.TabIndex = 4;
            button_GiveCode.Text = "Gửi mã";
            button_GiveCode.UseVisualStyleBackColor = false;
            button_GiveCode.Click += button_GiveCode_Click;
            // 
            // textBox_Code
            // 
            textBox_Code.Enabled = false;
            textBox_Code.Location = new Point(49, 196);
            textBox_Code.Name = "textBox_Code";
            textBox_Code.Size = new Size(470, 27);
            textBox_Code.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleGoldenrod;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 167);
            label3.Name = "label3";
            label3.Size = new Size(61, 26);
            label3.TabIndex = 2;
            label3.Text = "Code";
            // 
            // textBox_EMail
            // 
            textBox_EMail.Location = new Point(49, 80);
            textBox_EMail.Name = "textBox_EMail";
            textBox_EMail.Size = new Size(470, 27);
            textBox_EMail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGoldenrod;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 42);
            label2.Name = "label2";
            label2.Size = new Size(74, 26);
            label2.TabIndex = 0;
            label2.Text = "E-Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(182, 18);
            label1.Name = "label1";
            label1.Size = new Size(354, 62);
            label1.TabIndex = 2;
            label1.Text = "Quên Mật Khẩu";
            // 
            // ForgotPassGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ForgotPassGUI";
            Text = "ForgotPassGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label_Error;
        private Button button_Confirm;
        private Button button_GiveCode;
        private TextBox textBox_Code;
        private Label label3;
        private TextBox textBox_EMail;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}