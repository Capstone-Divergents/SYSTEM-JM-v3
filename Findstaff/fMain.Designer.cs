namespace Findstaff
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.lblName = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbQueries = new System.Windows.Forms.RadioButton();
            this.rbReports = new System.Windows.Forms.RadioButton();
            this.rbMaintenance = new System.Windows.Forms.RadioButton();
            this.rbAcco = new System.Windows.Forms.RadioButton();
            this.rbRecruitment = new System.Windows.Forms.RadioButton();
            this.rbJobOrderManagement = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCopyright = new System.Windows.Forms.Label();
            this.ucMaintenance = new Findstaff.ucMaintenance();
            this.ucAcco = new Findstaff.ucAcco();
            this.ucReports = new Findstaff.ucReports();
            this.ucJobOrderManagement = new Findstaff.ucJobOrderManagement();
            this.ucRecruitment = new Findstaff.ucRecruitment();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(183, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 20);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "name";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.BackColor = System.Drawing.Color.Transparent;
            this.lblDept.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(183, 146);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(45, 20);
            this.lblDept.TabIndex = 16;
            this.lblDept.Text = "dept";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbQueries);
            this.panel1.Controls.Add(this.rbReports);
            this.panel1.Controls.Add(this.rbMaintenance);
            this.panel1.Controls.Add(this.rbAcco);
            this.panel1.Controls.Add(this.rbRecruitment);
            this.panel1.Controls.Add(this.rbJobOrderManagement);
            this.panel1.Location = new System.Drawing.Point(1, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 328);
            this.panel1.TabIndex = 17;
            // 
            // rbQueries
            // 
            this.rbQueries.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbQueries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(80)))));
            this.rbQueries.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbQueries.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbQueries.FlatAppearance.BorderSize = 0;
            this.rbQueries.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbQueries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbQueries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbQueries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbQueries.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.rbQueries.ForeColor = System.Drawing.Color.White;
            this.rbQueries.Location = new System.Drawing.Point(0, 246);
            this.rbQueries.Name = "rbQueries";
            this.rbQueries.Size = new System.Drawing.Size(156, 48);
            this.rbQueries.TabIndex = 15;
            this.rbQueries.Text = "Queries";
            this.rbQueries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbQueries.UseVisualStyleBackColor = false;
            // 
            // rbReports
            // 
            this.rbReports.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(80)))));
            this.rbReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbReports.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbReports.FlatAppearance.BorderSize = 0;
            this.rbReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbReports.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReports.ForeColor = System.Drawing.Color.White;
            this.rbReports.Location = new System.Drawing.Point(0, 198);
            this.rbReports.Name = "rbReports";
            this.rbReports.Size = new System.Drawing.Size(156, 48);
            this.rbReports.TabIndex = 14;
            this.rbReports.Text = "Reports";
            this.rbReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbReports.UseVisualStyleBackColor = false;
            this.rbReports.CheckedChanged += new System.EventHandler(this.rbReports_CheckedChanged);
            // 
            // rbMaintenance
            // 
            this.rbMaintenance.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(80)))));
            this.rbMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbMaintenance.FlatAppearance.BorderSize = 0;
            this.rbMaintenance.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbMaintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMaintenance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaintenance.ForeColor = System.Drawing.Color.White;
            this.rbMaintenance.Location = new System.Drawing.Point(0, 150);
            this.rbMaintenance.Name = "rbMaintenance";
            this.rbMaintenance.Size = new System.Drawing.Size(156, 48);
            this.rbMaintenance.TabIndex = 13;
            this.rbMaintenance.Text = "Maintenance";
            this.rbMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMaintenance.UseVisualStyleBackColor = false;
            this.rbMaintenance.CheckedChanged += new System.EventHandler(this.rbMaintenance_CheckedChanged);
            // 
            // rbAcco
            // 
            this.rbAcco.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAcco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(80)))));
            this.rbAcco.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAcco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbAcco.FlatAppearance.BorderSize = 0;
            this.rbAcco.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbAcco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbAcco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbAcco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAcco.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAcco.ForeColor = System.Drawing.Color.White;
            this.rbAcco.Location = new System.Drawing.Point(0, 100);
            this.rbAcco.Name = "rbAcco";
            this.rbAcco.Size = new System.Drawing.Size(156, 50);
            this.rbAcco.TabIndex = 10;
            this.rbAcco.TabStop = true;
            this.rbAcco.Text = "Collections Monitoring";
            this.rbAcco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAcco.UseVisualStyleBackColor = false;
            this.rbAcco.CheckedChanged += new System.EventHandler(this.rbAcco_CheckedChanged);
            // 
            // rbRecruitment
            // 
            this.rbRecruitment.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRecruitment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(80)))));
            this.rbRecruitment.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbRecruitment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbRecruitment.FlatAppearance.BorderSize = 0;
            this.rbRecruitment.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbRecruitment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbRecruitment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbRecruitment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRecruitment.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecruitment.ForeColor = System.Drawing.Color.White;
            this.rbRecruitment.Location = new System.Drawing.Point(0, 50);
            this.rbRecruitment.Name = "rbRecruitment";
            this.rbRecruitment.Size = new System.Drawing.Size(156, 50);
            this.rbRecruitment.TabIndex = 8;
            this.rbRecruitment.TabStop = true;
            this.rbRecruitment.Text = "Applicant Management";
            this.rbRecruitment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRecruitment.UseVisualStyleBackColor = false;
            this.rbRecruitment.CheckedChanged += new System.EventHandler(this.rbRecruitment_CheckedChanged);
            // 
            // rbJobOrderManagement
            // 
            this.rbJobOrderManagement.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobOrderManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(80)))));
            this.rbJobOrderManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbJobOrderManagement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobOrderManagement.FlatAppearance.BorderSize = 0;
            this.rbJobOrderManagement.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobOrderManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobOrderManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobOrderManagement.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJobOrderManagement.ForeColor = System.Drawing.Color.White;
            this.rbJobOrderManagement.Location = new System.Drawing.Point(0, 0);
            this.rbJobOrderManagement.Name = "rbJobOrderManagement";
            this.rbJobOrderManagement.Size = new System.Drawing.Size(156, 50);
            this.rbJobOrderManagement.TabIndex = 7;
            this.rbJobOrderManagement.TabStop = true;
            this.rbJobOrderManagement.Text = "Job Order Management";
            this.rbJobOrderManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobOrderManagement.UseVisualStyleBackColor = false;
            this.rbJobOrderManagement.CheckedChanged += new System.EventHandler(this.rbJobOrderManagement_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.ucRecruitment);
            this.panel2.Controls.Add(this.ucMaintenance);
            this.panel2.Controls.Add(this.ucAcco);
            this.panel2.Controls.Add(this.ucReports);
            this.panel2.Controls.Add(this.ucJobOrderManagement);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(187, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 548);
            this.panel2.TabIndex = 18;
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnX.BackgroundImage")));
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(1344, -2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 25);
            this.btnX.TabIndex = 20;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1322, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(80)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(57, 590);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 50);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1029, 123);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 20);
            this.lblTime.TabIndex = 24;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1029, 146);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(551, 733);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(305, 34);
            this.lblCopyright.TabIndex = 27;
            this.lblCopyright.Text = "©2017 Polytechnic University of the Philippines\r\nBachelor of Science in Informati" +
    "on Technology";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopyright.Visible = false;
            // 
            // ucMaintenance
            // 
            this.ucMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucMaintenance.Location = new System.Drawing.Point(3, 155);
            this.ucMaintenance.Name = "ucMaintenance";
            this.ucMaintenance.Size = new System.Drawing.Size(200, 50);
            this.ucMaintenance.TabIndex = 13;
            // 
            // ucAcco
            // 
            this.ucAcco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucAcco.ForeColor = System.Drawing.Color.Black;
            this.ucAcco.Location = new System.Drawing.Point(3, 105);
            this.ucAcco.Name = "ucAcco";
            this.ucAcco.Size = new System.Drawing.Size(200, 50);
            this.ucAcco.TabIndex = 12;
            // 
            // ucReports
            // 
            this.ucReports.AutoScroll = true;
            this.ucReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucReports.ForeColor = System.Drawing.Color.Black;
            this.ucReports.Location = new System.Drawing.Point(3, 203);
            this.ucReports.Name = "ucReports";
            this.ucReports.Size = new System.Drawing.Size(200, 50);
            this.ucReports.TabIndex = 11;
            // 
            // ucJobOrderManagement
            // 
            this.ucJobOrderManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucJobOrderManagement.Location = new System.Drawing.Point(3, 3);
            this.ucJobOrderManagement.Name = "ucJobOrderManagement";
            this.ucJobOrderManagement.Size = new System.Drawing.Size(200, 50);
            this.ucJobOrderManagement.TabIndex = 8;
            // 
            // ucRecruitment
            // 
            this.ucRecruitment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucRecruitment.Location = new System.Drawing.Point(3, 55);
            this.ucRecruitment.Name = "ucRecruitment";
            this.ucRecruitment.Size = new System.Drawing.Size(200, 50);
            this.ucRecruitment.TabIndex = 14;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 772);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.RadioButton rbJobOrderManagement;
        private System.Windows.Forms.Label lblCopyright;
        public System.Windows.Forms.RadioButton rbAcco;
        public System.Windows.Forms.RadioButton rbRecruitment;
        private System.Windows.Forms.RadioButton rbMaintenance;
        private System.Windows.Forms.RadioButton rbReports;
        private System.Windows.Forms.RadioButton rbQueries;
        private ucJobOrderManagement ucJobOrderManagement;
        private ucReports ucReports;
        private ucAcco ucAcco;
        private ucMaintenance ucMaintenance;
        private ucRecruitment ucRecruitment;
    }
}