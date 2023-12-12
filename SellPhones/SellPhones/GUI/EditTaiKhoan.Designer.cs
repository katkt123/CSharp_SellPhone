namespace SellPhones.GUI
{
    partial class EditTaiKhoan
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
            button_Save = new Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            groupBox3.Location = new Point(23, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(982, 163);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin chung";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(713, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(713, 53);
            label5.Name = "label5";
            label5.Size = new Size(124, 22);
            label5.TabIndex = 16;
            label5.Text = "Mã Tài Khoản";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(350, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 27);
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
            label4.Location = new Point(350, 102);
            label4.Name = "label4";
            label4.Size = new Size(60, 22);
            label4.TabIndex = 14;
            label4.Text = "Quyền";
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(18, 48);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(249, 27);
            textBox_TK.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 27);
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
            label3.Location = new Point(350, 23);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // textBox_MK
            // 
            textBox_MK.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MK.Location = new Point(18, 123);
            textBox_MK.Multiline = true;
            textBox_MK.Name = "textBox_MK";
            textBox_MK.Size = new Size(249, 27);
            textBox_MK.TabIndex = 3;
            // 
            // button_Save
            // 
            button_Save.BackColor = Color.Gold;
            button_Save.Location = new Point(423, 206);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(175, 47);
            button_Save.TabIndex = 20;
            button_Save.Text = "Lưu";
            button_Save.UseVisualStyleBackColor = false;
            button_Save.Click += button_Save_Click;
            // 
            // EditTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1017, 278);
            Controls.Add(button_Save);
            Controls.Add(groupBox3);
            Name = "EditTaiKhoan";
            Text = "EditTaiKhoan";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox textBox2;
        private Label label1;
        private Label label4;
        private TextBox textBox_TK;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox_MK;
        private Button button_Save;
        private TextBox textBox3;
        private Label label5;
    }
}