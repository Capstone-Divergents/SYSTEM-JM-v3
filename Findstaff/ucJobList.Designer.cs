namespace Findstaff
{
    partial class ucJobList
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
            this.btnEmpView = new System.Windows.Forms.Button();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.btnEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.dgvJobList = new System.Windows.Forms.DataGridView();
            this.btnAdvSe = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.ucJobListAddEdit = new Findstaff.ucJobListAddEdit();
            this.ucJobListView = new Findstaff.ucJobListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpView
            // 
            this.btnEmpView.BackColor = System.Drawing.Color.White;
            this.btnEmpView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpView.FlatAppearance.BorderSize = 0;
            this.btnEmpView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpView.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpView.ForeColor = System.Drawing.Color.Black;
            this.btnEmpView.Location = new System.Drawing.Point(669, 439);
            this.btnEmpView.Name = "btnEmpView";
            this.btnEmpView.Size = new System.Drawing.Size(100, 38);
            this.btnEmpView.TabIndex = 60;
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
            this.btnEmpDel.Location = new System.Drawing.Point(563, 439);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(100, 38);
            this.btnEmpDel.TabIndex = 59;
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
            this.btnEmpEdit.Location = new System.Drawing.Point(457, 439);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(100, 38);
            this.btnEmpEdit.TabIndex = 58;
            this.btnEmpEdit.Text = "EDIT";
            this.btnEmpEdit.UseVisualStyleBackColor = false;
            this.btnEmpEdit.Click += new System.EventHandler(this.btnEmpEdit_Click);
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.BackColor = System.Drawing.Color.White;
            this.btnEmpAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpAdd.FlatAppearance.BorderSize = 0;
            this.btnEmpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpAdd.ForeColor = System.Drawing.Color.Black;
            this.btnEmpAdd.Location = new System.Drawing.Point(350, 439);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(100, 38);
            this.btnEmpAdd.TabIndex = 57;
            this.btnEmpAdd.Text = "ADD";
            this.btnEmpAdd.UseVisualStyleBackColor = false;
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // dgvJobList
            // 
            this.dgvJobList.AllowUserToAddRows = false;
            this.dgvJobList.AllowUserToDeleteRows = false;
            this.dgvJobList.AllowUserToResizeColumns = false;
            this.dgvJobList.AllowUserToResizeRows = false;
            this.dgvJobList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvJobList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvJobList.Location = new System.Drawing.Point(48, 62);
            this.dgvJobList.MultiSelect = false;
            this.dgvJobList.Name = "dgvJobList";
            this.dgvJobList.ReadOnly = true;
            this.dgvJobList.RowHeadersVisible = false;
            this.dgvJobList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobList.Size = new System.Drawing.Size(1056, 360);
            this.dgvJobList.TabIndex = 56;
            // 
            // btnAdvSe
            // 
            this.btnAdvSe.BackColor = System.Drawing.Color.White;
            this.btnAdvSe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvSe.FlatAppearance.BorderSize = 0;
            this.btnAdvSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvSe.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvSe.ForeColor = System.Drawing.Color.Black;
            this.btnAdvSe.Location = new System.Drawing.Point(305, 17);
            this.btnAdvSe.Name = "btnAdvSe";
            this.btnAdvSe.Size = new System.Drawing.Size(250, 30);
            this.btnAdvSe.TabIndex = 55;
            this.btnAdvSe.Text = "ADVANCED SEARCH";
            this.btnAdvSe.UseVisualStyleBackColor = false;
            this.btnAdvSe.Visible = false;
            this.btnAdvSe.Click += new System.EventHandler(this.btnAdvSe_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(99, 20);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 53;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(25, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 52;
            this.lblSearch.Text = "Search :";
            // 
            // ucJobListAddEdit
            // 
            this.ucJobListAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucJobListAddEdit.Location = new System.Drawing.Point(0, 0);
            this.ucJobListAddEdit.Name = "ucJobListAddEdit";
            this.ucJobListAddEdit.Size = new System.Drawing.Size(10, 10);
            this.ucJobListAddEdit.TabIndex = 63;
            this.ucJobListAddEdit.Visible = false;
            this.ucJobListAddEdit.VisibleChanged += new System.EventHandler(this.ucJobListAddEdit_VisibleChanged_1);
            // 
            // ucJobListView
            // 
            this.ucJobListView.AutoScroll = true;
            this.ucJobListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucJobListView.Location = new System.Drawing.Point(29, 0);
            this.ucJobListView.Name = "ucJobListView";
            this.ucJobListView.Size = new System.Drawing.Size(10, 10);
            this.ucJobListView.TabIndex = 64;
            this.ucJobListView.Visible = false;
            // 
            // ucJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucJobListView);
            this.Controls.Add(this.ucJobListAddEdit);
            this.Controls.Add(this.btnEmpView);
            this.Controls.Add(this.btnEmpDel);
            this.Controls.Add(this.btnEmpEdit);
            this.Controls.Add(this.btnEmpAdd);
            this.Controls.Add(this.dgvJobList);
            this.Controls.Add(this.btnAdvSe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSearch);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucJobList";
            this.Size = new System.Drawing.Size(1155, 500);
            this.Load += new System.EventHandler(this.ucJobList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpView;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.Button btnEmpAdd;
        private System.Windows.Forms.Button btnAdvSe;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.DataGridView dgvJobList;
        private ucJobListAddEdit ucJobListAddEdit;
        private ucJobListView ucJobListView;
    }
}
