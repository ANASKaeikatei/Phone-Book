namespace PHONE_BOOK
{
    partial class Form1
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnTextFile = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(100, 400);
            this.btnList.Name = "btnList";
            this.btnList.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnList.Size = new System.Drawing.Size(500, 65);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "📋  قائمة (List)";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnArray
            // 
            this.btnArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnArray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArray.FlatAppearance.BorderSize = 0;
            this.btnArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArray.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnArray.ForeColor = System.Drawing.Color.White;
            this.btnArray.Location = new System.Drawing.Point(100, 315);
            this.btnArray.Name = "btnArray";
            this.btnArray.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnArray.Size = new System.Drawing.Size(500, 65);
            this.btnArray.TabIndex = 6;
            this.btnArray.Text = "📊  مصفوفات (Array)";
            this.btnArray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArray.UseVisualStyleBackColor = false;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnTextFile
            // 
            this.btnTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTextFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTextFile.FlatAppearance.BorderSize = 0;
            this.btnTextFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnTextFile.ForeColor = System.Drawing.Color.White;
            this.btnTextFile.Location = new System.Drawing.Point(100, 230);
            this.btnTextFile.Name = "btnTextFile";
            this.btnTextFile.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTextFile.Size = new System.Drawing.Size(500, 65);
            this.btnTextFile.TabIndex = 7;
            this.btnTextFile.Text = "📄  ملف نصي (Text File)";
            this.btnTextFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextFile.UseVisualStyleBackColor = false;
            this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatabase.FlatAppearance.BorderSize = 0;
            this.btnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabase.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDatabase.ForeColor = System.Drawing.Color.White;
            this.btnDatabase.Location = new System.Drawing.Point(100, 145);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDatabase.Size = new System.Drawing.Size(500, 65);
            this.btnDatabase.TabIndex = 8;
            this.btnDatabase.Text = "🗄️  قاعدة بيانات (Database)";
            this.btnDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatabase.UseVisualStyleBackColor = false;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(690, 120);
            this.pnlHeader.TabIndex = 9;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblSubtitle.Location = new System.Drawing.Point(200, 75);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(312, 28);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "اختر طريقة التخزين المناسبة للبيانات";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(233, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Phone Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 506);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnTextFile);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnTextFile;
        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
    }
}

