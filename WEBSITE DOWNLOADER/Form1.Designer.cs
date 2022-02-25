namespace WEBSITE_DOWNLOADER
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
            this.Download_BTN = new System.Windows.Forms.Button();
            this.siteUrl_TB = new System.Windows.Forms.TextBox();
            this.fileNameToSave_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Download_BTN
            // 
            this.Download_BTN.Location = new System.Drawing.Point(129, 111);
            this.Download_BTN.Name = "Download_BTN";
            this.Download_BTN.Size = new System.Drawing.Size(75, 23);
            this.Download_BTN.TabIndex = 0;
            this.Download_BTN.Text = "Download";
            this.Download_BTN.UseVisualStyleBackColor = true;
            this.Download_BTN.Click += new System.EventHandler(this.Download_BTN_Click);
            // 
            // siteUrl_TB
            // 
            this.siteUrl_TB.Location = new System.Drawing.Point(12, 31);
            this.siteUrl_TB.Name = "siteUrl_TB";
            this.siteUrl_TB.Size = new System.Drawing.Size(343, 20);
            this.siteUrl_TB.TabIndex = 1;
            // 
            // fileNameToSave_TB
            // 
            this.fileNameToSave_TB.Location = new System.Drawing.Point(12, 71);
            this.fileNameToSave_TB.Name = "fileNameToSave_TB";
            this.fileNameToSave_TB.Size = new System.Drawing.Size(343, 20);
            this.fileNameToSave_TB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 196);
            this.Controls.Add(this.fileNameToSave_TB);
            this.Controls.Add(this.siteUrl_TB);
            this.Controls.Add(this.Download_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Download_BTN;
        private System.Windows.Forms.TextBox siteUrl_TB;
        private System.Windows.Forms.TextBox fileNameToSave_TB;
    }
}

