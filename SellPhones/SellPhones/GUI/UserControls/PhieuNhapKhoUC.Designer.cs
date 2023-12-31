﻿namespace SellPhones.GUI.UserControls
{
    partial class PhieuNhapKhoUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuNhapKhoUC));
            Find_date = new Button();
            Date_end = new GroupBox();
            text_DateEnd = new TextBox();
            pickDate_end = new DateTimePicker();
            Date_start = new GroupBox();
            text_DateStart = new TextBox();
            pickDate_start = new DateTimePicker();
            TimKiem = new GroupBox();
            text_Find = new TextBox();
            panel1 = new Panel();
            grid_PhieuNhap = new DataGridView();
            button_add = new Button();
            button_CTPhieuNhap = new Button();
            button_Excel = new Button();
            button1 = new Button();
            Date_end.SuspendLayout();
            Date_start.SuspendLayout();
            TimKiem.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_PhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // Find_date
            // 
            Find_date.BackColor = Color.AliceBlue;
            Find_date.Cursor = Cursors.Hand;
            Find_date.FlatStyle = FlatStyle.Popup;
            Find_date.Image = (Image)resources.GetObject("Find_date.Image");
            Find_date.Location = new Point(904, 35);
            Find_date.Margin = new Padding(2, 3, 2, 3);
            Find_date.Name = "Find_date";
            Find_date.Size = new Size(62, 71);
            Find_date.TabIndex = 30;
            Find_date.UseVisualStyleBackColor = false;
            Find_date.Click += Find_date_Click;
            // 
            // Date_end
            // 
            Date_end.BackColor = Color.AliceBlue;
            Date_end.Controls.Add(text_DateEnd);
            Date_end.Controls.Add(pickDate_end);
            Date_end.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Date_end.Location = new Point(650, 35);
            Date_end.Margin = new Padding(2, 3, 2, 3);
            Date_end.Name = "Date_end";
            Date_end.Padding = new Padding(2, 3, 2, 3);
            Date_end.Size = new Size(234, 71);
            Date_end.TabIndex = 29;
            Date_end.TabStop = false;
            Date_end.Text = "Đến ngày";
            // 
            // text_DateEnd
            // 
            text_DateEnd.Location = new Point(6, 24);
            text_DateEnd.Margin = new Padding(2, 3, 2, 3);
            text_DateEnd.Name = "text_DateEnd";
            text_DateEnd.Size = new Size(191, 27);
            text_DateEnd.TabIndex = 7;
            // 
            // pickDate_end
            // 
            pickDate_end.Cursor = Cursors.Hand;
            pickDate_end.Location = new Point(203, 24);
            pickDate_end.Margin = new Padding(2, 3, 2, 3);
            pickDate_end.Name = "pickDate_end";
            pickDate_end.Size = new Size(26, 27);
            pickDate_end.TabIndex = 0;
            pickDate_end.ValueChanged += pickDate_end_ValueChanged;
            // 
            // Date_start
            // 
            Date_start.BackColor = Color.AliceBlue;
            Date_start.Controls.Add(text_DateStart);
            Date_start.Controls.Add(pickDate_start);
            Date_start.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Date_start.Location = new Point(409, 35);
            Date_start.Margin = new Padding(2, 3, 2, 3);
            Date_start.Name = "Date_start";
            Date_start.Padding = new Padding(2, 3, 2, 3);
            Date_start.Size = new Size(225, 71);
            Date_start.TabIndex = 28;
            Date_start.TabStop = false;
            Date_start.Text = "Từ ngày";
            // 
            // text_DateStart
            // 
            text_DateStart.Location = new Point(6, 28);
            text_DateStart.Margin = new Padding(2, 3, 2, 3);
            text_DateStart.Name = "text_DateStart";
            text_DateStart.Size = new Size(182, 27);
            text_DateStart.TabIndex = 1;
            text_DateStart.TextChanged += text_DateStart_TextChanged;
            // 
            // pickDate_start
            // 
            pickDate_start.Cursor = Cursors.Hand;
            pickDate_start.Location = new Point(193, 28);
            pickDate_start.Margin = new Padding(2, 3, 2, 3);
            pickDate_start.Name = "pickDate_start";
            pickDate_start.Size = new Size(27, 27);
            pickDate_start.TabIndex = 0;
            pickDate_start.ValueChanged += pickDate_start_ValueChanged;
            // 
            // TimKiem
            // 
            TimKiem.BackColor = Color.AliceBlue;
            TimKiem.Controls.Add(text_Find);
            TimKiem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TimKiem.Location = new Point(78, 35);
            TimKiem.Margin = new Padding(2, 3, 2, 3);
            TimKiem.Name = "TimKiem";
            TimKiem.Padding = new Padding(2, 3, 2, 3);
            TimKiem.Size = new Size(327, 71);
            TimKiem.TabIndex = 27;
            TimKiem.TabStop = false;
            TimKiem.Text = "Tìm kiếm";
            // 
            // text_Find
            // 
            text_Find.Location = new Point(7, 29);
            text_Find.Margin = new Padding(2, 3, 2, 3);
            text_Find.Name = "text_Find";
            text_Find.Size = new Size(302, 27);
            text_Find.TabIndex = 0;
            text_Find.TextChanged += text_Find_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(grid_PhieuNhap);
            panel1.Location = new Point(24, 119);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 360);
            panel1.TabIndex = 32;
            // 
            // grid_PhieuNhap
            // 
            grid_PhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_PhieuNhap.Dock = DockStyle.Fill;
            grid_PhieuNhap.Location = new Point(0, 0);
            grid_PhieuNhap.Name = "grid_PhieuNhap";
            grid_PhieuNhap.RowHeadersWidth = 51;
            grid_PhieuNhap.RowTemplate.Height = 29;
            grid_PhieuNhap.Size = new Size(861, 360);
            grid_PhieuNhap.TabIndex = 1;
            // 
            // button_add
            // 
            button_add.BackColor = Color.AliceBlue;
            button_add.Cursor = Cursors.Hand;
            button_add.FlatStyle = FlatStyle.Popup;
            button_add.Image = (Image)resources.GetObject("button_add.Image");
            button_add.Location = new Point(904, 119);
            button_add.Margin = new Padding(2, 3, 2, 3);
            button_add.Name = "button_add";
            button_add.Size = new Size(62, 71);
            button_add.TabIndex = 33;
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_CTPhieuNhap
            // 
            button_CTPhieuNhap.BackColor = Color.AliceBlue;
            button_CTPhieuNhap.Cursor = Cursors.Hand;
            button_CTPhieuNhap.FlatStyle = FlatStyle.Popup;
            button_CTPhieuNhap.Image = (Image)resources.GetObject("button_CTPhieuNhap.Image");
            button_CTPhieuNhap.Location = new Point(904, 211);
            button_CTPhieuNhap.Margin = new Padding(2, 3, 2, 3);
            button_CTPhieuNhap.Name = "button_CTPhieuNhap";
            button_CTPhieuNhap.Size = new Size(62, 71);
            button_CTPhieuNhap.TabIndex = 34;
            button_CTPhieuNhap.UseVisualStyleBackColor = false;
            button_CTPhieuNhap.Click += button_CTPhieuNhap_Click;
            // 
            // button_Excel
            // 
            button_Excel.BackColor = Color.AliceBlue;
            button_Excel.Cursor = Cursors.Hand;
            button_Excel.FlatStyle = FlatStyle.Popup;
            button_Excel.Image = (Image)resources.GetObject("button_Excel.Image");
            button_Excel.Location = new Point(904, 311);
            button_Excel.Margin = new Padding(2, 3, 2, 3);
            button_Excel.Name = "button_Excel";
            button_Excel.Size = new Size(62, 71);
            button_Excel.TabIndex = 35;
            button_Excel.UseVisualStyleBackColor = false;
            button_Excel.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(904, 407);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(62, 72);
            button1.TabIndex = 34;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PhieuNhapKhoUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(button_Excel);
            Controls.Add(button_CTPhieuNhap);
            Controls.Add(button_add);
            Controls.Add(panel1);
            Controls.Add(Find_date);
            Controls.Add(Date_end);
            Controls.Add(Date_start);
            Controls.Add(TimKiem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PhieuNhapKhoUC";
            Size = new Size(981, 500);
            Load += PhieuNhapKho_Load;
            Date_end.ResumeLayout(false);
            Date_end.PerformLayout();
            Date_start.ResumeLayout(false);
            Date_start.PerformLayout();
            TimKiem.ResumeLayout(false);
            TimKiem.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_PhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Find_date;
        private GroupBox Date_end;
        private TextBox text_DateEnd;
        private DateTimePicker pickDate_end;
        private GroupBox Date_start;
        private TextBox text_DateStart;
        private DateTimePicker pickDate_start;
        private GroupBox TimKiem;
        private TextBox text_Find;
        private Panel panel1;
        private DataGridView grid_PhieuNhap;
        private Button button_add;
        private Button button_CTPhieuNhap;
        private Button button_Excel;
        private Button button1;
    }
}
