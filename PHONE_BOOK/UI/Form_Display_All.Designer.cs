namespace PHONE_BOOK
{
    partial class Form_Display_All
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.Interface_Show = new System.Windows.Forms.ListBox();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(59, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "❌ إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(587, 80);
            this.pnlHeader.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(150, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📋 جميع الأسماء المخزنة";
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btn_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Show.FlatAppearance.BorderSize = 0;
            this.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Show.ForeColor = System.Drawing.Color.White;
            this.btn_Show.Location = new System.Drawing.Point(328, 367);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(200, 40);
            this.btn_Show.TabIndex = 6;
            this.btn_Show.Text = " عرض";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // Interface_Show
            // 
            this.Interface_Show.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Interface_Show.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Interface_Show.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Interface_Show.FormattingEnabled = true;
            this.Interface_Show.ItemHeight = 30;
            this.Interface_Show.Location = new System.Drawing.Point(59, 86);
            this.Interface_Show.Name = "Interface_Show";
            this.Interface_Show.Size = new System.Drawing.Size(469, 274);
            this.Interface_Show.TabIndex = 8;
            // 
            // Form_Display_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 463);
            this.Controls.Add(this.Interface_Show);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form_Display_All";
            this.Text = "Form_Display_All";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ListBox Interface_Show;
    }
}