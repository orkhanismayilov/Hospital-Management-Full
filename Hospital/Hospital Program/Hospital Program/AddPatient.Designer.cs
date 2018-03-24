namespace Hospital_Program
{
    partial class NewPatient
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
            this.txtPatSurname = new System.Windows.Forms.TextBox();
            this.lblDocSurname = new System.Windows.Forms.Label();
            this.txtPatName = new System.Windows.Forms.TextBox();
            this.lblDocName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dtpPatBday = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbPatGender = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPatPhone = new System.Windows.Forms.TextBox();
            this.btnAddPatToDatabase = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPatSurname
            // 
            this.txtPatSurname.Location = new System.Drawing.Point(272, 35);
            this.txtPatSurname.Name = "txtPatSurname";
            this.txtPatSurname.Size = new System.Drawing.Size(207, 20);
            this.txtPatSurname.TabIndex = 7;
            // 
            // lblDocSurname
            // 
            this.lblDocSurname.AutoSize = true;
            this.lblDocSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocSurname.Location = new System.Drawing.Point(269, 15);
            this.lblDocSurname.Name = "lblDocSurname";
            this.lblDocSurname.Size = new System.Drawing.Size(65, 17);
            this.lblDocSurname.TabIndex = 6;
            this.lblDocSurname.Text = "Surname";
            // 
            // txtPatName
            // 
            this.txtPatName.Location = new System.Drawing.Point(12, 35);
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.Size = new System.Drawing.Size(207, 20);
            this.txtPatName.TabIndex = 5;
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocName.Location = new System.Drawing.Point(9, 15);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(45, 17);
            this.lblDocName.TabIndex = 4;
            this.lblDocName.Text = "Name";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthday.Location = new System.Drawing.Point(9, 70);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(60, 17);
            this.lblBirthday.TabIndex = 8;
            this.lblBirthday.Text = "Birthday";
            // 
            // dtpPatBday
            // 
            this.dtpPatBday.CustomFormat = "dd.MM.yyyy";
            this.dtpPatBday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPatBday.Location = new System.Drawing.Point(12, 90);
            this.dtpPatBday.Name = "dtpPatBday";
            this.dtpPatBday.Size = new System.Drawing.Size(207, 20);
            this.dtpPatBday.TabIndex = 9;
            this.dtpPatBday.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGender.Location = new System.Drawing.Point(269, 70);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // cmbPatGender
            // 
            this.cmbPatGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatGender.FormattingEnabled = true;
            this.cmbPatGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbPatGender.Location = new System.Drawing.Point(272, 90);
            this.cmbPatGender.Name = "cmbPatGender";
            this.cmbPatGender.Size = new System.Drawing.Size(207, 21);
            this.cmbPatGender.TabIndex = 11;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(9, 124);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone";
            // 
            // txtPatPhone
            // 
            this.txtPatPhone.Location = new System.Drawing.Point(12, 144);
            this.txtPatPhone.Name = "txtPatPhone";
            this.txtPatPhone.Size = new System.Drawing.Size(207, 20);
            this.txtPatPhone.TabIndex = 13;
            // 
            // btnAddPatToDatabase
            // 
            this.btnAddPatToDatabase.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddPatToDatabase.Location = new System.Drawing.Point(12, 170);
            this.btnAddPatToDatabase.Name = "btnAddPatToDatabase";
            this.btnAddPatToDatabase.Size = new System.Drawing.Size(467, 40);
            this.btnAddPatToDatabase.TabIndex = 14;
            this.btnAddPatToDatabase.Text = "Add";
            this.btnAddPatToDatabase.UseVisualStyleBackColor = false;
            this.btnAddPatToDatabase.Click += new System.EventHandler(this.btnAddPatToDatabase_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(12, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(467, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 264);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPatToDatabase);
            this.Controls.Add(this.txtPatPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.cmbPatGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dtpPatBday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.txtPatSurname);
            this.Controls.Add(this.lblDocSurname);
            this.Controls.Add(this.txtPatName);
            this.Controls.Add(this.lblDocName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Patient Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatSurname;
        private System.Windows.Forms.Label lblDocSurname;
        private System.Windows.Forms.TextBox txtPatName;
        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dtpPatBday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbPatGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPatPhone;
        private System.Windows.Forms.Button btnAddPatToDatabase;
        private System.Windows.Forms.Button btnCancel;
    }
}