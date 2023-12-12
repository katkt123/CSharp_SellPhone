namespace SellPhones.GUI.UserControls
{
    partial class SanPhamUC
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamUC));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox1 = new GroupBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            button_refresh = new Guna.UI2.WinForms.Guna2Button();
            button_edit = new Guna.UI2.WinForms.Guna2Button();
            button_delete = new Guna.UI2.WinForms.Guna2Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 124);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(guna2TextBox1);
            groupBox2.Location = new Point(662, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 94);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm Kiếm";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.BorderRadius = 20;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = (Image)resources.GetObject("guna2TextBox1.IconLeft");
            guna2TextBox1.Location = new Point(6, 27);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(238, 48);
            guna2TextBox1.TabIndex = 0;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            guna2TextBox1.Enter += guna2TextBox1_Enter;
            guna2TextBox1.Leave += guna2TextBox1_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(guna2Button1);
            groupBox1.Controls.Add(button_refresh);
            groupBox1.Controls.Add(button_edit);
            groupBox1.Controls.Add(button_delete);
            groupBox1.Location = new Point(3, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 94);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.ImageSize = new Size(32, 32);
            guna2Button1.Location = new Point(300, 27);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.LemonChiffon;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(66, 52);
            guna2Button1.TabIndex = 5;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // button_refresh
            // 
            button_refresh.CustomizableEdges = customizableEdges5;
            button_refresh.DisabledState.BorderColor = Color.DarkGray;
            button_refresh.DisabledState.CustomBorderColor = Color.DarkGray;
            button_refresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_refresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_refresh.FillColor = Color.Transparent;
            button_refresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_refresh.ForeColor = Color.White;
            button_refresh.Image = (Image)resources.GetObject("button_refresh.Image");
            button_refresh.ImageSize = new Size(32, 32);
            button_refresh.Location = new Point(203, 27);
            button_refresh.Margin = new Padding(3, 4, 3, 4);
            button_refresh.Name = "button_refresh";
            button_refresh.PressedColor = Color.LemonChiffon;
            button_refresh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            button_refresh.Size = new Size(66, 52);
            button_refresh.TabIndex = 4;
            button_refresh.Click += button_refresh_Click;
            // 
            // button_edit
            // 
            button_edit.CustomizableEdges = customizableEdges7;
            button_edit.DisabledState.BorderColor = Color.DarkGray;
            button_edit.DisabledState.CustomBorderColor = Color.DarkGray;
            button_edit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_edit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_edit.FillColor = Color.Transparent;
            button_edit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_edit.ForeColor = Color.White;
            button_edit.Image = (Image)resources.GetObject("button_edit.Image");
            button_edit.ImageSize = new Size(32, 32);
            button_edit.Location = new Point(6, 27);
            button_edit.Margin = new Padding(3, 4, 3, 4);
            button_edit.Name = "button_edit";
            button_edit.PressedColor = Color.LemonChiffon;
            button_edit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            button_edit.Size = new Size(66, 52);
            button_edit.TabIndex = 2;
            button_edit.Click += button_edit_Click;
            // 
            // button_delete
            // 
            button_delete.CustomizableEdges = customizableEdges9;
            button_delete.DisabledState.BorderColor = Color.DarkGray;
            button_delete.DisabledState.CustomBorderColor = Color.DarkGray;
            button_delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_delete.FillColor = Color.Transparent;
            button_delete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_delete.ForeColor = Color.White;
            button_delete.Image = (Image)resources.GetObject("button_delete.Image");
            button_delete.ImageSize = new Size(32, 32);
            button_delete.Location = new Point(96, 27);
            button_delete.Margin = new Padding(3, 4, 3, 4);
            button_delete.Name = "button_delete";
            button_delete.PressedColor = Color.LemonChiffon;
            button_delete.ShadowDecoration.CustomizableEdges = customizableEdges10;
            button_delete.Size = new Size(66, 52);
            button_delete.TabIndex = 3;
            button_delete.Click += button_delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleGoldenrod;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 124);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(980, 376);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SanPhamUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SanPhamUC";
            Size = new Size(980, 500);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button button_delete;
        private Guna.UI2.WinForms.Guna2Button button_edit;
        public DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button button_refresh;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
