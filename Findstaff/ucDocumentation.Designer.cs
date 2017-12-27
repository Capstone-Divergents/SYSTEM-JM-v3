namespace Findstaff
{
    partial class ucDocumentation
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
            this.dgvDocumentation = new System.Windows.Forms.DataGridView();
            this.btnAdvSe = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnCheckDetails = new System.Windows.Forms.Button();
            this.ucDocAppDetails = new Findstaff.ucDocAppDetails();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // dgvDocumentation
            // 
            this.dgvDocumentation.AllowUserToAddRows = false;
            this.dgvDocumentation.AllowUserToDeleteRows = false;
            this.dgvDocumentation.AllowUserToResizeColumns = false;
            this.dgvDocumentation.AllowUserToResizeRows = false;
            this.dgvDocumentation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocumentation.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDocumentation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocumentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumentation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocumentation.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDocumentation.Location = new System.Drawing.Point(48, 62);
            this.dgvDocumentation.MultiSelect = false;
            this.dgvDocumentation.Name = "dgvDocumentation";
            this.dgvDocumentation.ReadOnly = true;
            this.dgvDocumentation.RowHeadersVisible = false;
            this.dgvDocumentation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDocumentation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentation.Size = new System.Drawing.Size(1056, 360);
            this.dgvDocumentation.TabIndex = 51;
            // 
            // btnAdvSe
            // 
            this.btnAdvSe.BackColor = System.Drawing.Color.White;
            this.btnAdvSe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvSe.FlatAppearance.BorderSize = 0;
            this.btnAdvSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvSe.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvSe.ForeColor = System.Drawing.Color.Black;
            this.btnAdvSe.Location = new System.Drawing.Point(349, 20);
            this.btnAdvSe.Name = "btnAdvSe";
            this.btnAdvSe.Size = new System.Drawing.Size(250, 30);
            this.btnAdvSe.TabIndex = 50;
            this.btnAdvSe.Text = "ADVANCED SEARCH";
            this.btnAdvSe.UseVisualStyleBackColor = false;
            this.btnAdvSe.Visible = false;
            this.btnAdvSe.Click += new System.EventHandler(this.btnAdvSe_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(143, 22);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 48;
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
            this.lblSearch.Size = new System.Drawing.Size(112, 20);
            this.lblSearch.TabIndex = 47;
            this.lblSearch.Text = "Search Name:";
            // 
            // btnCheckDetails
            // 
            this.btnCheckDetails.BackColor = System.Drawing.Color.White;
            this.btnCheckDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckDetails.FlatAppearance.BorderSize = 0;
            this.btnCheckDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDetails.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckDetails.ForeColor = System.Drawing.Color.Black;
            this.btnCheckDetails.Location = new System.Drawing.Point(476, 435);
            this.btnCheckDetails.Name = "btnCheckDetails";
            this.btnCheckDetails.Size = new System.Drawing.Size(200, 50);
            this.btnCheckDetails.TabIndex = 46;
            this.btnCheckDetails.Text = "CHECK DETAILS";
            this.btnCheckDetails.UseVisualStyleBackColor = false;
            this.btnCheckDetails.Click += new System.EventHandler(this.btnCheckDetails_Click);
            // 
            // ucDocAppDetails
            // 
            this.ucDocAppDetails.AutoScroll = true;
            this.ucDocAppDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucDocAppDetails.ForeColor = System.Drawing.Color.Black;
            this.ucDocAppDetails.Location = new System.Drawing.Point(3, 3);
            this.ucDocAppDetails.Name = "ucDocAppDetails";
            this.ucDocAppDetails.Size = new System.Drawing.Size(10, 10);
            this.ucDocAppDetails.TabIndex = 52;
            this.ucDocAppDetails.Visible = false;
            // 
            // ucDocumentation
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucDocAppDetails);
            this.Controls.Add(this.dgvDocumentation);
            this.Controls.Add(this.btnAdvSe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCheckDetails);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucDocumentation";
            this.Size = new System.Drawing.Size(1118, 500);
            this.Load += new System.EventHandler(this.ucDocumentation_Load);
            this.VisibleChanged += new System.EventHandler(this.ucDocumentation_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdvSe;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCheckDetails;
        public System.Windows.Forms.DataGridView dgvDocumentation;
        private ucDocAppDetails ucDocAppDetails;
    }
}
