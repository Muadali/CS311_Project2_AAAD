using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_Project2_AAAD
{
    public partial class FrmCraps : Form
    {
        private enum GameStatus
        {
            WIN, LOSE, SETPOINT, TRYPOINT, INITIAL 
        }
        private GameStatus status= GameStatus.INITIAL;

        private float balance = 100.0f;
        private int pointValue;
        private int numberOfRolls;
        private int totalOutcome;
        private int bankAmount;
        private int betAmount;
        private float bettingOutcome;


        public FrmCraps()
        {
            InitializeComponent();
        }

        private void FrmCraps_Load(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {

            calculate_Score ();
           

        }//end btnRoll click

        private void calculate_Score()
        {
          // bankAmount = float.Parse(lblBalance.Text);
            if (numberOfRolls == 0 && bankAmount> betAmount)
            {
                roll();
                switch (totalOutcome)
                {
                    
                    case 2:
                        lblOutcome.Text = "you lose";
                        //need to minus txtbet with lblbalance- must clear pointvalue and 
                        bettingOutcome = bankAmount - betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        break;

                    case 3:
                        lblOutcome.Text = "you lose";
                        bettingOutcome = bankAmount - betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        //need to minus txtbet with lblbalance
                        break;
                    case 4:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;

                        break;
                    case 5:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;

                        break;
                    case 6:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;
                        break;
                    case 7:
                        lblOutcome.Text = "You Win! ";
                        bettingOutcome = bankAmount + betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        break;
                    case 8:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;
                        break;
                    case 9:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;
                        break;
                    case 10:
                        lblOutcome.Text = "Point is " + totalOutcome;
                        numberOfRolls++;
                        pointValue = totalOutcome;
                        break;
                    case 11:
                        lblOutcome.Text = "You Win!";

                        bettingOutcome = bankAmount + betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        break;

                    case 12:
                        lblOutcome.Text = "you lose";
                        bettingOutcome = bankAmount + betAmount;
                        lblBalance.Text = bettingOutcome.ToString("C");
                        break;

                }//end swtich statement

                if (totalOutcome == pointValue)
                {
                    lblOutcome.Text = "You Win!";
                    bettingOutcome = bankAmount + betAmount;
                    lblBalance.Text = bettingOutcome.ToString("C");
                }//end if statement
                else if (totalOutcome == 7)
                {
                    lblOutcome.Text = "You lose!";
                    bettingOutcome = bankAmount - betAmount;
                    lblBalance.Text = bettingOutcome.ToString("C");
                }//end else statement

            }//end if statement
            else
            {
                lblBalance.Text = bettingOutcome.ToString("Insufficient funds");
            }//end calculate score

        }

        private void txtBet_TextChanged(object sender, EventArgs e)
        {
            betAmount = (int) float.Parse(txtBet.Text);
        }//end txtBet_TextChanged

        private void lblDie1_Click(object sender, EventArgs e)
        {

        }

        private void lblDie2_Click(object sender, EventArgs e)
        {

        }



        //Random random = new Random();
        //dv1 = random.Next(1, 6);
        //dv2 = random.Next(1, 6);
        //sum = dv1 + dv2;


    //}
    public void roll()
        {
            Random random = new Random();
            int Die1 = random.Next(1, 7);
            int Die2 = random.Next(1, 7);

            lblDie1.Text = lblDie1.ToString();
            lblDie2.Text = lblDie2.ToString();
            totalOutcome = Die1 + Die2;
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {
            bankAmount = (int) float.Parse(lblBalance.Text);

        }
    }//end class
}//end nameSpace
