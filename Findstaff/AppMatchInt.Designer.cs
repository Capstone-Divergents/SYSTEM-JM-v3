namespace Findstaff
{
    partial class InitialInterviewDate
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
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.White;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.ForeColor = System.Drawing.Color.Black;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(394, 74);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(110, 28);
            this.cbYear.TabIndex = 53;
            // 
            // cbDay
            // 
            this.cbDay.BackColor = System.Drawing.Color.White;
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDay.ForeColor = System.Drawing.Color.Black;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(311, 73);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(77, 28);
            this.cbDay.TabIndex = 52;
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.Color.White;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.ForeColor = System.Drawing.Color.Black;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(105, 73);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(200, 28);
            this.cbMonth.TabIndex = 51;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.Location = new System.Drawing.Point(51, 77);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(48, 20);
            this.lblJob.TabIndex = 50;
            this.lblJob.Text = "Date:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(137, 23);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(260, 23);
            this.lblCountry.TabIndex = 49;
            this.lblCountry.Text = "Date for Initial Interview";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(282, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 33);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.White;
            this.btnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.Black;
            this.btnSchedule.Location = new System.Drawing.Point(152, 133);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(124, 33);
            this.btnSchedule.TabIndex = 56;
            this.btnSchedule.Text = "SCHEDULE";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // InitialInterviewDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(554, 184);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitialInterviewDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InitialInterviewDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSchedule;
    }
}