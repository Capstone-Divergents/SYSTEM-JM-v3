﻿namespace Findstaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFailInt = new System.Windows.Forms.Button();
            this.btnPassInt = new System.Windows.Forms.Button();
            this.dgvIntervieweeList = new System.Windows.Forms.DataGridView();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblJobOrder = new System.Windows.Forms.Label();
            this.lblIntervieweeList = new System.Windows.Forms.Label();
            this.employer = new System.Windows.Forms.Label();
            this.joborder = new System.Windows.Forms.Label();
            this.jobname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervieweeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(509, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFailInt
            // 
            this.btnFailInt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFailInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFailInt.FlatAppearance.BorderSize = 0;
            this.btnFailInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailInt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFailInt.ForeColor = System.Drawing.Color.Black;
            this.btnFailInt.Location = new System.Drawing.Point(563, 366);
            this.btnFailInt.Name = "btnFailInt";
            this.btnFailInt.Size = new System.Drawing.Size(200, 30);
            this.btnFailInt.TabIndex = 53;
            this.btnFailInt.Text = "FAIL INTERVIEWEE";
            this.btnFailInt.UseVisualStyleBackColor = false;
            this.btnFailInt.Click += new System.EventHandler(this.btnFailInt_Click);
            // 
            // btnPassInt
            // 
            this.btnPassInt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPassInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPassInt.FlatAppearance.BorderSize = 0;
            this.btnPassInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassInt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassInt.ForeColor = System.Drawing.Color.Black;
            this.btnPassInt.Location = new System.Drawing.Point(357, 366);
            this.btnPassInt.Name = "btnPassInt";
            this.btnPassInt.Size = new System.Drawing.Size(200, 30);
            this.btnPassInt.TabIndex = 52;
            this.btnPassInt.Text = "PASS INTERVIEWEE";
            this.btnPassInt.UseVisualStyleBackColor = false;
            this.btnPassInt.Click += new System.EventHandler(this.btnPassInt_Click);
            // 
            // dgvIntervieweeList
            // 
            this.dgvIntervieweeList.AllowUserToAddRows = false;
            this.dgvIntervieweeList.AllowUserToDeleteRows = false;
            this.dgvIntervieweeList.AllowUserToResizeColumns = false;
            this.dgvIntervieweeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvIntervieweeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIntervieweeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntervieweeList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvIntervieweeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervieweeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIntervieweeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntervieweeList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIntervieweeList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvIntervieweeList.Location = new System.Drawing.Point(100, 140);
            this.dgvIntervieweeList.MultiSelect = false;
            this.dgvIntervieweeList.Name = "dgvIntervieweeList";
            this.dgvIntervieweeList.ReadOnly = true;
            this.dgvIntervieweeList.RowHeadersVisible = false;
            this.dgvIntervieweeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvIntervieweeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntervieweeList.Size = new System.Drawing.Size(918, 200);
            this.dgvIntervieweeList.TabIndex = 51;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.Location = new System.Drawing.Point(448, 100);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(42, 19);
            this.lblJob.TabIndex = 50;
            this.lblJob.Text = "Job :";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.Black;
            this.lblEmp.Location = new System.Drawing.Point(761, 100);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(90, 19);
            this.lblEmp.TabIndex = 49;
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
            this.lblJobOrder.TabIndex = 48;
            this.lblJobOrder.Text = "Job Order :";
            // 
            // lblIntervieweeList
            // 
            this.lblIntervieweeList.AutoSize = true;
            this.lblIntervieweeList.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervieweeList.ForeColor = System.Drawing.Color.Black;
            this.lblIntervieweeList.Location = new System.Drawing.Point(25, 25);
            this.lblIntervieweeList.Name = "lblIntervieweeList";
            this.lblIntervieweeList.Size = new System.Drawing.Size(269, 39);
            this.lblIntervieweeList.TabIndex = 47;
            this.lblIntervieweeList.Text = "Interviewee List";
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
            this.employer.TabIndex = 487;
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
            this.joborder.TabIndex = 486;
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
            this.jobname.TabIndex = 485;
            this.jobname.Text = "jobname";
            // 
            // ucIntListFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.Name = "ucIntListFinal";
            this.Size = new System.Drawing.Size(1118, 450);
            this.Load += new System.EventHandler(this.ucIntListFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervieweeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFailInt;
        private System.Windows.Forms.Button btnPassInt;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblJobOrder;
        private System.Windows.Forms.Label lblIntervieweeList;
        public System.Windows.Forms.DataGridView dgvIntervieweeList;
        private System.Windows.Forms.Label employer;
        private System.Windows.Forms.Label joborder;
        private System.Windows.Forms.Label jobname;
    }
}
