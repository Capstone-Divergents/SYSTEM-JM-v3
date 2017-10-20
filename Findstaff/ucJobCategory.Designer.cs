namespace Findstaff
{
    partial class ucJobCategory
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
            this.dgvJobCategory = new System.Windows.Forms.DataGridView();
            this.lblJobCategory = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ucJobCategoryAddEdit = new Findstaff.ucJobCategoryAddEdit();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobCategory)).BeginInit();
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
            // dgvJobCategory
            // 
            this.dgvJobCategory.AllowUserToAddRows = false;
            this.dgvJobCategory.AllowUserToDeleteRows = false;
            this.dgvJobCategory.AllowUserToResizeColumns = false;
            this.dgvJobCategory.AllowUserToResizeRows = false;
            this.dgvJobCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobCategory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvJobCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobCategory.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvJobCategory.Location = new System.Drawing.Point(50, 117);
            this.dgvJobCategory.MultiSelect = false;
            this.dgvJobCategory.Name = "dgvJobCategory";
            this.dgvJobCategory.ReadOnly = true;
            this.dgvJobCategory.RowHeadersVisible = false;
            this.dgvJobCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJobCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobCategory.Size = new System.Drawing.Size(1018, 189);
            this.dgvJobCategory.TabIndex = 103;
            // 
            // lblJobCategory
            // 
            this.lblJobCategory.AutoSize = true;
            this.lblJobCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblJobCategory.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobCategory.ForeColor = System.Drawing.Color.Black;
            this.lblJobCategory.Location = new System.Drawing.Point(25, 25);
            this.lblJobCategory.Name = "lblJobCategory";
            this.lblJobCategory.Size = new System.Drawing.Size(220, 39);
            this.lblJobCategory.TabIndex = 102;
            this.lblJobCategory.Text = "Job Category";
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
            // ucJobCategoryAddEdit
            // 
            this.ucJobCategoryAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucJobCategoryAddEdit.Location = new System.Drawing.Point(0, 0);
            this.ucJobCategoryAddEdit.Name = "ucJobCategoryAddEdit";
            this.ucJobCategoryAddEdit.Size = new System.Drawing.Size(10, 10);
            this.ucJobCategoryAddEdit.TabIndex = 106;
            this.ucJobCategoryAddEdit.Visible = false;
            this.ucJobCategoryAddEdit.VisibleChanged += new System.EventHandler(this.ucJobCategoryAddEdit_VisibleChanged);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCategoryName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.ForeColor = System.Drawing.Color.DimGray;
            this.txtCategoryName.Location = new System.Drawing.Point(166, 78);
            this.txtCategoryName.MaxLength = 30;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(231, 26);
            this.txtCategoryName.TabIndex = 110;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(100, 83);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 19);
            this.lbl.TabIndex = 111;
            this.lbl.Text = "Search:";
            // 
            // ucJobCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucJobCategoryAddEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvJobCategory);
            this.Controls.Add(this.lblJobCategory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lbl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucJobCategory";
            this.Size = new System.Drawing.Size(1118, 400);
            this.Load += new System.EventHandler(this.ucJobCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblJobCategory;
        private System.Windows.Forms.Button btnAdd;
        private ucJobCategoryAddEdit ucJobCategoryAddEdit;
        public System.Windows.Forms.DataGridView dgvJobCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lbl;
    }
}
