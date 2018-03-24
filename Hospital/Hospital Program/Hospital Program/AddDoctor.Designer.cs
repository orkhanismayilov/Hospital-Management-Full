namespace Hospital_Program
{
    partial class AddDocWindow
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
            this.lblDocName = new System.Windows.Forms.Label();
            this.txtDocName = new System.Windows.Forms.TextBox();
            this.txtDocSurname = new System.Windows.Forms.TextBox();
            this.lblDocSurname = new System.Windows.Forms.Label();
            this.lblWorkDays = new System.Windows.Forms.Label();
            this.clbWorkingDays = new System.Windows.Forms.CheckedListBox();
            this.dtpShiftStart = new System.Windows.Forms.DateTimePicker();
            this.lblShiftStart = new System.Windows.Forms.Label();
            this.lblShiftEnd = new System.Windows.Forms.Label();
            this.dtpShiftEnd = new System.Windows.Forms.DateTimePicker();
            this.lblAddDocDept = new System.Windows.Forms.Label();
            this.cmbDepts = new System.Windows.Forms.ComboBox();
            this.btnAddDoctorToDatabase = new System.Windows.Forms.Button();
            this.btnCancelAddingDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocName.Location = new System.Drawing.Point(13, 13);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(45, 17);
            this.lblDocName.TabIndex = 0;
            this.lblDocName.Text = "Name";
            // 
            // txtDocName
            // 
            this.txtDocName.Location = new System.Drawing.Point(16, 34);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(207, 20);
            this.txtDocName.TabIndex = 1;
            // 
            // txtDocSurname
            // 
            this.txtDocSurname.Location = new System.Drawing.Point(276, 34);
            this.txtDocSurname.Name = "txtDocSurname";
            this.txtDocSurname.Size = new System.Drawing.Size(207, 20);
            this.txtDocSurname.TabIndex = 3;
            // 
            // lblDocSurname
            // 
            this.lblDocSurname.AutoSize = true;
            this.lblDocSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocSurname.Location = new System.Drawing.Point(273, 13);
            this.lblDocSurname.Name = "lblDocSurname";
            this.lblDocSurname.Size = new System.Drawing.Size(65, 17);
            this.lblDocSurname.TabIndex = 2;
            this.lblDocSurname.Text = "Surname";
            // 
            // lblWorkDays
            // 
            this.lblWorkDays.AutoSize = true;
            this.lblWorkDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkDays.Location = new System.Drawing.Point(13, 71);
            this.lblWorkDays.Name = "lblWorkDays";
            this.lblWorkDays.Size = new System.Drawing.Size(96, 17);
            this.lblWorkDays.TabIndex = 4;
            this.lblWorkDays.Text = "Working Days";
            // 
            // clbWorkingDays
            // 
            this.clbWorkingDays.CheckOnClick = true;
            this.clbWorkingDays.FormattingEnabled = true;
            this.clbWorkingDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.clbWorkingDays.Location = new System.Drawing.Point(16, 92);
            this.clbWorkingDays.Name = "clbWorkingDays";
            this.clbWorkingDays.Size = new System.Drawing.Size(93, 109);
            this.clbWorkingDays.TabIndex = 5;
            // 
            // dtpShiftStart
            // 
            this.dtpShiftStart.CustomFormat = "HH:mm";
            this.dtpShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShiftStart.Location = new System.Drawing.Point(140, 92);
            this.dtpShiftStart.Name = "dtpShiftStart";
            this.dtpShiftStart.ShowUpDown = true;
            this.dtpShiftStart.Size = new System.Drawing.Size(102, 20);
            this.dtpShiftStart.TabIndex = 6;
            this.dtpShiftStart.Value = new System.DateTime(2018, 3, 17, 10, 0, 0, 0);
            // 
            // lblShiftStart
            // 
            this.lblShiftStart.AutoSize = true;
            this.lblShiftStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShiftStart.Location = new System.Drawing.Point(137, 71);
            this.lblShiftStart.Name = "lblShiftStart";
            this.lblShiftStart.Size = new System.Drawing.Size(105, 17);
            this.lblShiftStart.TabIndex = 7;
            this.lblShiftStart.Text = "Shift Start Time";
            // 
            // lblShiftEnd
            // 
            this.lblShiftEnd.AutoSize = true;
            this.lblShiftEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShiftEnd.Location = new System.Drawing.Point(137, 131);
            this.lblShiftEnd.Name = "lblShiftEnd";
            this.lblShiftEnd.Size = new System.Drawing.Size(100, 17);
            this.lblShiftEnd.TabIndex = 9;
            this.lblShiftEnd.Text = "Shift End Time";
            // 
            // dtpShiftEnd
            // 
            this.dtpShiftEnd.CustomFormat = "HH:mm";
            this.dtpShiftEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShiftEnd.Location = new System.Drawing.Point(140, 151);
            this.dtpShiftEnd.Name = "dtpShiftEnd";
            this.dtpShiftEnd.ShowUpDown = true;
            this.dtpShiftEnd.Size = new System.Drawing.Size(102, 20);
            this.dtpShiftEnd.TabIndex = 8;
            this.dtpShiftEnd.Value = new System.DateTime(2018, 3, 17, 18, 0, 0, 0);
            // 
            // lblAddDocDept
            // 
            this.lblAddDocDept.AutoSize = true;
            this.lblAddDocDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddDocDept.Location = new System.Drawing.Point(273, 71);
            this.lblAddDocDept.Name = "lblAddDocDept";
            this.lblAddDocDept.Size = new System.Drawing.Size(82, 17);
            this.lblAddDocDept.TabIndex = 10;
            this.lblAddDocDept.Text = "Department";
            // 
            // cmbDepts
            // 
            this.cmbDepts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepts.FormattingEnabled = true;
            this.cmbDepts.Location = new System.Drawing.Point(276, 92);
            this.cmbDepts.Name = "cmbDepts";
            this.cmbDepts.Size = new System.Drawing.Size(207, 21);
            this.cmbDepts.TabIndex = 11;
            // 
            // btnAddDoctorToDatabase
            // 
            this.btnAddDoctorToDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDoctorToDatabase.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddDoctorToDatabase.Location = new System.Drawing.Point(16, 230);
            this.btnAddDoctorToDatabase.Name = "btnAddDoctorToDatabase";
            this.btnAddDoctorToDatabase.Size = new System.Drawing.Size(469, 40);
            this.btnAddDoctorToDatabase.TabIndex = 12;
            this.btnAddDoctorToDatabase.Text = "Add Doctor";
            this.btnAddDoctorToDatabase.UseVisualStyleBackColor = false;
            this.btnAddDoctorToDatabase.Click += new System.EventHandler(this.btnAddDoctorToDatabase_Click);
            // 
            // btnCancelAddingDoc
            // 
            this.btnCancelAddingDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAddingDoc.BackColor = System.Drawing.Color.Red;
            this.btnCancelAddingDoc.Location = new System.Drawing.Point(16, 276);
            this.btnCancelAddingDoc.Name = "btnCancelAddingDoc";
            this.btnCancelAddingDoc.Size = new System.Drawing.Size(469, 40);
            this.btnCancelAddingDoc.TabIndex = 13;
            this.btnCancelAddingDoc.Text = "Cancel";
            this.btnCancelAddingDoc.UseVisualStyleBackColor = false;
            this.btnCancelAddingDoc.Click += new System.EventHandler(this.btnCancelAddingDoc_Click);
            // 
            // AddDocWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 323);
            this.Controls.Add(this.btnCancelAddingDoc);
            this.Controls.Add(this.btnAddDoctorToDatabase);
            this.Controls.Add(this.cmbDepts);
            this.Controls.Add(this.lblAddDocDept);
            this.Controls.Add(this.lblShiftEnd);
            this.Controls.Add(this.dtpShiftEnd);
            this.Controls.Add(this.lblShiftStart);
            this.Controls.Add(this.dtpShiftStart);
            this.Controls.Add(this.clbWorkingDays);
            this.Controls.Add(this.lblWorkDays);
            this.Controls.Add(this.txtDocSurname);
            this.Controls.Add(this.lblDocSurname);
            this.Controls.Add(this.txtDocName);
            this.Controls.Add(this.lblDocName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddDocWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.TextBox txtDocName;
        private System.Windows.Forms.TextBox txtDocSurname;
        private System.Windows.Forms.Label lblDocSurname;
        private System.Windows.Forms.Label lblWorkDays;
        private System.Windows.Forms.CheckedListBox clbWorkingDays;
        private System.Windows.Forms.DateTimePicker dtpShiftStart;
        private System.Windows.Forms.Label lblShiftStart;
        private System.Windows.Forms.Label lblShiftEnd;
        private System.Windows.Forms.DateTimePicker dtpShiftEnd;
        private System.Windows.Forms.Label lblAddDocDept;
        private System.Windows.Forms.ComboBox cmbDepts;
        private System.Windows.Forms.Button btnAddDoctorToDatabase;
        private System.Windows.Forms.Button btnCancelAddingDoc;
    }
}