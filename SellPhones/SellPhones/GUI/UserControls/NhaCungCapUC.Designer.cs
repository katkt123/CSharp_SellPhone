﻿namespace SellPhones.GUI.UserControls
{
    partial class NhaCungCapUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCapUC));
            panel1 = new Panel();
            btn_Reload = new Button();
            button_AddSP = new Button();
            button_Excel = new Button();
            button_Xoa = new Button();
            button_Huy = new Button();
            button_Save = new Button();
            button_Edit = new Button();
            label6 = new Label();
            tb_TimNCC = new TextBox();
            label4 = new Label();
            tb_sdtncc = new TextBox();
            tb_diachincc = new TextBox();
            tb_tenncc = new TextBox();
            tb_mancc = new TextBox();
            button_Add = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grid_NhaCungCap = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_NhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Reload);
            panel1.Controls.Add(button_AddSP);
            panel1.Controls.Add(button_Excel);
            panel1.Controls.Add(button_Xoa);
            panel1.Controls.Add(button_Huy);
            panel1.Controls.Add(button_Save);
            panel1.Controls.Add(button_Edit);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tb_TimNCC);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tb_sdtncc);
            panel1.Controls.Add(tb_diachincc);
            panel1.Controls.Add(tb_tenncc);
            panel1.Controls.Add(tb_mancc);
            panel1.Controls.Add(button_Add);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 178);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_Reload
            // 
            btn_Reload.BackgroundImage = (Image)resources.GetObject("btn_Reload.BackgroundImage");
            btn_Reload.BackgroundImageLayout = ImageLayout.Center;
            btn_Reload.Location = new Point(760, 110);
            btn_Reload.Name = "btn_Reload";
            btn_Reload.Size = new Size(56, 43);
            btn_Reload.TabIndex = 27;
            btn_Reload.UseVisualStyleBackColor = true;
            btn_Reload.Click += btn_Reload_Click;
            // 
            // button_AddSP
            // 
            button_AddSP.Location = new Point(698, 110);
            button_AddSP.Name = "button_AddSP";
            button_AddSP.Size = new Size(56, 43);
            button_AddSP.TabIndex = 26;
            button_AddSP.Text = "Thêm SP";
            button_AddSP.UseVisualStyleBackColor = true;
            button_AddSP.Click += button_AddSP_Click;
            // 
            // button_Excel
            // 
            button_Excel.Image = (Image)resources.GetObject("button_Excel.Image");
            button_Excel.Location = new Point(645, 109);
            button_Excel.Name = "button_Excel";
            button_Excel.Size = new Size(51, 44);
            button_Excel.TabIndex = 25;
            button_Excel.TextAlign = ContentAlignment.TopCenter;
            button_Excel.UseVisualStyleBackColor = true;
            button_Excel.Click += button_Excel_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.BackgroundImage = (Image)resources.GetObject("button_Xoa.BackgroundImage");
            button_Xoa.BackgroundImageLayout = ImageLayout.Center;
            button_Xoa.ForeColor = SystemColors.ActiveCaptionText;
            button_Xoa.Location = new Point(588, 108);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(51, 44);
            button_Xoa.TabIndex = 24;
            button_Xoa.UseVisualStyleBackColor = true;
            button_Xoa.Click += button1_Click_1;
            // 
            // button_Huy
            // 
            button_Huy.Location = new Point(262, 144);
            button_Huy.Margin = new Padding(3, 2, 3, 2);
            button_Huy.Name = "button_Huy";
            button_Huy.Size = new Size(92, 25);
            button_Huy.TabIndex = 23;
            button_Huy.Text = "Hủy";
            button_Huy.UseVisualStyleBackColor = true;
            button_Huy.Click += button_Huy_Click;
            // 
            // button_Save
            // 
            button_Save.BackColor = Color.Gold;
            button_Save.ForeColor = SystemColors.ControlText;
            button_Save.Location = new Point(116, 146);
            button_Save.Margin = new Padding(3, 2, 3, 2);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(99, 23);
            button_Save.TabIndex = 22;
            button_Save.Text = "Lưu";
            button_Save.UseVisualStyleBackColor = false;
            button_Save.Click += button_Save_Click;
            // 
            // button_Edit
            // 
            button_Edit.AllowDrop = true;
            button_Edit.BackColor = SystemColors.Control;
            button_Edit.BackgroundImageLayout = ImageLayout.None;
            button_Edit.Font = new Font("Segoe UI", 5.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Edit.Image = (Image)resources.GetObject("button_Edit.Image");
            button_Edit.Location = new Point(531, 108);
            button_Edit.Margin = new Padding(3, 2, 3, 2);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(51, 44);
            button_Edit.TabIndex = 21;
            button_Edit.UseVisualStyleBackColor = false;
            button_Edit.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(510, 14);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(292, 31);
            label6.TabIndex = 20;
            label6.Text = "Tìm kiếm nhà cung cấp";
            // 
            // tb_TimNCC
            // 
            tb_TimNCC.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_TimNCC.Location = new Point(485, 51);
            tb_TimNCC.Margin = new Padding(2);
            tb_TimNCC.Name = "tb_TimNCC";
            tb_TimNCC.Size = new Size(317, 32);
            tb_TimNCC.TabIndex = 19;
            tb_TimNCC.TextChanged += tb_TimNCC_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 117);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 18;
            label4.Text = "Số Điện Thoại";
            // 
            // tb_sdtncc
            // 
            tb_sdtncc.Location = new Point(199, 117);
            tb_sdtncc.Margin = new Padding(3, 2, 3, 2);
            tb_sdtncc.MaximumSize = new Size(251, 30);
            tb_sdtncc.Name = "tb_sdtncc";
            tb_sdtncc.Size = new Size(251, 23);
            tb_sdtncc.TabIndex = 17;
            // 
            // tb_diachincc
            // 
            tb_diachincc.Location = new Point(199, 87);
            tb_diachincc.Margin = new Padding(3, 2, 3, 2);
            tb_diachincc.Name = "tb_diachincc";
            tb_diachincc.Size = new Size(251, 23);
            tb_diachincc.TabIndex = 16;
            // 
            // tb_tenncc
            // 
            tb_tenncc.Location = new Point(199, 51);
            tb_tenncc.Margin = new Padding(3, 2, 3, 2);
            tb_tenncc.Name = "tb_tenncc";
            tb_tenncc.Size = new Size(251, 23);
            tb_tenncc.TabIndex = 15;
            // 
            // tb_mancc
            // 
            tb_mancc.Location = new Point(199, 14);
            tb_mancc.Margin = new Padding(3, 2, 3, 2);
            tb_mancc.Name = "tb_mancc";
            tb_mancc.Size = new Size(251, 23);
            tb_mancc.TabIndex = 14;
            // 
            // button_Add
            // 
            button_Add.AllowDrop = true;
            button_Add.BackColor = SystemColors.Control;
            button_Add.BackgroundImageLayout = ImageLayout.None;
            button_Add.Font = new Font("Segoe UI", 5.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.Image = (Image)resources.GetObject("button_Add.Image");
            button_Add.Location = new Point(474, 107);
            button_Add.Margin = new Padding(3, 2, 3, 2);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(51, 44);
            button_Add.TabIndex = 8;
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 87);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 12;
            label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 51);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 9;
            label2.Text = "Nhà Cung Cấp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 7;
            label1.Text = "Mã nhà cung cấp";
            // 
            // grid_NhaCungCap
            // 
            grid_NhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_NhaCungCap.Location = new Point(19, 202);
            grid_NhaCungCap.Margin = new Padding(3, 2, 3, 2);
            grid_NhaCungCap.Name = "grid_NhaCungCap";
            grid_NhaCungCap.RowHeadersWidth = 51;
            grid_NhaCungCap.RowTemplate.Height = 29;
            grid_NhaCungCap.Size = new Size(819, 155);
            grid_NhaCungCap.TabIndex = 1;
            grid_NhaCungCap.CellClick += grid_NhaCungCap_CellClick;
            grid_NhaCungCap.CellContentClick += grid_NhaCungCap_CellContentClick;
            // 
            // NhaCungCapUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(grid_NhaCungCap);
            Controls.Add(panel1);
            Name = "NhaCungCapUC";
            Size = new Size(858, 375);
            Load += NhaCungCap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_NhaCungCap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_Add;
        private TextBox tb_sdtncc;
        private TextBox tb_diachincc;
        private TextBox tb_tenncc;
        private TextBox tb_mancc;
        private TextBox tb_TimNCC;
        private Label label6;
        private Label label4;
        private Button button_Edit;
        private Button button_Save;
        private Button button_Huy;
        private DataGridView grid_NhaCungCap;
        private Button button_Xoa;
        private Button button_Excel;
        private Button button_AddSP;
        private Button btn_Reload;
    }
}
