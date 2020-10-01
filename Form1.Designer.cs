namespace diceProjectGaming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.playerOneScorebox = new System.Windows.Forms.TextBox();
            this.playerTwoScorebox = new System.Windows.Forms.TextBox();
            this.scoreLabelOne = new System.Windows.Forms.Label();
            this.scoreLabelTwo = new System.Windows.Forms.Label();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.roleTwoButton = new System.Windows.Forms.Button();
            this.diceValueLabel = new System.Windows.Forms.Label();
            this.diceValue = new System.Windows.Forms.Label();
            this.roleOneButton = new System.Windows.Forms.Button();
            this.diceOne = new System.Windows.Forms.PictureBox();
            this.diceTwo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(371, 400);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dice game, press start to play";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(371, 68);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // playerOneScorebox
            // 
            this.playerOneScorebox.Location = new System.Drawing.Point(249, 248);
            this.playerOneScorebox.Name = "playerOneScorebox";
            this.playerOneScorebox.Size = new System.Drawing.Size(100, 20);
            this.playerOneScorebox.TabIndex = 5;
            // 
            // playerTwoScorebox
            // 
            this.playerTwoScorebox.Location = new System.Drawing.Point(515, 248);
            this.playerTwoScorebox.Name = "playerTwoScorebox";
            this.playerTwoScorebox.Size = new System.Drawing.Size(100, 20);
            this.playerTwoScorebox.TabIndex = 6;
            // 
            // scoreLabelOne
            // 
            this.scoreLabelOne.AutoSize = true;
            this.scoreLabelOne.Location = new System.Drawing.Point(182, 255);
            this.scoreLabelOne.Name = "scoreLabelOne";
            this.scoreLabelOne.Size = new System.Drawing.Size(41, 13);
            this.scoreLabelOne.TabIndex = 7;
            this.scoreLabelOne.Text = "Score :";
            // 
            // scoreLabelTwo
            // 
            this.scoreLabelTwo.AutoSize = true;
            this.scoreLabelTwo.Location = new System.Drawing.Point(450, 255);
            this.scoreLabelTwo.Name = "scoreLabelTwo";
            this.scoreLabelTwo.Size = new System.Drawing.Size(41, 13);
            this.scoreLabelTwo.TabIndex = 8;
            this.scoreLabelTwo.Text = "Score :";
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(258, 124);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(57, 13);
            this.playerOneLabel.TabIndex = 10;
            this.playerOneLabel.Text = "Player one";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Location = new System.Drawing.Point(525, 124);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(56, 13);
            this.playerTwoLabel.TabIndex = 11;
            this.playerTwoLabel.Text = "Player two";
            // 
            // roleTwoButton
            // 
            this.roleTwoButton.Enabled = false;
            this.roleTwoButton.Location = new System.Drawing.Point(515, 174);
            this.roleTwoButton.Name = "roleTwoButton";
            this.roleTwoButton.Size = new System.Drawing.Size(75, 23);
            this.roleTwoButton.TabIndex = 13;
            this.roleTwoButton.Text = "Press to roll!";
            this.roleTwoButton.UseVisualStyleBackColor = true;
            this.roleTwoButton.Click += new System.EventHandler(this.roleTwoButton_Click);
            // 
            // diceValueLabel
            // 
            this.diceValueLabel.AutoSize = true;
            this.diceValueLabel.Location = new System.Drawing.Point(526, 350);
            this.diceValueLabel.Name = "diceValueLabel";
            this.diceValueLabel.Size = new System.Drawing.Size(64, 13);
            this.diceValueLabel.TabIndex = 14;
            this.diceValueLabel.Text = "Dice value: ";
            // 
            // diceValue
            // 
            this.diceValue.AutoSize = true;
            this.diceValue.Location = new System.Drawing.Point(610, 350);
            this.diceValue.Name = "diceValue";
            this.diceValue.Size = new System.Drawing.Size(13, 13);
            this.diceValue.TabIndex = 15;
            this.diceValue.Text = "9";
            // 
            // roleOneButton
            // 
            this.roleOneButton.Enabled = false;
            this.roleOneButton.Location = new System.Drawing.Point(249, 174);
            this.roleOneButton.Name = "roleOneButton";
            this.roleOneButton.Size = new System.Drawing.Size(75, 23);
            this.roleOneButton.TabIndex = 16;
            this.roleOneButton.Text = "Press to roll!";
            this.roleOneButton.UseVisualStyleBackColor = true;
            this.roleOneButton.Click += new System.EventHandler(this.roleOneButton_Click);
            // 
            // diceOne
            // 
            this.diceOne.Location = new System.Drawing.Point(308, 313);
            this.diceOne.Name = "diceOne";
            this.diceOne.Size = new System.Drawing.Size(74, 62);
            this.diceOne.TabIndex = 17;
            this.diceOne.TabStop = false;
            // 
            // diceTwo
            // 
            this.diceTwo.Location = new System.Drawing.Point(428, 313);
            this.diceTwo.Name = "diceTwo";
            this.diceTwo.Size = new System.Drawing.Size(74, 62);
            this.diceTwo.TabIndex = 18;
            this.diceTwo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diceTwo);
            this.Controls.Add(this.diceOne);
            this.Controls.Add(this.roleOneButton);
            this.Controls.Add(this.diceValue);
            this.Controls.Add(this.diceValueLabel);
            this.Controls.Add(this.roleTwoButton);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.scoreLabelTwo);
            this.Controls.Add(this.scoreLabelOne);
            this.Controls.Add(this.playerTwoScorebox);
            this.Controls.Add(this.playerOneScorebox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Dice Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox playerOneScorebox;
        private System.Windows.Forms.TextBox playerTwoScorebox;
        private System.Windows.Forms.Label scoreLabelOne;
        private System.Windows.Forms.Label scoreLabelTwo;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.Button roleTwoButton;
        private System.Windows.Forms.Label diceValueLabel;
        private System.Windows.Forms.Label diceValue;
        private System.Windows.Forms.Button roleOneButton;
        private System.Windows.Forms.PictureBox diceOne;
        private System.Windows.Forms.PictureBox diceTwo;
    }
}

