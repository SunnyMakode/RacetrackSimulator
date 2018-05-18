using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacetrackSimulator
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            string description = string.Empty;
            if (Amount > 0)
            {
                description = Bettor.Name + " bets " + Amount + " on dog number " + Dog ;
            }
            else
            {
                description = Bettor.Name + " hasn't placed any bet";
            }
            return description;
        }

        public int PayOut(int Winner)
        {
            return 0;
        }
    }
}
