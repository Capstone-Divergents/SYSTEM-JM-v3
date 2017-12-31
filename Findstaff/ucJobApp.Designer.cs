namespace Findstaff
{
    partial class ucJobApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAppMatch = new System.Windows.Forms.TabPage();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnAppMatchInt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAppMatch = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbJobOrder = new System.Windows.Forms.ComboBox();
            this.lblEmployer = new System.Windows.Forms.Label();
            this.cbEmployer = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.tabJobSuggest = new System.Windows.Forms.TabPage();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnJobSuggestInt = new System.Windows.Forms.Button();
            this.dgvJobSuggest = new System.Windows.Forms.DataGridView();
            this.btnResults = new System.Windows.Forms.Button();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lbljaSearch = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAppMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppMatch)).BeginInit();
            this.tabJobSuggest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSuggest)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAppMatch);
            this.tabControl1.Controls.Add(this.tabJobSuggest);
            this.tabControl1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 448);
            this.tabControl1.TabIndex = 38;
            // 
            // tabAppMatch
            // 
            this.tabAppMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tabAppMatch.Controls.Add(this.txtJob);
            this.tabAppMatch.Controls.Add(this.btnAppMatchInt);
            this.tabAppMatch.Controls.Add(this.label1);
            this.tabAppMatch.Controls.Add(this.dgvAppMatch);
            this.tabAppMatch.Controls.Add(this.btnFilter);
            this.tabAppMatch.Controls.Add(this.cbJobOrder);
            this.tabAppMatch.Controls.Add(this.lblEmployer);
            this.tabAppMatch.Controls.Add(this.cbEmployer);
            this.tabAppMatch.Controls.Add(this.lblJob);
            this.tabAppMatch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAppMatch.Location = new System.Drawing.Point(4, 29);
            this.tabAppMatch.Name = "tabAppMatch";
            this.tabAppMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppMatch.Size = new System.Drawing.Size(1097, 415);
            this.tabAppMatch.TabIndex = 0;
            this.tabAppMatch.Text = "Applicant Matching";
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.White;
            this.txtJob.Enabled = false;
            this.txtJob.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.ForeColor = System.Drawing.Color.Black;
            this.txtJob.Location = new System.Drawing.Point(680, 15);
            this.txtJob.MaxLength = 30;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(200, 27);
            this.txtJob.TabIndex = 284;
            // 
            // btnAppMatchInt
            // 
            this.btnAppMatchInt.BackColor = System.Drawing.Color.White;
            this.btnAppMatchInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAppMatchInt.FlatAppearance.BorderSize = 0;
            this.btnAppMatchInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppMatchInt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppMatchInt.ForeColor = System.Drawing.Color.Black;
            this.btnAppMatchInt.Location = new System.Drawing.Point(406, 375);
            this.btnAppMatchInt.Name = "btnAppMatchInt";
            this.btnAppMatchInt.Size = new System.Drawing.Size(309, 33);
            this.btnAppMatchInt.TabIndex = 40;
            this.btnAppMatchInt.Text = "SCHEDULE INITIAL INTERVIEW";
            this.btnAppMatchInt.UseVisualStyleBackColor = false;
            this.btnAppMatchInt.Click += new System.EventHandler(this.btnAppMatchInt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(632, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Job :";
            // 
            // dgvAppMatch
            // 
            this.dgvAppMatch.AllowUserToAddRows = false;
            this.dgvAppMatch.AllowUserToDeleteRows = false;
            this.dgvAppMatch.AllowUserToResizeColumns = false;
            this.dgvAppMatch.AllowUserToResizeRows = false;
            this.dgvAppMatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppMatch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAppMatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppMatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAppMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppMatch.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAppMatch.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvAppMatch.Location = new System.Drawing.Point(22, 50);
            this.dgvAppMatch.Name = "dgvAppMatch";
            this.dgvAppMatch.ReadOnly = true;
            this.dgvAppMatch.RowHeadersVisible = false;
            this.dgvAppMatch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppMatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppMatch.Size = new System.Drawing.Size(1054, 318);
            this.dgvAppMatch.TabIndex = 18;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(976, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbJobOrder
            // 
            this.cbJobOrder.BackColor = System.Drawing.Color.White;
            this.cbJobOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobOrder.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJobOrder.ForeColor = System.Drawing.Color.Black;
            this.cbJobOrder.FormattingEnabled = true;
            this.cbJobOrder.Location = new System.Drawing.Point(419, 15);
            this.cbJobOrder.Name = "cbJobOrder";
            this.cbJobOrder.Size = new System.Drawing.Size(200, 28);
            this.cbJobOrder.TabIndex = 16;
            this.cbJobOrder.SelectedIndexChanged += new System.EventHandler(this.cbJobOrder_SelectedIndexChanged);
            // 
            // lblEmployer
            // 
            this.lblEmployer.AutoSize = true;
            this.lblEmployer.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployer.ForeColor = System.Drawing.Color.Black;
            this.lblEmployer.Location = new System.Drawing.Point(323, 18);
            this.lblEmployer.Name = "lblEmployer";
            this.lblEmployer.Size = new System.Drawing.Size(90, 20);
            this.lblEmployer.TabIndex = 15;
            this.lblEmployer.Text = "Job Order :";
            // 
            // cbEmployer
            // 
            this.cbEmployer.BackColor = System.Drawing.Color.White;
            this.cbEmployer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployer.ForeColor = System.Drawing.Color.Black;
            this.cbEmployer.FormattingEnabled = true;
            this.cbEmployer.Location = new System.Drawing.Point(117, 15);
            this.cbEmployer.Name = "cbEmployer";
            this.cbEmployer.Size = new System.Drawing.Size(200, 28);
            this.cbEmployer.TabIndex = 14;
            this.cbEmployer.SelectedIndexChanged += new System.EventHandler(this.cbEmployer_SelectedIndexChanged);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.Location = new System.Drawing.Point(25, 18);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(85, 20);
            this.lblJob.TabIndex = 13;
            this.lblJob.Text = "Employer:";
            // 
            // tabJobSuggest
            // 
            this.tabJobSuggest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tabJobSuggest.Controls.Add(this.txtMiddle);
            this.tabJobSuggest.Controls.Add(this.txtFirst);
            this.tabJobSuggest.Controls.Add(this.btnJobSuggestInt);
            this.tabJobSuggest.Controls.Add(this.dgvJobSuggest);
            this.tabJobSuggest.Controls.Add(this.btnResults);
            this.tabJobSuggest.Controls.Add(this.txtLast);
            this.tabJobSuggest.Controls.Add(this.lbljaSearch);
            this.tabJobSuggest.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabJobSuggest.Location = new System.Drawing.Point(4, 29);
            this.tabJobSuggest.Name = "tabJobSuggest";
            this.tabJobSuggest.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobSuggest.Size = new System.Drawing.Size(1097, 415);
            this.tabJobSuggest.TabIndex = 1;
            this.tabJobSuggest.Text = "Job Suggestion";
            // 
            // txtMiddle
            // 
            this.txtMiddle.BackColor = System.Drawing.Color.White;
            this.txtMiddle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddle.ForeColor = System.Drawing.Color.DimGray;
            this.txtMiddle.Location = new System.Drawing.Point(498, 16);
            this.txtMiddle.MaxLength = 30;
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(193, 27);
            this.txtMiddle.TabIndex = 43;
            this.txtMiddle.Text = "Middle Name";
            this.txtMiddle.Click += new System.EventHandler(this.txtMiddle_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.White;
            this.txtFirst.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirst.Location = new System.Drawing.Point(299, 16);
            this.txtFirst.MaxLength = 30;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(193, 27);
            this.txtFirst.TabIndex = 42;
            this.txtFirst.Text = "First Name";
            this.txtFirst.Click += new System.EventHandler(this.txtFirst_Click);
            // 
            // btnJobSuggestInt
            // 
            this.btnJobSuggestInt.BackColor = System.Drawing.Color.White;
            this.btnJobSuggestInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJobSuggestInt.FlatAppearance.BorderSize = 0;
            this.btnJobSuggestInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobSuggestInt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobSuggestInt.ForeColor = System.Drawing.Color.Black;
            this.btnJobSuggestInt.Location = new System.Drawing.Point(393, 375);
            this.btnJobSuggestInt.Name = "btnJobSuggestInt";
            this.btnJobSuggestInt.Size = new System.Drawing.Size(309, 33);
            this.btnJobSuggestInt.TabIndex = 41;
            this.btnJobSuggestInt.Text = "SCHEDULE INITIAL INTERVIEW";
            this.btnJobSuggestInt.UseVisualStyleBackColor = false;
            this.btnJobSuggestInt.Click += new System.EventHandler(this.btnJobSuggestInt_Click);
            // 
            // dgvJobSuggest
            // 
            this.dgvJobSuggest.AllowUserToAddRows = false;
            this.dgvJobSuggest.AllowUserToDeleteRows = false;
            this.dgvJobSuggest.AllowUserToResizeColumns = false;
            this.dgvJobSuggest.AllowUserToResizeRows = false;
            this.dgvJobSuggest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobSuggest.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvJobSuggest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobSuggest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvJobSuggest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobSuggest.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvJobSuggest.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvJobSuggest.Location = new System.Drawing.Point(20, 49);
            this.dgvJobSuggest.Name = "dgvJobSuggest";
            this.dgvJobSuggest.ReadOnly = true;
            this.dgvJobSuggest.RowHeadersVisible = false;
            this.dgvJobSuggest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJobSuggest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobSuggest.Size = new System.Drawing.Size(1054, 318);
            this.dgvJobSuggest.TabIndex = 19;
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.White;
            this.btnResults.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.Black;
            this.btnResults.Location = new System.Drawing.Point(974, 13);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(100, 30);
            this.btnResults.TabIndex = 18;
            this.btnResults.Text = "RESULTS";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.White;
            this.txtLast.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.ForeColor = System.Drawing.Color.DimGray;
            this.txtLast.Location = new System.Drawing.Point(100, 16);
            this.txtLast.MaxLength = 30;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(193, 27);
            this.txtLast.TabIndex = 11;
            this.txtLast.Text = "Last Name";
            this.txtLast.Click += new System.EventHandler(this.txtLast_Click);
            this.txtLast.TextChanged += new System.EventHandler(this.txtLast_TextChanged);
            // 
            // lbljaSearch
            // 
            this.lbljaSearch.AutoSize = true;
            this.lbljaSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbljaSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljaSearch.ForeColor = System.Drawing.Color.Black;
            this.lbljaSearch.Location = new System.Drawing.Point(25, 19);
            this.lbljaSearch.Name = "lbljaSearch";
            this.lbljaSearch.Size = new System.Drawing.Size(68, 20);
            this.lbljaSearch.TabIndex = 10;
            this.lbljaSearch.Text = "Search :";
            // 
            // ucJobApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucJobApp";
            this.Size = new System.Drawing.Size(1155, 500);
            this.VisibleChanged += new System.EventHandler(this.ucJobApp_VisibleChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabAppMatch.ResumeLayout(false);
            this.tabAppMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppMatch)).EndInit();
            this.tabJobSuggest.ResumeLayout(false);
            this.tabJobSuggest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSuggest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblEmployer;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lbljaSearch;
        public System.Windows.Forms.DataGridView dgvAppMatch;
        public System.Windows.Forms.DataGridView dgvJobSuggest;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnAppMatchInt;
        public System.Windows.Forms.Button btnJobSuggestInt;
        public System.Windows.Forms.TabPage tabAppMatch;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabJobSuggest;
        public System.Windows.Forms.ComboBox cbJobOrder;
        public System.Windows.Forms.ComboBox cbEmployer;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtFirst;
        public System.Windows.Forms.TextBox txtJob;
    }
}
