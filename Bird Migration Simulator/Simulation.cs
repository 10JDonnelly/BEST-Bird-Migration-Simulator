using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_Migration_Simulator
{
    public partial class Simulation : Form
    {
        public Simulation()
        {
            InitializeComponent();
            label26.Hide();
            label25.Hide();
            label27.Hide();
            label28.Hide();
        }

        int StartingX = 1;
        int StartingY = 11;
        int EndingX = 2;
        int EndingY = 12;




        private void button2_Click(object sender, EventArgs e)
        {

            string text = textBox3.Text;
            switch (text)
            {
                case "A":
                    label25.Hide();
                    StartingY = 11;
                    break;
                case "2":
                    label25.Hide();
                    StartingY = 12;
                    break;
                case "3":
                    label25.Hide();
                    StartingY = 13;
                    break;
                case "4":
                    label25.Hide();
                    StartingY = 14;
                    break;
                case "5":
                    label25.Hide();
                    StartingY = 15;
                    break;
                case "6":
                    label25.Hide();
                    StartingY = 16;
                    break;
                case "7":
                    label25.Hide();
                    StartingY = 17;
                    break;
                case "8":
                    label25.Hide();
                    StartingY = 18;
                    break;
                case "9":
                    label25.Hide();
                    StartingY = 19;
                    break;
                case "10":
                    label25.Hide();
                    StartingY = 20;
                    break;
                default:
                    label25.Show();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            switch (text)
            {
                case "1":
                    label26.Hide();
                    StartingX = 1;
                    break;
                case "2":
                    label26.Hide();
                    StartingX = 2;
                    break;
                case "3":
                    label26.Hide();
                    StartingX = 3;
                    break;
                case "4":
                    label26.Hide();
                    StartingX = 4;
                    break;
                case "5":
                    label26.Hide();
                    StartingX = 5;
                    break;
                case "6":
                    label26.Hide();
                    StartingX = 6;
                    break;
                case "7":
                    label26.Hide();
                    StartingX = 7;
                    break;
                case "8":
                    label26.Hide();
                    StartingX = 8;
                    break;
                case "9":
                    label26.Hide();
                    StartingX = 9;
                    break;
                case "10":
                    label26.Hide();
                    StartingX = 10;
                    break;
                default:
                    label26.Show();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            switch (text)
            {
                case "1":
                    label26.Hide();
                    EndingX = 1;
                    break;
                case "2":
                    label26.Hide();
                    EndingX = 2;
                    break;
                case "3":
                    label26.Hide();
                    EndingX = 3;
                    break;
                case "4":
                    label26.Hide();
                    EndingX = 4;
                    break;
                case "5":
                    label26.Hide();
                    EndingX = 5;
                    break;
                case "6":
                    label26.Hide();
                    EndingX = 6;
                    break;
                case "7":
                    label26.Hide();
                    EndingX = 7;
                    break;
                case "8":
                    label26.Hide();
                    EndingX = 8;
                    break;
                case "9":
                    label26.Hide();
                    EndingX = 9;
                    break;
                case "10":
                    label26.Hide();
                    EndingX = 10;
                    break;
                default:
                    label28.Show();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            switch (text)
            {
                case "A":
                    label25.Hide();
                    EndingY = 11;
                    break;
                case "B":
                    label25.Hide();
                    EndingY = 12;
                    break;
                case "C":
                    label25.Hide();
                    EndingY = 13;
                    break;
                case "D":
                    label25.Hide();
                    EndingY = 14;
                    break;
                case "E":
                    label25.Hide();
                    EndingY = 15;
                    break;
                case "F":
                    label25.Hide();
                    EndingY = 16;
                    break;
                case "G":
                    label25.Hide();
                    EndingY = 17;
                    break;
                case "H":
                    label25.Hide();
                    EndingY = 18;
                    break;
                case "I":
                    label25.Hide();
                    EndingY = 19;
                    break;
                case "J":
                    label25.Hide();
                    EndingY = 20;
                    break;
                default:
                    label27.Show();
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int TraversalX = StartingX;
            int TraversalY = StartingY;
            //Gives me 2 values that can act as an intermediary between the start and end points
            string finalPathTaken = "";
            //This will be what I use to display the final path taken by the simulator
            string letterOfY = "";
            while (TraversalX != EndingX || TraversalY != EndingY)
            {
                if (TraversalX > EndingX)
                {
                    TraversalX = TraversalX - 1;
                }
                else if (TraversalX < EndingX)
                {
                    TraversalX = TraversalX + 1;
                }
                if (TraversalY > EndingY)
                {
                    TraversalY = TraversalY - 1;
                }
                else if (TraversalY < EndingY)
                {
                    TraversalY = TraversalY + 1;
                }

                switch (TraversalY)
                {
                    case 11:
                        letterOfY = "A";
                        break;
                    case 12:
                        letterOfY = "B";
                        break;
                    case 13:
                        letterOfY = "C";
                        break;
                    case 14:
                        letterOfY = "D";
                        break;
                    case 15:
                        letterOfY = "E";
                        break;
                    case 16:
                        letterOfY = "F";
                        break;
                    case 17:
                        letterOfY = "G";
                        break;
                    case 18:
                        letterOfY = "H";
                        break;
                    case 19:
                        letterOfY = "I";
                        break;
                    case 20:
                        letterOfY = "J";
                        break;
                }

                finalPathTaken = String.Concat(finalPathTaken, TraversalX, letterOfY, ", ");
            }
            label29.Text = finalPathTaken;
        }
    }
}    
