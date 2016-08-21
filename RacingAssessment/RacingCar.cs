using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAssessment
{
    public class RacingCar
    {

      
        public int StartingPosition;
 
        public int RaceTrackLength;
        // The picturebox for the RacingCar object
        public PictureBox MyPictureBox;

        public int Location = 0;
        public Random random;
        
        
        // When instantiating a new racingcar you need to provide a picturebox, the racetrack length and starting position
        public RacingCar(PictureBox pb, int raceTrackLength, int startingPosition)
        {
            this.MyPictureBox = pb;
            this.RaceTrackLength = raceTrackLength;
            this.StartingPosition = startingPosition;
        }

        /// <summary>
        /// The method for the car to "race"
        /// </summary>
        public bool Race()
        {

            random = new Random();
            Thread.Sleep(5);
            // Sets the point to the current picturebox location
            Point p = MyPictureBox.Location;

            // Set a random distance for the car to move
            int distance = random.Next(1, 10);


            MoveMyPictureBox(distance);
            
            Location += distance;


      // If the car is at the finish line return true 
            if (Location >= (RaceTrackLength - StartingPosition))
            {
                return true;
            }
            return false;
        }




        /// <summary>
        /// Moves the picturebox..
        /// </summary>
        /// <param name="distance"></param>
        public void MoveMyPictureBox(int distance)
        {
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;




        }

        /// <summary>
        ///  Reset my location to the starting position
        /// </summary>
        public void TakeStartingPosition()
        {
            MoveMyPictureBox(-Location);
            Location = 0;

        }
    }
}



