namespace Findstaff
{
    partial class ucJobOrder
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
            this.dgvJobOrder = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblJobOrderId = new System.Windows.Forms.Label();
            this.btnAdvanceSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ucJobOrderAddEdit = new Findstaff.ucJobOrderAddEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobOrder
            // 
            this.dgvJobOrder.AllowUserToAddRows = false;
            this.dgvJobOrder.AllowUserToDeleteRows = false;
            this.dgvJobOrder.AllowUserToResizeColumns = false;
            this.dgvJobOrder.AllowUserToResizeRows = false;
            this.dgvJobOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobOrder.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvJobOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobOrder.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvJobOrder.Location = new System.Drawing.Point(48, 62);
            this.dgvJobOrder.MultiSelect = false;
            this.dgvJobOrder.Name = "dgvJobOrder";
            this.dgvJobOrder.ReadOnly = true;
            this.dgvJobOrder.RowHeadersVisible = false;
            this.dgvJobOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJobOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobOrder.Size = new System.Drawing.Size(1056, 360);
            this.dgvJobOrder.TabIndex = 51;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(96, 22);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 49;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblJobOrderId
            // 
            this.lblJobOrderId.AutoSize = true;
            this.lblJobOrderId.BackColor = System.Drawing.Color.Transparent;
            this.lblJobOrderId.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobOrderId.ForeColor = System.Drawing.Color.Black;
            this.lblJobOrderId.Location = new System.Drawing.Point(25, 25);
            this.lblJobOrderId.Name = "lblJobOrderId";
            this.lblJobOrderId.Size = new System.Drawing.Size(64, 20);
            this.lblJobOrderId.TabIndex = 48;
            this.lblJobOrderId.Text = "Search:";
            // 
            // btnAdvanceSearch
            // 
            this.btnAdvanceSearch.BackColor = System.Drawing.Color.White;
            this.btnAdvanceSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvanceSearch.FlatAppearance.BorderSize = 0;
            this.btnAdvanceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanceSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvanceSearch.ForeColor = System.Drawing.Color.Black;
            this.btnAdvanceSearch.Location = new System.Drawing.Point(302, 20);
            this.btnAdvanceSearch.Name = "btnAdvanceSearch";
            this.btnAdvanceSearch.Size = new System.Drawing.Size(250, 30);
            this.btnAdvanceSearch.TabIndex = 53;
            this.btnAdvanceSearch.Text = "ADVANCED SEARCH";
            this.btnAdvanceSearch.UseVisualStyleBackColor = false;
            this.btnAdvanceSearch.Visible = false;
            this.btnAdvanceSearch.Click += new System.EventHandler(this.btnAdvanceSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(632, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 38);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(526, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 38);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(420, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 38);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucJobOrderAddEdit
            // 
            this.ucJobOrderAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucJobOrderAddEdit.Location = new System.Drawing.Point(3, 3);
            this.ucJobOrderAddEdit.Name = "ucJobOrderAddEdit";
            this.ucJobOrderAddEdit.Size = new System.Drawing.Size(10, 10);
            this.ucJobOrderAddEdit.TabIndex = 57;
            this.ucJobOrderAddEdit.Visible = false;
            this.ucJobOrderAddEdit.VisibleChanged += new System.EventHandler(this.ucJobOrderAddEdit_VisibleChanged_1);
            // 
            // ucJobOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucJobOrderAddEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAdvanceSearch);
            this.Controls.Add(this.dgvJobOrder);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblJobOrderId);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucJobOrder";
            this.Size = new System.Drawing.Size(1155, 500);
            this.Load += new System.EventHandler(this.ucJobOrder_Load);
            this.VisibleChanged += new System.EventHandler(this.ucJobOrder_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblJobOrderId;
        private System.Windows.Forms.Button btnAdvanceSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dgvJobOrder;
        private ucJobOrderAddEdit ucJobOrderAddEdit;
    }
}
