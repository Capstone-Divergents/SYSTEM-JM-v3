namespace Findstaff
{
    partial class ucEmployee
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnEmpView = new System.Windows.Forms.Button();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.btnEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.ucEmployeeAddEdit = new Findstaff.ucEmployeeAddEdit();
            this.ucEmployeeView = new Findstaff.ucEmployeeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployee.Location = new System.Drawing.Point(48, 62);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1056, 360);
            this.dgvEmployee.TabIndex = 12;
            // 
            // btnEmpView
            // 
            this.btnEmpView.BackColor = System.Drawing.Color.White;
            this.btnEmpView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpView.FlatAppearance.BorderSize = 0;
            this.btnEmpView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpView.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpView.ForeColor = System.Drawing.Color.Black;
            this.btnEmpView.Location = new System.Drawing.Point(685, 439);
            this.btnEmpView.Name = "btnEmpView";
            this.btnEmpView.Size = new System.Drawing.Size(100, 38);
            this.btnEmpView.TabIndex = 16;
            this.btnEmpView.Text = "VIEW";
            this.btnEmpView.UseVisualStyleBackColor = false;
            this.btnEmpView.Click += new System.EventHandler(this.btnEmpView_Click);
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.BackColor = System.Drawing.Color.White;
            this.btnEmpDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpDel.FlatAppearance.BorderSize = 0;
            this.btnEmpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpDel.ForeColor = System.Drawing.Color.Black;
            this.btnEmpDel.Location = new System.Drawing.Point(579, 439);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(100, 38);
            this.btnEmpDel.TabIndex = 15;
            this.btnEmpDel.Text = "DELETE";
            this.btnEmpDel.UseVisualStyleBackColor = false;
            this.btnEmpDel.Click += new System.EventHandler(this.btnEmpDel_Click);
            // 
            // btnEmpEdit
            // 
            this.btnEmpEdit.BackColor = System.Drawing.Color.White;
            this.btnEmpEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpEdit.FlatAppearance.BorderSize = 0;
            this.btnEmpEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpEdit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEmpEdit.Location = new System.Drawing.Point(473, 439);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(100, 38);
            this.btnEmpEdit.TabIndex = 14;
            this.btnEmpEdit.Text = "EDIT";
            this.btnEmpEdit.UseVisualStyleBackColor = false;
            this.btnEmpEdit.Click += new System.EventHandler(this.btnEmpUpd_Click);
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.BackColor = System.Drawing.Color.White;
            this.btnEmpAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpAdd.FlatAppearance.BorderSize = 0;
            this.btnEmpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAdd.ForeColor = System.Drawing.Color.Black;
            this.btnEmpAdd.Location = new System.Drawing.Point(367, 439);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(100, 38);
            this.btnEmpAdd.TabIndex = 13;
            this.btnEmpAdd.Text = "ADD";
            this.btnEmpAdd.UseVisualStyleBackColor = false;
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(99, 20);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 27);
            this.txtName.TabIndex = 116;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(25, 25);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 19);
            this.lbl.TabIndex = 117;
            this.lbl.Text = "Search:";
            // 
            // ucEmployeeAddEdit
            // 
            this.ucEmployeeAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucEmployeeAddEdit.Location = new System.Drawing.Point(3, 0);
            this.ucEmployeeAddEdit.Name = "ucEmployeeAddEdit";
            this.ucEmployeeAddEdit.Size = new System.Drawing.Size(10, 10);
            this.ucEmployeeAddEdit.TabIndex = 118;
            this.ucEmployeeAddEdit.Visible = false;
            this.ucEmployeeAddEdit.VisibleChanged += new System.EventHandler(this.ucEmployeeAddEdit_VisibleChanged_1);
            // 
            // ucEmployeeView
            // 
            this.ucEmployeeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucEmployeeView.Location = new System.Drawing.Point(29, 0);
            this.ucEmployeeView.Name = "ucEmployeeView";
            this.ucEmployeeView.Size = new System.Drawing.Size(10, 10);
            this.ucEmployeeView.TabIndex = 119;
            this.ucEmployeeView.Visible = false;
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucEmployeeView);
            this.Controls.Add(this.ucEmployeeAddEdit);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnEmpView);
            this.Controls.Add(this.btnEmpDel);
            this.Controls.Add(this.btnEmpEdit);
            this.Controls.Add(this.btnEmpAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(1155, 500);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmpView;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.Button btnEmpAdd;
        public System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl;
        private ucEmployeeAddEdit ucEmployeeAddEdit;
        private ucEmployeeView ucEmployeeView;
    }
}
