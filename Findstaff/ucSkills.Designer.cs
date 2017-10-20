namespace Findstaff
{
    partial class ucSkills
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvSkills = new System.Windows.Forms.DataGridView();
            this.lblSkills = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.ucSkillsAddEdit = new Findstaff.ucSkillsAddEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(615, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 105;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(509, 325);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 50);
            this.btnEdit.TabIndex = 104;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvSkills
            // 
            this.dgvSkills.AllowUserToAddRows = false;
            this.dgvSkills.AllowUserToDeleteRows = false;
            this.dgvSkills.AllowUserToResizeColumns = false;
            this.dgvSkills.AllowUserToResizeRows = false;
            this.dgvSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkills.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSkills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSkills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSkills.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSkills.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSkills.Location = new System.Drawing.Point(50, 107);
            this.dgvSkills.MultiSelect = false;
            this.dgvSkills.Name = "dgvSkills";
            this.dgvSkills.ReadOnly = true;
            this.dgvSkills.RowHeadersVisible = false;
            this.dgvSkills.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSkills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkills.Size = new System.Drawing.Size(1018, 200);
            this.dgvSkills.TabIndex = 103;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.BackColor = System.Drawing.Color.Transparent;
            this.lblSkills.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkills.ForeColor = System.Drawing.Color.Black;
            this.lblSkills.Location = new System.Drawing.Point(25, 25);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(104, 39);
            this.lblSkills.TabIndex = 102;
            this.lblSkills.Text = "Skills";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(403, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 101;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSkillName
            // 
            this.txtSkillName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSkillName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkillName.ForeColor = System.Drawing.Color.DimGray;
            this.txtSkillName.Location = new System.Drawing.Point(164, 72);
            this.txtSkillName.MaxLength = 30;
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(231, 26);
            this.txtSkillName.TabIndex = 108;
            this.txtSkillName.TextChanged += new System.EventHandler(this.txtSkillName_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(98, 77);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 19);
            this.lbl.TabIndex = 109;
            this.lbl.Text = "Search:";
            // 
            // ucSkillsAddEdit
            // 
            this.ucSkillsAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucSkillsAddEdit.Location = new System.Drawing.Point(0, 0);
            this.ucSkillsAddEdit.Name = "ucSkillsAddEdit";
            this.ucSkillsAddEdit.Size = new System.Drawing.Size(10, 10);
            this.ucSkillsAddEdit.TabIndex = 106;
            this.ucSkillsAddEdit.Visible = false;
            this.ucSkillsAddEdit.VisibleChanged += new System.EventHandler(this.ucSkillsAddEdit_VisibleChanged);
            // 
            // ucSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucSkillsAddEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvSkills);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSkillName);
            this.Controls.Add(this.lbl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucSkills";
            this.Size = new System.Drawing.Size(1118, 400);
            this.Load += new System.EventHandler(this.ucSkills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Button btnAdd;
        private ucSkillsAddEdit ucSkillsAddEdit;
        public System.Windows.Forms.DataGridView dgvSkills;
        private System.Windows.Forms.TextBox txtSkillName;
        private System.Windows.Forms.Label lbl;
    }
}
