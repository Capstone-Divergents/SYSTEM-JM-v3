namespace Findstaff
{
    partial class ucUtilities
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
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.ucEmployee = new Findstaff.ucEmployee();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Controls.Add(this.rbEmployee);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1155, 50);
            this.pnlTabs.TabIndex = 43;
            // 
            // rbEmployee
            // 
            this.rbEmployee.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbEmployee.FlatAppearance.BorderSize = 0;
            this.rbEmployee.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEmployee.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmployee.ForeColor = System.Drawing.Color.White;
            this.rbEmployee.Location = new System.Drawing.Point(1, 10);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(100, 40);
            this.rbEmployee.TabIndex = 1;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEmployee.UseVisualStyleBackColor = false;
            // 
            // ucEmployee
            // 
            this.ucEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ucEmployee.ForeColor = System.Drawing.Color.Black;
            this.ucEmployee.Location = new System.Drawing.Point(3, 56);
            this.ucEmployee.Name = "ucEmployee";
            this.ucEmployee.Size = new System.Drawing.Size(100, 100);
            this.ucEmployee.TabIndex = 44;
            this.ucEmployee.Visible = false;
            // 
            // ucUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.ucEmployee);
            this.Controls.Add(this.pnlTabs);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucUtilities";
            this.Size = new System.Drawing.Size(1155, 500);
            this.VisibleChanged += new System.EventHandler(this.ucUtilities_VisibleChanged);
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.RadioButton rbEmployee;
        private ucEmployee ucEmployee;
    }
}
