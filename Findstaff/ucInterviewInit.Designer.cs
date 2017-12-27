namespace Findstaff
{
    partial class ucInterviewInit
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
            this.btnViewIntList = new System.Windows.Forms.Button();
            this.dgvInitInt = new System.Windows.Forms.DataGridView();
            this.ucIntListInit = new Findstaff.ucIntListInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitInt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewIntList
            // 
            this.btnViewIntList.BackColor = System.Drawing.Color.White;
            this.btnViewIntList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewIntList.FlatAppearance.BorderSize = 0;
            this.btnViewIntList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIntList.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIntList.ForeColor = System.Drawing.Color.Black;
            this.btnViewIntList.Location = new System.Drawing.Point(452, 440);
            this.btnViewIntList.Name = "btnViewIntList";
            this.btnViewIntList.Size = new System.Drawing.Size(248, 43);
            this.btnViewIntList.TabIndex = 43;
            this.btnViewIntList.Text = "VIEW INTERVIEWEE LIST";
            this.btnViewIntList.UseVisualStyleBackColor = false;
            this.btnViewIntList.Click += new System.EventHandler(this.btnViewIntList_Click);
            // 
            // dgvInitInt
            // 
            this.dgvInitInt.AllowUserToAddRows = false;
            this.dgvInitInt.AllowUserToDeleteRows = false;
            this.dgvInitInt.AllowUserToResizeColumns = false;
            this.dgvInitInt.AllowUserToResizeRows = false;
            this.dgvInitInt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInitInt.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvInitInt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInitInt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInitInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInitInt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInitInt.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvInitInt.Location = new System.Drawing.Point(25, 25);
            this.dgvInitInt.MultiSelect = false;
            this.dgvInitInt.Name = "dgvInitInt";
            this.dgvInitInt.ReadOnly = true;
            this.dgvInitInt.RowHeadersVisible = false;
            this.dgvInitInt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInitInt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInitInt.Size = new System.Drawing.Size(1103, 388);
            this.dgvInitInt.TabIndex = 42;
            // 
            // ucIntListInit
            // 
            this.ucIntListInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucIntListInit.ForeColor = System.Drawing.Color.Black;
            this.ucIntListInit.Location = new System.Drawing.Point(3, 3);
            this.ucIntListInit.Name = "ucIntListInit";
            this.ucIntListInit.Size = new System.Drawing.Size(10, 10);
            this.ucIntListInit.TabIndex = 44;
            this.ucIntListInit.Visible = false;
            // 
            // ucInterviewInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucIntListInit);
            this.Controls.Add(this.btnViewIntList);
            this.Controls.Add(this.dgvInitInt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucInterviewInit";
            this.Size = new System.Drawing.Size(1155, 500);
            this.Load += new System.EventHandler(this.ucInterviewInit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitInt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewIntList;
        public System.Windows.Forms.DataGridView dgvInitInt;
        private ucIntListInit ucIntListInit;
    }
}
