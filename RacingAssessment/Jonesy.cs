using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAssessment
{
    public class Jonesy : Punter

    { // When instantiating a Jonesy you need to provide these
        public Jonesy(string Name, Bet MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel)

        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;
        }
    }
}
