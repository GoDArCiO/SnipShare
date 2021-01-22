namespace SnipShare
{
    partial class Form2
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
            this.addRoomButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roomCodeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(351, 261);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(96, 41);
            this.addRoomButton.TabIndex = 0;
            this.addRoomButton.Text = "Add Room";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Aqua;
            this.textBox1.Location = new System.Drawing.Point(324, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Room Code";
            // 
            // roomCodeInput
            // 
            this.roomCodeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(211)))), ((int)(((byte)(128)))));
            this.roomCodeInput.Location = new System.Drawing.Point(324, 210);
            this.roomCodeInput.Name = "roomCodeInput";
            this.roomCodeInput.Size = new System.Drawing.Size(148, 26);
            this.roomCodeInput.TabIndex = 2;
            this.roomCodeInput.TextChanged += new System.EventHandler(this.roomCodeInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(351, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(817, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomCodeInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addRoomButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox roomCodeInput;
        private System.Windows.Forms.Label label1;
    }
}