using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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



        }

        private void roleTwoButton_Click(object sender, EventArgs e)
        {
            roleOneButton.Enabled = true;
            roleTwoButton.Enabled = false;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
