﻿namespace Findstaff
{
    partial class ucRequirementsAddEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.cbDesignation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddRequirement = new System.Windows.Forms.Label();
            this.txtRequirement = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.cbDesignation1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRequirement2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRequirementID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEditRequirements = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel1);
            this.panel1.Controls.Add(this.cbDesignation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblAddRequirement);
            this.panel1.Controls.Add(this.txtRequirement);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 400);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel1.FlatAppearance.BorderSize = 0;
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.ForeColor = System.Drawing.Color.Black;
            this.btnCancel1.Location = new System.Drawing.Point(563, 270);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(100, 50);
            this.btnCancel1.TabIndex = 274;
            this.btnCancel1.Text = "CANCEL";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // cbDesignation
            // 
            this.cbDesignation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbDesignation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesignation.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesignation.ForeColor = System.Drawing.Color.Black;
            this.cbDesignation.FormattingEnabled = true;
            this.cbDesignation.Items.AddRange(new object[] {
            "Country",
            "Job",
            "Basic"});
            this.cbDesignation.Location = new System.Drawing.Point(524, 167);
            this.cbDesignation.Name = "cbDesignation";
            this.cbDesignation.Size = new System.Drawing.Size(200, 27);
            this.cbDesignation.TabIndex = 273;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(417, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 272;
            this.label1.Text = "Designation:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(457, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 271;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddRequirement
            // 
            this.lblAddRequirement.AutoSize = true;
            this.lblAddRequirement.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRequirement.ForeColor = System.Drawing.Color.Black;
            this.lblAddRequirement.Location = new System.Drawing.Point(25, 25);
            this.lblAddRequirement.Name = "lblAddRequirement";
            this.lblAddRequirement.Size = new System.Drawing.Size(266, 39);
            this.lblAddRequirement.TabIndex = 270;
            this.lblAddRequirement.Text = "Add Documents";
            // 
            // txtRequirement
            // 
            this.txtRequirement.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRequirement.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequirement.ForeColor = System.Drawing.Color.Black;
            this.txtRequirement.Location = new System.Drawing.Point(524, 135);
            this.txtRequirement.MaxLength = 30;
            this.txtRequirement.Name = "txtRequirement";
            this.txtRequirement.Size = new System.Drawing.Size(200, 26);
            this.txtRequirement.TabIndex = 268;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(361, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 19);
            this.label8.TabIndex = 267;
            this.label8.Text = "Requirement Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel2);
            this.panel2.Controls.Add(this.cbDesignation1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtRequirement2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtRequirementID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblEditRequirements);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1108, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 400);
            this.panel2.TabIndex = 2;
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel2.FlatAppearance.BorderSize = 0;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Location = new System.Drawing.Point(563, 270);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 50);
            this.btnCancel2.TabIndex = 282;
            this.btnCancel2.Text = "CANCEL";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // cbDesignation1
            // 
            this.cbDesignation1.AutoCompleteCustomSource.AddRange(new string[] {
            "Country",
            "Job",
            "Basic"});
            this.cbDesignation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbDesignation1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDesignation1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesignation1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesignation1.ForeColor = System.Drawing.Color.Black;
            this.cbDesignation1.FormattingEnabled = true;
            this.cbDesignation1.Items.AddRange(new object[] {
            "Country",
            "Job",
            "Basic"});
            this.cbDesignation1.Location = new System.Drawing.Point(516, 187);
            this.cbDesignation1.Name = "cbDesignation1";
            this.cbDesignation1.Size = new System.Drawing.Size(200, 27);
            this.cbDesignation1.TabIndex = 281;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(409, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 280;
            this.label3.Text = "Designation:";
            // 
            // txtRequirement2
            // 
            this.txtRequirement2.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRequirement2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequirement2.ForeColor = System.Drawing.Color.Black;
            this.txtRequirement2.Location = new System.Drawing.Point(516, 154);
            this.txtRequirement2.MaxLength = 30;
            this.txtRequirement2.Name = "txtRequirement2";
            this.txtRequirement2.Size = new System.Drawing.Size(200, 26);
            this.txtRequirement2.TabIndex = 279;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(356, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 19);
            this.label4.TabIndex = 278;
            this.label4.Text = "Requirement Name:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(457, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 277;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRequirementID
            // 
            this.txtRequirementID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRequirementID.Enabled = false;
            this.txtRequirementID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequirementID.ForeColor = System.Drawing.Color.Black;
            this.txtRequirementID.Location = new System.Drawing.Point(516, 122);
            this.txtRequirementID.MaxLength = 30;
            this.txtRequirementID.Name = "txtRequirementID";
            this.txtRequirementID.Size = new System.Drawing.Size(200, 26);
            this.txtRequirementID.TabIndex = 276;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(380, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 275;
            this.label2.Text = "Requirement ID:";
            // 
            // lblEditRequirements
            // 
            this.lblEditRequirements.AutoSize = true;
            this.lblEditRequirements.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditRequirements.ForeColor = System.Drawing.Color.Black;
            this.lblEditRequirements.Location = new System.Drawing.Point(25, 25);
            this.lblEditRequirements.Name = "lblEditRequirements";
            this.lblEditRequirements.Size = new System.Drawing.Size(267, 39);
            this.lblEditRequirements.TabIndex = 274;
            this.lblEditRequirements.Text = "Edit Documents";
            // 
            // ucRequirementsAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucRequirementsAddEdit";
            this.Size = new System.Drawing.Size(1118, 400);
            this.VisibleChanged += new System.EventHandler(this.ucRequirementsAddEdit_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddRequirement;
        private System.Windows.Forms.TextBox txtRequirement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDesignation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEditRequirements;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnCancel2;
        public System.Windows.Forms.TextBox txtRequirement2;
        public System.Windows.Forms.TextBox txtRequirementID;
        public System.Windows.Forms.ComboBox cbDesignation1;
    }
}
