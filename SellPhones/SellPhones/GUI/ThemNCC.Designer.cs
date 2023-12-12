namespace SellPhones.GUI
{
    partial class ThemNCC
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
            button_Huy = new Button();
            button_Save = new Button();
            label4 = new Label();
            tb_sdtncc = new TextBox();
            tb_diachincc = new TextBox();
            tb_tenncc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_Huy
            // 
            button_Huy.Location = new Point(289, 159);
            button_Huy.Margin = new Padding(3, 2, 3, 2);
            button_Huy.Name = "button_Huy";
            button_Huy.Size = new Size(92, 25);
            button_Huy.TabIndex = 31;
            button_Huy.Text = "Hủy";
            button_Huy.UseVisualStyleBackColor = true;
            button_Huy.Click += button_Huy_Click;
            // 
            // button_Save
            // 
            button_Save.BackColor = Color.Gold;
            button_Save.ForeColor = SystemColors.ControlText;
            button_Save.Location = new Point(134, 161);
            button_Save.Margin = new Padding(3, 2, 3, 2);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(99, 23);
            button_Save.TabIndex = 30;
            button_Save.Text = "Thêm";
            button_Save.UseVisualStyleBackColor = false;
            button_Save.Click += button_Save_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 124);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 29;
            label4.Text = "Số Điện Thoại";
            // 
            // tb_sdtncc
            // 
            tb_sdtncc.Location = new Point(228, 124);
            tb_sdtncc.Margin = new Padding(3, 2, 3, 2);
            tb_sdtncc.MaximumSize = new Size(251, 30);
            tb_sdtncc.Name = "tb_sdtncc";
            tb_sdtncc.Size = new Size(251, 23);
            tb_sdtncc.TabIndex = 28;
            // 
            // tb_diachincc
            // 
            tb_diachincc.Location = new Point(228, 84);
            tb_diachincc.Margin = new Padding(3, 2, 3, 2);
            tb_diachincc.Name = "tb_diachincc";
            tb_diachincc.Size = new Size(251, 23);
            tb_diachincc.TabIndex = 27;
            // 
            // tb_tenncc
            // 
            tb_tenncc.Location = new Point(228, 48);
            tb_tenncc.Margin = new Padding(3, 2, 3, 2);
            tb_tenncc.Name = "tb_tenncc";
            tb_tenncc.Size = new Size(251, 23);
            tb_tenncc.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 84);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 25;
            label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 24;
            label2.Text = "Nhà Cung Cấp";
            // 
            // ThemNCC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 198);
            Controls.Add(button_Huy);
            Controls.Add(button_Save);
            Controls.Add(label4);
            Controls.Add(tb_sdtncc);
            Controls.Add(tb_diachincc);
            Controls.Add(tb_tenncc);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ThemNCC";
            Text = "ThemNCC";
            Load += ThemNCC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Huy;
        private Button button_Save;
        private Label label4;
        private TextBox tb_sdtncc;
        private TextBox tb_diachincc;
        private TextBox tb_tenncc;
        private Label label3;
        private Label label2;
    }
}