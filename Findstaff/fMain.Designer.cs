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
            this.rbReports = new System.Windows.Forms.RadioButton();
            this.rbMaintenance = new System.Windows.Forms.RadioButton();
            this.rbFlightBooking = new System.Windows.Forms.RadioButton();
            this.rbAcco = new System.Windows.Forms.RadioButton();
            this.rbDocumentation = new System.Windows.Forms.RadioButton();
            this.rbRecruitment = new System.Windows.Forms.RadioButton();
            this.rbJobOrderManagement = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucFlightBooking = new Findstaff.ucFlightBooking();
            this.ucJobOrderManagement = new Findstaff.ucJobOrderManagement();
            this.ucMaintenance = new Findstaff.ucMaintenance();
            this.ucRecruitment = new Findstaff.ucRecruitment();
            this.ucAcco = new Findstaff.ucAcco();
            this.ucDocumentation = new Findstaff.ucDocumentation();
            this.btnX = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.ucReports = new Findstaff.ucReports();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(220, 169);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 23);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "name";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.BackColor = System.Drawing.Color.Transparent;
            this.lblDept.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(220, 192);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(52, 23);
            this.lblDept.TabIndex = 16;
            this.lblDept.Text = "dept";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbReports);
            this.panel1.Controls.Add(this.rbMaintenance);
            this.panel1.Controls.Add(this.rbFlightBooking);
            this.panel1.Controls.Add(this.rbAcco);
            this.panel1.Controls.Add(this.rbDocumentation);
            this.panel1.Controls.Add(this.rbRecruitment);
            this.panel1.Controls.Add(this.rbJobOrderManagement);
            this.panel1.Location = new System.Drawing.Point(25, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 17;
            // 
            // rbReports
            // 
            this.rbReports.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbReports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbReports.FlatAppearance.BorderSize = 0;
            this.rbReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbReports.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReports.ForeColor = System.Drawing.Color.White;
            this.rbReports.Location = new System.Drawing.Point(0, 298);
            this.rbReports.Name = "rbReports";
            this.rbReports.Size = new System.Drawing.Size(200, 48);
            this.rbReports.TabIndex = 14;
            this.rbReports.Text = "Reports";
            this.rbReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbReports.UseVisualStyleBackColor = false;
            this.rbReports.CheckedChanged += new System.EventHandler(this.rbReports_CheckedChanged);
            // 
            // rbMaintenance
            // 
            this.rbMaintenance.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbMaintenance.FlatAppearance.BorderSize = 0;
            this.rbMaintenance.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbMaintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMaintenance.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaintenance.ForeColor = System.Drawing.Color.White;
            this.rbMaintenance.Location = new System.Drawing.Point(0, 250);
            this.rbMaintenance.Name = "rbMaintenance";
            this.rbMaintenance.Size = new System.Drawing.Size(200, 48);
            this.rbMaintenance.TabIndex = 13;
            this.rbMaintenance.Text = "Maintenance";
            this.rbMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMaintenance.UseVisualStyleBackColor = false;
            this.rbMaintenance.CheckedChanged += new System.EventHandler(this.rbMaintenance_CheckedChanged);
            // 
            // rbFlightBooking
            // 
            this.rbFlightBooking.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFlightBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbFlightBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbFlightBooking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbFlightBooking.FlatAppearance.BorderSize = 0;
            this.rbFlightBooking.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbFlightBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbFlightBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbFlightBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbFlightBooking.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFlightBooking.ForeColor = System.Drawing.Color.White;
            this.rbFlightBooking.Location = new System.Drawing.Point(0, 200);
            this.rbFlightBooking.Name = "rbFlightBooking";
            this.rbFlightBooking.Size = new System.Drawing.Size(200, 50);
            this.rbFlightBooking.TabIndex = 11;
            this.rbFlightBooking.TabStop = true;
            this.rbFlightBooking.Text = "Flight Booking";
            this.rbFlightBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbFlightBooking.UseVisualStyleBackColor = false;
            this.rbFlightBooking.CheckedChanged += new System.EventHandler(this.rbFlightBooking_CheckedChanged);
            // 
            // rbAcco
            // 
            this.rbAcco.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAcco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbAcco.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbAcco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbAcco.FlatAppearance.BorderSize = 0;
            this.rbAcco.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbAcco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbAcco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbAcco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAcco.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAcco.ForeColor = System.Drawing.Color.White;
            this.rbAcco.Location = new System.Drawing.Point(0, 150);
            this.rbAcco.Name = "rbAcco";
            this.rbAcco.Size = new System.Drawing.Size(200, 50);
            this.rbAcco.TabIndex = 10;
            this.rbAcco.TabStop = true;
            this.rbAcco.Text = "Accounting";
            this.rbAcco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAcco.UseVisualStyleBackColor = false;
            this.rbAcco.CheckedChanged += new System.EventHandler(this.rbAcco_CheckedChanged);
            // 
            // rbDocumentation
            // 
            this.rbDocumentation.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDocumentation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbDocumentation.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbDocumentation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbDocumentation.FlatAppearance.BorderSize = 0;
            this.rbDocumentation.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbDocumentation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbDocumentation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbDocumentation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDocumentation.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocumentation.ForeColor = System.Drawing.Color.White;
            this.rbDocumentation.Location = new System.Drawing.Point(0, 100);
            this.rbDocumentation.Name = "rbDocumentation";
            this.rbDocumentation.Size = new System.Drawing.Size(200, 50);
            this.rbDocumentation.TabIndex = 9;
            this.rbDocumentation.TabStop = true;
            this.rbDocumentation.Text = "Documentation";
            this.rbDocumentation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbDocumentation.UseVisualStyleBackColor = false;
            this.rbDocumentation.CheckedChanged += new System.EventHandler(this.rbDocumentation_CheckedChanged);
            // 
            // rbRecruitment
            // 
            this.rbRecruitment.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRecruitment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbRecruitment.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbRecruitment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbRecruitment.FlatAppearance.BorderSize = 0;
            this.rbRecruitment.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbRecruitment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbRecruitment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbRecruitment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRecruitment.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecruitment.ForeColor = System.Drawing.Color.White;
            this.rbRecruitment.Location = new System.Drawing.Point(0, 50);
            this.rbRecruitment.Name = "rbRecruitment";
            this.rbRecruitment.Size = new System.Drawing.Size(200, 50);
            this.rbRecruitment.TabIndex = 8;
            this.rbRecruitment.TabStop = true;
            this.rbRecruitment.Text = "Recruitment";
            this.rbRecruitment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRecruitment.UseVisualStyleBackColor = false;
            this.rbRecruitment.CheckedChanged += new System.EventHandler(this.rbRecruitment_CheckedChanged);
            // 
            // rbJobOrderManagement
            // 
            this.rbJobOrderManagement.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobOrderManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbJobOrderManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbJobOrderManagement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobOrderManagement.FlatAppearance.BorderSize = 0;
            this.rbJobOrderManagement.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobOrderManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobOrderManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobOrderManagement.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJobOrderManagement.ForeColor = System.Drawing.Color.White;
            this.rbJobOrderManagement.Location = new System.Drawing.Point(0, 0);
            this.rbJobOrderManagement.Name = "rbJobOrderManagement";
            this.rbJobOrderManagement.Size = new System.Drawing.Size(200, 50);
            this.rbJobOrderManagement.TabIndex = 7;
            this.rbJobOrderManagement.TabStop = true;
            this.rbJobOrderManagement.Text = "Job Order Management";
            this.rbJobOrderManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobOrderManagement.UseVisualStyleBackColor = false;
            this.rbJobOrderManagement.CheckedChanged += new System.EventHandler(this.rbJobOrderManagement_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ucReports);
            this.panel2.Controls.Add(this.ucFlightBooking);
            this.panel2.Controls.Add(this.ucJobOrderManagement);
            this.panel2.Controls.Add(this.ucMaintenance);
            this.panel2.Controls.Add(this.ucRecruitment);
            this.panel2.Controls.Add(this.ucAcco);
            this.panel2.Controls.Add(this.ucDocumentation);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(224, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 500);
            this.panel2.TabIndex = 18;
            // 
            // ucFlightBooking
            // 
            this.ucFlightBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucFlightBooking.Location = new System.Drawing.Point(3, 250);
            this.ucFlightBooking.Name = "ucFlightBooking";
            this.ucFlightBooking.Size = new System.Drawing.Size(200, 50);
            this.ucFlightBooking.TabIndex = 6;
            this.ucFlightBooking.Visible = false;
            // 
            // ucJobOrderManagement
            // 
            this.ucJobOrderManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucJobOrderManagement.Location = new System.Drawing.Point(3, 50);
            this.ucJobOrderManagement.Name = "ucJobOrderManagement";
            this.ucJobOrderManagement.Size = new System.Drawing.Size(200, 50);
            this.ucJobOrderManagement.TabIndex = 5;
            this.ucJobOrderManagement.Visible = false;
            // 
            // ucMaintenance
            // 
            this.ucMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucMaintenance.Location = new System.Drawing.Point(3, 298);
            this.ucMaintenance.Name = "ucMaintenance";
            this.ucMaintenance.Size = new System.Drawing.Size(200, 50);
            this.ucMaintenance.TabIndex = 4;
            this.ucMaintenance.Visible = false;
            // 
            // ucRecruitment
            // 
            this.ucRecruitment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucRecruitment.Location = new System.Drawing.Point(3, 100);
            this.ucRecruitment.Name = "ucRecruitment";
            this.ucRecruitment.Size = new System.Drawing.Size(200, 50);
            this.ucRecruitment.TabIndex = 3;
            this.ucRecruitment.Visible = false;
            // 
            // ucAcco
            // 
            this.ucAcco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucAcco.ForeColor = System.Drawing.Color.Black;
            this.ucAcco.Location = new System.Drawing.Point(3, 200);
            this.ucAcco.Name = "ucAcco";
            this.ucAcco.Size = new System.Drawing.Size(200, 50);
            this.ucAcco.TabIndex = 2;
            this.ucAcco.Visible = false;
            // 
            // ucDocumentation
            // 
            this.ucDocumentation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucDocumentation.Location = new System.Drawing.Point(3, 150);
            this.ucDocumentation.Name = "ucDocumentation";
            this.ucDocumentation.Size = new System.Drawing.Size(200, 50);
            this.ucDocumentation.TabIndex = 1;
            this.ucDocumentation.Visible = false;
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
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1242, 94);
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
            this.lblTime.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1066, 169);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 23);
            this.lblTime.TabIndex = 24;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1066, 192);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 23);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(551, 733);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(276, 32);
            this.lblCopyright.TabIndex = 27;
            this.lblCopyright.Text = "©2017 Polytechnic University of the Philippines\r\nBachelor of Science in Informati" +
    "on Technology";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopyright.Visible = false;
            // 
            // ucReports
            // 
            this.ucReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucReports.Location = new System.Drawing.Point(3, 348);
            this.ucReports.Name = "ucReports";
            this.ucReports.Size = new System.Drawing.Size(200, 48);
            this.ucReports.TabIndex = 7;
            this.ucReports.Visible = false;
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
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyright;
        public ucAcco ucAcco;
        public ucDocumentation ucDocumentation;
        public ucRecruitment ucRecruitment;
        public ucMaintenance ucMaintenance;
        private ucJobOrderManagement ucJobOrderManagement;
        public System.Windows.Forms.RadioButton rbAcco;
        public System.Windows.Forms.RadioButton rbDocumentation;
        public System.Windows.Forms.RadioButton rbRecruitment;
        private System.Windows.Forms.RadioButton rbMaintenance;
        public System.Windows.Forms.RadioButton rbFlightBooking;
        private ucFlightBooking ucFlightBooking;
        private System.Windows.Forms.RadioButton rbReports;
        private ucReports ucReports;
    }
}