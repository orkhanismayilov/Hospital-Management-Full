namespace Hospital_Program
{
    partial class ProcedureInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatFullname = new System.Windows.Forms.TextBox();
            this.txtDocFullname = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.txtProc = new System.Windows.Forms.TextBox();
            this.lblProc = new System.Windows.Forms.Label();
            this.lblProcDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient";
            // 
            // txtPatFullname
            // 
            this.txtPatFullname.Location = new System.Drawing.Point(16, 34);
            this.txtPatFullname.Name = "txtPatFullname";
            this.txtPatFullname.ReadOnly = true;
            this.txtPatFullname.Size = new System.Drawing.Size(244, 20);
            this.txtPatFullname.TabIndex = 1;
            // 
            // txtDocFullname
            // 
            this.txtDocFullname.Location = new System.Drawing.Point(298, 34);
            this.txtDocFullname.Name = "txtDocFullname";
            this.txtDocFullname.ReadOnly = true;
            this.txtDocFullname.Size = new System.Drawing.Size(244, 20);
            this.txtDocFullname.TabIndex = 3;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDoc.Location = new System.Drawing.Point(295, 13);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(56, 17);
            this.lblDoc.TabIndex = 2;
            this.lblDoc.Text = "Doctor";
            // 
            // txtProc
            // 
            this.txtProc.Location = new System.Drawing.Point(16, 87);
            this.txtProc.Name = "txtProc";
            this.txtProc.ReadOnly = true;
            this.txtProc.Size = new System.Drawing.Size(244, 20);
            this.txtProc.TabIndex = 5;
            // 
            // lblProc
            // 
            this.lblProc.AutoSize = true;
            this.lblProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProc.Location = new System.Drawing.Point(13, 66);
            this.lblProc.Name = "lblProc";
            this.lblProc.Size = new System.Drawing.Size(83, 17);
            this.lblProc.TabIndex = 4;
            this.lblProc.Text = "Procedure";
            // 
            // lblProcDate
            // 
            this.lblProcDate.AutoSize = true;
            this.lblProcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProcDate.Location = new System.Drawing.Point(13, 122);
            this.lblProcDate.Name = "lblProcDate";
            this.lblProcDate.Size = new System.Drawing.Size(42, 17);
            this.lblProcDate.TabIndex = 6;
            this.lblProcDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(16, 143);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(244, 20);
            this.txtDate.TabIndex = 7;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(298, 87);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(244, 20);
            this.txtDept.TabIndex = 9;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDept.Location = new System.Drawing.Point(295, 66);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(92, 17);
            this.lblDept.TabIndex = 8;
            this.lblDept.Text = "Department";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNote.Location = new System.Drawing.Point(13, 180);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(42, 17);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "Note";
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(16, 201);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.ReadOnly = true;
            this.rtbNote.Size = new System.Drawing.Size(526, 133);
            this.rtbNote.TabIndex = 11;
            this.rtbNote.Text = "";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(298, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(244, 20);
            this.txtPrice.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(295, 122);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 17);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // ProcedureInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 349);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblProcDate);
            this.Controls.Add(this.txtProc);
            this.Controls.Add(this.lblProc);
            this.Controls.Add(this.txtDocFullname);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.txtPatFullname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProcedureInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procedure Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatFullname;
        private System.Windows.Forms.TextBox txtDocFullname;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtProc;
        private System.Windows.Forms.Label lblProc;
        private System.Windows.Forms.Label lblProcDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}