using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dograce
{
    public partial class Form1 : Form
    {
        private Greyhound[] GreyHound = new Greyhound[4];
        private Punter[] Punter = new Punter[3];
    ///    private Joe p1;
      //  private Bob p2; //= new Joe[1];
       // private AI p3; // = new Joe[1];

        private Random random = new Random();
        public int PunterID { get; set; }
        public int Max { get; set; }

        public Form1()
        {
            InitializeComponent();
            Start();
        }

        public void Start()
        {
            int Start = racer1.Left;
            int Racetrack = rTrack.Width - 70;//racer1.Right;


            GreyHound[0] = new Greyhound() { MypictureBox = racer1, RacetrackLength = Racetrack, StartingPostion = Start };
            GreyHound[1] = new Greyhound() { MypictureBox = racer2, RacetrackLength = Racetrack, StartingPostion = Start };
            GreyHound[2] = new Greyhound() { MypictureBox = racer3, RacetrackLength = Racetrack, StartingPostion = Start };
            GreyHound[3] = new Greyhound() { MypictureBox = racer4, RacetrackLength = Racetrack, StartingPostion = Start };

            Punter[0] = new Joe() { Cash = 50, MyLabel = Joebet, MyRadioButton = rbJoe, Name = "Joe" };
            Punter[1] = new Bob() { Cash = 75, MyLabel = Bobbet, MyRadioButton = rbBob, Name = "Bob" };
            Punter[2] = new AI() { Cash = 45, MyLabel = Aibet, MyRadioButton = rbAl, Name = "Al" };
        }

        public void LetDogsRun()
        {
            while (true)
            {
                for (int i = 0; i < GreyHound.Length; i++)
                {
                    Thread.Sleep(6);
                    GreyHound[random.Next(0, 4)].Run();
                    if (GreyHound[i].Run())
                    {
                        DeclareWinner(i + 1); //array starts with 0
                        return;
                    }
                }
            }
        }

        public void DeclareWinner(int Winner)
        {
            MessageBox.Show("Dog #" + Winner + " is the Winner!");
            for (int i = 0; i < 3; i++)
            {
                Punter[i].Collect(Winner);
                Punter[i].UpdateLabels();
                ResetDogsPosition();
                ResetBets();
            }
        }

        public void ResetDogsPosition()
        {
            for (int i = 0; i < 4; i++)
            {
                GreyHound[i].TakeStartingPosition();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LetDogsRun();
            for (int i = 0; i < 3; i++)
            {
                if (Punter[i].Cash == 0)
                {
                    if (i == 0)
                    {
                        rbJoe.Enabled = false;
                        Joebet.Text = "Busted";
                    }
                    if (i == 1)
                    {
                        rbBob.Enabled = false;
                        Bobbet.Text = "Busted";
                    }
                    if (i == 2)
                    {
                        rbAl.Enabled = false;
                        Aibet.Text = "Busted";
                    }
                }
            }
            if (Joebet.Text == "Busted" && Bobbet.Text == "Busted" && Aibet.Text == "Busted")
            {
                MessageBox.Show(" Game is Draw !!!");
                but_Res.Text = "Game over suckers";
                but_Res.Enabled = false;
                but_Rac.Enabled = false;
            }
           else if (Joebet.Text == "Busted" && Bobbet.Text == "Busted" )
            {
                MessageBox.Show(" Game Won by AI ");
                but_Res.Enabled = false;
                but_Rac.Enabled = false;
            }
            else if (Joebet.Text == "Busted" && Aibet.Text == "Busted")
            {
                MessageBox.Show(" Game Won by  Bob");
                but_Res.Enabled = false;
                but_Rac.Enabled = false;
            }

            else if ( Bobbet.Text == "Busted" && Aibet.Text == "Busted")
            {
                MessageBox.Show(" Game Won by Joe");
                 but_Res.Enabled = false;
                but_Rac.Enabled = false;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ResetBets()
        {
            Joebet.Text = "Joe hasn't placed a bet";
            Bobbet.Text = "Bob hasn't placed a bet";
            Aibet.Text = "Al hasn't placed a bet";
            label4.Text = "Max Bet";
        }

        private void but_Res_Click(object sender, EventArgs e)
        {
          
        // '  MessageBox.Show ("sdf");
            for (int i = 0;i< 3;i++)
            {
                Punter[i].ResetBet (); 
                Punter[i].Amount = 0;
               Punter[i].UpdateLabels();
            }
            ResetBets();
          
        }

        private void but_Bet_Click(object sender, EventArgs e)
        {
            int amount = (int)nUD_bet.Value;
            int dog = (int)nUD_dog.Value;
            Punter [PunterID].PlaceBet(amount, dog);
            Punter [PunterID].UpdateLabels();
            // find out maximum betting
            Max = 0;
            for (int i = 0; i < 3; i++)
            {
                if (Max < Punter[i].BAmount())
                    Max = Punter[i].BAmount();
            }
            label4.Text = " Maximum Betting is $ " + Max;
        }

        private void rbJoe_CheckedChanged(object sender, EventArgs e)
        {
            PunterID = 0;
        }

        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            PunterID = 1;
        }

        private void rbAl_CheckedChanged(object sender, EventArgs e)
        {
            PunterID = 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
