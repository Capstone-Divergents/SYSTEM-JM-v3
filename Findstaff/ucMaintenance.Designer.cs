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
            this.rbGeneralRequirements = new System.Windows.Forms.RadioButton();
            this.rbCountry = new System.Windows.Forms.RadioButton();
            this.ucCountry = new Findstaff.ucCountry();
            this.ucGenReqs = new Findstaff.ucGenReqs();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Controls.Add(this.rbGeneralRequirements);
            this.pnlTabs.Controls.Add(this.rbCountry);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 31;
            // 
            // rbGeneralRequirements
            // 
            this.rbGeneralRequirements.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbGeneralRequirements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbGeneralRequirements.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbGeneralRequirements.FlatAppearance.BorderSize = 0;
            this.rbGeneralRequirements.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbGeneralRequirements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbGeneralRequirements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbGeneralRequirements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbGeneralRequirements.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGeneralRequirements.ForeColor = System.Drawing.Color.White;
            this.rbGeneralRequirements.Location = new System.Drawing.Point(106, 10);
            this.rbGeneralRequirements.Name = "rbGeneralRequirements";
            this.rbGeneralRequirements.Size = new System.Drawing.Size(200, 40);
            this.rbGeneralRequirements.TabIndex = 8;
            this.rbGeneralRequirements.Text = "General Requirements";
            this.rbGeneralRequirements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbGeneralRequirements.UseVisualStyleBackColor = false;
            this.rbGeneralRequirements.CheckedChanged += new System.EventHandler(this.rbGeneralRequirements_CheckedChanged);
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
            // ucGenReqs
            // 
            this.ucGenReqs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucGenReqs.Location = new System.Drawing.Point(106, 56);
            this.ucGenReqs.Name = "ucGenReqs";
            this.ucGenReqs.Size = new System.Drawing.Size(100, 100);
            this.ucGenReqs.TabIndex = 44;
            this.ucGenReqs.Visible = false;
            // 
            // ucMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucGenReqs);
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
        private System.Windows.Forms.RadioButton rbGeneralRequirements;
        private ucCountry ucCountry;
        private ucGenReqs ucGenReqs;
    }
}
