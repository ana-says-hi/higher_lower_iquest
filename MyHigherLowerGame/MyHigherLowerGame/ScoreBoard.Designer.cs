namespace MyHigherLowerGame
{
    partial class ScoreBoard
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
            this.playerList = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.winnerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerList
            // 
            this.playerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.Location = new System.Drawing.Point(130, 123);
            this.playerList.Name = "playerList";
            this.playerList.ReadOnly = true;
            this.playerList.Size = new System.Drawing.Size(526, 315);
            this.playerList.TabIndex = 25;
            this.playerList.Text = "";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(330, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(154, 31);
            this.titleLabel.TabIndex = 24;
            this.titleLabel.Text = "Scoreboard";
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(713, 415);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 26;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(202, 71);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(91, 25);
            this.winnerLabel.TabIndex = 27;
            this.winnerLabel.Text = "Winner : ";
            // 
            // winnerNameLabel
            // 
            this.winnerNameLabel.AutoSize = true;
            this.winnerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerNameLabel.Location = new System.Drawing.Point(299, 71);
            this.winnerNameLabel.Name = "winnerNameLabel";
            this.winnerNameLabel.Size = new System.Drawing.Size(127, 25);
            this.winnerNameLabel.TabIndex = 28;
            this.winnerNameLabel.Text = "WinnerName";
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winnerNameLabel);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.titleLabel);
            this.Name = "ScoreBoard";
            this.Text = "ScoreBoard";
            this.Resize += new System.EventHandler(this.ScoreBoard_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private int padding = 20;
        private int winnerRowWidth;

        private void replaceItems()
        {
            this.titleLabel.Location
                = new System.Drawing.Point((this.ClientSize.Width - this.titleLabel.Width) / 2,
                this.titleLabel.Location.Y);

            this.finishButton.Location
                = new System.Drawing.Point(this.ClientSize.Width - padding - this.finishButton.Width,
                this.ClientSize.Height - padding - this.finishButton.Height);

            this.winnerLabel.Location
                = new System.Drawing.Point((this.ClientSize.Width - winnerRowWidth) / 2,
                this.titleLabel.Location.Y + this.titleLabel.Height + 2 * padding);

            this.winnerNameLabel.Location
                = new System.Drawing.Point(this.winnerLabel.Width + this.winnerLabel.Location.X + padding,
                this.winnerLabel.Location.Y);

            this.playerList.Location
               = new System.Drawing.Point(this.finishButton.Width + 2 * padding,
               this.winnerLabel.Location.Y + this.winnerLabel.Height + padding);

            this.playerList.Width = this.ClientSize.Width - 2 * (2 * padding + this.finishButton.Width);
            this.playerList.Height = this.ClientSize.Height - this.playerList.Location.Y - padding;

        }

        private System.Windows.Forms.RichTextBox playerList;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label winnerNameLabel;
    }
}