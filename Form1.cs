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
        int playerTwoRoll;
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

            diceRoll.Text = playerOneRoll.ToString();

            playerOneScore = playerOneScore + playerOneRoll;

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

            diceRoll.Text = playerTwoRoll.ToString();

            playerTwoScore = playerTwoScore + playerTwoRoll;

            playerTwoScorebox.Text = playerTwoScore.ToString();

            if(playerTwoScore >= winner)
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
