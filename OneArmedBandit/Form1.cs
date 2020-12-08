using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random RandGen = new Random();

        // int value for score initialized to 10
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            int reel1value;
            
            int reel2value;
            
            int reel3value;

            reel1value = RandGen.Next(1,4);

            reel2value = RandGen.Next(1,4);

            reel3value = RandGen.Next(1,4);
            // check value of reel 1 with a switch statement and set appropriate image
            switch (reel1value) 
            {
                case 1:
                    reel1.Image = OneArmedBandit.Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel1.Image = OneArmedBandit.Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel1.Image = OneArmedBandit.Properties.Resources.diamond_100x125;
                    break;
            }


            // check value of reel 2 with a switch statement and set appropriate image
             switch (reel2value) 
            {
                case 1:
                    reel2.Image = OneArmedBandit.Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel2.Image = OneArmedBandit.Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel2.Image = OneArmedBandit.Properties.Resources.diamond_100x125;
                    break;
            }

            // check value of reel 3 with a switch statement and set appropriate image
             switch (reel3value) 
            {
                case 1:
                    reel3.Image = OneArmedBandit.Properties.Resources._7_100x125;
                    break;
                case 2:
                    reel3.Image = OneArmedBandit.Properties.Resources.cherry_100x125;
                    break;
                case 3:
                    reel3.Image = OneArmedBandit.Properties.Resources.diamond_100x125;
                    break;
            }

            if (reel1value == reel2value && reel1value == reel3value)
            {
                outputLabel.Text = "Winner!";
                score  += 3;
                scoreDisplay.Text = $"{score}";
            }
            else
            {
                outputLabel.Text = "Play Again";
                score--;
                scoreDisplay.Text = $"{score}";
            }

            if (score == 0)
            {
                outputLabel.Text = "Lose :(";
                scoreDisplay.Text = "0";
                spinButton.Enabled = false;
            } 
            

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         


            // if score has reached 0 display "lose" message and set button enabled property to false


            // display updated score

        }
    }
}
