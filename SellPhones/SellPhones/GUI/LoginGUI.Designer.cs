namespace SellPhones.GUI
{
    partial class LoginGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label_Error = new Label();
            button_SignUp = new Button();
            button_SignIn = new Button();
            textBox_MK = new TextBox();
            label3 = new Label();
            textBox_TK = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel1.TabIndex = 0;
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
            label6.Click += label6_Click;
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
            label4.Click += label4_Click;
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
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label_Error);
            panel3.Controls.Add(button_SignUp);
            panel3.Controls.Add(button_SignIn);
            panel3.Controls.Add(textBox_MK);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox_TK);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(75, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 481);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(488, 229);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 27);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(488, 229);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 27);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(374, 270);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 10;
            label7.Text = "Quên mật khẩu?";
            label7.Click += label7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 34);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 113);
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
            // button_SignUp
            // 
            button_SignUp.Location = new Point(268, 304);
            button_SignUp.Name = "button_SignUp";
            button_SignUp.Size = new Size(222, 44);
            button_SignUp.TabIndex = 5;
            button_SignUp.Text = "Đăng Ký";
            button_SignUp.UseVisualStyleBackColor = true;
            button_SignUp.Click += button_SignUp_Click;
            // 
            // button_SignIn
            // 
            button_SignIn.BackColor = Color.Gold;
            button_SignIn.Cursor = Cursors.Hand;
            button_SignIn.ForeColor = SystemColors.ControlText;
            button_SignIn.Location = new Point(24, 304);
            button_SignIn.Name = "button_SignIn";
            button_SignIn.Size = new Size(222, 44);
            button_SignIn.TabIndex = 4;
            button_SignIn.Text = "Đăng Nhập";
            button_SignIn.UseVisualStyleBackColor = false;
            button_SignIn.Click += button_SignIn_Click;
            // 
            // textBox_MK
            // 
            textBox_MK.Location = new Point(49, 229);
            textBox_MK.Name = "textBox_MK";
            textBox_MK.PasswordChar = '*';
            textBox_MK.Size = new Size(441, 27);
            textBox_MK.TabIndex = 3;
            textBox_MK.Text = "PassWord";
            textBox_MK.Enter += textBox_MK_Enter;
            textBox_MK.Leave += textBox_MK_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleGoldenrod;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 191);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(49, 118);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(441, 27);
            textBox_TK.TabIndex = 1;
            textBox_TK.Text = "UserName";
            textBox_TK.Enter += textBox_TK_Enter;
            textBox_TK.Leave += textBox_TK_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGoldenrod;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 80);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 0;
            label2.Text = "Tài Khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(225, 22);
            label1.Name = "label1";
            label1.Size = new Size(266, 62);
            label1.TabIndex = 2;
            label1.Text = "Đăng Nhập";
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1215, 650);
            MinimumSize = new Size(1215, 650);
            Name = "LoginGUI";
            Text = "LoginGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox textBox_TK;
        private TextBox textBox_MK;
        private Label label3;
        private Label label2;
        private Button button_SignUp;
        private Button button_SignIn;
        private Label label_Error;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}