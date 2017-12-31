namespace Findstaff
{
    partial class ucJobOrderManagement
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
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.rbJobFees = new System.Windows.Forms.RadioButton();
            this.rbJobList = new System.Windows.Forms.RadioButton();
            this.rbEmployer = new System.Windows.Forms.RadioButton();
            this.ucJobFees = new Findstaff.ucJobFees();
            this.ucEmployer = new Findstaff.ucEmployer();
            this.ucJobList = new Findstaff.ucJobList();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Controls.Add(this.rbJobFees);
            this.pnlTabs.Controls.Add(this.rbJobList);
            this.pnlTabs.Controls.Add(this.rbEmployer);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 32;
            // 
            // rbJobFees
            // 
            this.rbJobFees.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbJobFees.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobFees.FlatAppearance.BorderSize = 0;
            this.rbJobFees.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobFees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobFees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobFees.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.rbJobFees.ForeColor = System.Drawing.Color.White;
            this.rbJobFees.Location = new System.Drawing.Point(213, 10);
            this.rbJobFees.Name = "rbJobFees";
            this.rbJobFees.Size = new System.Drawing.Size(100, 40);
            this.rbJobFees.TabIndex = 4;
            this.rbJobFees.Text = "Job Fees";
            this.rbJobFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobFees.UseVisualStyleBackColor = false;
            this.rbJobFees.CheckedChanged += new System.EventHandler(this.rbJobFees_CheckedChanged);
            // 
            // rbJobList
            // 
            this.rbJobList.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbJobList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobList.FlatAppearance.BorderSize = 0;
            this.rbJobList.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobList.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.rbJobList.ForeColor = System.Drawing.Color.White;
            this.rbJobList.Location = new System.Drawing.Point(107, 10);
            this.rbJobList.Name = "rbJobList";
            this.rbJobList.Size = new System.Drawing.Size(100, 40);
            this.rbJobList.TabIndex = 3;
            this.rbJobList.Text = "Job Order";
            this.rbJobList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobList.UseVisualStyleBackColor = false;
            this.rbJobList.CheckedChanged += new System.EventHandler(this.rbJobList_CheckedChanged);
            // 
            // rbEmployer
            // 
            this.rbEmployer.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEmployer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbEmployer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbEmployer.FlatAppearance.BorderSize = 0;
            this.rbEmployer.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbEmployer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbEmployer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbEmployer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEmployer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.rbEmployer.ForeColor = System.Drawing.Color.White;
            this.rbEmployer.Location = new System.Drawing.Point(0, 10);
            this.rbEmployer.Name = "rbEmployer";
            this.rbEmployer.Size = new System.Drawing.Size(100, 40);
            this.rbEmployer.TabIndex = 1;
            this.rbEmployer.Text = "Employer";
            this.rbEmployer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEmployer.UseVisualStyleBackColor = false;
            this.rbEmployer.CheckedChanged += new System.EventHandler(this.rbEmployer_CheckedChanged);
            // 
            // ucJobFees
            // 
            this.ucJobFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucJobFees.ForeColor = System.Drawing.Color.Black;
            this.ucJobFees.Location = new System.Drawing.Point(213, 56);
            this.ucJobFees.Name = "ucJobFees";
            this.ucJobFees.Size = new System.Drawing.Size(100, 100);
            this.ucJobFees.TabIndex = 39;
            // 
            // ucEmployer
            // 
            this.ucEmployer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucEmployer.ForeColor = System.Drawing.Color.Black;
            this.ucEmployer.Location = new System.Drawing.Point(0, 56);
            this.ucEmployer.Name = "ucEmployer";
            this.ucEmployer.Size = new System.Drawing.Size(100, 100);
            this.ucEmployer.TabIndex = 37;
            // 
            // ucJobList
            // 
            this.ucJobList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucJobList.ForeColor = System.Drawing.Color.Black;
            this.ucJobList.Location = new System.Drawing.Point(107, 56);
            this.ucJobList.Name = "ucJobList";
            this.ucJobList.Size = new System.Drawing.Size(100, 100);
            this.ucJobList.TabIndex = 38;
            // 
            // ucJobOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucJobFees);
            this.Controls.Add(this.ucJobList);
            this.Controls.Add(this.ucEmployer);
            this.Controls.Add(this.pnlTabs);
            this.Name = "ucJobOrderManagement";
            this.Size = new System.Drawing.Size(1118, 500);
            this.VisibleChanged += new System.EventHandler(this.ucJobOrderManagement_VisibleChanged);
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.RadioButton rbJobFees;
        private System.Windows.Forms.RadioButton rbJobList;
        private System.Windows.Forms.RadioButton rbEmployer;
        private ucEmployer ucEmployer;
        private ucJobFees ucJobFees;
        private ucJobList ucJobList;
    }
}
