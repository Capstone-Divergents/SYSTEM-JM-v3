namespace Findstaff
{
    partial class ucRequirements
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
            this.dgvRequirements = new System.Windows.Forms.DataGridView();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ucRequirementsAddEdit = new Findstaff.ucRequirementsAddEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirements)).BeginInit();
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
            // dgvRequirements
            // 
            this.dgvRequirements.AllowUserToAddRows = false;
            this.dgvRequirements.AllowUserToDeleteRows = false;
            this.dgvRequirements.AllowUserToResizeColumns = false;
            this.dgvRequirements.AllowUserToResizeRows = false;
            this.dgvRequirements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequirements.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRequirements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequirements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequirements.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRequirements.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvRequirements.Location = new System.Drawing.Point(100, 100);
            this.dgvRequirements.MultiSelect = false;
            this.dgvRequirements.Name = "dgvRequirements";
            this.dgvRequirements.ReadOnly = true;
            this.dgvRequirements.RowHeadersVisible = false;
            this.dgvRequirements.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRequirements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequirements.Size = new System.Drawing.Size(918, 200);
            this.dgvRequirements.TabIndex = 103;
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.BackColor = System.Drawing.Color.Transparent;
            this.lblRequirements.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequirements.ForeColor = System.Drawing.Color.Black;
            this.lblRequirements.Location = new System.Drawing.Point(25, 25);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(238, 39);
            this.lblRequirements.TabIndex = 102;
            this.lblRequirements.Text = "Requirements";
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
            // ucRequirementsAddEdit
            // 
            this.ucRequirementsAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucRequirementsAddEdit.Location = new System.Drawing.Point(0, 0);
            this.ucRequirementsAddEdit.Name = "ucRequirementsAddEdit";
            this.ucRequirementsAddEdit.Size = new System.Drawing.Size(10, 10);
            this.ucRequirementsAddEdit.TabIndex = 106;
            this.ucRequirementsAddEdit.Visible = false;
            this.ucRequirementsAddEdit.VisibleChanged += new System.EventHandler(this.ucRequirementsAddEdit_VisibleChanged);
            // 
            // ucRequirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucRequirementsAddEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvRequirements);
            this.Controls.Add(this.lblRequirements);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucRequirements";
            this.Size = new System.Drawing.Size(1118, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.Button btnAdd;
        private ucRequirementsAddEdit ucRequirementsAddEdit;
        public System.Windows.Forms.DataGridView dgvRequirements;
    }
}
