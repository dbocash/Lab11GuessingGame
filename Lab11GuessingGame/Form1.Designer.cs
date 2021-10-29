
namespace Lab11GuessingGame
{
    partial class GuessForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblUserGuess = new System.Windows.Forms.Label();
            this.btnNumGuesses = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDisplayRand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayLabel.Location = new System.Drawing.Point(43, 34);
            this.displayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(229, 32);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "I have a number between 1 and 1000. \r\nCan you guess the number?";
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.inputTextBox.Location = new System.Drawing.Point(191, 126);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(100, 23);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(372, 30);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Padding = new System.Windows.Forms.Padding(4);
            this.newGameButton.Size = new System.Drawing.Size(112, 34);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "&New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(43, 410);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 15);
            this.outputLabel.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(372, 71);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(49, 377);
            this.lblGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(116, 15);
            this.lblGuess.TabIndex = 5;
            this.lblGuess.Text = "Number of Guesses: ";
            // 
            // lblUserGuess
            // 
            this.lblUserGuess.AutoSize = true;
            this.lblUserGuess.Location = new System.Drawing.Point(49, 137);
            this.lblUserGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserGuess.Name = "lblUserGuess";
            this.lblUserGuess.Size = new System.Drawing.Size(80, 15);
            this.lblUserGuess.TabIndex = 6;
            this.lblUserGuess.Text = "Enter a Guess:";
            // 
            // btnNumGuesses
            // 
            this.btnNumGuesses.Location = new System.Drawing.Point(191, 369);
            this.btnNumGuesses.Margin = new System.Windows.Forms.Padding(4);
            this.btnNumGuesses.Name = "btnNumGuesses";
            this.btnNumGuesses.Size = new System.Drawing.Size(57, 22);
            this.btnNumGuesses.TabIndex = 7;
            this.btnNumGuesses.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(49, 175);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(305, 169);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // lblDisplayRand
            // 
            this.lblDisplayRand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayRand.Enabled = false;
            this.lblDisplayRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayRand.ForeColor = System.Drawing.Color.Red;
            this.lblDisplayRand.Location = new System.Drawing.Point(291, 126);
            this.lblDisplayRand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayRand.Name = "lblDisplayRand";
            this.lblDisplayRand.Size = new System.Drawing.Size(59, 25);
            this.lblDisplayRand.TabIndex = 9;
            this.lblDisplayRand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 427);
            this.Controls.Add(this.lblDisplayRand);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnNumGuesses);
            this.Controls.Add(this.lblUserGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.displayLabel);
            this.Name = "GuessForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblUserGuess;
        private System.Windows.Forms.Button btnNumGuesses;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblDisplayRand;
    }
}

