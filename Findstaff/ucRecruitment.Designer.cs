namespace Findstaff
{
    partial class ucRecruitment
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
            this.rbJobApplicant = new System.Windows.Forms.RadioButton();
            this.rbApplicantList = new System.Windows.Forms.RadioButton();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.rbInterviewFin = new System.Windows.Forms.RadioButton();
            this.rbInterviewInit = new System.Windows.Forms.RadioButton();
            this.ucJobApp = new Findstaff.ucJobApp();
            this.ucAppList = new Findstaff.ucAppList();
            this.ucInterviewInit = new Findstaff.ucInterviewInit();
            this.ucInterviewFin = new Findstaff.ucInterviewFin();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbJobApplicant
            // 
            this.rbJobApplicant.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobApplicant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbJobApplicant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobApplicant.FlatAppearance.BorderSize = 0;
            this.rbJobApplicant.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobApplicant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobApplicant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobApplicant.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJobApplicant.ForeColor = System.Drawing.Color.White;
            this.rbJobApplicant.Location = new System.Drawing.Point(216, 10);
            this.rbJobApplicant.Name = "rbJobApplicant";
            this.rbJobApplicant.Size = new System.Drawing.Size(320, 40);
            this.rbJobApplicant.TabIndex = 2;
            this.rbJobApplicant.Text = "Applicant Matching / Job Suggestion";
            this.rbJobApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobApplicant.UseVisualStyleBackColor = false;
            this.rbJobApplicant.CheckedChanged += new System.EventHandler(this.rbJobApplicant_CheckedChanged);
            // 
            // rbApplicantList
            // 
            this.rbApplicantList.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbApplicantList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbApplicantList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbApplicantList.FlatAppearance.BorderSize = 0;
            this.rbApplicantList.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbApplicantList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbApplicantList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbApplicantList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbApplicantList.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApplicantList.ForeColor = System.Drawing.Color.White;
            this.rbApplicantList.Location = new System.Drawing.Point(10, 10);
            this.rbApplicantList.Name = "rbApplicantList";
            this.rbApplicantList.Size = new System.Drawing.Size(200, 40);
            this.rbApplicantList.TabIndex = 1;
            this.rbApplicantList.Text = "Applicant List";
            this.rbApplicantList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbApplicantList.UseVisualStyleBackColor = false;
            this.rbApplicantList.CheckedChanged += new System.EventHandler(this.rbApplicantList_CheckedChanged);
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTabs.Controls.Add(this.rbInterviewFin);
            this.pnlTabs.Controls.Add(this.rbInterviewInit);
            this.pnlTabs.Controls.Add(this.rbJobApplicant);
            this.pnlTabs.Controls.Add(this.rbApplicantList);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 30;
            // 
            // rbInterviewFin
            // 
            this.rbInterviewFin.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbInterviewFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbInterviewFin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbInterviewFin.FlatAppearance.BorderSize = 0;
            this.rbInterviewFin.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbInterviewFin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbInterviewFin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbInterviewFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbInterviewFin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInterviewFin.ForeColor = System.Drawing.Color.White;
            this.rbInterviewFin.Location = new System.Drawing.Point(748, 10);
            this.rbInterviewFin.Name = "rbInterviewFin";
            this.rbInterviewFin.Size = new System.Drawing.Size(200, 40);
            this.rbInterviewFin.TabIndex = 4;
            this.rbInterviewFin.Text = "Final Interview";
            this.rbInterviewFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbInterviewFin.UseVisualStyleBackColor = false;
            this.rbInterviewFin.CheckedChanged += new System.EventHandler(this.rbInterviewFin_CheckedChanged);
            // 
            // rbInterviewInit
            // 
            this.rbInterviewInit.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbInterviewInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbInterviewInit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbInterviewInit.FlatAppearance.BorderSize = 0;
            this.rbInterviewInit.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbInterviewInit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbInterviewInit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbInterviewInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbInterviewInit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInterviewInit.ForeColor = System.Drawing.Color.White;
            this.rbInterviewInit.Location = new System.Drawing.Point(542, 10);
            this.rbInterviewInit.Name = "rbInterviewInit";
            this.rbInterviewInit.Size = new System.Drawing.Size(200, 40);
            this.rbInterviewInit.TabIndex = 3;
            this.rbInterviewInit.Text = "Initial Interview";
            this.rbInterviewInit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbInterviewInit.UseVisualStyleBackColor = false;
            this.rbInterviewInit.CheckedChanged += new System.EventHandler(this.rbInterview_CheckedChanged);
            // 
            // ucJobApp
            // 
            this.ucJobApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucJobApp.Location = new System.Drawing.Point(216, 56);
            this.ucJobApp.Name = "ucJobApp";
            this.ucJobApp.Size = new System.Drawing.Size(320, 320);
            this.ucJobApp.TabIndex = 32;
            this.ucJobApp.Visible = false;
            // 
            // ucAppList
            // 
            this.ucAppList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucAppList.Location = new System.Drawing.Point(10, 56);
            this.ucAppList.Name = "ucAppList";
            this.ucAppList.Size = new System.Drawing.Size(200, 200);
            this.ucAppList.TabIndex = 31;
            this.ucAppList.Visible = false;
            // 
            // ucInterviewInit
            // 
            this.ucInterviewInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucInterviewInit.Location = new System.Drawing.Point(542, 56);
            this.ucInterviewInit.Name = "ucInterviewInit";
            this.ucInterviewInit.Size = new System.Drawing.Size(200, 200);
            this.ucInterviewInit.TabIndex = 33;
            this.ucInterviewInit.Visible = false;
            // 
            // ucInterviewFin
            // 
            this.ucInterviewFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucInterviewFin.Location = new System.Drawing.Point(748, 56);
            this.ucInterviewFin.Name = "ucInterviewFin";
            this.ucInterviewFin.Size = new System.Drawing.Size(200, 200);
            this.ucInterviewFin.TabIndex = 34;
            this.ucInterviewFin.Visible = false;
            // 
            // ucRecruitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucInterviewFin);
            this.Controls.Add(this.ucInterviewInit);
            this.Controls.Add(this.ucJobApp);
            this.Controls.Add(this.ucAppList);
            this.Controls.Add(this.pnlTabs);
            this.Name = "ucRecruitment";
            this.Size = new System.Drawing.Size(1118, 500);
            this.VisibleChanged += new System.EventHandler(this.ucRecruitment_VisibleChanged);
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbJobApplicant;
        private System.Windows.Forms.RadioButton rbApplicantList;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.RadioButton rbInterviewInit;
        private ucAppList ucAppList;
        private ucJobApp ucJobApp;
        private System.Windows.Forms.RadioButton rbInterviewFin;
        private ucInterviewInit ucInterviewInit;
        private ucInterviewFin ucInterviewFin;
    }
}
