using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAssessment
{
    public abstract class Punter
    {

        //amount;
        public string Name;// The Gambler's Name
        public Bet MyBet; // An instance of Bet() that has his bet
        public int Cash;// How much cash he has 

        // The last two fields are the Gambler's GUI controls on the form
        public RadioButton MyRadioButton; // MyRadioButton
        public Label MyLabel; // Punter has a label to hold data




        // When you instantiate a Punter you can provide values the following parameters
        //public Punter(string Name, Bet MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel)
        //{
        //    this.Name = Name;
        //    this.MyBet = MyBet;
        //    this.Cash = Cash;
        //    this.MyRadioButton = MyRadioButton;
        //    this.MyLabel = MyLabel;
        //}

        public void UpdateLabels()
        {
            if (MyBet == null)
            {
                MyLabel.Text = Name +  " hasn't placed any bets";
                 //   String.Format("{0} hasn't placed any bets", Name);
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }


      public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int RaceCarNumber)
        {
            if (Amount <= Cash)
            {
                MyBet = new Bet(Amount, RaceCarNumber, this);
                return true;
            }
            return false;
        }




        public void Collect(int Winner)
        {
            Cash += MyBet.Payout(Winner);
        }
    }
}
