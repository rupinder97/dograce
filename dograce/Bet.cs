using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dograce
{
    class Bet
    {
        public int Amount { get; set; }
        public int Dog { get; set; }
        public Joe   jBettor { get; set; }
        public Bob  bBettor { get; set; }
        public AI  aBettor { get; set; }
        public Punter Bettor { get; set; }

        public string GetDescription()

        {
            if (Amount == 0)
            {
                return Bettor.Name + " hasn't placed a bet";
            }
            else
            {
                return Bettor.Name + " bets " + Amount + " on dog " + Dog;
            }
        }

        public int PayOut(int winner)
        {
            if (Dog == winner)
            {
                int amount = Amount;
                MessageBox.Show(Bettor.Name + " takes the money!!");
                ClearBet();
                return Bettor.Cash += amount * 4;
            }
            else
            {
                ClearBet();
                return 0;

            }
        }

        public void ClearBet()
        {
            Amount = 0;
        }

    }
}
