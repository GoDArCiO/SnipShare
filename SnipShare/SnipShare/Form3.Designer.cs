namespace SnipShare
{
    partial class Form3
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
            this.download = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.downText = new System.Windows.Forms.TextBox();
            this.upText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(104, 130);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(219, 49);
            this.download.TabIndex = 0;
            this.download.Text = "download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(497, 130);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(219, 49);
            this.upload.TabIndex = 1;
            this.upload.Text = "upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // downText
            // 
            this.downText.Location = new System.Drawing.Point(104, 196);
            this.downText.Multiline = true;
            this.downText.Name = "downText";
            this.downText.Size = new System.Drawing.Size(219, 282);
            this.downText.TabIndex = 2;
            // 
            // upText
            // 
            this.upText.Location = new System.Drawing.Point(497, 196);
            this.upText.Multiline = true;
            this.upText.Name = "upText";
            this.upText.Size = new System.Drawing.Size(219, 282);
            this.upText.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(817, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.upText);
            this.Controls.Add(this.downText);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.download);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.TextBox downText;
        private System.Windows.Forms.TextBox upText;
        private System.Windows.Forms.Button button1;
    }
}