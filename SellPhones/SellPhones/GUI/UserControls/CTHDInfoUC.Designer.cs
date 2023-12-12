namespace SellPhones.GUI.UserControls
{
    partial class CTHDInfoUC
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
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(500, 15);
            label13.Name = "label13";
            label13.Size = new Size(95, 20);
            label13.TabIndex = 18;
            label13.Text = "THÀNH TIỀN";
            //label13.MouseEnter += label13_MouseEnter;
            //label13.MouseLeave += label13_MouseLeave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(361, 15);
            label14.Name = "label14";
            label14.Size = new Size(82, 20);
            label14.TabIndex = 17;
            label14.Text = "SỐ LƯỢNG";
            //label14.MouseEnter += label14_MouseEnter;
            //label14.MouseLeave += label14_MouseLeave;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(165, 15);
            label15.Name = "label15";
            label15.Size = new Size(56, 20);
            label15.TabIndex = 16;
            label15.Text = "TÊN SP";
            //label15.MouseEnter += label15_MouseEnter;
            //label15.MouseLeave += label15_MouseLeave;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 15);
            label16.Name = "label16";
            label16.Size = new Size(52, 20);
            label16.TabIndex = 15;
            label16.Text = "MÃ SP";
            //label16.MouseEnter += label16_MouseEnter;
            //label16.MouseLeave += label16_MouseLeave;
            // 
            // CTHDInfoUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Name = "CTHDInfoUC";
            Size = new Size(611, 48);
            //MouseEnter += CTHDInfoUC_MouseEnter;
            //MouseLeave += CTHDInfoUC_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        public Label label14;
        private Label label15;
        private Label label16;
    }
}
