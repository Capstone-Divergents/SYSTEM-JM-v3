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
            this.rbApplicant = new System.Windows.Forms.RadioButton();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.rbDocu = new System.Windows.Forms.RadioButton();
            this.rbInterviewFin = new System.Windows.Forms.RadioButton();
            this.rbInterviewInit = new System.Windows.Forms.RadioButton();
            this.ucDocumentation = new Findstaff.ucDocumentation();
            this.ucInterviewFin = new Findstaff.ucInterviewFin();
            this.ucInterviewInit = new Findstaff.ucInterviewInit();
            this.ucApplicant = new Findstaff.ucApplicant();
            this.ucJobApp = new Findstaff.ucJobApp();
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
            this.rbJobApplicant.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJobApplicant.ForeColor = System.Drawing.Color.White;
            this.rbJobApplicant.Location = new System.Drawing.Point(146, 10);
            this.rbJobApplicant.Name = "rbJobApplicant";
            this.rbJobApplicant.Size = new System.Drawing.Size(320, 40);
            this.rbJobApplicant.TabIndex = 2;
            this.rbJobApplicant.Text = "Applicant Matching / Job Suggestion";
            this.rbJobApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobApplicant.UseVisualStyleBackColor = false;
            this.rbJobApplicant.CheckedChanged += new System.EventHandler(this.rbJobApplicant_CheckedChanged);
            // 
            // rbApplicant
            // 
            this.rbApplicant.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbApplicant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbApplicant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbApplicant.FlatAppearance.BorderSize = 0;
            this.rbApplicant.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbApplicant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbApplicant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbApplicant.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApplicant.ForeColor = System.Drawing.Color.White;
            this.rbApplicant.Location = new System.Drawing.Point(0, 10);
            this.rbApplicant.Name = "rbApplicant";
            this.rbApplicant.Size = new System.Drawing.Size(139, 40);
            this.rbApplicant.TabIndex = 1;
            this.rbApplicant.Text = "Applicant";
            this.rbApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbApplicant.UseVisualStyleBackColor = false;
            this.rbApplicant.CheckedChanged += new System.EventHandler(this.rbApplicant_CheckedChanged);
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Controls.Add(this.rbDocu);
            this.pnlTabs.Controls.Add(this.rbInterviewFin);
            this.pnlTabs.Controls.Add(this.rbInterviewInit);
            this.pnlTabs.Controls.Add(this.rbJobApplicant);
            this.pnlTabs.Controls.Add(this.rbApplicant);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 30;
            // 
            // rbDocu
            // 
            this.rbDocu.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDocu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbDocu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbDocu.FlatAppearance.BorderSize = 0;
            this.rbDocu.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbDocu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbDocu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbDocu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDocu.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocu.ForeColor = System.Drawing.Color.White;
            this.rbDocu.Location = new System.Drawing.Point(800, 10);
            this.rbDocu.Name = "rbDocu";
            this.rbDocu.Size = new System.Drawing.Size(200, 40);
            this.rbDocu.TabIndex = 36;
            this.rbDocu.Text = "Documents Collection";
            this.rbDocu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbDocu.UseVisualStyleBackColor = false;
            this.rbDocu.CheckedChanged += new System.EventHandler(this.rbDocu_CheckedChanged);
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
            this.rbInterviewFin.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInterviewFin.ForeColor = System.Drawing.Color.White;
            this.rbInterviewFin.Location = new System.Drawing.Point(636, 10);
            this.rbInterviewFin.Name = "rbInterviewFin";
            this.rbInterviewFin.Size = new System.Drawing.Size(158, 40);
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
            this.rbInterviewInit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInterviewInit.ForeColor = System.Drawing.Color.White;
            this.rbInterviewInit.Location = new System.Drawing.Point(472, 10);
            this.rbInterviewInit.Name = "rbInterviewInit";
            this.rbInterviewInit.Size = new System.Drawing.Size(158, 40);
            this.rbInterviewInit.TabIndex = 3;
            this.rbInterviewInit.Text = "Initial Interview";
            this.rbInterviewInit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbInterviewInit.UseVisualStyleBackColor = false;
            this.rbInterviewInit.CheckedChanged += new System.EventHandler(this.rbInterview_CheckedChanged);
            // 
            // ucDocumentation
            // 
            this.ucDocumentation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucDocumentation.ForeColor = System.Drawing.Color.Black;
            this.ucDocumentation.Location = new System.Drawing.Point(800, 56);
            this.ucDocumentation.Name = "ucDocumentation";
            this.ucDocumentation.Size = new System.Drawing.Size(100, 100);
            this.ucDocumentation.TabIndex = 41;
            this.ucDocumentation.Visible = false;
            // 
            // ucInterviewFin
            // 
            this.ucInterviewFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucInterviewFin.ForeColor = System.Drawing.Color.Black;
            this.ucInterviewFin.Location = new System.Drawing.Point(636, 56);
            this.ucInterviewFin.Name = "ucInterviewFin";
            this.ucInterviewFin.Size = new System.Drawing.Size(100, 100);
            this.ucInterviewFin.TabIndex = 40;
            this.ucInterviewFin.Visible = false;
            // 
            // ucInterviewInit
            // 
            this.ucInterviewInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucInterviewInit.ForeColor = System.Drawing.Color.Black;
            this.ucInterviewInit.Location = new System.Drawing.Point(472, 56);
            this.ucInterviewInit.Name = "ucInterviewInit";
            this.ucInterviewInit.Size = new System.Drawing.Size(100, 100);
            this.ucInterviewInit.TabIndex = 39;
            this.ucInterviewInit.Visible = false;
            // 
            // ucApplicant
            // 
            this.ucApplicant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucApplicant.ForeColor = System.Drawing.Color.Black;
            this.ucApplicant.Location = new System.Drawing.Point(0, 56);
            this.ucApplicant.Name = "ucApplicant";
            this.ucApplicant.Size = new System.Drawing.Size(100, 100);
            this.ucApplicant.TabIndex = 37;
            this.ucApplicant.Visible = false;
            // 
            // ucJobApp
            // 
            this.ucJobApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucJobApp.ForeColor = System.Drawing.Color.Black;
            this.ucJobApp.Location = new System.Drawing.Point(146, 56);
            this.ucJobApp.Name = "ucJobApp";
            this.ucJobApp.Size = new System.Drawing.Size(100, 100);
            this.ucJobApp.TabIndex = 42;
            this.ucJobApp.Visible = false;
            // 
            // ucRecruitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucJobApp);
            this.Controls.Add(this.ucDocumentation);
            this.Controls.Add(this.ucInterviewFin);
            this.Controls.Add(this.ucInterviewInit);
            this.Controls.Add(this.ucApplicant);
            this.Controls.Add(this.pnlTabs);
            this.Name = "ucRecruitment";
            this.Size = new System.Drawing.Size(1118, 500);
            this.VisibleChanged += new System.EventHandler(this.ucRecruitment_VisibleChanged);
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbJobApplicant;
        private System.Windows.Forms.RadioButton rbApplicant;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.RadioButton rbInterviewInit;
        private System.Windows.Forms.RadioButton rbInterviewFin;
        private System.Windows.Forms.RadioButton rbDocu;
        private ucApplicant ucApplicant;
        private ucInterviewInit ucInterviewInit;
        private ucInterviewFin ucInterviewFin;
        private ucDocumentation ucDocumentation;
        private ucJobApp ucJobApp;
    }
}
