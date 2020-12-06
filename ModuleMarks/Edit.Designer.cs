namespace ModuleMarks
{
    partial class Edit
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
            this.lblStuID = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtstuMark = new System.Windows.Forms.TextBox();
            this.txtstuID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStuID
            // 
            this.lblStuID.Location = new System.Drawing.Point(94, 58);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(116, 20);
            this.lblStuID.TabIndex = 0;
            this.lblStuID.Text = "Student ID";
            this.lblStuID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMark
            // 
            this.lblMark.Location = new System.Drawing.Point(94, 112);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(116, 20);
            this.lblMark.TabIndex = 1;
            this.lblMark.Text = "Mark";
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtstuMark
            // 
            this.txtstuMark.Location = new System.Drawing.Point(241, 109);
            this.txtstuMark.Name = "txtstuMark";
            this.txtstuMark.Size = new System.Drawing.Size(54, 20);
            this.txtstuMark.TabIndex = 3;
            // 
            // txtstuID
            // 
            this.txtstuID.Location = new System.Drawing.Point(241, 58);
            this.txtstuID.Name = "txtstuID";
            this.txtstuID.Size = new System.Drawing.Size(100, 20);
            this.txtstuID.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 281);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtstuID);
            this.Controls.Add(this.txtstuMark);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lblStuID);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtstuMark;
        private System.Windows.Forms.TextBox txtstuID;
        private System.Windows.Forms.Button btnCancel;
    }
}