namespace Hospital_Program
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDepts = new System.Windows.Forms.Label();
            this.cmbDepts = new System.Windows.Forms.ComboBox();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProcesses = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.btnNewProc = new System.Windows.Forms.Button();
            this.lblDocs = new System.Windows.Forms.Label();
            this.btnEditDel = new System.Windows.Forms.Button();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnFindPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepts
            // 
            this.lblDepts.AutoSize = true;
            this.lblDepts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepts.Location = new System.Drawing.Point(13, 13);
            this.lblDepts.Name = "lblDepts";
            this.lblDepts.Size = new System.Drawing.Size(113, 20);
            this.lblDepts.TabIndex = 0;
            this.lblDepts.Text = "Departments";
            // 
            // cmbDepts
            // 
            this.cmbDepts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDepts.FormattingEnabled = true;
            this.cmbDepts.Location = new System.Drawing.Point(17, 37);
            this.cmbDepts.Name = "cmbDepts";
            this.cmbDepts.Size = new System.Drawing.Size(196, 24);
            this.cmbDepts.TabIndex = 1;
            this.cmbDepts.SelectedIndexChanged += new System.EventHandler(this.cmbDepts_SelectedIndexChanged);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.AllowUserToOrderColumns = true;
            this.dgvDoctors.AllowUserToResizeRows = false;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDoctors.Location = new System.Drawing.Point(17, 88);
            this.dgvDoctors.MultiSelect = false;
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.Size = new System.Drawing.Size(543, 325);
            this.dgvDoctors.TabIndex = 2;
            this.dgvDoctors.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoctors_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Doctor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Workday";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ShiftStart";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ShiftEnd";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dgvProcesses
            // 
            this.dgvProcesses.AllowUserToAddRows = false;
            this.dgvProcesses.AllowUserToDeleteRows = false;
            this.dgvProcesses.AllowUserToResizeRows = false;
            this.dgvProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvProcesses.Location = new System.Drawing.Point(606, 88);
            this.dgvProcesses.MultiSelect = false;
            this.dgvProcesses.Name = "dgvProcesses";
            this.dgvProcesses.ReadOnly = true;
            this.dgvProcesses.Size = new System.Drawing.Size(603, 325);
            this.dgvProcesses.TabIndex = 3;
            this.dgvProcesses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProcesses_RowHeaderMouseDoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Patient";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Procedure";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 130;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Date";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 130;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Price";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(602, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Procedures";
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.Location = new System.Drawing.Point(17, 432);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(95, 31);
            this.btnAddDoc.TabIndex = 5;
            this.btnAddDoc.Text = "Add Doctor";
            this.btnAddDoc.UseVisualStyleBackColor = true;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Location = new System.Drawing.Point(236, 37);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(95, 24);
            this.btnAddDept.TabIndex = 6;
            this.btnAddDept.Text = "Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnNewProc
            // 
            this.btnNewProc.Location = new System.Drawing.Point(606, 432);
            this.btnNewProc.Name = "btnNewProc";
            this.btnNewProc.Size = new System.Drawing.Size(95, 31);
            this.btnNewProc.TabIndex = 7;
            this.btnNewProc.Text = "New Procedure";
            this.btnNewProc.UseVisualStyleBackColor = true;
            this.btnNewProc.Click += new System.EventHandler(this.btnNewProc_Click);
            // 
            // lblDocs
            // 
            this.lblDocs.AutoSize = true;
            this.lblDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocs.Location = new System.Drawing.Point(13, 65);
            this.lblDocs.Name = "lblDocs";
            this.lblDocs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDocs.Size = new System.Drawing.Size(72, 20);
            this.lblDocs.TabIndex = 8;
            this.lblDocs.Text = "Doctors";
            // 
            // btnEditDel
            // 
            this.btnEditDel.Location = new System.Drawing.Point(118, 432);
            this.btnEditDel.Name = "btnEditDel";
            this.btnEditDel.Size = new System.Drawing.Size(95, 31);
            this.btnEditDel.TabIndex = 9;
            this.btnEditDel.Text = "Edit/Delete";
            this.btnEditDel.UseVisualStyleBackColor = true;
            this.btnEditDel.Click += new System.EventHandler(this.btnEditDel_Click);
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(337, 37);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(95, 24);
            this.btnNewPatient.TabIndex = 10;
            this.btnNewPatient.Text = "New Patient";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.Location = new System.Drawing.Point(438, 37);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(95, 24);
            this.btnFindPatient.TabIndex = 11;
            this.btnFindPatient.Text = "Find Patient";
            this.btnFindPatient.UseVisualStyleBackColor = true;
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 487);
            this.Controls.Add(this.btnFindPatient);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.btnEditDel);
            this.Controls.Add(this.lblDocs);
            this.Controls.Add(this.btnNewProc);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProcesses);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.cmbDepts);
            this.Controls.Add(this.lblDepts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepts;
        private System.Windows.Forms.ComboBox cmbDepts;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.DataGridView dgvProcesses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDoc;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnNewProc;
        private System.Windows.Forms.Label lblDocs;
        private System.Windows.Forms.Button btnEditDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnFindPatient;
    }
}

