using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAssessment
{
    public partial class Form1 : Form
    {

       public List<RacingCar> Contestants = new List<RacingCar>();
      public List<Punter> Punters = new List<Punter>();

        public Form1()
        {

            InitializeComponent();

            SetupRaceTrack();
           
        
            //  Punter[] Punters = new Punter[3];
          

    }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        // These 3 CheckedChanged events set the max bet the Punter can make based upon
        // the checkbox checked
        private void rbGambler1_CheckedChanged(object sender, EventArgs e)
        { // Jonesy checkbox
            inputBetAmount.Maximum = Punters[0].Cash;
            lblMaxBet.Text = Punters[0].Cash.ToString();
            ;
        }

        private void rbGambler2_CheckedChanged(object sender, EventArgs e)
        {// Johnson checkbox
            inputBetAmount.Maximum = Punters[1].Cash;
            lblMaxBet.Text = Punters[1].Cash.ToString();
        }

        private void rbGambler3_CheckedChanged(object sender, EventArgs e)
        { // Bob checkbox
            inputBetAmount.Maximum = Punters[2].Cash;
            lblMaxBet.Text = Punters[2].Cash.ToString();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningCar;
            btnRace.Enabled = false;
            btnPlaceBet.Enabled = false;

            //While there is no winner
            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < Contestants.Count; i++)
                {
                    if (Contestants[i].Race())
                    {
                        winningCar = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - car # " + winningCar);

                        foreach (Punter punter in Punters)
                        {
                            if (punter.MyBet != null)
                            {
                                punter.Collect(winningCar);
                                punter.MyBet = null;
                                punter.UpdateLabels();
                            }
                        }
                        foreach (RacingCar car in Contestants)
                        {
                            car.TakeStartingPosition();
                        }
                        break;
                    }
                }

            }
            btnRace.Enabled = true;
            btnPlaceBet.Enabled = true;
            CheckCash();
            rbDisabledCheck();
            //  rbDisabledCheck();


        }

        /// <summary>
        /// Sets up a brand-new race. 
        /// </summary>
        private void SetupRaceTrack()
        {
          
            Punters.Clear();
            Contestants.Clear();

            // Sets the starting position 
            int startingPosition = imgCar1.Right - imgRacingTrack.Left;
            // Sets the race track length
            int raceTrackLength = imgRacingTrack.Size.Width;

       
           // Instantiates and adds the 4 RacingCar objects to the Contestants List and gives values to their properties
            Contestants.Add(new RacingCar(imgCar1, raceTrackLength, startingPosition));
          
            Contestants.Add(new RacingCar(imgCar2, raceTrackLength, startingPosition));
        
            Contestants.Add(new RacingCar(imgCar3, raceTrackLength, startingPosition));
        
            Contestants.Add(new RacingCar(imgCar4, raceTrackLength, startingPosition));

            // Adds the Punters to the List
            AddThePunters();







            // Set the labels and radio text for the punters
            foreach (Punter p in Punters)
            {
               p.UpdateLabels();
            }
            assignRadioText();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }








     
        /// <summary>
        /// Places a bet, based upon the checked RadioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlaceBet_Click(object sender, EventArgs e)
        {
            
            int punterNumber = 0;

            if (rbPunter0.Checked)
            {
                punterNumber = 0;
            }

            if (rbPunter1.Checked)
            {
                punterNumber = 1;
            }

            if (rbPunter2.Checked)
            {
                punterNumber = 2;
            }


                // If the punters[number] cash property value is less then the amount bet
            if (Punters[punterNumber].Cash < inputBetAmount.Value)
            {
               
                MessageBox.Show("You cannot bet $" + inputBetAmount.Value + " You only have $" +
                                Punters[punterNumber].Cash);
            }
            else
            {


                // Place the bet for the Punter[number], the value from the betamount and car number boxes
                // are passed into the parameters for the PlaceBet method
                Punters[punterNumber].PlaceBet((int) inputBetAmount.Value, (int) inputCarNumber.Value);
                // Update the labels on the form for the punter
                Punters[punterNumber].UpdateLabels();
                 
            }
        }

        /// <summary>
        /// Sets up the RadioButtons for the associated Punter and Enables the radio buttons if Disabled
        /// </summary>
        private void assignRadioText()
        {
            lblMaxBet.Text = null;
            rbPunter0.Enabled = true;
            rbPunter1.Enabled = true;
            rbPunter2.Enabled = true;
            rbPunter0.Text = Punters[0].Name;
            rbPunter1.Text = Punters[1].Name;
            rbPunter2.Text = Punters[2].Name;
            foreach (Punter p in Punters)
            {
                p.UpdateLabels();
            }
         
        }



        /// <summary>
        /// This checks all of the Punters cash and updates their labels, if they have no more money
        /// Their Radiobutton is disabled and their label text is changed
        /// </summary>
        private void CheckCash()
        {
            foreach (Punter p in Punters)
            {
                p.UpdateLabels();
               
                if (p.Cash == 0)
                {
                    p.MyRadioButton.Enabled = false;
                    p.MyLabel.Text = p.Name + " is out of money!";
                }


            }
        }

        private void inputBetAmount_ValueChanged(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// The Reset button sets up the contestants and Punters  and enables the Place Bet and Race buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetupRaceTrack();
            btnPlaceBet.Enabled = true;
            btnRace.Enabled = true;
            lblMaxBet.Text = Punters[0].Cash.ToString();

        }


        /// <summary>
        /// Checks to see if all the Radio Buttons are disabled, if they are
        ///The Race Button and the PlaceBet button is disabled
        /// </summary>
        private void rbDisabledCheck()
        {
            if (rbPunter0.Enabled == false & rbPunter1.Enabled == false & rbPunter2.Enabled == false)
            {
                btnPlaceBet.Enabled = false;
                btnRace.Enabled = false;
            }
        }

        /// <summary>
        /// Instantiates and adds Jonesy, Johnson and Bob and their property values to the Punters List
        /// </summary>
        public void AddThePunters()
        {
           

        Punters.Add(new Jonesy("Jonesy", null, 50, rbPunter0, lblJonesy));
            Punters.Add(new Johnson("Johnson", null, 50, rbPunter1, lblJohnson));
            Punters.Add(new Bob("Bob", null, 50, rbPunter2, lblBob));
        }
    }
}

    
