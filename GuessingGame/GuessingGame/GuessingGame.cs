using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GuessingGame : Form
    {
        int randomNumber;
        int GuessNum;
        int highGuess;
        int lowGuess;

        public GuessingGame()
        {
            InitializeComponent();
            Random ranNumber = new Random();
            randomNumber = ranNumber.Next(1, 10);
        }


        private void btnGuess_Click(object sender, EventArgs e)
        {
            GuessNum = Convert.ToInt32(txtGuessNum.Text);

        
           


            if (GuessNum != randomNumber)
            {
                 if (highGuess != 0 && GuessNum >= highGuess || lowGuess != 0 && GuessNum >= lowGuess)
                {
                    if (GuessNum >= highGuess || GuessNum <= lowGuess)
                    { 
                        if (GuessNum == highGuess || GuessNum == lowGuess)
                        {
                            lblResult.Text = "You guess the same number from your previous guess, you dumb head";
                        }
                        else if (GuessNum >= highGuess || GuessNum <= lowGuess)
                        {
                            lblResult.Text = "You guess higher or lower than your previous guess, you dumb head";
                        }
                        /*else if (GuessNum <= lowGuess)
                        {
                            lblResult.Text = "You guess lower than your previous guess, you dumb head";
                        }*/
                    }                 
                }

                else if (GuessNum > randomNumber)
                {
                    lblResult.Text = "Your guess is To high, Try again";
                    highGuess = GuessNum;
                }
                else if (GuessNum < randomNumber)
                {
                    lblResult.Text = "Your guess is To low, Try again";
                    lowGuess = GuessNum;
                }
    
            }
              else
                {
                    lblResult.Text = "Your guess is Corret, you Win";
                }
              
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random ranNumber = new Random();
            randomNumber = ranNumber.Next(1, 10);

            txtGuessNum.Clear();
            lblResult.Text = String.Empty;
        }

    
    }
}
