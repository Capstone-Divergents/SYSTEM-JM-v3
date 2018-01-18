namespace Findstaff
{
    partial class ucMaintenance
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
            this.rbJobDetails = new System.Windows.Forms.RadioButton();
            this.rbCountry = new System.Windows.Forms.RadioButton();
            this.rbCurrency = new System.Windows.Forms.RadioButton();
            this.rbEmployer = new System.Windows.Forms.RadioButton();
            this.rbBanksAllowed = new System.Windows.Forms.RadioButton();
            this.ucEmployerMainte = new Findstaff.ucEmployerMainte();
            this.ucCurrency = new Findstaff.ucCurrency();
            this.ucJobDetails = new Findstaff.ucGenReqs();
            this.ucCountry = new Findstaff.ucCountry();
            this.ucBanksAllowed = new Findstaff.ucBanksAllowed();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Controls.Add(this.rbBanksAllowed);
            this.pnlTabs.Controls.Add(this.rbEmployer);
            this.pnlTabs.Controls.Add(this.rbCurrency);
            this.pnlTabs.Controls.Add(this.rbJobDetails);
            this.pnlTabs.Controls.Add(this.rbCountry);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 31;
            // 
            // rbJobDetails
            // 
            this.rbJobDetails.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbJobDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobDetails.FlatAppearance.BorderSize = 0;
            this.rbJobDetails.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobDetails.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJobDetails.ForeColor = System.Drawing.Color.White;
            this.rbJobDetails.Location = new System.Drawing.Point(474, 10);
            this.rbJobDetails.Name = "rbJobDetails";
            this.rbJobDetails.Size = new System.Drawing.Size(120, 40);
            this.rbJobDetails.TabIndex = 8;
            this.rbJobDetails.Text = "Job Details";
            this.rbJobDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobDetails.UseVisualStyleBackColor = false;
            this.rbJobDetails.CheckedChanged += new System.EventHandler(this.rbGeneralRequirements_CheckedChanged);
            // 
            // rbCountry
            // 
            this.rbCountry.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbCountry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbCountry.FlatAppearance.BorderSize = 0;
            this.rbCountry.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCountry.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCountry.ForeColor = System.Drawing.Color.White;
            this.rbCountry.Location = new System.Drawing.Point(0, 10);
            this.rbCountry.Name = "rbCountry";
            this.rbCountry.Size = new System.Drawing.Size(100, 40);
            this.rbCountry.TabIndex = 3;
            this.rbCountry.Text = "Country";
            this.rbCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCountry.UseVisualStyleBackColor = false;
            this.rbCountry.CheckedChanged += new System.EventHandler(this.rbCountry_CheckedChanged);
            // 
            // rbCurrency
            // 
            this.rbCurrency.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbCurrency.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbCurrency.FlatAppearance.BorderSize = 0;
            this.rbCurrency.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbCurrency.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbCurrency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCurrency.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCurrency.ForeColor = System.Drawing.Color.White;
            this.rbCurrency.Location = new System.Drawing.Point(106, 10);
            this.rbCurrency.Name = "rbCurrency";
            this.rbCurrency.Size = new System.Drawing.Size(100, 40);
            this.rbCurrency.TabIndex = 9;
            this.rbCurrency.Text = "Currency";
            this.rbCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCurrency.UseVisualStyleBackColor = false;
            this.rbCurrency.CheckedChanged += new System.EventHandler(this.rbCurrency_CheckedChanged);
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
            this.rbEmployer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmployer.ForeColor = System.Drawing.Color.White;
            this.rbEmployer.Location = new System.Drawing.Point(212, 10);
            this.rbEmployer.Name = "rbEmployer";
            this.rbEmployer.Size = new System.Drawing.Size(100, 40);
            this.rbEmployer.TabIndex = 10;
            this.rbEmployer.Text = "Employer";
            this.rbEmployer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEmployer.UseVisualStyleBackColor = false;
            this.rbEmployer.CheckedChanged += new System.EventHandler(this.rbEmployer_CheckedChanged);
            // 
            // rbBanksAllowed
            // 
            this.rbBanksAllowed.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbBanksAllowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbBanksAllowed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbBanksAllowed.FlatAppearance.BorderSize = 0;
            this.rbBanksAllowed.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbBanksAllowed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbBanksAllowed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbBanksAllowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBanksAllowed.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBanksAllowed.ForeColor = System.Drawing.Color.White;
            this.rbBanksAllowed.Location = new System.Drawing.Point(318, 10);
            this.rbBanksAllowed.Name = "rbBanksAllowed";
            this.rbBanksAllowed.Size = new System.Drawing.Size(150, 40);
            this.rbBanksAllowed.TabIndex = 11;
            this.rbBanksAllowed.Text = "Banks Allowed";
            this.rbBanksAllowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBanksAllowed.UseVisualStyleBackColor = false;
            this.rbBanksAllowed.CheckedChanged += new System.EventHandler(this.rbBanksAllowed_CheckedChanged);
            // 
            // ucEmployerMainte
            // 
            this.ucEmployerMainte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucEmployerMainte.Location = new System.Drawing.Point(212, 56);
            this.ucEmployerMainte.Name = "ucEmployerMainte";
            this.ucEmployerMainte.Size = new System.Drawing.Size(100, 100);
            this.ucEmployerMainte.TabIndex = 46;
            this.ucEmployerMainte.Visible = false;
            // 
            // ucCurrency
            // 
            this.ucCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucCurrency.Location = new System.Drawing.Point(106, 56);
            this.ucCurrency.Name = "ucCurrency";
            this.ucCurrency.Size = new System.Drawing.Size(100, 100);
            this.ucCurrency.TabIndex = 45;
            this.ucCurrency.Visible = false;
            // 
            // ucJobDetails
            // 
            this.ucJobDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucJobDetails.Location = new System.Drawing.Point(474, 56);
            this.ucJobDetails.Name = "ucJobDetails";
            this.ucJobDetails.Size = new System.Drawing.Size(120, 100);
            this.ucJobDetails.TabIndex = 44;
            this.ucJobDetails.Visible = false;
            // 
            // ucCountry
            // 
            this.ucCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucCountry.ForeColor = System.Drawing.Color.Black;
            this.ucCountry.Location = new System.Drawing.Point(0, 56);
            this.ucCountry.Name = "ucCountry";
            this.ucCountry.Size = new System.Drawing.Size(100, 100);
            this.ucCountry.TabIndex = 43;
            this.ucCountry.Visible = false;
            // 
            // ucBanksAllowed
            // 
            this.ucBanksAllowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucBanksAllowed.Location = new System.Drawing.Point(318, 56);
            this.ucBanksAllowed.Name = "ucBanksAllowed";
            this.ucBanksAllowed.Size = new System.Drawing.Size(150, 100);
            this.ucBanksAllowed.TabIndex = 47;
            this.ucBanksAllowed.Visible = false;
            // 
            // ucMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucBanksAllowed);
            this.Controls.Add(this.ucEmployerMainte);
            this.Controls.Add(this.ucCurrency);
            this.Controls.Add(this.ucJobDetails);
            this.Controls.Add(this.ucCountry);
            this.Controls.Add(this.pnlTabs);
            this.Name = "ucMaintenance";
            this.Size = new System.Drawing.Size(1118, 500);
            this.VisibleChanged += new System.EventHandler(this.ucMaintenance_VisibleChanged);
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.RadioButton rbCountry;
        private System.Windows.Forms.RadioButton rbJobDetails;
        private ucCountry ucCountry;
        private ucGenReqs ucJobDetails;
        private System.Windows.Forms.RadioButton rbBanksAllowed;
        private System.Windows.Forms.RadioButton rbEmployer;
        private System.Windows.Forms.RadioButton rbCurrency;
        private ucCurrency ucCurrency;
        private ucEmployerMainte ucEmployerMainte;
        private ucBanksAllowed ucBanksAllowed;
    }
}
