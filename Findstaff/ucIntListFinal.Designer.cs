namespace Findstaff
{
    partial class ucIntListFinal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvIntervieweeList = new System.Windows.Forms.DataGridView();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblJobOrder = new System.Windows.Forms.Label();
            this.lblIntervieweeList = new System.Windows.Forms.Label();
            this.employer = new System.Windows.Forms.Label();
            this.joborder = new System.Windows.Forms.Label();
            this.jobname = new System.Windows.Forms.Label();
            this.btnPassInt = new System.Windows.Forms.Button();
            this.btnFailInt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervieweeList)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervieweeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvIntervieweeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntervieweeList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvIntervieweeList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvIntervieweeList.Location = new System.Drawing.Point(53, 106);
            this.dgvIntervieweeList.MultiSelect = false;
            this.dgvIntervieweeList.Name = "dgvIntervieweeList";
            this.dgvIntervieweeList.ReadOnly = true;
            this.dgvIntervieweeList.RowHeadersVisible = false;
            this.dgvIntervieweeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvIntervieweeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntervieweeList.Size = new System.Drawing.Size(1056, 327);
            this.dgvIntervieweeList.TabIndex = 51;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.Location = new System.Drawing.Point(448, 74);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(43, 20);
            this.lblJob.TabIndex = 50;
            this.lblJob.Text = "Job :";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.Black;
            this.lblEmp.Location = new System.Drawing.Point(761, 74);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(89, 20);
            this.lblEmp.TabIndex = 49;
            this.lblEmp.Text = "Employer :";
            // 
            // lblJobOrder
            // 
            this.lblJobOrder.AutoSize = true;
            this.lblJobOrder.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobOrder.ForeColor = System.Drawing.Color.Black;
            this.lblJobOrder.Location = new System.Drawing.Point(100, 74);
            this.lblJobOrder.Name = "lblJobOrder";
            this.lblJobOrder.Size = new System.Drawing.Size(90, 20);
            this.lblJobOrder.TabIndex = 48;
            this.lblJobOrder.Text = "Job Order :";
            // 
            // lblIntervieweeList
            // 
            this.lblIntervieweeList.AutoSize = true;
            this.lblIntervieweeList.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervieweeList.ForeColor = System.Drawing.Color.Black;
            this.lblIntervieweeList.Location = new System.Drawing.Point(25, 25);
            this.lblIntervieweeList.Name = "lblIntervieweeList";
            this.lblIntervieweeList.Size = new System.Drawing.Size(212, 28);
            this.lblIntervieweeList.TabIndex = 47;
            this.lblIntervieweeList.Text = "Interviewee List";
            // 
            // employer
            // 
            this.employer.AutoSize = true;
            this.employer.BackColor = System.Drawing.Color.Transparent;
            this.employer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer.ForeColor = System.Drawing.Color.Black;
            this.employer.Location = new System.Drawing.Point(857, 74);
            this.employer.Name = "employer";
            this.employer.Size = new System.Drawing.Size(77, 20);
            this.employer.TabIndex = 487;
            this.employer.Text = "employer";
            // 
            // joborder
            // 
            this.joborder.AutoSize = true;
            this.joborder.BackColor = System.Drawing.Color.Transparent;
            this.joborder.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joborder.ForeColor = System.Drawing.Color.Black;
            this.joborder.Location = new System.Drawing.Point(198, 74);
            this.joborder.Name = "joborder";
            this.joborder.Size = new System.Drawing.Size(70, 20);
            this.joborder.TabIndex = 486;
            this.joborder.Text = "joborder";
            // 
            // jobname
            // 
            this.jobname.AutoSize = true;
            this.jobname.BackColor = System.Drawing.Color.Transparent;
            this.jobname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobname.ForeColor = System.Drawing.Color.Black;
            this.jobname.Location = new System.Drawing.Point(496, 74);
            this.jobname.Name = "jobname";
            this.jobname.Size = new System.Drawing.Size(72, 20);
            this.jobname.TabIndex = 485;
            this.jobname.Text = "jobname";
            // 
            // btnPassInt
            // 
            this.btnPassInt.BackColor = System.Drawing.Color.White;
            this.btnPassInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPassInt.FlatAppearance.BorderSize = 0;
            this.btnPassInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassInt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassInt.ForeColor = System.Drawing.Color.Black;
            this.btnPassInt.Location = new System.Drawing.Point(267, 450);
            this.btnPassInt.Name = "btnPassInt";
            this.btnPassInt.Size = new System.Drawing.Size(238, 38);
            this.btnPassInt.TabIndex = 52;
            this.btnPassInt.Text = "PASS INTERVIEWEE";
            this.btnPassInt.UseVisualStyleBackColor = false;
            this.btnPassInt.Click += new System.EventHandler(this.btnPassInt_Click);
            // 
            // btnFailInt
            // 
            this.btnFailInt.BackColor = System.Drawing.Color.White;
            this.btnFailInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFailInt.FlatAppearance.BorderSize = 0;
            this.btnFailInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailInt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFailInt.ForeColor = System.Drawing.Color.Black;
            this.btnFailInt.Location = new System.Drawing.Point(511, 450);
            this.btnFailInt.Name = "btnFailInt";
            this.btnFailInt.Size = new System.Drawing.Size(238, 38);
            this.btnFailInt.TabIndex = 53;
            this.btnFailInt.Text = "FAIL INTERVIEWEE";
            this.btnFailInt.UseVisualStyleBackColor = false;
            this.btnFailInt.Click += new System.EventHandler(this.btnFailInt_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(755, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 38);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucIntListFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.employer);
            this.Controls.Add(this.joborder);
            this.Controls.Add(this.jobname);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFailInt);
            this.Controls.Add(this.btnPassInt);
            this.Controls.Add(this.dgvIntervieweeList);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblJobOrder);
            this.Controls.Add(this.lblIntervieweeList);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucIntListFinal";
            this.Size = new System.Drawing.Size(1155, 500);
            this.Load += new System.EventHandler(this.ucIntListFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervieweeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblJobOrder;
        private System.Windows.Forms.Label lblIntervieweeList;
        public System.Windows.Forms.DataGridView dgvIntervieweeList;
        private System.Windows.Forms.Button btnPassInt;
        private System.Windows.Forms.Button btnFailInt;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label employer;
        public System.Windows.Forms.Label joborder;
        public System.Windows.Forms.Label jobname;
    }
}
