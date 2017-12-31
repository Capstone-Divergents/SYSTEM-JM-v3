namespace Findstaff
{
    partial class ucSkillsAddEdit
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddSkills = new System.Windows.Forms.Label();
            this.txtSkillName1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSkillID = new System.Windows.Forms.TextBox();
            this.lblSkillId = new System.Windows.Forms.Label();
            this.lblEditSkills = new System.Windows.Forms.Label();
            this.txtSkillName2 = new System.Windows.Forms.TextBox();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblAddSkills);
            this.panel1.Controls.Add(this.txtSkillName1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 500);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.White;
            this.btnCancel1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel1.FlatAppearance.BorderSize = 0;
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.ForeColor = System.Drawing.Color.Black;
            this.btnCancel1.Location = new System.Drawing.Point(574, 294);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(100, 38);
            this.btnCancel1.TabIndex = 272;
            this.btnCancel1.Text = "CANCEL";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(468, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 38);
            this.btnAdd.TabIndex = 271;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddSkills
            // 
            this.lblAddSkills.AutoSize = true;
            this.lblAddSkills.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSkills.ForeColor = System.Drawing.Color.Black;
            this.lblAddSkills.Location = new System.Drawing.Point(25, 25);
            this.lblAddSkills.Name = "lblAddSkills";
            this.lblAddSkills.Size = new System.Drawing.Size(138, 28);
            this.lblAddSkills.TabIndex = 270;
            this.lblAddSkills.Text = "Add Skills";
            // 
            // txtSkillName1
            // 
            this.txtSkillName1.BackColor = System.Drawing.Color.White;
            this.txtSkillName1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkillName1.ForeColor = System.Drawing.Color.Black;
            this.txtSkillName1.Location = new System.Drawing.Point(510, 152);
            this.txtSkillName1.MaxLength = 30;
            this.txtSkillName1.Name = "txtSkillName1";
            this.txtSkillName1.Size = new System.Drawing.Size(200, 27);
            this.txtSkillName1.TabIndex = 268;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(409, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 267;
            this.label8.Text = "Skill Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel2);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtSkillID);
            this.panel2.Controls.Add(this.lblSkillId);
            this.panel2.Controls.Add(this.lblEditSkills);
            this.panel2.Controls.Add(this.txtSkillName2);
            this.panel2.Controls.Add(this.lblSkillName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1145, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 500);
            this.panel2.TabIndex = 2;
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.White;
            this.btnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel2.FlatAppearance.BorderSize = 0;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Location = new System.Drawing.Point(574, 294);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 38);
            this.btnCancel2.TabIndex = 278;
            this.btnCancel2.Text = "CANCEL";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(468, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 38);
            this.btnSave.TabIndex = 277;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSkillID
            // 
            this.txtSkillID.BackColor = System.Drawing.Color.White;
            this.txtSkillID.Enabled = false;
            this.txtSkillID.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkillID.ForeColor = System.Drawing.Color.Black;
            this.txtSkillID.Location = new System.Drawing.Point(508, 152);
            this.txtSkillID.MaxLength = 30;
            this.txtSkillID.Name = "txtSkillID";
            this.txtSkillID.Size = new System.Drawing.Size(200, 27);
            this.txtSkillID.TabIndex = 276;
            // 
            // lblSkillId
            // 
            this.lblSkillId.AutoSize = true;
            this.lblSkillId.BackColor = System.Drawing.Color.Transparent;
            this.lblSkillId.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillId.ForeColor = System.Drawing.Color.Black;
            this.lblSkillId.Location = new System.Drawing.Point(432, 155);
            this.lblSkillId.Name = "lblSkillId";
            this.lblSkillId.Size = new System.Drawing.Size(70, 20);
            this.lblSkillId.TabIndex = 275;
            this.lblSkillId.Text = "Skill ID:";
            // 
            // lblEditSkills
            // 
            this.lblEditSkills.AutoSize = true;
            this.lblEditSkills.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditSkills.ForeColor = System.Drawing.Color.Black;
            this.lblEditSkills.Location = new System.Drawing.Point(25, 25);
            this.lblEditSkills.Name = "lblEditSkills";
            this.lblEditSkills.Size = new System.Drawing.Size(142, 28);
            this.lblEditSkills.TabIndex = 274;
            this.lblEditSkills.Text = "Edit Skills";
            // 
            // txtSkillName2
            // 
            this.txtSkillName2.BackColor = System.Drawing.Color.White;
            this.txtSkillName2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkillName2.ForeColor = System.Drawing.Color.Black;
            this.txtSkillName2.Location = new System.Drawing.Point(508, 184);
            this.txtSkillName2.MaxLength = 30;
            this.txtSkillName2.Name = "txtSkillName2";
            this.txtSkillName2.Size = new System.Drawing.Size(200, 27);
            this.txtSkillName2.TabIndex = 272;
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.BackColor = System.Drawing.Color.Transparent;
            this.lblSkillName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillName.ForeColor = System.Drawing.Color.Black;
            this.lblSkillName.Location = new System.Drawing.Point(407, 187);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(95, 20);
            this.lblSkillName.TabIndex = 271;
            this.lblSkillName.Text = "Skill Name:";
            // 
            // ucSkillsAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucSkillsAddEdit";
            this.Size = new System.Drawing.Size(1155, 500);
            this.VisibleChanged += new System.EventHandler(this.ucSkillsAddEdit_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddSkills;
        private System.Windows.Forms.TextBox txtSkillName1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSkillId;
        private System.Windows.Forms.Label lblEditSkills;
        private System.Windows.Forms.Label lblSkillName;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnCancel2;
        public System.Windows.Forms.TextBox txtSkillID;
        public System.Windows.Forms.TextBox txtSkillName2;
    }
}
