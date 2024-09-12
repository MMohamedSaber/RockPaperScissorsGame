using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class PlayingForm : Form
    {

        Random random = new Random();
        private string[] computerChoise = { "R", "P", "S" };


        int Rounds=3;
        public PlayingForm( int rounds)
        {
            InitializeComponent();
            Rounds = rounds;
        }

        private void btnPlayerScore_Click(object sender, EventArgs e)
        {

        }



        // isiwinner

        bool isIwinner(PictureBox pbme,PictureBox pbComputer)
        {
            if (pbme.Tag.ToString() == "R" && pbComputer.Tag.ToString() == "P")
            {
                return true;
            }
            if (pbme.Tag.ToString() == "R" && pbComputer.Tag.ToString() == "S")
            {
                return true;
            }
            else if (pbme.Tag.ToString() == "P" && pbComputer.Tag.ToString() == "R")
            {
                return true;
            }

            else if (pbme.Tag.ToString() == "S" && pbComputer.Tag.ToString() == "P")
            {
                return true;
            }


            return false;

        }

        int PlayerScoreCounter;
        int ComputerScoreCounter;
        void   CheckWinner(PictureBox pbme ,PictureBox pbComputer)
        {

            if (pbme.Tag == pbComputer.Tag)
            {
                lblChosingOption.Text = "Drow";
                return;
            }


            if (isIwinner( pbme,  pbComputer))
            {
                PlayerScoreCounter++;
                btnPlayerScore.Text = PlayerScoreCounter.ToString();
                lblChosingOption.Text = "You are Winner";

                return;
            }
         
            lblChosingOption.Text = "The Computer is  Winner";

            ComputerScoreCounter++;
            btnCoputerScore.Text = ComputerScoreCounter.ToString();
        }



        void PlayGame(PictureBox MyPicture)
        {


            // CheckChoise for mine
            if (MyPicture.Tag == "R")
            {
                MyPicture.Image = Properties.Resources.Rock;
            }
            else if (MyPicture.Tag == "P")
            {
                MyPicture.Image = Properties.Resources.Paper;
            }
            else
            {
                MyPicture.Image = Properties.Resources.Scissors;
            }




            //check choise for Computer

            pbComputer.Tag = computerChoise[random.Next(computerChoise.Length)];

            if (pbComputer.Tag == "R")
            {
                pbComputer.Image = Properties.Resources.Rock;
            }
            else if (pbComputer.Tag == "P")
            {
                pbComputer.Image = Properties.Resources.Paper;
            }
            else
            {
                pbComputer.Image = Properties.Resources.Scissors;
            }




            //check winner

            CheckWinner(MyPicture, pbComputer);
            
            


        }
        private void btnRock_Click(object sender, EventArgs e)
        {

            pbme.Tag= "R";
            Form1 frm = new Form1();


           
                PlayGame(pbme);
            
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            pbme.Tag = "P";
            PlayGame(pbme);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            pbme.Tag = "S";
            PlayGame(pbme);
        }
    }
}
