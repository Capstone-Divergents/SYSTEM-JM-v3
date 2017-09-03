﻿namespace Findstaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvJobOrder = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtJobOrderSearch = new System.Windows.Forms.TextBox();
            this.lblJobOrderId = new System.Windows.Forms.Label();
            this.lblJobOrder = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvJobOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobOrder.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvJobOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJobOrder.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvJobOrder.Location = new System.Drawing.Point(100, 140);
            this.dgvJobOrder.MultiSelect = false;
            this.dgvJobOrder.Name = "dgvJobOrder";
            this.dgvJobOrder.ReadOnly = true;
            this.dgvJobOrder.RowHeadersVisible = false;
            this.dgvJobOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJobOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobOrder.Size = new System.Drawing.Size(918, 200);
            this.dgvJobOrder.TabIndex = 51;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(377, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtJobOrderSearch
            // 
            this.txtJobOrderSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtJobOrderSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobOrderSearch.ForeColor = System.Drawing.Color.Black;
            this.txtJobOrderSearch.Location = new System.Drawing.Point(171, 97);
            this.txtJobOrderSearch.MaxLength = 30;
            this.txtJobOrderSearch.Name = "txtJobOrderSearch";
            this.txtJobOrderSearch.Size = new System.Drawing.Size(200, 26);
            this.txtJobOrderSearch.TabIndex = 49;
            // 
            // lblJobOrderId
            // 
            this.lblJobOrderId.AutoSize = true;
            this.lblJobOrderId.BackColor = System.Drawing.Color.Transparent;
            this.lblJobOrderId.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobOrderId.ForeColor = System.Drawing.Color.Black;
            this.lblJobOrderId.Location = new System.Drawing.Point(100, 100);
            this.lblJobOrderId.Name = "lblJobOrderId";
            this.lblJobOrderId.Size = new System.Drawing.Size(65, 19);
            this.lblJobOrderId.TabIndex = 48;
            this.lblJobOrderId.Text = "Search:";
            // 
            // lblJobOrder
            // 
            this.lblJobOrder.AutoSize = true;
            this.lblJobOrder.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobOrder.ForeColor = System.Drawing.Color.Black;
            this.lblJobOrder.Location = new System.Drawing.Point(25, 25);
            this.lblJobOrder.Name = "lblJobOrder";
            this.lblJobOrder.Size = new System.Drawing.Size(169, 39);
            this.lblJobOrder.TabIndex = 47;
            this.lblJobOrder.Text = "Job Order";
            // 
            // btnAdvanceSearch
            // 
            this.btnAdvanceSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdvanceSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvanceSearch.FlatAppearance.BorderSize = 0;
            this.btnAdvanceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanceSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvanceSearch.ForeColor = System.Drawing.Color.Black;
            this.btnAdvanceSearch.Location = new System.Drawing.Point(483, 94);
            this.btnAdvanceSearch.Name = "btnAdvanceSearch";
            this.btnAdvanceSearch.Size = new System.Drawing.Size(250, 30);
            this.btnAdvanceSearch.TabIndex = 53;
            this.btnAdvanceSearch.Text = "ADVANCED SEARCH";
            this.btnAdvanceSearch.UseVisualStyleBackColor = false;
            this.btnAdvanceSearch.Click += new System.EventHandler(this.btnAdvanceSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(615, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 56;
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
            this.btnEdit.Location = new System.Drawing.Point(509, 359);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 50);
            this.btnEdit.TabIndex = 55;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(403, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucJobOrderAddEdit
            // 
            this.ucJobOrderAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucJobOrderAddEdit.Location = new System.Drawing.Point(0, 0);
            this.ucJobOrderAddEdit.Name = "ucJobOrderAddEdit";
            this.ucJobOrderAddEdit.Size = new System.Drawing.Size(10, 10);
            this.ucJobOrderAddEdit.TabIndex = 57;
            this.ucJobOrderAddEdit.Visible = false;
            this.ucJobOrderAddEdit.VisibleChanged += new System.EventHandler(this.ucJobOrderAddEdit_VisibleChanged);
            // 
            // ucJobOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucJobOrderAddEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAdvanceSearch);
            this.Controls.Add(this.dgvJobOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtJobOrderSearch);
            this.Controls.Add(this.lblJobOrderId);
            this.Controls.Add(this.lblJobOrder);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucJobOrder";
            this.Size = new System.Drawing.Size(1118, 450);
            this.VisibleChanged += new System.EventHandler(this.ucJobOrder_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtJobOrderSearch;
        private System.Windows.Forms.Label lblJobOrderId;
        private System.Windows.Forms.Label lblJobOrder;
        private System.Windows.Forms.Button btnAdvanceSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private ucJobOrderAddEdit ucJobOrderAddEdit;
        public System.Windows.Forms.DataGridView dgvJobOrder;
    }
}
