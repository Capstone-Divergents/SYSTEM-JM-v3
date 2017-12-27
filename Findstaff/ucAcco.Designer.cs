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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAccounting = new System.Windows.Forms.DataGridView();
            this.btnAdvSe = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnViewAcco = new System.Windows.Forms.Button();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.ucAccoView = new Findstaff.ucAccoView();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounting.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccounting.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvAccounting.Location = new System.Drawing.Point(50, 109);
            this.dgvAccounting.MultiSelect = false;
            this.dgvAccounting.Name = "dgvAccounting";
            this.dgvAccounting.ReadOnly = true;
            this.dgvAccounting.RowHeadersVisible = false;
            this.dgvAccounting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAccounting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounting.Size = new System.Drawing.Size(1059, 373);
            this.dgvAccounting.TabIndex = 56;
            // 
            // btnAdvSe
            // 
            this.btnAdvSe.BackColor = System.Drawing.Color.White;
            this.btnAdvSe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvSe.FlatAppearance.BorderSize = 0;
            this.btnAdvSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvSe.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvSe.ForeColor = System.Drawing.Color.Black;
            this.btnAdvSe.Location = new System.Drawing.Point(359, 73);
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
            this.txtName.Location = new System.Drawing.Point(120, 73);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 27);
            this.txtName.TabIndex = 53;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(46, 76);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 52;
            this.lblSearch.Text = "Search :";
            // 
            // btnViewAcco
            // 
            this.btnViewAcco.BackColor = System.Drawing.Color.White;
            this.btnViewAcco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewAcco.FlatAppearance.BorderSize = 0;
            this.btnViewAcco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnViewAcco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnViewAcco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAcco.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAcco.ForeColor = System.Drawing.Color.Black;
            this.btnViewAcco.Location = new System.Drawing.Point(479, 492);
            this.btnViewAcco.Name = "btnViewAcco";
            this.btnViewAcco.Size = new System.Drawing.Size(200, 39);
            this.btnViewAcco.TabIndex = 51;
            this.btnViewAcco.Text = "VIEW ACCOUNT";
            this.btnViewAcco.UseVisualStyleBackColor = false;
            this.btnViewAcco.Click += new System.EventHandler(this.btnViewAcco_Click);
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1155, 50);
            this.pnlTabs.TabIndex = 58;
            // 
            // ucAccoView
            // 
            this.ucAccoView.AutoScroll = true;
            this.ucAccoView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucAccoView.ForeColor = System.Drawing.Color.Black;
            this.ucAccoView.Location = new System.Drawing.Point(0, 0);
            this.ucAccoView.Name = "ucAccoView";
            this.ucAccoView.Size = new System.Drawing.Size(15, 15);
            this.ucAccoView.TabIndex = 57;
            this.ucAccoView.Visible = false;
            this.ucAccoView.VisibleChanged += new System.EventHandler(this.ucAccoView_VisibleChanged);
            // 
            // ucAcco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.ucAccoView);
            this.Controls.Add(this.dgvAccounting);
            this.Controls.Add(this.btnAdvSe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnViewAcco);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucAcco";
            this.Size = new System.Drawing.Size(1155, 546);
            this.Load += new System.EventHandler(this.ucAcco_Load);
            this.VisibleChanged += new System.EventHandler(this.ucAcco_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdvSe;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnViewAcco;
        private ucAccoView ucAccoView;
        private System.Windows.Forms.Panel pnlTabs;
        public System.Windows.Forms.DataGridView dgvAccounting;
    }
}
