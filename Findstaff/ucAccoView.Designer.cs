namespace Findstaff
{
    partial class ucAccoView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblViewAcco = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblJobOrder = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.dgvViewAcco = new System.Windows.Forms.DataGridView();
            this.btnPayBal = new System.Windows.Forms.Button();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.applicant = new System.Windows.Forms.Label();
            this.jobname = new System.Windows.Forms.Label();
            this.joborder = new System.Windows.Forms.Label();
            this.employer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAcco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewAcco
            // 
            this.lblViewAcco.AutoSize = true;
            this.lblViewAcco.BackColor = System.Drawing.Color.Transparent;
            this.lblViewAcco.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAcco.ForeColor = System.Drawing.Color.Black;
            this.lblViewAcco.Location = new System.Drawing.Point(25, 75);
            this.lblViewAcco.Name = "lblViewAcco";
            this.lblViewAcco.Size = new System.Drawing.Size(229, 39);
            this.lblViewAcco.TabIndex = 0;
            this.lblViewAcco.Text = "View Account";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.BackColor = System.Drawing.Color.Transparent;
            this.lblApp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.ForeColor = System.Drawing.Color.Black;
            this.lblApp.Location = new System.Drawing.Point(100, 150);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(88, 19);
            this.lblApp.TabIndex = 1;
            this.lblApp.Text = "Applicant :";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.BackColor = System.Drawing.Color.Transparent;
            this.lblJobName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.ForeColor = System.Drawing.Color.Black;
            this.lblJobName.Location = new System.Drawing.Point(100, 180);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(90, 19);
            this.lblJobName.TabIndex = 2;
            this.lblJobName.Text = "Job Name :";
            // 
            // lblJobOrder
            // 
            this.lblJobOrder.AutoSize = true;
            this.lblJobOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblJobOrder.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobOrder.ForeColor = System.Drawing.Color.Black;
            this.lblJobOrder.Location = new System.Drawing.Point(600, 150);
            this.lblJobOrder.Name = "lblJobOrder";
            this.lblJobOrder.Size = new System.Drawing.Size(92, 19);
            this.lblJobOrder.TabIndex = 3;
            this.lblJobOrder.Text = "Job Order :";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblEmp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.Black;
            this.lblEmp.Location = new System.Drawing.Point(600, 180);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(90, 19);
            this.lblEmp.TabIndex = 4;
            this.lblEmp.Text = "Employer :";
            // 
            // dgvViewAcco
            // 
            this.dgvViewAcco.AllowUserToAddRows = false;
            this.dgvViewAcco.AllowUserToDeleteRows = false;
            this.dgvViewAcco.AllowUserToResizeColumns = false;
            this.dgvViewAcco.AllowUserToResizeRows = false;
            this.dgvViewAcco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewAcco.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvViewAcco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewAcco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewAcco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewAcco.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewAcco.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvViewAcco.Location = new System.Drawing.Point(100, 220);
            this.dgvViewAcco.Name = "dgvViewAcco";
            this.dgvViewAcco.ReadOnly = true;
            this.dgvViewAcco.RowHeadersVisible = false;
            this.dgvViewAcco.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvViewAcco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewAcco.Size = new System.Drawing.Size(918, 200);
            this.dgvViewAcco.TabIndex = 5;
            // 
            // btnPayBal
            // 
            this.btnPayBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPayBal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayBal.FlatAppearance.BorderSize = 0;
            this.btnPayBal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPayBal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPayBal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayBal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayBal.ForeColor = System.Drawing.Color.Black;
            this.btnPayBal.Location = new System.Drawing.Point(456, 435);
            this.btnPayBal.Name = "btnPayBal";
            this.btnPayBal.Size = new System.Drawing.Size(100, 50);
            this.btnPayBal.TabIndex = 6;
            this.btnPayBal.Text = "PAY BALANCE";
            this.btnPayBal.UseVisualStyleBackColor = false;
            this.btnPayBal.Click += new System.EventHandler(this.btnPayBal_Click);
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 60;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(562, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 61;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // applicant
            // 
            this.applicant.AutoSize = true;
            this.applicant.BackColor = System.Drawing.Color.Transparent;
            this.applicant.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicant.ForeColor = System.Drawing.Color.Black;
            this.applicant.Location = new System.Drawing.Point(194, 150);
            this.applicant.Name = "applicant";
            this.applicant.Size = new System.Drawing.Size(84, 19);
            this.applicant.TabIndex = 62;
            this.applicant.Text = "applicant";
            // 
            // jobname
            // 
            this.jobname.AutoSize = true;
            this.jobname.BackColor = System.Drawing.Color.Transparent;
            this.jobname.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobname.ForeColor = System.Drawing.Color.Black;
            this.jobname.Location = new System.Drawing.Point(196, 180);
            this.jobname.Name = "jobname";
            this.jobname.Size = new System.Drawing.Size(78, 19);
            this.jobname.TabIndex = 63;
            this.jobname.Text = "jobname";
            // 
            // joborder
            // 
            this.joborder.AutoSize = true;
            this.joborder.BackColor = System.Drawing.Color.Transparent;
            this.joborder.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joborder.ForeColor = System.Drawing.Color.Black;
            this.joborder.Location = new System.Drawing.Point(698, 150);
            this.joborder.Name = "joborder";
            this.joborder.Size = new System.Drawing.Size(76, 19);
            this.joborder.TabIndex = 64;
            this.joborder.Text = "joborder";
            // 
            // employer
            // 
            this.employer.AutoSize = true;
            this.employer.BackColor = System.Drawing.Color.Transparent;
            this.employer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer.ForeColor = System.Drawing.Color.Black;
            this.employer.Location = new System.Drawing.Point(696, 180);
            this.employer.Name = "employer";
            this.employer.Size = new System.Drawing.Size(85, 19);
            this.employer.TabIndex = 65;
            this.employer.Text = "employer";
            // 
            // ucAccoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.employer);
            this.Controls.Add(this.joborder);
            this.Controls.Add(this.jobname);
            this.Controls.Add(this.applicant);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.btnPayBal);
            this.Controls.Add(this.dgvViewAcco);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblJobOrder);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.lblViewAcco);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucAccoView";
            this.Size = new System.Drawing.Size(1118, 500);
            this.Load += new System.EventHandler(this.ucAccoView_Load);
            this.VisibleChanged += new System.EventHandler(this.ucAccoView_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAcco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewAcco;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblJobOrder;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Button btnPayBal;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView dgvViewAcco;
        public System.Windows.Forms.Label applicant;
        public System.Windows.Forms.Label jobname;
        public System.Windows.Forms.Label joborder;
        public System.Windows.Forms.Label employer;
    }
}
