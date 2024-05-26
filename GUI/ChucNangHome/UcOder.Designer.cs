namespace GUI.ChucNangHome
{
    partial class UcOder
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
            this.components = new System.ComponentModel.Container();
            this.gb1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lv1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sl = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtdanhmuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txttongtien = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtmon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThêm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.DSban = new System.Windows.Forms.FlowLayoutPanel();
            this.listban = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtChuyen = new Guna.UI2.WinForms.Guna2Button();
            this.txtban = new Guna.UI2.WinForms.Guna2TextBox();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.listban.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.BorderColor = System.Drawing.Color.White;
            this.gb1.Controls.Add(this.guna2HtmlLabel5);
            this.gb1.Controls.Add(this.lv1);
            this.gb1.Controls.Add(this.guna2HtmlLabel2);
            this.gb1.Controls.Add(this.sl);
            this.gb1.Controls.Add(this.txtdanhmuc);
            this.gb1.Controls.Add(this.txttongtien);
            this.gb1.Controls.Add(this.guna2Button1);
            this.gb1.Controls.Add(this.txtmon);
            this.gb1.Controls.Add(this.btnThêm);
            this.gb1.CustomBorderColor = System.Drawing.Color.White;
            this.gb1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gb1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gb1.Location = new System.Drawing.Point(400, 0);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(348, 515);
            this.gb1.TabIndex = 152;
            this.gb1.Click += new System.EventHandler(this.gb1_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(3, 3);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(109, 37);
            this.guna2HtmlLabel5.TabIndex = 174;
            this.guna2HtmlLabel5.Text = "Đặt Bàn";
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lv1.GridLines = true;
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(-2, 157);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(347, 300);
            this.lv1.TabIndex = 125;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
        
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên ";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SL";
            this.columnHeader6.Width = 46;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá";
            this.columnHeader7.Width = 78;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Thành Tiền";
            this.columnHeader8.Width = 119;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 49);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(84, 25);
            this.guna2HtmlLabel2.TabIndex = 160;
            this.guna2HtmlLabel2.Text = "Chọn món";
            // 
            // sl
            // 
            this.sl.BackColor = System.Drawing.Color.Transparent;
            this.sl.BorderColor = System.Drawing.Color.Black;
            this.sl.BorderRadius = 15;
            this.sl.BorderThickness = 3;
            this.sl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sl.Location = new System.Drawing.Point(178, 76);
            this.sl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sl.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(79, 37);
            this.sl.TabIndex = 158;
            this.sl.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.sl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtdanhmuc
            // 
            this.txtdanhmuc.BackColor = System.Drawing.Color.Transparent;
            this.txtdanhmuc.BorderColor = System.Drawing.Color.Black;
            this.txtdanhmuc.BorderRadius = 15;
            this.txtdanhmuc.BorderThickness = 3;
            this.txtdanhmuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtdanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdanhmuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdanhmuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdanhmuc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdanhmuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtdanhmuc.ItemHeight = 30;
            this.txtdanhmuc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txtdanhmuc.Location = new System.Drawing.Point(3, 77);
            this.txtdanhmuc.Name = "txtdanhmuc";
            this.txtdanhmuc.Size = new System.Drawing.Size(169, 36);
            this.txtdanhmuc.TabIndex = 157;
            this.txtdanhmuc.SelectedIndexChanged += new System.EventHandler(this.txtdanhmuc_SelectedIndexChanged);
            // 
            // txttongtien
            // 
            this.txttongtien.Animated = true;
            this.txttongtien.AutoRoundedCorners = true;
            this.txttongtien.BorderColor = System.Drawing.Color.Black;
            this.txttongtien.BorderRadius = 18;
            this.txttongtien.BorderThickness = 3;
            this.txttongtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttongtien.DefaultText = "0";
            this.txttongtien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttongtien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttongtien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttongtien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttongtien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttongtien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.txttongtien.ForeColor = System.Drawing.Color.Red;
            this.txttongtien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttongtien.Location = new System.Drawing.Point(0, 473);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.PasswordChar = '\0';
            this.txttongtien.PlaceholderText = "";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.SelectedText = "";
            this.txttongtien.Size = new System.Drawing.Size(172, 39);
            this.txttongtien.TabIndex = 156;
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(179, 473);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(166, 39);
            this.guna2Button1.TabIndex = 127;
            this.guna2Button1.Text = "Thanh Toán";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtmon
            // 
            this.txtmon.BackColor = System.Drawing.Color.Transparent;
            this.txtmon.BorderColor = System.Drawing.Color.Black;
            this.txtmon.BorderRadius = 15;
            this.txtmon.BorderThickness = 3;
            this.txtmon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtmon.ItemHeight = 30;
            this.txtmon.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txtmon.Location = new System.Drawing.Point(3, 115);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(254, 36);
            this.txtmon.TabIndex = 126;
 
            // 
            // btnThêm
            // 
            this.btnThêm.BorderRadius = 15;
            this.btnThêm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThêm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThêm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThêm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThêm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.btnThêm.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnThêm.ForeColor = System.Drawing.Color.White;
            this.btnThêm.Location = new System.Drawing.Point(263, 74);
            this.btnThêm.Name = "btnThêm";
            this.btnThêm.Size = new System.Drawing.Size(74, 39);
            this.btnThêm.TabIndex = 124;
            this.btnThêm.Text = "Thêm";
            this.btnThêm.Click += new System.EventHandler(this.btnThêm_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(390, -9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(4, 550);
            this.guna2PictureBox1.TabIndex = 92;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 23);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(102, 18);
            this.guna2HtmlLabel1.TabIndex = 153;
            this.guna2HtmlLabel1.Text = "Danh Sách Bàn :";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // DSban
            // 
            this.DSban.Location = new System.Drawing.Point(3, 3);
            this.DSban.Name = "DSban";
            this.DSban.Size = new System.Drawing.Size(372, 399);
            this.DSban.TabIndex = 0;
            // 
            // listban
            // 
            this.listban.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.listban.BorderThickness = 3;
            this.listban.Controls.Add(this.DSban);
            this.listban.CustomBorderColor = System.Drawing.Color.White;
            this.listban.Location = new System.Drawing.Point(3, 47);
            this.listban.Name = "listban";
            this.listban.Size = new System.Drawing.Size(381, 410);
            this.listban.TabIndex = 155;
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.Color.Transparent;
            this.cb.BorderColor = System.Drawing.Color.Black;
            this.cb.BorderRadius = 15;
            this.cb.BorderThickness = 3;
            this.cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb.ItemHeight = 30;
            this.cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb.Location = new System.Drawing.Point(173, 473);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(108, 36);
            this.cb.TabIndex = 158;
            // 
            // txtChuyen
            // 
            this.txtChuyen.BorderRadius = 15;
            this.txtChuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtChuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtChuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.txtChuyen.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtChuyen.ForeColor = System.Drawing.Color.White;
            this.txtChuyen.Location = new System.Drawing.Point(287, 470);
            this.txtChuyen.Name = "txtChuyen";
            this.txtChuyen.Size = new System.Drawing.Size(92, 39);
            this.txtChuyen.TabIndex = 158;
            this.txtChuyen.Text = "Chuyển bàn";
            this.txtChuyen.Click += new System.EventHandler(this.txtChuyen_Click);
            // 
            // txtban
            // 
            this.txtban.Animated = true;
            this.txtban.AutoRoundedCorners = true;
            this.txtban.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.txtban.BorderRadius = 17;
            this.txtban.BorderThickness = 3;
            this.txtban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtban.DefaultText = "";
            this.txtban.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtban.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtban.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtban.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtban.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtban.Location = new System.Drawing.Point(119, 473);
            this.txtban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtban.Name = "txtban";
            this.txtban.PasswordChar = '\0';
            this.txtban.PlaceholderText = " ";
            this.txtban.ReadOnly = true;
            this.txtban.SelectedText = "";
            this.txtban.Size = new System.Drawing.Size(49, 37);
            this.txtban.TabIndex = 126;
            this.txtban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UcOder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtban);
            this.Controls.Add(this.txtChuyen);
            this.Controls.Add(this.listban);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.cb);
            this.Name = "UcOder";
            this.Size = new System.Drawing.Size(748, 515);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.listban.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gb1;
        private System.Windows.Forms.ListView lv1;
        private Guna.UI2.WinForms.Guna2Button btnThêm;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox txtmon;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel listban;
        private System.Windows.Forms.FlowLayoutPanel DSban;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private Guna.UI2.WinForms.Guna2TextBox txttongtien;
        private Guna.UI2.WinForms.Guna2ComboBox txtdanhmuc;
        private Guna.UI2.WinForms.Guna2Button txtChuyen;
        private Guna.UI2.WinForms.Guna2ComboBox cb;
        private Guna.UI2.WinForms.Guna2NumericUpDown sl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtban;
    }
}
