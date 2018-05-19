using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacetrackSimulator
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            if (MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            bool canBet = false;
            if (Cash >= BetAmount)
            {
                canBet = true;
                MyBet = new Bet() { Amount = BetAmount, Bettor = this, Dog = DogToWin };
            }
            return canBet;
        }

        public void Collect(int Winner)
        {
            int collectedAmount = 0;
            collectedAmount = MyBet.PayOut(Winner);
            Cash += collectedAmount;
            ClearBet();
            UpdateLabels();
        }

    }
}
