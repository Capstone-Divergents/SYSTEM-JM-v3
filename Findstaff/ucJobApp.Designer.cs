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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSetForInitInt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAppMatch = new System.Windows.Forms.TabPage();
            this.dgvAppMatch = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbJobOrder = new System.Windows.Forms.ComboBox();
            this.lblEmployer = new System.Windows.Forms.Label();
            this.cbEmployer = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.tabJobSuggest = new System.Windows.Forms.TabPage();
            this.dgvJobSuggest = new System.Windows.Forms.DataGridView();
            this.btnResults = new System.Windows.Forms.Button();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lbljaSearch = new System.Windows.Forms.Label();
            this.lblJobApp = new System.Windows.Forms.Label();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAppMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppMatch)).BeginInit();
            this.tabJobSuggest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSuggest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetForInitInt
            // 
            this.btnSetForInitInt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSetForInitInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSetForInitInt.FlatAppearance.BorderSize = 0;
            this.btnSetForInitInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetForInitInt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetForInitInt.ForeColor = System.Drawing.Color.Black;
            this.btnSetForInitInt.Location = new System.Drawing.Point(459, 380);
            this.btnSetForInitInt.Name = "btnSetForInitInt";
            this.btnSetForInitInt.Size = new System.Drawing.Size(200, 50);
            this.btnSetForInitInt.TabIndex = 39;
            this.btnSetForInitInt.Text = "SET FOR INITIAL INTERVIEW";
            this.btnSetForInitInt.UseVisualStyleBackColor = false;
            this.btnSetForInitInt.Click += new System.EventHandler(this.btnSetForInitInt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAppMatch);
            this.tabControl1.Controls.Add(this.tabJobSuggest);
            this.tabControl1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(32, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1071, 280);
            this.tabControl1.TabIndex = 38;
            // 
            // tabAppMatch
            // 
            this.tabAppMatch.BackColor = System.Drawing.Color.White;
            this.tabAppMatch.Controls.Add(this.cbJob);
            this.tabAppMatch.Controls.Add(this.label1);
            this.tabAppMatch.Controls.Add(this.dgvAppMatch);
            this.tabAppMatch.Controls.Add(this.btnFilter);
            this.tabAppMatch.Controls.Add(this.cbJobOrder);
            this.tabAppMatch.Controls.Add(this.lblEmployer);
            this.tabAppMatch.Controls.Add(this.cbEmployer);
            this.tabAppMatch.Controls.Add(this.lblJob);
            this.tabAppMatch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAppMatch.Location = new System.Drawing.Point(4, 28);
            this.tabAppMatch.Name = "tabAppMatch";
            this.tabAppMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppMatch.Size = new System.Drawing.Size(1063, 248);
            this.tabAppMatch.TabIndex = 0;
            this.tabAppMatch.Text = "Applicant Matching";
            // 
            // dgvAppMatch
            // 
            this.dgvAppMatch.AllowUserToAddRows = false;
            this.dgvAppMatch.AllowUserToDeleteRows = false;
            this.dgvAppMatch.AllowUserToResizeColumns = false;
            this.dgvAppMatch.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppMatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAppMatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppMatch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAppMatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppMatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAppMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppMatch.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAppMatch.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvAppMatch.Location = new System.Drawing.Point(22, 75);
            this.dgvAppMatch.MultiSelect = false;
            this.dgvAppMatch.Name = "dgvAppMatch";
            this.dgvAppMatch.ReadOnly = true;
            this.dgvAppMatch.RowHeadersVisible = false;
            this.dgvAppMatch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppMatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppMatch.Size = new System.Drawing.Size(1022, 150);
            this.dgvAppMatch.TabIndex = 18;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(944, 22);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // cbJobOrder
            // 
            this.cbJobOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.cbJobOrder.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJobOrder.ForeColor = System.Drawing.Color.Black;
            this.cbJobOrder.FormattingEnabled = true;
            this.cbJobOrder.Location = new System.Drawing.Point(419, 22);
            this.cbJobOrder.Name = "cbJobOrder";
            this.cbJobOrder.Size = new System.Drawing.Size(200, 27);
            this.cbJobOrder.TabIndex = 16;
            this.cbJobOrder.SelectedIndexChanged += new System.EventHandler(this.cbJobOrder_SelectedIndexChanged);
            // 
            // lblEmployer
            // 
            this.lblEmployer.AutoSize = true;
            this.lblEmployer.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployer.ForeColor = System.Drawing.Color.Black;
            this.lblEmployer.Location = new System.Drawing.Point(323, 25);
            this.lblEmployer.Name = "lblEmployer";
            this.lblEmployer.Size = new System.Drawing.Size(92, 19);
            this.lblEmployer.TabIndex = 15;
            this.lblEmployer.Text = "Job Order :";
            // 
            // cbEmployer
            // 
            this.cbEmployer.BackColor = System.Drawing.Color.Gainsboro;
            this.cbEmployer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployer.ForeColor = System.Drawing.Color.Black;
            this.cbEmployer.FormattingEnabled = true;
            this.cbEmployer.Location = new System.Drawing.Point(117, 22);
            this.cbEmployer.Name = "cbEmployer";
            this.cbEmployer.Size = new System.Drawing.Size(200, 27);
            this.cbEmployer.TabIndex = 14;
            this.cbEmployer.SelectedIndexChanged += new System.EventHandler(this.cbEmployer_SelectedIndexChanged);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.Location = new System.Drawing.Point(25, 25);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(86, 19);
            this.lblJob.TabIndex = 13;
            this.lblJob.Text = "Employer:";
            // 
            // tabJobSuggest
            // 
            this.tabJobSuggest.BackColor = System.Drawing.Color.White;
            this.tabJobSuggest.Controls.Add(this.dgvJobSuggest);
            this.tabJobSuggest.Controls.Add(this.btnResults);
            this.tabJobSuggest.Controls.Add(this.txtMiddle);
            this.tabJobSuggest.Controls.Add(this.txtFirst);
            this.tabJobSuggest.Controls.Add(this.txtLast);
            this.tabJobSuggest.Controls.Add(this.lbljaSearch);
            this.tabJobSuggest.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabJobSuggest.Location = new System.Drawing.Point(4, 28);
            this.tabJobSuggest.Name = "tabJobSuggest";
            this.tabJobSuggest.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobSuggest.Size = new System.Drawing.Size(910, 248);
            this.tabJobSuggest.TabIndex = 1;
            this.tabJobSuggest.Text = "Job Suggestion";
            // 
            // dgvJobSuggest
            // 
            this.dgvJobSuggest.AllowUserToAddRows = false;
            this.dgvJobSuggest.AllowUserToDeleteRows = false;
            this.dgvJobSuggest.AllowUserToResizeColumns = false;
            this.dgvJobSuggest.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvJobSuggest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvJobSuggest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobSuggest.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvJobSuggest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobSuggest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvJobSuggest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobSuggest.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvJobSuggest.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvJobSuggest.Location = new System.Drawing.Point(75, 75);
            this.dgvJobSuggest.MultiSelect = false;
            this.dgvJobSuggest.Name = "dgvJobSuggest";
            this.dgvJobSuggest.ReadOnly = true;
            this.dgvJobSuggest.RowHeadersVisible = false;
            this.dgvJobSuggest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvJobSuggest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobSuggest.Size = new System.Drawing.Size(750, 150);
            this.dgvJobSuggest.TabIndex = 19;
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.Gainsboro;
            this.btnResults.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.Black;
            this.btnResults.Location = new System.Drawing.Point(478, 19);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(100, 30);
            this.btnResults.TabIndex = 18;
            this.btnResults.Text = "RESULTS";
            this.btnResults.UseVisualStyleBackColor = false;
            // 
            // txtMiddle
            // 
            this.txtMiddle.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMiddle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddle.ForeColor = System.Drawing.Color.DimGray;
            this.txtMiddle.Location = new System.Drawing.Point(352, 22);
            this.txtMiddle.MaxLength = 30;
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(120, 26);
            this.txtMiddle.TabIndex = 15;
            this.txtMiddle.Text = "Middle Name";
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFirst.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirst.Location = new System.Drawing.Point(226, 22);
            this.txtFirst.MaxLength = 30;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(120, 26);
            this.txtFirst.TabIndex = 13;
            this.txtFirst.Text = "First Name";
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLast.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.ForeColor = System.Drawing.Color.DimGray;
            this.txtLast.Location = new System.Drawing.Point(100, 22);
            this.txtLast.MaxLength = 30;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(120, 26);
            this.txtLast.TabIndex = 11;
            this.txtLast.Text = "Last Name";
            // 
            // lbljaSearch
            // 
            this.lbljaSearch.AutoSize = true;
            this.lbljaSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbljaSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljaSearch.ForeColor = System.Drawing.Color.Black;
            this.lbljaSearch.Location = new System.Drawing.Point(25, 25);
            this.lbljaSearch.Name = "lbljaSearch";
            this.lbljaSearch.Size = new System.Drawing.Size(69, 19);
            this.lbljaSearch.TabIndex = 10;
            this.lbljaSearch.Text = "Search :";
            // 
            // lblJobApp
            // 
            this.lblJobApp.AutoSize = true;
            this.lblJobApp.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobApp.ForeColor = System.Drawing.Color.Black;
            this.lblJobApp.Location = new System.Drawing.Point(25, 25);
            this.lblJobApp.Name = "lblJobApp";
            this.lblJobApp.Size = new System.Drawing.Size(591, 39);
            this.lblJobApp.TabIndex = 37;
            this.lblJobApp.Text = "Applicant Matching / Job Suggestion";
            // 
            // cbJob
            // 
            this.cbJob.BackColor = System.Drawing.Color.Gainsboro;
            this.cbJob.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJob.ForeColor = System.Drawing.Color.Black;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(680, 22);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(200, 27);
            this.cbJob.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(632, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Job :";
            // 
            // ucJobApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnSetForInitInt);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblJobApp);
            this.Name = "ucJobApp";
            this.Size = new System.Drawing.Size(1118, 450);
            this.VisibleChanged += new System.EventHandler(this.ucJobApp_VisibleChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabAppMatch.ResumeLayout(false);
            this.tabAppMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppMatch)).EndInit();
            this.tabJobSuggest.ResumeLayout(false);
            this.tabJobSuggest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSuggest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAppMatch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbJobOrder;
        private System.Windows.Forms.Label lblEmployer;
        private System.Windows.Forms.ComboBox cbEmployer;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TabPage tabJobSuggest;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lbljaSearch;
        private System.Windows.Forms.Label lblJobApp;
        public System.Windows.Forms.Button btnSetForInitInt;
        public System.Windows.Forms.DataGridView dgvAppMatch;
        public System.Windows.Forms.DataGridView dgvJobSuggest;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label label1;
    }
}
