namespace MyHigherLowerGame
{
    partial class Lobby
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
            this.passWordLabel = new System.Windows.Forms.Label();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.playerList = new System.Windows.Forms.RichTextBox();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.clearPlayerButton = new System.Windows.Forms.Button();
            this.resetScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passWordLabel
            // 
            this.passWordLabel.AutoSize = true;
            this.passWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordLabel.Location = new System.Drawing.Point(149, 185);
            this.passWordLabel.Name = "passWordLabel";
            this.passWordLabel.Size = new System.Drawing.Size(69, 17);
            this.passWordLabel.TabIndex = 19;
            this.passWordLabel.Text = "Password";
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Location = new System.Drawing.Point(230, 184);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.PasswordChar = '*';
            this.passWordTextBox.Size = new System.Drawing.Size(133, 20);
            this.passWordTextBox.TabIndex = 18;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(149, 159);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(73, 17);
            this.userNameLabel.TabIndex = 17;
            this.userNameLabel.Text = "Username";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(230, 158);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(133, 20);
            this.userNameTextBox.TabIndex = 16;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(357, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(88, 31);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "Lobby";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(202, 219);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 21;
            this.logInButton.Text = "Login";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(319, 368);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 46);
            this.startButton.TabIndex = 22;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // playerList
            // 
            this.playerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.Location = new System.Drawing.Point(565, 76);
            this.playerList.Name = "playerList";
            this.playerList.ReadOnly = true;
            this.playerList.Size = new System.Drawing.Size(223, 292);
            this.playerList.TabIndex = 23;
            this.playerList.Text = "";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(23, 415);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(91, 23);
            this.newAccountButton.TabIndex = 24;
            this.newAccountButton.Text = "Create Account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Location = new System.Drawing.Point(10, 399);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(116, 13);
            this.createAccountLabel.TabIndex = 25;
            this.createAccountLabel.Text = "Don\'t have an accout?";
            // 
            // clearPlayerButton
            // 
            this.clearPlayerButton.Location = new System.Drawing.Point(565, 380);
            this.clearPlayerButton.Name = "clearPlayerButton";
            this.clearPlayerButton.Size = new System.Drawing.Size(103, 23);
            this.clearPlayerButton.TabIndex = 26;
            this.clearPlayerButton.Text = "Clear Players";
            this.clearPlayerButton.UseVisualStyleBackColor = true;
            this.clearPlayerButton.Click += new System.EventHandler(this.clearPlayers_Click);
            // 
            // resetScoreButton
            // 
            this.resetScoreButton.Location = new System.Drawing.Point(674, 380);
            this.resetScoreButton.Name = "resetScoreButton";
            this.resetScoreButton.Size = new System.Drawing.Size(114, 23);
            this.resetScoreButton.TabIndex = 27;
            this.resetScoreButton.Text = "Reset Scores";
            this.resetScoreButton.UseVisualStyleBackColor = true;
            this.resetScoreButton.Click += new System.EventHandler(this.resetScoreButton_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetScoreButton);
            this.Controls.Add(this.clearPlayerButton);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.passWordLabel);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.ClientSizeChanged += new System.EventHandler(this.Lobby_Resize);
            this.Resize += new System.EventHandler(this.Lobby_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private int padding = 20;
        bool init = true;

        private void replaceItems()
        {
            if(init == true)
            {
                init = false;
                replaceItems();
            }
            this.titleLabel.Location 
                = new System.Drawing.Point((this.ClientSize.Width - this.titleLabel.Width) / 2,
                titleLabel.Location.Y);

            this.createAccountLabel.Location 
                = new System.Drawing.Point(padding,
                this.newAccountButton.Location.Y - padding - this.createAccountLabel.Height);

            this.newAccountButton.Location
                = new System.Drawing.Point(this.createAccountLabel.Location.X
                + this.createAccountLabel.Width / 2 - this.newAccountButton.Width / 2,
                this.ClientSize.Height - padding - this.newAccountButton.Height);

            this.startButton.Location
                = new System.Drawing.Point((this.ClientSize.Width - this.startButton.Width) / 2,
                this.ClientSize.Height - this.startButton.Height - padding);

            this.userNameLabel.Location
                = new System.Drawing.Point(this.ClientSize.Width / 4 - this.userNameLabel.Width / 2,
                (this.ClientSize.Height) / 2 - padding);

            this.userNameTextBox.Location
                = new System.Drawing.Point(this.userNameLabel.Location.X + this.userNameLabel.Width + padding,
                this.userNameLabel.Location.Y);

            this.passWordLabel.Location
                = new System.Drawing.Point(this.userNameLabel.Location.X,
                this.userNameLabel.Location.Y + 2 * padding);

            this.passWordTextBox.Location
                = new System.Drawing.Point(this.userNameTextBox.Location.X,
                this.passWordLabel.Location.Y);

            this.logInButton.Location
                = new System.Drawing.Point((this.passWordLabel.Location.X + this.passWordTextBox.Location.X 
                + this.passWordTextBox.Width - this.logInButton.Width) / 2,
                this.passWordLabel.Location.Y + this.passWordTextBox.Height + padding);
            
            this.playerList.Location
                = new System.Drawing.Point(this.startButton.Location.X + this.startButton.Width+ 2*padding,
                this.playerList.Location.Y);

            this.playerList.Width = this.resetScoreButton.Location.X + this.resetScoreButton.Width - this.playerList.Location.X;
            this.playerList.Height = this.resetScoreButton.Location.Y - padding - this.playerList.Location.Y;

            this.resetScoreButton.Location
                = new System.Drawing.Point(this.ClientSize.Width - padding - this.resetScoreButton.Width,
                this.ClientSize.Height - padding - this.resetScoreButton.Height);

            this.clearPlayerButton.Location
                = new System.Drawing.Point(this.playerList.Location.X,
                this.resetScoreButton.Location.Y);

        }

        private System.Windows.Forms.Label passWordLabel;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RichTextBox playerList;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Button clearPlayerButton;
        private System.Windows.Forms.Button resetScoreButton;
    }
}