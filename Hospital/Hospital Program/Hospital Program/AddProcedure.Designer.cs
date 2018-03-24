namespace Hospital_Program
{
    partial class NewProcedure
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
            this.lblPatient = new System.Windows.Forms.Label();
            this.cmbPatients = new System.Windows.Forms.ComboBox();
            this.cmbDocs = new System.Windows.Forms.ComboBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.lblTypes = new System.Windows.Forms.Label();
            this.lblProcedureDate = new System.Windows.Forms.Label();
            this.dtpProcedureDate = new System.Windows.Forms.DateTimePicker();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnAddProcedureToDatabase = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatient.Location = new System.Drawing.Point(13, 13);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(52, 17);
            this.lblPatient.TabIndex = 0;
            this.lblPatient.Text = "Patient";
            // 
            // cmbPatients
            // 
            this.cmbPatients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPatients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatients.FormattingEnabled = true;
            this.cmbPatients.Location = new System.Drawing.Point(16, 34);
            this.cmbPatients.Name = "cmbPatients";
            this.cmbPatients.Size = new System.Drawing.Size(200, 21);
            this.cmbPatients.TabIndex = 1;
            // 
            // cmbDocs
            // 
            this.cmbDocs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDocs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDocs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocs.FormattingEnabled = true;
            this.cmbDocs.Location = new System.Drawing.Point(265, 34);
            this.cmbDocs.Name = "cmbDocs";
            this.cmbDocs.Size = new System.Drawing.Size(200, 21);
            this.cmbDocs.TabIndex = 3;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDoc.Location = new System.Drawing.Point(262, 13);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(50, 17);
            this.lblDoc.TabIndex = 2;
            this.lblDoc.Text = "Doctor";
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(16, 89);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(200, 21);
            this.cmbTypes.TabIndex = 5;
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypes.Location = new System.Drawing.Point(13, 68);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(110, 17);
            this.lblTypes.TabIndex = 4;
            this.lblTypes.Text = "Procedure Type";
            // 
            // lblProcedureDate
            // 
            this.lblProcedureDate.AutoSize = true;
            this.lblProcedureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProcedureDate.Location = new System.Drawing.Point(262, 68);
            this.lblProcedureDate.Name = "lblProcedureDate";
            this.lblProcedureDate.Size = new System.Drawing.Size(38, 17);
            this.lblProcedureDate.TabIndex = 6;
            this.lblProcedureDate.Text = "Date";
            // 
            // dtpProcedureDate
            // 
            this.dtpProcedureDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpProcedureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProcedureDate.Location = new System.Drawing.Point(265, 89);
            this.dtpProcedureDate.Name = "dtpProcedureDate";
            this.dtpProcedureDate.Size = new System.Drawing.Size(200, 20);
            this.dtpProcedureDate.TabIndex = 7;
            this.dtpProcedureDate.Value = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(13, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(16, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(203, 20);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(16, 201);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(449, 121);
            this.rtbNote.TabIndex = 10;
            this.rtbNote.Text = "";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNote.Location = new System.Drawing.Point(13, 180);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(38, 17);
            this.lblNote.TabIndex = 11;
            this.lblNote.Text = "Note";
            // 
            // btnAddProcedureToDatabase
            // 
            this.btnAddProcedureToDatabase.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddProcedureToDatabase.Location = new System.Drawing.Point(16, 328);
            this.btnAddProcedureToDatabase.Name = "btnAddProcedureToDatabase";
            this.btnAddProcedureToDatabase.Size = new System.Drawing.Size(449, 40);
            this.btnAddProcedureToDatabase.TabIndex = 15;
            this.btnAddProcedureToDatabase.Text = "Add";
            this.btnAddProcedureToDatabase.UseVisualStyleBackColor = false;
            this.btnAddProcedureToDatabase.Click += new System.EventHandler(this.btnAddProcedureToDatabase_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(16, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(449, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(220, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "AZN";
            // 
            // NewProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddProcedureToDatabase);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dtpProcedureDate);
            this.Controls.Add(this.lblProcedureDate);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.cmbDocs);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.cmbPatients);
            this.Controls.Add(this.lblPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewProcedure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Procedure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatients;
        private System.Windows.Forms.ComboBox cmbDocs;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.Label lblProcedureDate;
        private System.Windows.Forms.DateTimePicker dtpProcedureDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnAddProcedureToDatabase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}