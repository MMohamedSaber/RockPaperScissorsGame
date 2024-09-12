using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {


        public int Rounds=0;

        public Form1()
        {
            InitializeComponent();

            
            int.TryParse(txtBox.Text, out Rounds);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayingForm frm =new PlayingForm(Rounds);

            frm.Show();



        }

        public void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
