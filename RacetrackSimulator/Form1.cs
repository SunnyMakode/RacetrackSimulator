using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public partial class Form1 : Form
    {
        Random MyRandomizer;
        Greyhound[] greyhoundArray = new Greyhound[4];
        Guy[] guy = new Guy[3];
        public Form1()
        {
            InitializeComponent();
            MyRandomizer = new Random();
            greyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = raceTrackPictureBox,
                StartingPosition = raceTrackPictureBox.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureBox1.Width,
                Randomizer = MyRandomizer
            };
            greyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = raceTrackPictureBox,
                StartingPosition = raceTrackPictureBox.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureBox2.Width,
                Randomizer = MyRandomizer
            };
            greyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = raceTrackPictureBox,
                StartingPosition = raceTrackPictureBox.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureBox3.Width,
                Randomizer = MyRandomizer
            };
            greyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = raceTrackPictureBox,
                StartingPosition = raceTrackPictureBox.Left,
                RaceTrackLength = raceTrackPictureBox.Width - pictureBox4.Width,
                Randomizer = MyRandomizer
            };

            guy[0] = new Guy()
            {
                Name = "Joe",
                MyLabel = joeBetLabel,
                MyRadioButton = joeRadioButton,
                Cash = 50,
                //MyBet = new Bet()
                //{
                //    Amount = Convert.ToInt16(numericUpDown1.Value),
                //    Bettor = this.guy[0],
                //    Dog = Convert.ToInt16(numericUpDown2.Value)
                //}
            };

            guy[1] = new Guy()
            {
                Name = "Bob",
                MyLabel = bobBetLabel,
                MyRadioButton = bobRadioButton,
                Cash = 75,
                //MyBet = new Bet()
                //{
                //    Amount = Convert.ToInt16(numericUpDown1.Value),
                //    Bettor = this.guy[1],
                //    Dog = Convert.ToInt16(numericUpDown2.Value) }
            };

            guy[2] = new Guy()
            {
                Name = "Al",
                MyLabel = alBetLabel,
                MyRadioButton = alRadioButton,
                Cash = 45,
                //MyBet = new Bet()
                //{
                //    Amount = Convert.ToInt16(numericUpDown1.Value),
                //    Bettor = this.guy[2],
                //    Dog = Convert.ToInt16(numericUpDown2.Value) }
                
            };

        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = guy[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = guy[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = guy[2].Name;
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            guy[1].PlaceBet(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < greyhoundArray.Length; i++)
            {
                if (greyhoundArray[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Dog: " + i+1 + " wins", "Winner" );                   
                }
                
            }
        }
    }
}
