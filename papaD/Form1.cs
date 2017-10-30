using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace papaD
{
    public partial class Form1 : Form
    {
        int support = 30;
        int military = 70;
        int purgelvl = 0;

        Random newrand = new Random();

        public Form1()
        {
            InitializeComponent();
            initializer();
        }

        private void initializer()
        {
            Graphics start = this.CreateGraphics();
            Font startF = new Font("Ariel", 10);
            SolidBrush startB = new SolidBrush(Color.Yellow);

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "My MP3 file.mp3";
            wplayer.controls.play();
            Thread.Sleep(1000);

            start.DrawString("Click anywhere to start", startF, startB, 75, 75);
        }
        private void coupEnd()
        {
            storyline.Text = "In a unseen turn of events Trotsky has led a violent coup. " +
                "You were killed when some of your own guards gun you and other loyalists down.";
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.M)       //red button press
            {
                if (purgelvl == 0) purgelvl = 1;
                else if (purgelvl == 1) purgelvl = 3;
                else if (purgelvl == 2) purgelvl = 5;
                else if (purgelvl == 3) purgelvl = 7;
                else if (purgelvl == 4) purgelvl = 9;
                else if (purgelvl == 5) purgelvl = 11;
                else if (purgelvl == 6) purgelvl = 13;
                else if (purgelvl == 7) purgelvl = 15;
                else if (purgelvl == 8) purgelvl = 17;
                else if (purgelvl == 9) purgelvl = 19;
                else if (purgelvl == 10) purgelvl = 21;
                else if (purgelvl == 11) purgelvl = 23;
                else if (purgelvl == 12) purgelvl = 25;
                else if (purgelvl == 13) purgelvl = 27;
                else if (purgelvl == 14) purgelvl = 29;
                else if (purgelvl == 15) purgelvl = 31;
            }
            //All the B options should be even numbers(yes option) and M options odd numbers(no option)
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (purgelvl == 0) purgelvl = 2;
                else if (purgelvl == 1) purgelvl = 4;
                else if (purgelvl == 2) purgelvl = 6;
                else if (purgelvl == 3) purgelvl = 8;
                else if (purgelvl == 2) purgelvl = 10;
                else if (purgelvl == 2) purgelvl = 12;
                else if (purgelvl == 2) purgelvl = 14;
            }

            switch (purgelvl)
            {
                case 0: //original decision
                    storyline.Text = "The revolution is won! But sadly Vladimir Lenin is dead." +
                        " After cheating that fool Trotsky out of power, I must now lead our glorious union.";
                    Thread.Sleep(4000);
                    storyline.Text = "I have long disliked Lenin's idea of countries without borders" +
                        " and wonder whether the USSR should abandon the ideas of the so-called 'world revolution.' " +
                                     "Should I implement my theory of 'socialism in one country?;'";
                    bOption.Text = "B: The international ideals of Communism must be preserved.";
                    mOption.Text = "M: The USSR must look inward to survive.";
                    break;
                case 1: //NEP Internationalism
                    support = support + 2;
                    storyline.Text = "The Internationale unites the humna race!.";
                    bOption.Text = "";
                    mOption.Text = "";
                    Thread.Sleep(4000);
                    storyline.Text = "Trotsky poses a big threat to my legimacy, " +
                           "He knows that he was supposed to be the ruler of the Soviet Union," +
                           " with him still in the army he could overthrow me at any point.";
                    bOption.Text = "Trotsky must be removed from the army to protect my rule.";
                    mOption.Text = "It would be against our ideals to bring the union further down the" +
                        " path of autocracy.";
                    break;
                case 2: //GULAG Stalinism
                    support = support - 2;
                    storyline.Text = "My two allies, Zinoviev and Kamenev have broken broken up our political" +
                        " triumvirate in the wake of my recent decision to abandon Lenin's ideals. " +
                        "They and many others now stand with the traitor Trotsky. I should think about" +
                        "removing him from a number of offices to reduce his influence over the Politburo.";
                    bOption.Text = "Remove Trotsky from the Politburo but let him keep his position in the Red Army.";
                    mOption.Text = "Remove Trotsky from both the Red Army and the Politburo. We can't risk him " +
                        "organizing a coup.";
                    break;
                case 3: //NEP Trotsky removed from RA
                    int chance;
                    chance = newrand.Next(1, 11);

                    if(chance > 2)
                    {
                        storyline.Text = "I have decided to let Trotsky remain in command of the Red Army " +
                            "in the hopes he will not overthrow me.";
                    }
                    else
                    {
                        storyline.Text = "My decision to let Trotsky remain in command of the Red Army " +
                            "ended in betrayal. He overthrew me and became leader of the USSR.";  
                        Thread.Sleep(2000);
                        coupEnd();
                    }
                    break;
                case 4:
                    storyline.Text = "";
                    break;
                case 5:
                    storyline.Text = "";
                    break;
                case 6:
                    storyline.Text = "";
                    break;
                case 7:
                    storyline.Text = "";
                    break;
                case 8:
                    storyline.Text = "";
                    break;
                case 9:
                    storyline.Text = "";
                    break;
                case 10:
                    storyline.Text = "";
                    break;
                case 11:
                    storyline.Text = "";
                    break;
                case 12:
                    storyline.Text = "";
                    break;
                case 13:
                    storyline.Text = "";
                    break;
                case 14:
                    storyline.Text = "";
                    break;
                case 15:
                    storyline.Text = "";
                    break;
                case 16:
                    storyline.Text = "";
                    break;
                case 17:
                    storyline.Text = "";
                    break;
                case 18:
                    storyline.Text = "";
                    break;
                case 19:
                    storyline.Text = "";
                    break;
                case 20:
                    storyline.Text = "";
                    break;
                case 21:
                    storyline.Text = "";
                    break;
                case 22:
                    storyline.Text = "";
                    break;
                case 23:
                    storyline.Text = "";
                    break;
                case 24:
                    storyline.Text = "";
                    break;
                case 25:
                    storyline.Text = "";
                    break;
            }
        }

    }
}
