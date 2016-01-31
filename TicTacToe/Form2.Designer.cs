namespace TicTacToe
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
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerOne = new System.Windows.Forms.TextBox();
            this.playerTwo = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.Location = new System.Drawing.Point(11, 73);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(119, 20);
            this.playerOneLabel.TabIndex = 0;
            this.playerOneLabel.Text = "Player One (X): ";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.Location = new System.Drawing.Point(11, 109);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(119, 20);
            this.playerTwoLabel.TabIndex = 1;
            this.playerTwoLabel.Text = "Player Two (O): ";
            // 
            // playerOne
            // 
            this.playerOne.Location = new System.Drawing.Point(122, 75);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(189, 20);
            this.playerOne.TabIndex = 2;
            this.playerOne.Text = "Player 1";
            // 
            // playerTwo
            // 
            this.playerTwo.Location = new System.Drawing.Point(122, 111);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(189, 20);
            this.playerTwo.TabIndex = 3;
            this.playerTwo.Text = "Computer";
            this.playerTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerTwo_KeyPress);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(236, 137);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(299, 53);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Type the names of the players below. If you would like to play against the Comput" +
    "er, leave player two as \"Computer\". Otherwise, enter the name of the second huma" +
    "n player.";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 168);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.TextBox playerOne;
        private System.Windows.Forms.TextBox playerTwo;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}