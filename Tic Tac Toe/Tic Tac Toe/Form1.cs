using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true; // true - X turn , False = Y turn.
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "by Joe","Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkforwinner();
        }
        private void checkforwinner()
        {
            bool there_is_a_winner = false;
            // horizontal check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
             else if ((b1.Text == B2.Text) && (B2.Text == B3.Text) && (!b1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;
            // verticl checks
            if ((A1.Text == b1.Text) && (b1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!C3.Enabled))
                there_is_a_winner = true;

            //Diagonal 
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = "O";
                    Ocount.Text = (Int32.Parse(Ocount.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    Xcount.Text = (Int32.Parse(Xcount.Text) + 1).ToString();
                }
                    MessageBox.Show(winner + " Wins!");
                
                    }
            else
            {
                if (turn_count == 9)
                {
                    Dcount.Text = (Int32.Parse(Dcount.Text) + 1).ToString();

                    MessageBox.Show("Its a draw");
                }
            }
        }// end of check winner
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }

                catch { }
            }
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Enabled)
            { 
            if (turn)
             b.Text = "X";
                else
                b.Text = "O";
            }
             
        
        }

        private void Button_Leave(object sender, EventArgs e)
        {
                Button b = (Button)sender;
                if (b.Enabled)
                {
                    b.Text = "";
                }
            }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocount.Text = "0";
            Xcount.Text = "0";
            Dcount.Text = "0";
        }
    }
}
