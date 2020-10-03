using diceProjectGaming.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diceProjectGaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global variables

        int winner = 50;
        int playerOneRoll;
        int playerOneRollTwo; // test
        int playerOneRollTotal; 

        int playerTwoRoll;
        int playerTwoRollTwo;
        int playerTwoRollTotal;

        int playerOneScore;
        int playerTwoScore;
        
        private void startButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Welcome to the game, player one rolls first. Reach 50 points to win!");

            roleOneButton.Enabled = true;
            startButton.Enabled = false;
        }

        private void roleOneButton_Click(object sender, EventArgs e)
        {      

            roleTwoButton.Enabled = true;
            roleOneButton.Enabled = false;

            Random rnd = new Random();

            playerOneRoll = rnd.Next(1, 7);

            // Dice labels 

            if(playerOneRoll == 1)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die1.bmp";
            } else if (playerOneRoll == 2)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die2.bmp";
            }
            else if (playerOneRoll == 3)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die3.bmp";
            }
            else if (playerOneRoll == 4)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die4.bmp";
            }
            else if (playerOneRoll == 5)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die5.bmp";
            }
            else if (playerOneRoll == 6)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die6.bmp";
            }

            playerOneRollTwo = rnd.Next(1, 7);

            // Dice labels 

            if (playerOneRollTwo == 1)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die1.bmp";
            }
            else if (playerOneRollTwo == 2)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die2.bmp";
            }
            else if (playerOneRollTwo == 3)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die3.bmp";
            }
            else if (playerOneRollTwo == 4)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die4.bmp";
            }
            else if (playerOneRollTwo == 5)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die5.bmp";
            }
            else if (playerOneRollTwo == 6)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die6.bmp";
            }

            playerOneRollTotal = playerOneRoll + playerOneRollTwo;

            diceRoll.Text = playerOneRollTotal.ToString();

            playerOneScore = playerOneScore + playerOneRollTotal;

            playerOneScorebox.Text = playerOneScore.ToString();
    
            if (playerOneScore >= winner)
            {
                MessageBox.Show("Congrats Player one, You win!");
                roleTwoButton.Enabled = false;
            }

        }

        private void roleTwoButton_Click(object sender, EventArgs e)
        {
            roleOneButton.Enabled = true;
            roleTwoButton.Enabled = false;

            Random rnd = new Random();

            playerTwoRoll = rnd.Next(1, 7);


            // Dice labels 

            if (playerTwoRoll == 1)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die1.bmp";
            }
            else if (playerTwoRoll == 2)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die2.bmp";
            }
            else if (playerTwoRoll == 3)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die3.bmp";
            }
            else if (playerTwoRoll == 4)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die4.bmp";
            }
            else if (playerTwoRoll == 5)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die5.bmp";
            }
            else if (playerTwoRoll == 6)
            {
                diceOne.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die6.bmp";
            }

            playerTwoRollTwo = rnd.Next(1, 7);


            // Dice labels 

            if (playerTwoRollTwo == 1)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die1.bmp";
            }
            else if (playerTwoRollTwo == 2)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die2.bmp";
            }
            else if (playerTwoRollTwo == 3)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die3.bmp";
            }
            else if (playerTwoRollTwo == 4)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die4.bmp";
            }
            else if (playerTwoRollTwo == 5)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die5.bmp";
            }
            else if (playerTwoRollTwo == 6)
            {
                diceTwo.ImageLocation = @"C:\Users\Luis\source\repos\diceProjectGaming\Resources\Die6.bmp";
            }

            playerTwoRollTotal = playerTwoRoll + playerTwoRollTwo;

            diceRoll.Text = playerTwoRollTotal.ToString();

            playerTwoScore = playerTwoScore + playerTwoRollTotal;

            playerTwoScorebox.Text = playerTwoScore.ToString();


            if (playerTwoScore >= winner)
            {
                MessageBox.Show("Congrats player two, You win!");
                roleOneButton.Enabled = false;
            }
        
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
