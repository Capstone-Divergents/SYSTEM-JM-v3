namespace Findstaff
{
    partial class ucIntListInit
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
            this.lblIntervieweeList = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblJobOrder = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.dgvIntervieweeList = new System.Windows.Forms.DataGridView();
            this.employer = new System.Windows.Forms.Label();
            this.joborder = new System.Windows.Forms.Label();
            this.jobname = new System.Windows.Forms.Label();
            this.btnIntApp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucInterviewCriteria = new Findstaff.ucInterviewCriteria();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervieweeList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntervieweeList
            // 
            this.lblIntervieweeList.AutoSize = true;
            this.lblIntervieweeList.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervieweeList.ForeColor = System.Drawing.Color.Black;
            this.lblIntervieweeList.Location = new System.Drawing.Point(25, 25);
            this.lblIntervieweeList.Name = "lblIntervieweeList";
            this.lblIntervieweeList.Size = new System.Drawing.Size(269, 39);
            this.lblIntervieweeList.TabIndex = 39;
            this.lblIntervieweeList.Text = "Interviewee List";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.Black;
            this.lblEmp.Location = new System.Drawing.Point(761, 100);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(90, 19);
            this.lblEmp.TabIndex = 41;
            this.lblEmp.Text = "Employer :";
            // 
            // lblJobOrder
            // 
            this.lblJobOrder.AutoSize = true;
            this.lblJobOrder.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobOrder.ForeColor = System.Drawing.Color.Black;
            this.lblJobOrder.Location = new System.Drawing.Point(100, 100);
            this.lblJobOrder.Name = "lblJobOrder";
            this.lblJobOrder.Size = new System.Drawing.Size(92, 19);
            this.lblJobOrder.TabIndex = 40;
            this.lblJobOrder.Text = "Job Order :";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.Location = new System.Drawing.Point(448, 100);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(42, 19);
            this.lblJob.TabIndex = 42;
            this.lblJob.Text = "Job :";
            // 
            // dgvIntervieweeList
            // 
            this.dgvIntervieweeList.AllowUserToAddRows = false;
            this.dgvIntervieweeList.AllowUserToDeleteRows = false;
            this.dgvIntervieweeList.AllowUserToResizeColumns = false;
            this.dgvIntervieweeList.AllowUserToResizeRows = false;
            this.dgvIntervieweeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntervieweeList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvIntervieweeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervieweeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIntervieweeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntervieweeList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIntervieweeList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvIntervieweeList.Location = new System.Drawing.Point(100, 140);
            this.dgvIntervieweeList.MultiSelect = false;
            this.dgvIntervieweeList.Name = "dgvIntervieweeList";
            this.dgvIntervieweeList.ReadOnly = true;
            this.dgvIntervieweeList.RowHeadersVisible = false;
            this.dgvIntervieweeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvIntervieweeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntervieweeList.Size = new System.Drawing.Size(918, 200);
            this.dgvIntervieweeList.TabIndex = 43;
            // 
            // employer
            // 
            this.employer.AutoSize = true;
            this.employer.BackColor = System.Drawing.Color.Transparent;
            this.employer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer.ForeColor = System.Drawing.Color.Black;
            this.employer.Location = new System.Drawing.Point(857, 100);
            this.employer.Name = "employer";
            this.employer.Size = new System.Drawing.Size(85, 19);
            this.employer.TabIndex = 490;
            this.employer.Text = "employer";
            // 
            // joborder
            // 
            this.joborder.AutoSize = true;
            this.joborder.BackColor = System.Drawing.Color.Transparent;
            this.joborder.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joborder.ForeColor = System.Drawing.Color.Black;
            this.joborder.Location = new System.Drawing.Point(198, 100);
            this.joborder.Name = "joborder";
            this.joborder.Size = new System.Drawing.Size(76, 19);
            this.joborder.TabIndex = 489;
            this.joborder.Text = "joborder";
            // 
            // jobname
            // 
            this.jobname.AutoSize = true;
            this.jobname.BackColor = System.Drawing.Color.Transparent;
            this.jobname.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobname.ForeColor = System.Drawing.Color.Black;
            this.jobname.Location = new System.Drawing.Point(496, 100);
            this.jobname.Name = "jobname";
            this.jobname.Size = new System.Drawing.Size(78, 19);
            this.jobname.TabIndex = 488;
            this.jobname.Text = "jobname";
            // 
            // btnIntApp
            // 
            this.btnIntApp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIntApp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIntApp.FlatAppearance.BorderSize = 0;
            this.btnIntApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntApp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntApp.ForeColor = System.Drawing.Color.Black;
            this.btnIntApp.Location = new System.Drawing.Point(425, 370);
            this.btnIntApp.Name = "btnIntApp";
            this.btnIntApp.Size = new System.Drawing.Size(150, 50);
            this.btnIntApp.TabIndex = 491;
            this.btnIntApp.Text = "INTERVIEW APPLICANT";
            this.btnIntApp.UseVisualStyleBackColor = false;
            this.btnIntApp.Click += new System.EventHandler(this.btnIntApp_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(581, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 492;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucInterviewCriteria
            // 
            this.ucInterviewCriteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucInterviewCriteria.Location = new System.Drawing.Point(0, 0);
            this.ucInterviewCriteria.Name = "ucInterviewCriteria";
            this.ucInterviewCriteria.Size = new System.Drawing.Size(10, 10);
            this.ucInterviewCriteria.TabIndex = 493;
            this.ucInterviewCriteria.Visible = false;
            // 
            // ucIntListInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucInterviewCriteria);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIntApp);
            this.Controls.Add(this.employer);
            this.Controls.Add(this.joborder);
            this.Controls.Add(this.jobname);
            this.Controls.Add(this.dgvIntervieweeList);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblJobOrder);
            this.Controls.Add(this.lblIntervieweeList);
            this.Name = "ucIntListInit";
            this.Size = new System.Drawing.Size(1118, 450);
            this.Load += new System.EventHandler(this.ucIntListInit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervieweeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntervieweeList;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblJobOrder;
        private System.Windows.Forms.Label lblJob;
        public System.Windows.Forms.DataGridView dgvIntervieweeList;
        private System.Windows.Forms.Label employer;
        private System.Windows.Forms.Label joborder;
        private System.Windows.Forms.Label jobname;
        private System.Windows.Forms.Button btnIntApp;
        private System.Windows.Forms.Button btnClose;
        private ucInterviewCriteria ucInterviewCriteria;
    }
}
