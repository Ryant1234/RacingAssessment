using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingAssessment
{
   public class Bet
   {
       public int Amount; // The amount of cash that was bet
       public int CarNumber;// The number of the car being bet on
        public Punter Bettor; // The gambler who placed the bet



        // When the Bet class is declared you must provide Amount, CarNumber and a Punter(Bettor)
        public Bet(int Amount, int CarNumber, Punter Bettor)
        {
            this.Amount = Amount;
            this.CarNumber = CarNumber;
            this.Bettor = Bettor;
        }




        public string GetDescription()
        {
            string description = "";
            if (Amount > 0)
            {
                description = String.Format("{0} bets {1} on car #{2}",
                    Bettor.Name, Amount, CarNumber);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets",
                    Bettor.Name);
            }
            return description;
        }

        public int Payout(int Winner)
       {

           if (CarNumber == Winner)
           {
               return Amount;
           }
           else
           {
               return -Amount;
           }
                    }


    

    }



        }
    

