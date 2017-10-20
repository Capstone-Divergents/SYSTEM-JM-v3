namespace Findstaff
{
    partial class ucInterviewFin
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
            this.dgvFinInt = new System.Windows.Forms.DataGridView();
            this.lblFinInt = new System.Windows.Forms.Label();
            this.ucIntListFinal = new Findstaff.ucIntListFinal();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinInt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewIntList
            // 
            this.btnViewIntList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewIntList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewIntList.FlatAppearance.BorderSize = 0;
            this.btnViewIntList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIntList.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIntList.ForeColor = System.Drawing.Color.Black;
            this.btnViewIntList.Location = new System.Drawing.Point(459, 345);
            this.btnViewIntList.Name = "btnViewIntList";
            this.btnViewIntList.Size = new System.Drawing.Size(200, 50);
            this.btnViewIntList.TabIndex = 46;
            this.btnViewIntList.Text = "VIEW INTERVIEWEE LIST";
            this.btnViewIntList.UseVisualStyleBackColor = false;
            this.btnViewIntList.Click += new System.EventHandler(this.btnViewIntList_Click);
            // 
            // dgvFinInt
            // 
            this.dgvFinInt.AllowUserToAddRows = false;
            this.dgvFinInt.AllowUserToDeleteRows = false;
            this.dgvFinInt.AllowUserToResizeColumns = false;
            this.dgvFinInt.AllowUserToResizeRows = false;
            this.dgvFinInt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinInt.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFinInt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinInt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinInt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFinInt.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvFinInt.Location = new System.Drawing.Point(100, 100);
            this.dgvFinInt.MultiSelect = false;
            this.dgvFinInt.Name = "dgvFinInt";
            this.dgvFinInt.ReadOnly = true;
            this.dgvFinInt.RowHeadersVisible = false;
            this.dgvFinInt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFinInt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinInt.Size = new System.Drawing.Size(918, 200);
            this.dgvFinInt.TabIndex = 45;
            // 
            // lblFinInt
            // 
            this.lblFinInt.AutoSize = true;
            this.lblFinInt.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinInt.ForeColor = System.Drawing.Color.Black;
            this.lblFinInt.Location = new System.Drawing.Point(25, 25);
            this.lblFinInt.Name = "lblFinInt";
            this.lblFinInt.Size = new System.Drawing.Size(256, 39);
            this.lblFinInt.TabIndex = 44;
            this.lblFinInt.Text = "Final Interview";
            // 
            // ucIntListFinal
            // 
            this.ucIntListFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucIntListFinal.Location = new System.Drawing.Point(0, 0);
            this.ucIntListFinal.Name = "ucIntListFinal";
            this.ucIntListFinal.Size = new System.Drawing.Size(10, 10);
            this.ucIntListFinal.TabIndex = 47;
            this.ucIntListFinal.VisibleChanged += new System.EventHandler(this.ucIntListFinal_VisibleChanged);
            // 
            // ucInterviewFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucIntListFinal);
            this.Controls.Add(this.btnViewIntList);
            this.Controls.Add(this.dgvFinInt);
            this.Controls.Add(this.lblFinInt);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucInterviewFin";
            this.Size = new System.Drawing.Size(1118, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinInt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewIntList;
        private System.Windows.Forms.Label lblFinInt;
        private ucIntListFinal ucIntListFinal;
        public System.Windows.Forms.DataGridView dgvFinInt;
    }
}
