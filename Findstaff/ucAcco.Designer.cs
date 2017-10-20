namespace Findstaff
{
    partial class ucAcco
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
            this.dgvAccounting = new System.Windows.Forms.DataGridView();
            this.btnAdvSe = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnViewAcco = new System.Windows.Forms.Button();
            this.lblAcco = new System.Windows.Forms.Label();
            this.ucAccoView = new Findstaff.ucAccoView();
            this.pnlTabs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounting)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccounting
            // 
            this.dgvAccounting.AllowUserToAddRows = false;
            this.dgvAccounting.AllowUserToDeleteRows = false;
            this.dgvAccounting.AllowUserToResizeColumns = false;
            this.dgvAccounting.AllowUserToResizeRows = false;
            this.dgvAccounting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounting.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAccounting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounting.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounting.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvAccounting.Location = new System.Drawing.Point(50, 200);
            this.dgvAccounting.MultiSelect = false;
            this.dgvAccounting.Name = "dgvAccounting";
            this.dgvAccounting.ReadOnly = true;
            this.dgvAccounting.RowHeadersVisible = false;
            this.dgvAccounting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccounting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounting.Size = new System.Drawing.Size(1018, 200);
            this.dgvAccounting.TabIndex = 56;
            // 
            // btnAdvSe
            // 
            this.btnAdvSe.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdvSe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvSe.FlatAppearance.BorderSize = 0;
            this.btnAdvSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvSe.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvSe.ForeColor = System.Drawing.Color.Black;
            this.btnAdvSe.Location = new System.Drawing.Point(487, 144);
            this.btnAdvSe.Name = "btnAdvSe";
            this.btnAdvSe.Size = new System.Drawing.Size(250, 30);
            this.btnAdvSe.TabIndex = 55;
            this.btnAdvSe.Text = "ADVANCED SEARCH";
            this.btnAdvSe.UseVisualStyleBackColor = false;
            this.btnAdvSe.Visible = false;
            this.btnAdvSe.Click += new System.EventHandler(this.btnAdvSe_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(381, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(175, 147);
            this.txtSearch.MaxLength = 30;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 26);
            this.txtSearch.TabIndex = 53;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(100, 150);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(69, 19);
            this.lblSearch.TabIndex = 52;
            this.lblSearch.Text = "Search :";
            // 
            // btnViewAcco
            // 
            this.btnViewAcco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewAcco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewAcco.FlatAppearance.BorderSize = 0;
            this.btnViewAcco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnViewAcco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnViewAcco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAcco.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAcco.ForeColor = System.Drawing.Color.Black;
            this.btnViewAcco.Location = new System.Drawing.Point(459, 425);
            this.btnViewAcco.Name = "btnViewAcco";
            this.btnViewAcco.Size = new System.Drawing.Size(200, 50);
            this.btnViewAcco.TabIndex = 51;
            this.btnViewAcco.Text = "VIEW ACCOUNT";
            this.btnViewAcco.UseVisualStyleBackColor = false;
            this.btnViewAcco.Click += new System.EventHandler(this.btnViewAcco_Click);
            // 
            // lblAcco
            // 
            this.lblAcco.AutoSize = true;
            this.lblAcco.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcco.ForeColor = System.Drawing.Color.Black;
            this.lblAcco.Location = new System.Drawing.Point(25, 75);
            this.lblAcco.Name = "lblAcco";
            this.lblAcco.Size = new System.Drawing.Size(195, 39);
            this.lblAcco.TabIndex = 50;
            this.lblAcco.Text = "Accounting";
            // 
            // ucAccoView
            // 
            this.ucAccoView.AutoScroll = true;
            this.ucAccoView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucAccoView.Location = new System.Drawing.Point(0, 0);
            this.ucAccoView.Name = "ucAccoView";
            this.ucAccoView.Size = new System.Drawing.Size(15, 15);
            this.ucAccoView.TabIndex = 57;
            this.ucAccoView.Visible = false;
            this.ucAccoView.VisibleChanged += new System.EventHandler(this.ucAccoView_VisibleChanged);
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 58;
            // 
            // ucAcco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.ucAccoView);
            this.Controls.Add(this.dgvAccounting);
            this.Controls.Add(this.btnAdvSe);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnViewAcco);
            this.Controls.Add(this.lblAcco);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucAcco";
            this.Size = new System.Drawing.Size(1118, 500);
            this.VisibleChanged += new System.EventHandler(this.ucAcco_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdvSe;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnViewAcco;
        private System.Windows.Forms.Label lblAcco;
        private ucAccoView ucAccoView;
        private System.Windows.Forms.Panel pnlTabs;
        public System.Windows.Forms.DataGridView dgvAccounting;
    }
}
