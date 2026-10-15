namespace PHONE_BOOK
{
    partial class Form_Edit
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.lblNewNumber = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtOldName = new System.Windows.Forms.TextBox();
            this.lblOldName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(50, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 45);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "رجوع";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(295, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "💾 حفظ التعديلات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewNumber.Location = new System.Drawing.Point(50, 320);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(435, 34);
            this.txtNewNumber.TabIndex = 11;
            // 
            // lblNewNumber
            // 
            this.lblNewNumber.AutoSize = true;
            this.lblNewNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNewNumber.Location = new System.Drawing.Point(376, 289);
            this.lblNewNumber.Name = "lblNewNumber";
            this.lblNewNumber.Size = new System.Drawing.Size(109, 28);
            this.lblNewNumber.TabIndex = 12;
            this.lblNewNumber.Text = "الرقم الجديد";
            // 
            // txtNewName
            // 
            this.txtNewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewName.Location = new System.Drawing.Point(50, 240);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(435, 34);
            this.txtNewName.TabIndex = 13;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNewName.Location = new System.Drawing.Point(370, 210);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(115, 28);
            this.lblNewName.TabIndex = 14;
            this.lblNewName.Text = "الاسم الجديد";
            // 
            // txtOldName
            // 
            this.txtOldName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOldName.Location = new System.Drawing.Point(50, 160);
            this.txtOldName.Name = "txtOldName";
            this.txtOldName.Size = new System.Drawing.Size(435, 34);
            this.txtOldName.TabIndex = 15;
            // 
            // lblOldName
            // 
            this.lblOldName.AutoSize = true;
            this.lblOldName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOldName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblOldName.Location = new System.Drawing.Point(317, 129);
            this.lblOldName.Name = "lblOldName";
            this.lblOldName.Size = new System.Drawing.Size(168, 28);
            this.lblOldName.TabIndex = 16;
            this.lblOldName.Text = "الاسم المراد تعديله";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(522, 80);
            this.pnlHeader.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(145, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "✏️ تعديل بيانات";
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewNumber);
            this.Controls.Add(this.lblNewNumber);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtOldName);
            this.Controls.Add(this.lblOldName);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form_Edit";
            this.Text = "Form_Edit";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Label lblNewNumber;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtOldName;
        private System.Windows.Forms.Label lblOldName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
    }
}