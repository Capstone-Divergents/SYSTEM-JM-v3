namespace Findstaff
{
    partial class ucFlightBooking
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
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnReschedule = new System.Windows.Forms.Button();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.dgvFlightBooking = new System.Windows.Forms.DataGridView();
            this.lblFlightBooking = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 61;
            // 
            // btnReschedule
            // 
            this.btnReschedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReschedule.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReschedule.FlatAppearance.BorderSize = 0;
            this.btnReschedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnReschedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReschedule.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReschedule.ForeColor = System.Drawing.Color.Black;
            this.btnReschedule.Location = new System.Drawing.Point(484, 400);
            this.btnReschedule.Name = "btnReschedule";
            this.btnReschedule.Size = new System.Drawing.Size(150, 50);
            this.btnReschedule.TabIndex = 65;
            this.btnReschedule.Text = "RESCHEDULE";
            this.btnReschedule.UseVisualStyleBackColor = false;
            this.btnReschedule.Click += new System.EventHandler(this.btnReschedule_Click);
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBookFlight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBookFlight.FlatAppearance.BorderSize = 0;
            this.btnBookFlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBookFlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBookFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookFlight.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookFlight.ForeColor = System.Drawing.Color.Black;
            this.btnBookFlight.Location = new System.Drawing.Point(328, 400);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(150, 50);
            this.btnBookFlight.TabIndex = 64;
            this.btnBookFlight.Text = "BOOK FLIGHT";
            this.btnBookFlight.UseVisualStyleBackColor = false;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // dgvFlightBooking
            // 
            this.dgvFlightBooking.AllowUserToAddRows = false;
            this.dgvFlightBooking.AllowUserToDeleteRows = false;
            this.dgvFlightBooking.AllowUserToResizeColumns = false;
            this.dgvFlightBooking.AllowUserToResizeRows = false;
            this.dgvFlightBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlightBooking.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFlightBooking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlightBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlightBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlightBooking.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlightBooking.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvFlightBooking.Location = new System.Drawing.Point(100, 150);
            this.dgvFlightBooking.MultiSelect = false;
            this.dgvFlightBooking.Name = "dgvFlightBooking";
            this.dgvFlightBooking.ReadOnly = true;
            this.dgvFlightBooking.RowHeadersVisible = false;
            this.dgvFlightBooking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFlightBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlightBooking.Size = new System.Drawing.Size(918, 200);
            this.dgvFlightBooking.TabIndex = 63;
            // 
            // lblFlightBooking
            // 
            this.lblFlightBooking.AutoSize = true;
            this.lblFlightBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblFlightBooking.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightBooking.ForeColor = System.Drawing.Color.Black;
            this.lblFlightBooking.Location = new System.Drawing.Point(25, 75);
            this.lblFlightBooking.Name = "lblFlightBooking";
            this.lblFlightBooking.Size = new System.Drawing.Size(249, 39);
            this.lblFlightBooking.TabIndex = 62;
            this.lblFlightBooking.Text = "Flight Booking";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnViewDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.Black;
            this.btnViewDetails.Location = new System.Drawing.Point(640, 400);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(150, 50);
            this.btnViewDetails.TabIndex = 66;
            this.btnViewDetails.Text = "VIEW DETAILS";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // ucFlightBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnReschedule);
            this.Controls.Add(this.btnBookFlight);
            this.Controls.Add(this.dgvFlightBooking);
            this.Controls.Add(this.lblFlightBooking);
            this.Controls.Add(this.pnlTabs);
            this.Name = "ucFlightBooking";
            this.Size = new System.Drawing.Size(1118, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlightBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnReschedule;
        private System.Windows.Forms.Button btnBookFlight;
        public System.Windows.Forms.DataGridView dgvFlightBooking;
        private System.Windows.Forms.Label lblFlightBooking;
        private System.Windows.Forms.Button btnViewDetails;
    }
}
