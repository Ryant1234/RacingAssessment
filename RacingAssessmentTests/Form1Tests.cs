using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingAssessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAssessment.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        // Each punter needs a radio button
        RadioButton rbPunter0 = new RadioButton();
        RadioButton rbPunter1 = new RadioButton();
        RadioButton rbPunter2 = new RadioButton();
        // And labels
        Label lblJonesy = new Label();
        Label lblJohnson = new Label();
        Label lblBob = new Label();

        private Form1 form1 = new Form1();



        [TestMethod()]
        public void AddThePuntersTest()
        {
           

            // Create a new List of Punters and add Jonesy Johnson and Bob to it 
            var punters = new List<Punter>();
        punters.Add(new Jonesy("Jonesy", null,  50, rbPunter0, lblJonesy));
            punters.Add(new Johnson("Johnson", null, 50, rbPunter1, lblJohnson));
            punters.Add(new Bob("Bob", null, 50, rbPunter2, lblBob));

            // expected is the count of the list we are expecting and actual is the count of the list 
            var expected = 3;
            var actual = punters.Count;

            Assert.AreEqual(expected, actual);


        }




    }
}