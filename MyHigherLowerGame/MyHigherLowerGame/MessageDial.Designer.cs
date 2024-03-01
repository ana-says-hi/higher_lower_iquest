namespace MyHigherLowerGame
{
    partial class MessageDial
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
            this.msgLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(132, 89);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(10, 13);
            this.msgLabel.TabIndex = 0;
            this.msgLabel.Text = ".";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(163, 184);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MessageDial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MinimumSize = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height);
            this.ClientSize = new System.Drawing.Size(421, 219);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.msgLabel);
            this.Name = "MessageDial";
            this.Text = "Message";
            this.ClientSizeChanged += new System.EventHandler(this.MessageDial_Resize);
            this.Resize += new System.EventHandler(this.MessageDial_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private int padding = 20;
        private void replaceItems()
        {
            this.closeButton.Location
                = new System.Drawing.Point((this.ClientSize.Width - this.closeButton.Width) / 2,
                this.ClientSize.Height - padding - this.closeButton.Height);

            this.msgLabel.Location
                = new System.Drawing.Point((this.ClientSize.Width - this.msgLabel.Width) / 2,
                (this.ClientSize.Height - this.msgLabel.Height) / 2);
        }


        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button closeButton;
    }
}