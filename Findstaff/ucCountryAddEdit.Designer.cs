using System.Windows.Forms;

namespace Findstaff
{
    partial class ucCountryAddEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveRequirement = new System.Windows.Forms.Button();
            this.btnAddRequirement = new System.Windows.Forms.Button();
            this.cbReqName = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridEduc = new System.Windows.Forms.DataGridView();
            this.pnlButtons1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtCountryID2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReq2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRequire2 = new System.Windows.Forms.Button();
            this.btnRemoveRequire2 = new System.Windows.Forms.Button();
            this.cbReq2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountryName2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveRequire = new System.Windows.Forms.Button();
            this.btnAddRequire = new System.Windows.Forms.Button();
            this.cbReq = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCountryName1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEduc)).BeginInit();
            this.pnlButtons1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCountry.ForeColor = System.Drawing.Color.Black;
            this.lblAddCountry.Location = new System.Drawing.Point(34, 21);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(214, 39);
            this.lblAddCountry.TabIndex = 39;
            this.lblAddCountry.Text = "Add Country";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCountry.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(191, 73);
            this.txtCountry.MaxLength = 30;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 26);
            this.txtCountry.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 106;
            this.label2.Text = "Country Name:";
            // 
            // btnRemoveRequirement
            // 
            this.btnRemoveRequirement.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveRequirement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveRequirement.FlatAppearance.BorderSize = 0;
            this.btnRemoveRequirement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRequirement.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRequirement.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveRequirement.Location = new System.Drawing.Point(781, 311);
            this.btnRemoveRequirement.Name = "btnRemoveRequirement";
            this.btnRemoveRequirement.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveRequirement.TabIndex = 267;
            this.btnRemoveRequirement.Text = "REMOVE";
            this.btnRemoveRequirement.UseVisualStyleBackColor = false;
            // 
            // btnAddRequirement
            // 
            this.btnAddRequirement.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddRequirement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddRequirement.FlatAppearance.BorderSize = 0;
            this.btnAddRequirement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRequirement.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequirement.ForeColor = System.Drawing.Color.Black;
            this.btnAddRequirement.Location = new System.Drawing.Point(425, 108);
            this.btnAddRequirement.Name = "btnAddRequirement";
            this.btnAddRequirement.Size = new System.Drawing.Size(100, 30);
            this.btnAddRequirement.TabIndex = 266;
            this.btnAddRequirement.Text = "ADD";
            this.btnAddRequirement.UseVisualStyleBackColor = false;
            // 
            // cbReqName
            // 
            this.cbReqName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbReqName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbReqName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReqName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReqName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReqName.ForeColor = System.Drawing.Color.Black;
            this.cbReqName.FormattingEnabled = true;
            this.cbReqName.Items.AddRange(new object[] {
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
            this.cbReqName.Location = new System.Drawing.Point(226, 108);
            this.cbReqName.Name = "cbReqName";
            this.cbReqName.Size = new System.Drawing.Size(184, 27);
            this.cbReqName.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(63, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 19);
            this.label16.TabIndex = 264;
            this.label16.Text = "Requirement Name:";
            // 
            // dataGridEduc
            // 
            this.dataGridEduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEduc.Location = new System.Drawing.Point(41, 155);
            this.dataGridEduc.Name = "dataGridEduc";
            this.dataGridEduc.Size = new System.Drawing.Size(840, 150);
            this.dataGridEduc.TabIndex = 269;
            // 
            // pnlButtons1
            // 
            this.pnlButtons1.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons1.Controls.Add(this.btnCancel);
            this.pnlButtons1.Controls.Add(this.btnAdd);
            this.pnlButtons1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButtons1.Location = new System.Drawing.Point(413, 370);
            this.pnlButtons1.Name = "pnlButtons1";
            this.pnlButtons1.Size = new System.Drawing.Size(249, 80);
            this.pnlButtons1.TabIndex = 270;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(128, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 50);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "ADD COUNTRY";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCancel2);
            this.panel2.Controls.Add(this.btnSave2);
            this.panel2.Controls.Add(this.txtCountryID2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgvReq2);
            this.panel2.Controls.Add(this.btnAddRequire2);
            this.panel2.Controls.Add(this.btnRemoveRequire2);
            this.panel2.Controls.Add(this.cbReq2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCountryName2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1145, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 500);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 28);
            this.label4.TabIndex = 278;
            this.label4.Text = "Edit Country";
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.White;
            this.btnCancel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel2.FlatAppearance.BorderSize = 0;
            this.btnCancel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Location = new System.Drawing.Point(561, 444);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 38);
            this.btnCancel2.TabIndex = 274;
            this.btnCancel2.Text = "CANCEL";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.White;
            this.btnSave2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave2.FlatAppearance.BorderSize = 0;
            this.btnSave2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSave2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.ForeColor = System.Drawing.Color.Black;
            this.btnSave2.Location = new System.Drawing.Point(455, 444);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(100, 38);
            this.btnSave2.TabIndex = 273;
            this.btnSave2.Text = "SAVE";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCountryID2
            // 
            this.txtCountryID2.BackColor = System.Drawing.Color.White;
            this.txtCountryID2.Enabled = false;
            this.txtCountryID2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryID2.ForeColor = System.Drawing.Color.Black;
            this.txtCountryID2.Location = new System.Drawing.Point(151, 76);
            this.txtCountryID2.MaxLength = 30;
            this.txtCountryID2.Name = "txtCountryID2";
            this.txtCountryID2.Size = new System.Drawing.Size(150, 27);
            this.txtCountryID2.TabIndex = 272;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(50, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 271;
            this.label5.Text = "Country ID:";
            // 
            // dgvReq2
            // 
            this.dgvReq2.AllowUserToAddRows = false;
            this.dgvReq2.AllowUserToDeleteRows = false;
            this.dgvReq2.AllowUserToResizeColumns = false;
            this.dgvReq2.AllowUserToResizeRows = false;
            this.dgvReq2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReq2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvReq2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReq2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReq2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReq2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReq2.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvReq2.Location = new System.Drawing.Point(100, 181);
            this.dgvReq2.MultiSelect = false;
            this.dgvReq2.Name = "dgvReq2";
            this.dgvReq2.ReadOnly = true;
            this.dgvReq2.RowHeadersVisible = false;
            this.dgvReq2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReq2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReq2.Size = new System.Drawing.Size(918, 184);
            this.dgvReq2.TabIndex = 269;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Country ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Requirement Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnAddRequire2
            // 
            this.btnAddRequire2.BackColor = System.Drawing.Color.White;
            this.btnAddRequire2.FlatAppearance.BorderSize = 0;
            this.btnAddRequire2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRequire2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequire2.Location = new System.Drawing.Point(449, 127);
            this.btnAddRequire2.Name = "btnAddRequire2";
            this.btnAddRequire2.Size = new System.Drawing.Size(100, 30);
            this.btnAddRequire2.TabIndex = 275;
            this.btnAddRequire2.Text = "ADD";
            this.btnAddRequire2.UseVisualStyleBackColor = false;
            this.btnAddRequire2.Click += new System.EventHandler(this.btnAddRequire2_Click);
            // 
            // btnRemoveRequire2
            // 
            this.btnRemoveRequire2.BackColor = System.Drawing.Color.White;
            this.btnRemoveRequire2.FlatAppearance.BorderSize = 0;
            this.btnRemoveRequire2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRequire2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRequire2.Location = new System.Drawing.Point(918, 367);
            this.btnRemoveRequire2.Name = "btnRemoveRequire2";
            this.btnRemoveRequire2.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveRequire2.TabIndex = 276;
            this.btnRemoveRequire2.Text = "REMOVE";
            this.btnRemoveRequire2.UseVisualStyleBackColor = false;
            this.btnRemoveRequire2.Click += new System.EventHandler(this.btnRemoveRequire2_Click);
            // 
            // cbReq2
            // 
            this.cbReq2.BackColor = System.Drawing.Color.White;
            this.cbReq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReq2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReq2.Location = new System.Drawing.Point(213, 130);
            this.cbReq2.Name = "cbReq2";
            this.cbReq2.Size = new System.Drawing.Size(230, 28);
            this.cbReq2.TabIndex = 277;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 264;
            this.label1.Text = "Requirement Name:";
            // 
            // txtCountryName2
            // 
            this.txtCountryName2.BackColor = System.Drawing.Color.White;
            this.txtCountryName2.Enabled = false;
            this.txtCountryName2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryName2.ForeColor = System.Drawing.Color.Black;
            this.txtCountryName2.Location = new System.Drawing.Point(468, 76);
            this.txtCountryName2.MaxLength = 30;
            this.txtCountryName2.Name = "txtCountryName2";
            this.txtCountryName2.Size = new System.Drawing.Size(197, 27);
            this.txtCountryName2.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(340, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 106;
            this.label3.Text = "Country Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCancel1);
            this.panel1.Controls.Add(this.btnAddCountry);
            this.panel1.Controls.Add(this.dgvCountry);
            this.panel1.Controls.Add(this.btnRemoveRequire);
            this.panel1.Controls.Add(this.btnAddRequire);
            this.panel1.Controls.Add(this.cbReq);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCountryName1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 500);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 28);
            this.label6.TabIndex = 279;
            this.label6.Text = "Add Country";
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.White;
            this.btnCancel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel1.FlatAppearance.BorderSize = 0;
            this.btnCancel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.ForeColor = System.Drawing.Color.Black;
            this.btnCancel1.Location = new System.Drawing.Point(581, 408);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(110, 38);
            this.btnCancel1.TabIndex = 271;
            this.btnCancel1.Text = "CANCEL";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.Color.White;
            this.btnAddCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCountry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCountry.FlatAppearance.BorderSize = 0;
            this.btnAddCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAddCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCountry.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCountry.ForeColor = System.Drawing.Color.Black;
            this.btnAddCountry.Location = new System.Drawing.Point(455, 408);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(110, 38);
            this.btnAddCountry.TabIndex = 270;
            this.btnAddCountry.Text = "ADD";
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // dgvCountry
            // 
            this.dgvCountry.AllowUserToAddRows = false;
            this.dgvCountry.AllowUserToDeleteRows = false;
            this.dgvCountry.AllowUserToResizeColumns = false;
            this.dgvCountry.AllowUserToResizeRows = false;
            this.dgvCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCountry.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCountry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCountry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCountry.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCountry.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCountry.Location = new System.Drawing.Point(114, 181);
            this.dgvCountry.MultiSelect = false;
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.ReadOnly = true;
            this.dgvCountry.RowHeadersVisible = false;
            this.dgvCountry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCountry.Size = new System.Drawing.Size(918, 184);
            this.dgvCountry.TabIndex = 269;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Requirement Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnRemoveRequire
            // 
            this.btnRemoveRequire.BackColor = System.Drawing.Color.White;
            this.btnRemoveRequire.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveRequire.FlatAppearance.BorderSize = 0;
            this.btnRemoveRequire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRequire.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRequire.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveRequire.Location = new System.Drawing.Point(933, 367);
            this.btnRemoveRequire.Name = "btnRemoveRequire";
            this.btnRemoveRequire.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveRequire.TabIndex = 267;
            this.btnRemoveRequire.Text = "REMOVE";
            this.btnRemoveRequire.UseVisualStyleBackColor = false;
            this.btnRemoveRequire.Click += new System.EventHandler(this.btnRemoveRequire_Click);
            // 
            // btnAddRequire
            // 
            this.btnAddRequire.BackColor = System.Drawing.Color.White;
            this.btnAddRequire.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddRequire.FlatAppearance.BorderSize = 0;
            this.btnAddRequire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRequire.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequire.ForeColor = System.Drawing.Color.Black;
            this.btnAddRequire.Location = new System.Drawing.Point(456, 128);
            this.btnAddRequire.Name = "btnAddRequire";
            this.btnAddRequire.Size = new System.Drawing.Size(100, 30);
            this.btnAddRequire.TabIndex = 266;
            this.btnAddRequire.Text = "ADD";
            this.btnAddRequire.UseVisualStyleBackColor = false;
            this.btnAddRequire.Click += new System.EventHandler(this.btnAddRequire_Click);
            // 
            // cbReq
            // 
            this.cbReq.BackColor = System.Drawing.Color.White;
            this.cbReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReq.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReq.ForeColor = System.Drawing.Color.Black;
            this.cbReq.FormattingEnabled = true;
            this.cbReq.Location = new System.Drawing.Point(201, 130);
            this.cbReq.Name = "cbReq";
            this.cbReq.Size = new System.Drawing.Size(249, 28);
            this.cbReq.TabIndex = 265;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 264;
            this.label7.Text = "Requirement Name:";
            // 
            // txtCountryName1
            // 
            this.txtCountryName1.BackColor = System.Drawing.Color.White;
            this.txtCountryName1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryName1.ForeColor = System.Drawing.Color.Black;
            this.txtCountryName1.Location = new System.Drawing.Point(175, 76);
            this.txtCountryName1.MaxLength = 30;
            this.txtCountryName1.Name = "txtCountryName1";
            this.txtCountryName1.Size = new System.Drawing.Size(200, 27);
            this.txtCountryName1.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 106;
            this.label8.Text = "Country Name:";
            // 
            // ucCountryAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucCountryAddEdit";
            this.Size = new System.Drawing.Size(1155, 500);
            this.VisibleChanged += new System.EventHandler(this.ucCountryAddEdit_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEduc)).EndInit();
            this.pnlButtons1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveRequirement;
        private System.Windows.Forms.Button btnAddRequirement;
        private System.Windows.Forms.ComboBox cbReqName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridEduc;
        private System.Windows.Forms.Panel pnlButtons1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddRequire2;
        private System.Windows.Forms.Button btnRemoveRequire2;
        private System.Windows.Forms.ComboBox cbReq2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveRequire;
        private System.Windows.Forms.Button btnAddRequire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCountryName1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnAddCountry;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSave2;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox cbReq;
        private DataGridView dgvCountry;
        public TextBox txtCountryName2;
        public TextBox txtCountryID2;
        public DataGridView dgvReq2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private Label label4;
        private Label label6;
    }
}
