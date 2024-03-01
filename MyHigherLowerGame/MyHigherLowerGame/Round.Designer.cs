namespace MyHigherLowerGame
{
    partial class Round
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.playerList = new System.Windows.Forms.RichTextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.answerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.higherButton = new System.Windows.Forms.Button();
            this.muchHigherButton = new System.Windows.Forms.Button();
            this.lowerButton = new System.Windows.Forms.Button();
            this.muchLowerButton = new System.Windows.Forms.Button();
            this.player1AnswerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.answerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(308, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(130, 31);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Round Nr";
            // 
            // playerList
            // 
            this.playerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.Location = new System.Drawing.Point(565, 146);
            this.playerList.Name = "playerList";
            this.playerList.ReadOnly = true;
            this.playerList.Size = new System.Drawing.Size(223, 292);
            this.playerList.TabIndex = 24;
            this.playerList.Text = "";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(651, 123);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(59, 20);
            this.scoreLabel.TabIndex = 25;
            this.scoreLabel.Text = "Scores";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(40, 100);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(94, 20);
            this.playerNameLabel.TabIndex = 26;
            this.playerNameLabel.Text = "PlayerName";
            // 
            // answerNumericUpDown
            // 
            this.answerNumericUpDown.Location = new System.Drawing.Point(57, 166);
            this.answerNumericUpDown.Name = "answerNumericUpDown";
            this.answerNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.answerNumericUpDown.TabIndex = 27;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextLabel.Location = new System.Drawing.Point(53, 61);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(103, 20);
            this.questionTextLabel.TabIndex = 28;
            this.questionTextLabel.Text = "QuestionText";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(148, 166);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 29;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // higherButton
            // 
            this.higherButton.Location = new System.Drawing.Point(298, 352);
            this.higherButton.Name = "higherButton";
            this.higherButton.Size = new System.Drawing.Size(76, 23);
            this.higherButton.TabIndex = 30;
            this.higherButton.Text = "Higher";
            this.higherButton.UseVisualStyleBackColor = true;
            this.higherButton.Click += new System.EventHandler(this.higherButton_Click);
            // 
            // muchHigherButton
            // 
            this.muchHigherButton.Location = new System.Drawing.Point(409, 352);
            this.muchHigherButton.Name = "muchHigherButton";
            this.muchHigherButton.Size = new System.Drawing.Size(78, 23);
            this.muchHigherButton.TabIndex = 31;
            this.muchHigherButton.Text = "Much Higher";
            this.muchHigherButton.UseVisualStyleBackColor = true;
            this.muchHigherButton.Click += new System.EventHandler(this.muchHigherButton_Click);
            // 
            // lowerButton
            // 
            this.lowerButton.Location = new System.Drawing.Point(187, 352);
            this.lowerButton.Name = "lowerButton";
            this.lowerButton.Size = new System.Drawing.Size(79, 23);
            this.lowerButton.TabIndex = 32;
            this.lowerButton.Text = "Lower";
            this.lowerButton.UseVisualStyleBackColor = true;
            this.lowerButton.Click += new System.EventHandler(this.lowerButton_Click);
            // 
            // muchLowerButton
            // 
            this.muchLowerButton.Location = new System.Drawing.Point(76, 352);
            this.muchLowerButton.Name = "muchLowerButton";
            this.muchLowerButton.Size = new System.Drawing.Size(80, 23);
            this.muchLowerButton.TabIndex = 34;
            this.muchLowerButton.Text = "Much Lower";
            this.muchLowerButton.UseVisualStyleBackColor = true;
            this.muchLowerButton.Click += new System.EventHandler(this.muchLowerButton_Click);
            // 
            // player1AnswerLabel
            // 
            this.player1AnswerLabel.AutoSize = true;
            this.player1AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1AnswerLabel.Location = new System.Drawing.Point(52, 138);
            this.player1AnswerLabel.Name = "player1AnswerLabel";
            this.player1AnswerLabel.Size = new System.Drawing.Size(84, 25);
            this.player1AnswerLabel.TabIndex = 35;
            this.player1AnswerLabel.Text = "Answer";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 424);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 36;
            // 
            // Round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.player1AnswerLabel);
            this.Controls.Add(this.muchLowerButton);
            this.Controls.Add(this.lowerButton);
            this.Controls.Add(this.muchHigherButton);
            this.Controls.Add(this.higherButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.answerNumericUpDown);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.titleLabel);
            this.Name = "Round";
            this.Text = "Round";
            this.ClientSizeChanged += new System.EventHandler(this.Round_Resize);
            this.Resize += new System.EventHandler(this.Round_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.answerNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private int padding = 20;

        private void replaceItems()
        {
            this.titleLabel.Location
                = new System.Drawing.Point((this.ClientSize.Width - this.titleLabel.Width) / 2,
                padding);

            this.questionTextLabel.Location
                = new System.Drawing.Point(padding,
                this.titleLabel.Location.Y + this.titleLabel.Height + padding);

            this.playerNameLabel.Location
                = new System.Drawing.Point(padding,
                this.questionTextLabel.Location.Y + this.questionTextLabel.Height + padding);

            this.answerNumericUpDown.Location
                = new System.Drawing.Point(padding,
                this.playerNameLabel.Location.Y + this.playerNameLabel.Height + 2 * padding);

            this.confirmButton.Location
                = new System.Drawing.Point(this.answerNumericUpDown.Location.X + this.answerNumericUpDown.Width + 2*padding,
                this.answerNumericUpDown.Location.Y);

            this.player1AnswerLabel.Location
                = new System.Drawing.Point(padding,
                this.playerNameLabel.Location.Y + this.playerNameLabel.Height + 2 * padding);

            this.scoreLabel.Location
                = new System.Drawing.Point(this.playerList.Location.X + (this.playerList.Width - this.scoreLabel.Width)/2,
                this.playerNameLabel.Location.Y + this.playerNameLabel.Height + padding);

            this.playerList.Location
                = new System.Drawing.Point(this.ClientSize.Width / 4 * 3,
                this.scoreLabel.Location.Y + this.scoreLabel.Height + padding);

            this.playerList.Width = this.ClientSize.Width / 4 - padding;
            this.playerList.Height = this.ClientSize.Height - this.playerList.Location.Y - padding;

            this.timeLabel.Location
                = new System.Drawing.Point(padding,
                this.ClientSize.Height - padding - this.timeLabel.Height);

            int buttonSpaceLeftBorder = this.timeLabel.Location.X + this.timeLabel.Width;
            int buttonSpaceRightBorder = this.playerList.Location.X;
            int buttonSpaceWidth = buttonSpaceRightBorder - buttonSpaceLeftBorder;

            System.Drawing.Point firstOfTwo
                = new System.Drawing.Point(buttonSpaceWidth / 3 + buttonSpaceLeftBorder - this.higherButton.Width / 2,
                        this.timeLabel.Location.Y - this.muchLowerButton.Height - padding);

            System.Drawing.Point secondOfTwo
                = new System.Drawing.Point(buttonSpaceWidth / 3 * 2 + buttonSpaceLeftBorder - this.muchHigherButton.Width / 2,
                        this.timeLabel.Location.Y - this.muchLowerButton.Height - padding);


            System.Drawing.Point firstOfThree
                = new System.Drawing.Point(buttonSpaceWidth / 4 + buttonSpaceLeftBorder - this.lowerButton.Width / 2,
                this.timeLabel.Location.Y - this.muchLowerButton.Height - padding);

            System.Drawing.Point secondOfThree
                = new System.Drawing.Point(buttonSpaceWidth / 2 + buttonSpaceLeftBorder - this.higherButton.Width / 2,
                this.timeLabel.Location.Y - this.muchLowerButton.Height - padding);

            System.Drawing.Point thirdOfThree
                = new System.Drawing.Point(buttonSpaceWidth / 4 * 3 + buttonSpaceLeftBorder - this.muchHigherButton.Width / 2,
                this.timeLabel.Location.Y - this.muchLowerButton.Height - padding);


            System.Drawing.Point firstOfFour
                = new System.Drawing.Point(buttonSpaceWidth / 5 + buttonSpaceLeftBorder - this.muchHigherButton.Width / 2,
                        this.timeLabel.Location.Y - this.muchLowerButton.Height - padding);

            System.Drawing.Point secondOfFour
                = new System.Drawing.Point(buttonSpaceWidth / 5 * 2 + buttonSpaceLeftBorder - this.muchHigherButton.Width / 2,
                        this.timeLabel.Location.Y - this.muchLowerButton.Height - padding);

            System.Drawing.Point thirdOfFour
                = new System.Drawing.Point(buttonSpaceWidth / 5 * 3 + buttonSpaceLeftBorder - this.muchHigherButton.Width / 2,
                        this.timeLabel.Location.Y - this.muchLowerButton.Height - padding);


            System.Drawing.Point fourthOfFour
                = new System.Drawing.Point(buttonSpaceWidth / 5 * 4 + buttonSpaceLeftBorder - this.muchHigherButton.Width / 2,
                        this.timeLabel.Location.Y - this.muchLowerButton.Height - padding);

            if (this.muchLowerButton.Visible == false)
            {
                if (this.lowerButton.Visible == false)
                {
                    this.higherButton.Location = firstOfTwo;
                    this.muchHigherButton.Location = secondOfTwo;
                }
                else
                {
                    this.lowerButton.Location = firstOfThree;
                    this.higherButton.Location = secondOfThree;
                    this.muchHigherButton.Location = thirdOfThree;
                }
            }
            else if (this.muchHigherButton.Visible == false) 
            {
                if(this.higherButton.Visible == false)
                {
                    this.muchLowerButton.Location = firstOfTwo;
                    this.lowerButton.Location = secondOfTwo;
                }
                else
                {
                    this.muchLowerButton.Location = firstOfThree;
                    this.lowerButton.Location = secondOfThree;
                    this.higherButton.Location = thirdOfThree;
                }
            }
            else
            {
                this.muchLowerButton.Location = firstOfFour;
                this.lowerButton.Location = secondOfFour;
                this.higherButton.Location = thirdOfFour;
                this.muchHigherButton.Location = fourthOfFour;
            }

        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RichTextBox playerList;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.NumericUpDown answerNumericUpDown;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button higherButton;
        private System.Windows.Forms.Button muchHigherButton;
        private System.Windows.Forms.Button lowerButton;
        private System.Windows.Forms.Button muchLowerButton;
        private System.Windows.Forms.Label player1AnswerLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
    }
}