namespace ModuleMarks
{
    partial class Delete
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.StuID = new System.Windows.Forms.Label();
            this.Mark = new System.Windows.Forms.Label();
            this.lblstuID = new System.Windows.Forms.Label();
            this.lblstuMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(68, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 39);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(258, 173);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(110, 39);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Main Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // StuID
            // 
            this.StuID.Location = new System.Drawing.Point(65, 57);
            this.StuID.Name = "StuID";
            this.StuID.Size = new System.Drawing.Size(110, 20);
            this.StuID.TabIndex = 2;
            this.StuID.Text = "Student ID";
            this.StuID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(65, 112);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(110, 20);
            this.Mark.TabIndex = 3;
            this.Mark.Text = "Mark";
            this.Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblstuID
            // 
            this.lblstuID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblstuID.Location = new System.Drawing.Point(212, 60);
            this.lblstuID.Name = "lblstuID";
            this.lblstuID.Size = new System.Drawing.Size(100, 20);
            this.lblstuID.TabIndex = 4;
            // 
            // lblstuMark
            // 
            this.lblstuMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblstuMark.Location = new System.Drawing.Point(212, 112);
            this.lblstuMark.Name = "lblstuMark";
            this.lblstuMark.Size = new System.Drawing.Size(62, 20);
            this.lblstuMark.TabIndex = 5;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 291);
            this.Controls.Add(this.lblstuMark);
            this.Controls.Add(this.lblstuID);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.StuID);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnDelete);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label StuID;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Label lblstuID;
        private System.Windows.Forms.Label lblstuMark;
    }
}