namespace Findstaff
{
    partial class ucJobOrderAddEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEmployer = new System.Windows.Forms.ComboBox();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAddJobOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.cbEditYear = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbEditDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEditMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditJobNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEditJobOrder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbEmployer);
            this.panel1.Controls.Add(this.btnCancel1);
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.btnAdd1);
            this.panel1.Controls.Add(this.cbDay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbMonth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtJobNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblAddJobOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 450);
            this.panel1.TabIndex = 3;
            // 
            // cbEmployer
            // 
            this.cbEmployer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbEmployer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEmployer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployer.ForeColor = System.Drawing.Color.Black;
            this.cbEmployer.FormattingEnabled = true;
            this.cbEmployer.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbEmployer.Location = new System.Drawing.Point(491, 188);
            this.cbEmployer.Name = "cbEmployer";
            this.cbEmployer.Size = new System.Drawing.Size(200, 27);
            this.cbEmployer.TabIndex = 275;
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel1.FlatAppearance.BorderSize = 0;
            this.btnCancel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.ForeColor = System.Drawing.Color.Black;
            this.btnCancel1.Location = new System.Drawing.Point(562, 330);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(120, 50);
            this.btnCancel1.TabIndex = 57;
            this.btnCancel1.Text = "CANCEL";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.ForeColor = System.Drawing.Color.Black;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cbYear.Location = new System.Drawing.Point(731, 221);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(83, 27);
            this.cbYear.TabIndex = 274;
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd1.FlatAppearance.BorderSize = 0;
            this.btnAdd1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAdd1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.ForeColor = System.Drawing.Color.Black;
            this.btnAdd1.Location = new System.Drawing.Point(436, 330);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(120, 50);
            this.btnAdd1.TabIndex = 56;
            this.btnAdd1.Text = "ADD";
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbDay
            // 
            this.cbDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDay.ForeColor = System.Drawing.Color.Black;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDay.Location = new System.Drawing.Point(665, 221);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(60, 27);
            this.cbDay.TabIndex = 273;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(354, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 272;
            this.label1.Text = "Contract Start:";
            // 
            // cbMonth
            // 
            this.cbMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.ForeColor = System.Drawing.Color.Black;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(491, 221);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(168, 27);
            this.cbMonth.TabIndex = 265;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(399, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 264;
            this.label7.Text = "Employer:";
            // 
            // txtJobNo
            // 
            this.txtJobNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtJobNo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobNo.ForeColor = System.Drawing.Color.Black;
            this.txtJobNo.Location = new System.Drawing.Point(491, 157);
            this.txtJobNo.MaxLength = 6;
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Size = new System.Drawing.Size(200, 26);
            this.txtJobNo.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(367, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 106;
            this.label8.Text = "Job Order No.:";
            // 
            // lblAddJobOrder
            // 
            this.lblAddJobOrder.AutoSize = true;
            this.lblAddJobOrder.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddJobOrder.ForeColor = System.Drawing.Color.Black;
            this.lblAddJobOrder.Location = new System.Drawing.Point(25, 25);
            this.lblAddJobOrder.Name = "lblAddJobOrder";
            this.lblAddJobOrder.Size = new System.Drawing.Size(239, 39);
            this.lblAddJobOrder.TabIndex = 39;
            this.lblAddJobOrder.Text = "Add Job Order";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnCancel2);
            this.panel2.Controls.Add(this.cbEditYear);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.cbEditDay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbEditMonth);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEditJobNo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblEditJobOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1108, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 450);
            this.panel2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox1.Location = new System.Drawing.Point(491, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 27);
            this.comboBox1.TabIndex = 276;
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel2.FlatAppearance.BorderSize = 0;
            this.btnCancel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Location = new System.Drawing.Point(562, 330);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(120, 50);
            this.btnCancel2.TabIndex = 57;
            this.btnCancel2.Text = "CANCEL";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // cbEditYear
            // 
            this.cbEditYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbEditYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEditYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditYear.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditYear.ForeColor = System.Drawing.Color.Black;
            this.cbEditYear.FormattingEnabled = true;
            this.cbEditYear.Items.AddRange(new object[] {
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001"});
            this.cbEditYear.Location = new System.Drawing.Point(731, 202);
            this.cbEditYear.Name = "cbEditYear";
            this.cbEditYear.Size = new System.Drawing.Size(83, 27);
            this.cbEditYear.TabIndex = 274;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(436, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 50);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbEditDay
            // 
            this.cbEditDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbEditDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEditDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditDay.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditDay.ForeColor = System.Drawing.Color.Black;
            this.cbEditDay.FormattingEnabled = true;
            this.cbEditDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "15",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbEditDay.Location = new System.Drawing.Point(665, 202);
            this.cbEditDay.Name = "cbEditDay";
            this.cbEditDay.Size = new System.Drawing.Size(60, 27);
            this.cbEditDay.TabIndex = 273;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(368, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 272;
            this.label2.Text = "Contract Start:";
            // 
            // cbEditMonth
            // 
            this.cbEditMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbEditMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEditMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditMonth.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditMonth.ForeColor = System.Drawing.Color.Black;
            this.cbEditMonth.FormattingEnabled = true;
            this.cbEditMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbEditMonth.Location = new System.Drawing.Point(491, 202);
            this.cbEditMonth.Name = "cbEditMonth";
            this.cbEditMonth.Size = new System.Drawing.Size(168, 27);
            this.cbEditMonth.TabIndex = 265;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(399, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 264;
            this.label3.Text = "Employer:";
            // 
            // txtEditJobNo
            // 
            this.txtEditJobNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEditJobNo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditJobNo.ForeColor = System.Drawing.Color.Black;
            this.txtEditJobNo.Location = new System.Drawing.Point(491, 138);
            this.txtEditJobNo.MaxLength = 30;
            this.txtEditJobNo.Name = "txtEditJobNo";
            this.txtEditJobNo.Size = new System.Drawing.Size(200, 26);
            this.txtEditJobNo.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(367, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 106;
            this.label4.Text = "Job Order No.:";
            // 
            // lblEditJobOrder
            // 
            this.lblEditJobOrder.AutoSize = true;
            this.lblEditJobOrder.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditJobOrder.ForeColor = System.Drawing.Color.Black;
            this.lblEditJobOrder.Location = new System.Drawing.Point(25, 25);
            this.lblEditJobOrder.Name = "lblEditJobOrder";
            this.lblEditJobOrder.Size = new System.Drawing.Size(240, 39);
            this.lblEditJobOrder.TabIndex = 39;
            this.lblEditJobOrder.Text = "Edit Job Order";
            // 
            // ucJobOrderAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucJobOrderAddEdit";
            this.Size = new System.Drawing.Size(1118, 450);
            this.VisibleChanged += new System.EventHandler(this.ucJobOrderAddEdit_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAddJobOrder;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.ComboBox cbEditYear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbEditDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEditMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditJobNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEditJobOrder;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbEmployer;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
