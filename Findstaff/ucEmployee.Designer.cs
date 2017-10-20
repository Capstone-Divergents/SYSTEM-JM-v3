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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnEmpView = new System.Windows.Forms.Button();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.btnEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.ucEmployeeView = new Findstaff.ucEmployeeView();
            this.ucEmployeeAddEdit = new Findstaff.ucEmployeeAddEdit();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployee.Location = new System.Drawing.Point(50, 110);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1018, 230);
            this.dgvEmployee.TabIndex = 12;
            // 
            // btnEmpView
            // 
            this.btnEmpView.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmpView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpView.FlatAppearance.BorderSize = 0;
            this.btnEmpView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpView.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpView.ForeColor = System.Drawing.Color.Black;
            this.btnEmpView.Location = new System.Drawing.Point(668, 365);
            this.btnEmpView.Name = "btnEmpView";
            this.btnEmpView.Size = new System.Drawing.Size(100, 50);
            this.btnEmpView.TabIndex = 16;
            this.btnEmpView.Text = "VIEW";
            this.btnEmpView.UseVisualStyleBackColor = false;
            this.btnEmpView.Click += new System.EventHandler(this.btnEmpView_Click);
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmpDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpDel.FlatAppearance.BorderSize = 0;
            this.btnEmpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpDel.ForeColor = System.Drawing.Color.Black;
            this.btnEmpDel.Location = new System.Drawing.Point(562, 365);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(100, 50);
            this.btnEmpDel.TabIndex = 15;
            this.btnEmpDel.Text = "DELETE";
            this.btnEmpDel.UseVisualStyleBackColor = false;
            this.btnEmpDel.Click += new System.EventHandler(this.btnEmpDel_Click);
            // 
            // btnEmpEdit
            // 
            this.btnEmpEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmpEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpEdit.FlatAppearance.BorderSize = 0;
            this.btnEmpEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpEdit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEmpEdit.Location = new System.Drawing.Point(456, 365);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(100, 50);
            this.btnEmpEdit.TabIndex = 14;
            this.btnEmpEdit.Text = "EDIT";
            this.btnEmpEdit.UseVisualStyleBackColor = false;
            this.btnEmpEdit.Click += new System.EventHandler(this.btnEmpUpd_Click);
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmpAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpAdd.FlatAppearance.BorderSize = 0;
            this.btnEmpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAdd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAdd.ForeColor = System.Drawing.Color.Black;
            this.btnEmpAdd.Location = new System.Drawing.Point(350, 365);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(100, 50);
            this.btnEmpAdd.TabIndex = 13;
            this.btnEmpAdd.Text = "ADD";
            this.btnEmpAdd.UseVisualStyleBackColor = false;
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // ucEmployeeView
            // 
            this.ucEmployeeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucEmployeeView.Location = new System.Drawing.Point(10, 0);
            this.ucEmployeeView.Name = "ucEmployeeView";
            this.ucEmployeeView.Size = new System.Drawing.Size(10, 10);
            this.ucEmployeeView.TabIndex = 18;
            this.ucEmployeeView.Visible = false;
            // 
            // ucEmployeeAddEdit
            // 
            this.ucEmployeeAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucEmployeeAddEdit.Location = new System.Drawing.Point(0, 0);
            this.ucEmployeeAddEdit.Name = "ucEmployeeAddEdit";
            this.ucEmployeeAddEdit.Size = new System.Drawing.Size(10, 10);
            this.ucEmployeeAddEdit.TabIndex = 17;
            this.ucEmployeeAddEdit.Visible = false;
            this.ucEmployeeAddEdit.VisibleChanged += new System.EventHandler(this.ucEmployeeAddEdit_VisibleChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(165, 77);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 26);
            this.txtName.TabIndex = 116;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(99, 82);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 19);
            this.lbl.TabIndex = 117;
            this.lbl.Text = "Search:";
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucEmployeeView);
            this.Controls.Add(this.ucEmployeeAddEdit);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnEmpView);
            this.Controls.Add(this.btnEmpDel);
            this.Controls.Add(this.btnEmpEdit);
            this.Controls.Add(this.btnEmpAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(1118, 450);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpView;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.Button btnEmpAdd;
        private ucEmployeeAddEdit ucEmployeeAddEdit;
        private ucEmployeeView ucEmployeeView;
        public System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl;
    }
}
