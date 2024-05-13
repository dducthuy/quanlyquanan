namespace GUI.report
{
    partial class rpthoadon
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnThêm = new Guna.UI2.WinForms.Guna2Button();
            this.rptv1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.btnThêm.Location = new System.Drawing.Point(610, 686);
            this.btnThêm.Name = "btnThêm";
            this.btnThêm.Size = new System.Drawing.Size(132, 39);
            this.btnThêm.TabIndex = 125;
            this.btnThêm.Text = "Thoát";
            this.btnThêm.Click += new System.EventHandler(this.btnThêm_Click);
            // 
            // rptv1
            // 
            this.rptv1.ActiveViewIndex = -1;
            this.rptv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptv1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptv1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rptv1.Location = new System.Drawing.Point(0, 0);
            this.rptv1.Name = "rptv1";
            this.rptv1.PrintMode = CrystalDecisions.Windows.Forms.PrintMode.PrintOutputController;
            this.rptv1.Size = new System.Drawing.Size(754, 680);
            this.rptv1.TabIndex = 126;
            this.rptv1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rpthoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 737);
            this.Controls.Add(this.rptv1);
            this.Controls.Add(this.btnThêm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rpthoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rpthoadon";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnThêm;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer rptv1;
    }
}