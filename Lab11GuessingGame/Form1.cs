using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11GuessingGame
{
    public partial class GuessForm : Form
    {
        int secret = 0;
        int count = 0;
        Random randomNumber;
        // default constructor
        public GuessForm()
        {
            InitializeComponent();
            inputTextBox.Enabled = false;
        } // end constructor
          // randomly generate secret number (1-1000)
        private void GenerateSecret()
        {
            randomNumber = new Random();
            secret = randomNumber.Next(1000) + 1;
            lblDisplayRand.Text = secret.ToString();
        } // end method GenerateSecret
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            int userGuess = -1;
            bool success = Int32.TryParse(inputTextBox.Text, out userGuess);
            if (!success) return;
            // Check to see if user has pressed enter in textbox
            if (e.KeyCode == Keys.Enter)
            {
                if (userGuess >= 0)
                    count++;
                if (userGuess < secret)
                {
                    richTextBox1.Text += userGuess.ToString() + " - Too low, guess a bit higher\r\n";
                }
                else if (userGuess > secret)
                {
                    richTextBox1.Text += userGuess.ToString() + " - Too high, guess a bit lower\r\n";
                }
                else
                {
                    if (count > 10)
                    {
                        BackColor = Color.LightSalmon;
                        outputLabel.Text = "You have guessed the number, but you could do better.";
                    newGameButton.Enabled = true;
                        inputTextBox.ReadOnly = true;
                        richTextBox1.Text += userGuess.ToString();
                    }
                    if (count < 4)
                    {
                        BackColor = Color.LightCyan;
                        outputLabel.Text = "You are lucky or you know how to cheat.";
                    newGameButton.Enabled = true;
                        inputTextBox.ReadOnly = true;
                        richTextBox1.Text += userGuess.ToString();
                    }
                    else
                    {
                        BackColor = Color.LightBlue;
                        outputLabel.Text = "Congratulations, You have guessed the number.";
                    newGameButton.Enabled = true;
                        inputTextBox.ReadOnly = true;
                        richTextBox1.Text += userGuess.ToString();
                    }
                }
                btnNumGuesses.Text = Convert.ToString(count);
                // clear guess
                inputTextBox.SelectAll();
            } // end if
        } // end method inputTextBox_KeyDown
        private void newGameButton_Click(object sender, EventArgs e)
        {
            GenerateSecret();
            newGameButton.Enabled = false;
            inputTextBox.ReadOnly = false;
            BackColor = Color.FromName("Control");
            outputLabel.Text = "";
            inputTextBox.Enabled = true;
            inputTextBox.Clear();
            richTextBox1.Clear();
            inputTextBox.Focus();
            outputLabel.Text = "New Game in Progress...";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
