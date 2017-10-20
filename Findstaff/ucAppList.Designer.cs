namespace Findstaff
{
    partial class ucAppList
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
            this.btnView = new System.Windows.Forms.Button();
            this.dgvAppList = new System.Windows.Forms.DataGridView();
            this.btnAdvSe = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblalSearch = new System.Windows.Forms.Label();
            this.lblApplicantList = new System.Windows.Forms.Label();
            this.ucAppView = new Findstaff.ucAppView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gainsboro;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(509, 371);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 50);
            this.btnView.TabIndex = 44;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvAppList
            // 
            this.dgvAppList.AllowUserToAddRows = false;
            this.dgvAppList.AllowUserToDeleteRows = false;
            this.dgvAppList.AllowUserToResizeColumns = false;
            this.dgvAppList.AllowUserToResizeRows = false;
            this.dgvAppList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAppList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppList.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvAppList.Location = new System.Drawing.Point(50, 140);
            this.dgvAppList.MultiSelect = false;
            this.dgvAppList.Name = "dgvAppList";
            this.dgvAppList.ReadOnly = true;
            this.dgvAppList.RowHeadersVisible = false;
            this.dgvAppList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppList.Size = new System.Drawing.Size(1018, 200);
            this.dgvAppList.TabIndex = 43;
            // 
            // btnAdvSe
            // 
            this.btnAdvSe.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdvSe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvSe.FlatAppearance.BorderSize = 0;
            this.btnAdvSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvSe.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvSe.ForeColor = System.Drawing.Color.Black;
            this.btnAdvSe.Location = new System.Drawing.Point(518, 96);
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
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(223, 97);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 26);
            this.txtName.TabIndex = 40;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblalSearch
            // 
            this.lblalSearch.AutoSize = true;
            this.lblalSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblalSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalSearch.ForeColor = System.Drawing.Color.Black;
            this.lblalSearch.Location = new System.Drawing.Point(100, 100);
            this.lblalSearch.Name = "lblalSearch";
            this.lblalSearch.Size = new System.Drawing.Size(117, 19);
            this.lblalSearch.TabIndex = 39;
            this.lblalSearch.Text = "Search Name :";
            // 
            // lblApplicantList
            // 
            this.lblApplicantList.AutoSize = true;
            this.lblApplicantList.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantList.ForeColor = System.Drawing.Color.Black;
            this.lblApplicantList.Location = new System.Drawing.Point(25, 25);
            this.lblApplicantList.Name = "lblApplicantList";
            this.lblApplicantList.Size = new System.Drawing.Size(236, 39);
            this.lblApplicantList.TabIndex = 38;
            this.lblApplicantList.Text = "Applicant List";
            // 
            // ucAppView
            // 
            this.ucAppView.AutoScroll = true;
            this.ucAppView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucAppView.Location = new System.Drawing.Point(0, 0);
            this.ucAppView.Name = "ucAppView";
            this.ucAppView.Size = new System.Drawing.Size(10, 10);
            this.ucAppView.TabIndex = 47;
            this.ucAppView.Visible = false;
            // 
            // ucAppList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucAppView);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvAppList);
            this.Controls.Add(this.btnAdvSe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblalSearch);
            this.Controls.Add(this.lblApplicantList);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucAppList";
            this.Size = new System.Drawing.Size(1118, 450);
            this.Load += new System.EventHandler(this.ucAppList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdvSe;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblalSearch;
        private System.Windows.Forms.Label lblApplicantList;
        private ucAppView ucAppView;
        public System.Windows.Forms.DataGridView dgvAppList;
    }
}
