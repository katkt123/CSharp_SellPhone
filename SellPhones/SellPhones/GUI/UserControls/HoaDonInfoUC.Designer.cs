namespace SellPhones.GUI.UserControls
{
    partial class HoaDonInfoUC
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(624, 13);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 18;
            label4.Text = "TRỊ GIÁ";
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 13);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 17;
            label3.Text = "CHƯA XÁC NHẬN";
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 13);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 16;
            label2.Text = "KHÁCH HÀNG";
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 15;
            label1.Text = "SỐ HD";
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // HoaDonInfoUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "HoaDonInfoUC";
            Size = new Size(760, 50);
            MouseEnter += HoaDonInfoUC_MouseEnter;
            MouseLeave += HoaDonInfoUC_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
