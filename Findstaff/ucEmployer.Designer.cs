namespace Findstaff
{
    partial class ucEmployer
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
            this.dgvEmployer = new System.Windows.Forms.DataGridView();
            this.btnAdvSe = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.btnEmpEdit = new System.Windows.Forms.Button();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.ucEmployerView = new Findstaff.ucEmployerView();
            this.ucEmployerAddEdit = new Findstaff.ucEmployerAddEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployer
            // 
            this.dgvEmployer.AllowUserToAddRows = false;
            this.dgvEmployer.AllowUserToDeleteRows = false;
            this.dgvEmployer.AllowUserToResizeColumns = false;
            this.dgvEmployer.AllowUserToResizeRows = false;
            this.dgvEmployer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployer.GridColor = System.Drawing.Color.White;
            this.dgvEmployer.Location = new System.Drawing.Point(48, 62);
            this.dgvEmployer.MultiSelect = false;
            this.dgvEmployer.Name = "dgvEmployer";
            this.dgvEmployer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployer.RowHeadersVisible = false;
            this.dgvEmployer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployer.Size = new System.Drawing.Size(1056, 360);
            this.dgvEmployer.TabIndex = 43;
            // 
            // btnAdvSe
            // 
            this.btnAdvSe.BackColor = System.Drawing.Color.White;
            this.btnAdvSe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvSe.FlatAppearance.BorderSize = 0;
            this.btnAdvSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvSe.Font = new System.Drawing.Font("Century", 12F);
            this.btnAdvSe.ForeColor = System.Drawing.Color.Black;
            this.btnAdvSe.Location = new System.Drawing.Point(305, 17);
            this.btnAdvSe.Name = "btnAdvSe";
            this.btnAdvSe.Size = new System.Drawing.Size(250, 30);
            this.btnAdvSe.TabIndex = 42;
            this.btnAdvSe.Text = "ADVANCED SEARCH";
            this.btnAdvSe.UseVisualStyleBackColor = false;
            this.btnAdvSe.Visible = false;
            this.btnAdvSe.Click += new System.EventHandler(this.btnAdvSe_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(99, 20);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 26);
            this.txtName.TabIndex = 40;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Century", 12F);
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(25, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 39;
            this.lblSearch.Text = "Search :";
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.BackColor = System.Drawing.Color.White;
            this.btnEmpDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpDel.FlatAppearance.BorderSize = 0;
            this.btnEmpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDel.Font = new System.Drawing.Font("Century", 12F);
            this.btnEmpDel.ForeColor = System.Drawing.Color.Black;
            this.btnEmpDel.Location = new System.Drawing.Point(579, 439);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(100, 38);
            this.btnEmpDel.TabIndex = 49;
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
            this.btnEmpEdit.Font = new System.Drawing.Font("Century", 12F);
            this.btnEmpEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEmpEdit.Location = new System.Drawing.Point(473, 439);
            this.btnEmpEdit.Name = "btnEmpEdit";
            this.btnEmpEdit.Size = new System.Drawing.Size(100, 38);
            this.btnEmpEdit.TabIndex = 48;
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
            this.btnEmpAdd.Font = new System.Drawing.Font("Century", 12F);
            this.btnEmpAdd.ForeColor = System.Drawing.Color.Black;
            this.btnEmpAdd.Location = new System.Drawing.Point(367, 439);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(100, 38);
            this.btnEmpAdd.TabIndex = 47;
            this.btnEmpAdd.Text = "ADD";
            this.btnEmpAdd.UseVisualStyleBackColor = false;
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.White;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Century", 12F);
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(685, 439);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 38);
            this.btnView.TabIndex = 51;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ucEmployerView
            // 
            this.ucEmployerView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucEmployerView.Location = new System.Drawing.Point(29, 3);
            this.ucEmployerView.Name = "ucEmployerView";
            this.ucEmployerView.Size = new System.Drawing.Size(10, 10);
            this.ucEmployerView.TabIndex = 52;
            this.ucEmployerView.Visible = false;
            // 
            // ucEmployerAddEdit
            // 
            this.ucEmployerAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucEmployerAddEdit.Location = new System.Drawing.Point(0, 0);
            this.ucEmployerAddEdit.Name = "ucEmployerAddEdit";
            this.ucEmployerAddEdit.Size = new System.Drawing.Size(10, 10);
            this.ucEmployerAddEdit.TabIndex = 50;
            this.ucEmployerAddEdit.Visible = false;
            this.ucEmployerAddEdit.VisibleChanged += new System.EventHandler(this.ucEmployerAddEdit_VisibleChanged_1);
            // 
            // ucEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucEmployerView);
            this.Controls.Add(this.ucEmployerAddEdit);
            this.Controls.Add(this.btnEmpDel);
            this.Controls.Add(this.btnEmpEdit);
            this.Controls.Add(this.btnEmpAdd);
            this.Controls.Add(this.dgvEmployer);
            this.Controls.Add(this.btnAdvSe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnView);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucEmployer";
            this.Size = new System.Drawing.Size(1155, 500);
            this.Load += new System.EventHandler(this.ucEmployer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdvSe;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.Button btnEmpEdit;
        private System.Windows.Forms.Button btnEmpAdd;
        public System.Windows.Forms.DataGridView dgvEmployer;
        private ucEmployerAddEdit ucEmployerAddEdit;
        private System.Windows.Forms.Button btnView;
        private ucEmployerView ucEmployerView;
    }
}
