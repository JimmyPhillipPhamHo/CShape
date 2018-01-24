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

        public GuessingGame()
        {
            InitializeComponent();
            Random ranNumber = new Random();
            randomNumber = ranNumber.Next(1, 5);
        }


        private void btnGuess_Click(object sender, EventArgs e)
        {
            GuessNum = Convert.ToInt32(txtGuessNum.Text);

            if (GuessNum != randomNumber)
                if (GuessNum > randomNumber)
                    lblResult.Text = "Guess is To high, Try again";
                else if (GuessNum < randomNumber)
                    lblResult.Text = "Guess is To high, Try again";
            else
            lblResult.Text = "Guess is Corret, you WIN";
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random ranNumber = new Random();
            randomNumber = ranNumber.Next(1, 5);

            txtGuessNum.Clear();
            lblResult.Text = String.Empty;
        }

    
    }
}
