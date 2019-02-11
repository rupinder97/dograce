using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dograce
{
  abstract  class Punter
    {
        public string Name { get; set; }
        public int Cash { get; set; }
        public RadioButton MyRadioButton { get; set; }
        public Label MyLabel { get; set; }
        public int Amount { get; set; }
        private Bet MyBet = new Bet();
     //   private int A;
        public void UpdateLabels()
        {
            MyBet.Bettor = this;
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }
        

        public bool PlaceBet(int Amount, int Dog)
        {

            if (Cash >= Amount)
            {

                MyBet.Amount = Amount;
                Cash -= Amount;
                MyBet.Dog = Dog;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int WinningDog)
        {
            MyBet.PayOut(WinningDog);
        }

        public void  ResetBet()
        {
               
                Cash += MyBet.Amount;
            MyBet.Amount = 0;
            MessageBox.Show(Cash + " df");  
            
        }
        public int BAmount()
        {
           return( MyBet.Amount);

        }

    }
}
