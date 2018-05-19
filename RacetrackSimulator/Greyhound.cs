using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        #region Methods
        public bool Run()
        {
            bool winningFlag = false;
            Location = Randomizer.Next(1, 4);
            MyPictureBox.Left += StartingPosition + Location;
            if (MyPictureBox.Left >= RaceTrackLength)
            {
                winningFlag = true;
            }
            return winningFlag;
        }


        public void TakeStartingPosition()
        {
            MyPictureBox.Left = StartingPosition;
            Location = 0;
        }
        #endregion
    }
}
