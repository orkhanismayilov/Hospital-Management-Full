namespace Hospital_Program
{
    partial class AddingDept
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
            this.txtNewDeptName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDeptToDatabase = new System.Windows.Forms.Button();
            this.btnCancelAddingDept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewDeptName
            // 
            this.txtNewDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNewDeptName.Location = new System.Drawing.Point(12, 29);
            this.txtNewDeptName.Name = "txtNewDeptName";
            this.txtNewDeptName.Size = new System.Drawing.Size(311, 23);
            this.txtNewDeptName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter department name";
            // 
            // btnAddDeptToDatabase
            // 
            this.btnAddDeptToDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDeptToDatabase.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddDeptToDatabase.Location = new System.Drawing.Point(13, 68);
            this.btnAddDeptToDatabase.Name = "btnAddDeptToDatabase";
            this.btnAddDeptToDatabase.Size = new System.Drawing.Size(143, 40);
            this.btnAddDeptToDatabase.TabIndex = 13;
            this.btnAddDeptToDatabase.Text = "Add Department";
            this.btnAddDeptToDatabase.UseVisualStyleBackColor = false;
            this.btnAddDeptToDatabase.Click += new System.EventHandler(this.btnAddDeptToDatabase_Click);
            // 
            // btnCancelAddingDept
            // 
            this.btnCancelAddingDept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAddingDept.BackColor = System.Drawing.Color.Red;
            this.btnCancelAddingDept.Location = new System.Drawing.Point(181, 68);
            this.btnCancelAddingDept.Name = "btnCancelAddingDept";
            this.btnCancelAddingDept.Size = new System.Drawing.Size(143, 40);
            this.btnCancelAddingDept.TabIndex = 14;
            this.btnCancelAddingDept.Text = "Cancel";
            this.btnCancelAddingDept.UseVisualStyleBackColor = false;
            this.btnCancelAddingDept.Click += new System.EventHandler(this.btnCancelAddingDept_Click);
            // 
            // AddingDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 118);
            this.Controls.Add(this.btnCancelAddingDept);
            this.Controls.Add(this.btnAddDeptToDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewDeptName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddingDept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewDeptName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDeptToDatabase;
        private System.Windows.Forms.Button btnCancelAddingDept;
    }
}