namespace ModuleMarks
{
    partial class Add
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblstuID = new System.Windows.Forms.Label();
            this.txtstuMark = new System.Windows.Forms.TextBox();
            this.txtstuID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(89, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(226, 178);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 35);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblMark
            // 
            this.lblMark.Location = new System.Drawing.Point(89, 117);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(97, 20);
            this.lblMark.TabIndex = 5;
            this.lblMark.Text = "Mark";
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblstuID
            // 
            this.lblstuID.Location = new System.Drawing.Point(86, 60);
            this.lblstuID.Name = "lblstuID";
            this.lblstuID.Size = new System.Drawing.Size(100, 20);
            this.lblstuID.TabIndex = 6;
            this.lblstuID.Text = "Student ID";
            this.lblstuID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtstuMark
            // 
            this.txtstuMark.Location = new System.Drawing.Point(226, 117);
            this.txtstuMark.Name = "txtstuMark";
            this.txtstuMark.Size = new System.Drawing.Size(50, 20);
            this.txtstuMark.TabIndex = 7;
            // 
            // txtstuID
            // 
            this.txtstuID.Location = new System.Drawing.Point(226, 60);
            this.txtstuID.Name = "txtstuID";
            this.txtstuID.Size = new System.Drawing.Size(100, 20);
            this.txtstuID.TabIndex = 8;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 290);
            this.Controls.Add(this.txtstuID);
            this.Controls.Add(this.txtstuMark);
            this.Controls.Add(this.lblstuID);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnAdd);
            this.Name = "Add";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblstuID;
        private System.Windows.Forms.TextBox txtstuMark;
        private System.Windows.Forms.TextBox txtstuID;
    }
}