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
            //1
            box1A.Hide();
            box1B.Hide();
            box1C.Hide();
            box1D.Hide();
            box1E.Hide();
            box1F.Hide();
            box1G.Hide();
            box1H.Hide();
            box1I.Hide();
            box1J.Hide();
            //2
            box2A.Hide();
            box2B.Hide();
            box2C.Hide();
            box2D.Hide();
            box2E.Hide();
            box2F.Hide();
            box2G.Hide();
            box2H.Hide();
            box2I.Hide();
            box2J.Hide();
            //3
            box3A.Hide();
            box3B.Hide();
            box3C.Hide();
            box3D.Hide();
            box3E.Hide();
            box3F.Hide();
            box3G.Hide();
            box3H.Hide();
            box3I.Hide();
            box3J.Hide();
            //4
            box4A.Hide();
            box4B.Hide();
            box4C.Hide();
            box4D.Hide();
            box4E.Hide();
            box4F.Hide();
            box4G.Hide();
            box4H.Hide();
            box4I.Hide();
            box4J.Hide();
            //5
            box5A.Hide();
            box5B.Hide();
            box5C.Hide();
            box5D.Hide();
            box5E.Hide();
            box5F.Hide();
            box5G.Hide();
            box5H.Hide();
            box5I.Hide();
            box5J.Hide();
            //6
            box6A.Hide();
            box6B.Hide();
            box6C.Hide();
            box6D.Hide();
            box6E.Hide();
            box6F.Hide();
            box6G.Hide();
            box6H.Hide();
            box6I.Hide();
            box6J.Hide();
            //7
            box7A.Hide();
            box7B.Hide();
            box7C.Hide();
            box7D.Hide();
            box7E.Hide();
            box7F.Hide();
            box7G.Hide();
            box7H.Hide();
            box7I.Hide();
            box7J.Hide();
            //8
            box8A.Hide();
            box8B.Hide();
            box8C.Hide();
            box8D.Hide();
            box8E.Hide();
            box8F.Hide();
            box8G.Hide();
            box8H.Hide();
            box8I.Hide();
            box8J.Hide();
            //9
            box9A.Hide();
            box9B.Hide();
            box9C.Hide();
            box9D.Hide();
            box9E.Hide();
            box9F.Hide();
            box9G.Hide();
            box9H.Hide();
            box9I.Hide();
            box9J.Hide();
            //10
            box10A.Hide();
            box10B.Hide();
            box10C.Hide();
            box10D.Hide();
            box10E.Hide();
            box10F.Hide();
            box10G.Hide();
            box10H.Hide();
            box10I.Hide();
            box10J.Hide();
        }

        int StartingX = 1;
        int StartingY = 11;
        int EndingX = 2;
        int EndingY = 12;
        string startingLettorOfY = "A";



        private void button2_Click(object sender, EventArgs e)
        {

            string text = textBox3.Text;
            startingLettorOfY = text;
            switch (text)
            {
                case "A":
                    label25.Hide();
                    StartingY = 11;
                    break;
                case "B":
                    label25.Hide();
                    StartingY = 12;
                    break;
                case "C":
                    label25.Hide();
                    StartingY = 13;
                    break;
                case "D":
                    label25.Hide();
                    StartingY = 14;
                    break;
                case "E":
                    label25.Hide();
                    StartingY = 15;
                    break;
                case "F":
                    label25.Hide();
                    StartingY = 16;
                    break;
                case "G":
                    label25.Hide();
                    StartingY = 17;
                    break;
                case "H":
                    label25.Hide();
                    StartingY = 18;
                    break;
                case "I":
                    label25.Hide();
                    StartingY = 19;
                    break;
                case "J":
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
            //1
            box1A.Hide();
            box1B.Hide();
            box1C.Hide();
            box1D.Hide();
            box1E.Hide();
            box1F.Hide();
            box1G.Hide();
            box1H.Hide();
            box1I.Hide();
            box1J.Hide();
            //2
            box2A.Hide();
            box2B.Hide();
            box2C.Hide();
            box2D.Hide();
            box2E.Hide();
            box2F.Hide();
            box2G.Hide();
            box2H.Hide();
            box2I.Hide();
            box2J.Hide();
            //3
            box3A.Hide();
            box3B.Hide();
            box3C.Hide();
            box3D.Hide();
            box3E.Hide();
            box3F.Hide();
            box3G.Hide();
            box3H.Hide();
            box3I.Hide();
            box3J.Hide();
            //4
            box4A.Hide();
            box4B.Hide();
            box4C.Hide();
            box4D.Hide();
            box4E.Hide();
            box4F.Hide();
            box4G.Hide();
            box4H.Hide();
            box4I.Hide();
            box4J.Hide();
            //5
            box5A.Hide();
            box5B.Hide();
            box5C.Hide();
            box5D.Hide();
            box5E.Hide();
            box5F.Hide();
            box5G.Hide();
            box5H.Hide();
            box5I.Hide();
            box5J.Hide();
            //6
            box6A.Hide();
            box6B.Hide();
            box6C.Hide();
            box6D.Hide();
            box6E.Hide();
            box6F.Hide();
            box6G.Hide();
            box6H.Hide();
            box6I.Hide();
            box6J.Hide();
            //7
            box7A.Hide();
            box7B.Hide();
            box7C.Hide();
            box7D.Hide();
            box7E.Hide();
            box7F.Hide();
            box7G.Hide();
            box7H.Hide();
            box7I.Hide();
            box7J.Hide();
            //8
            box8A.Hide();
            box8B.Hide();
            box8C.Hide();
            box8D.Hide();
            box8E.Hide();
            box8F.Hide();
            box8G.Hide();
            box8H.Hide();
            box8I.Hide();
            box8J.Hide();
            //9
            box9A.Hide();
            box9B.Hide();
            box9C.Hide();
            box9D.Hide();
            box9E.Hide();
            box9F.Hide();
            box9G.Hide();
            box9H.Hide();
            box9I.Hide();
            box9J.Hide();
            //10
            box10A.Hide();
            box10B.Hide();
            box10C.Hide();
            box10D.Hide();
            box10E.Hide();
            box10F.Hide();
            box10G.Hide();
            box10H.Hide();
            box10I.Hide();
            box10J.Hide();
            //By declaring these as invisible, it will reset the previous path
            int TraversalX = StartingX;
            int TraversalY = StartingY;
            //Gives me 2 values that can act as an intermediary between the start and end points
            string finalPathTaken = "";
            //This will be what I use to display the final path taken by the simulator
            string letterOfY = "";
            //Used to translate TraversalY into a letter
            string newVisibleBox;
            //Will be used to decide which box becomes visible
            newVisibleBox = string.Concat(TraversalX, startingLettorOfY);
            switch (newVisibleBox)
            {
                case "1A":
                    box1A.Show();
                    break;
                case "1B":
                    box1B.Show();
                    break;
                case "1C":
                    box1C.Show();
                    break;
                case "1D":
                    box1D.Show();
                    break;
                case "1E":
                    box1E.Show();
                    break;
                case "1F":
                    box1F.Show();
                    break;
                case "1G":
                    box1G.Show();
                    break;
                case "1H":
                    box1H.Show();
                    break;
                case "1I":
                    box1I.Show();
                    break;
                case "1J":
                    box1J.Show();
                    break;
                case "2A":
                    box2A.Show();
                    break;
                case "2B":
                    box2B.Show();
                    break;
                case "2C":
                    box2C.Show();
                    break;
                case "2D":
                    box2D.Show();
                    break;
                case "2E":
                    box2E.Show();
                    break;
                case "2F":
                    box2F.Show();
                    break;
                case "2G":
                    box2G.Show();
                    break;
                case "2H":
                    box2H.Show();
                    break;
                case "2I":
                    box2I.Show();
                    break;
                case "2J":
                    box2J.Show();
                    break;
                case "3A":
                    box3A.Show();
                    break;
                case "3B":
                    box3B.Show();
                    break;
                case "3C":
                    box3C.Show();
                    break;
                case "3D":
                    box3D.Show();
                    break;
                case "3E":
                    box3E.Show();
                    break;
                case "3F":
                    box3F.Show();
                    break;
                case "3G":
                    box3G.Show();
                    break;
                case "3H":
                    box3H.Show();
                    break;
                case "3I":
                    box3I.Show();
                    break;
                case "3J":
                    box3J.Show();
                    break;
                case "4A":
                    box4A.Show();
                    break;
                case "4B":
                    box4B.Show();
                    break;
                case "4C":
                    box4C.Show();
                    break;
                case "4D":
                    box4D.Show();
                    break;
                case "4E":
                    box4E.Show();
                    break;
                case "4F":
                    box4F.Show();
                    break;
                case "4G":
                    box4G.Show();
                    break;
                case "4H":
                    box4H.Show();
                    break;
                case "4I":
                    box4I.Show();
                    break;
                case "4J":
                    box4J.Show();
                    break;
                case "5A":
                    box5A.Show();
                    break;
                case "5B":
                    box5B.Show();
                    break;
                case "5C":
                    box5C.Show();
                    break;
                case "5D":
                    box5D.Show();
                    break;
                case "5E":
                    box5E.Show();
                    break;
                case "5F":
                    box5F.Show();
                    break;
                case "5G":
                    box5G.Show();
                    break;
                case "5H":
                    box5H.Show();
                    break;
                case "5I":
                    box5I.Show();
                    break;
                case "5J":
                    box5J.Show();
                    break;
                case "6A":
                    box6A.Show();
                    break;
                case "6B":
                    box6B.Show();
                    break;
                case "6C":
                    box6C.Show();
                    break;
                case "6D":
                    box6D.Show();
                    break;
                case "6E":
                    box6E.Show();
                    break;
                case "6F":
                    box6F.Show();
                    break;
                case "6G":
                    box6G.Show();
                    break;
                case "6H":
                    box6H.Show();
                    break;
                case "6I":
                    box6I.Show();
                    break;
                case "6J":
                    box6J.Show();
                    break;
                case "7A":
                    box7A.Show();
                    break;
                case "7B":
                    box7B.Show();
                    break;
                case "7C":
                    box7C.Show();
                    break;
                case "7D":
                    box7D.Show();
                    break;
                case "7E":
                    box7E.Show();
                    break;
                case "7F":
                    box7F.Show();
                    break;
                case "7G":
                    box7G.Show();
                    break;
                case "7H":
                    box7H.Show();
                    break;
                case "7I":
                    box7I.Show();
                    break;
                case "7J":
                    box7J.Show();
                    break;
                case "8A":
                    box8A.Show();
                    break;
                case "8B":
                    box8B.Show();
                    break;
                case "8C":
                    box8C.Show();
                    break;
                case "8D":
                    box8D.Show();
                    break;
                case "8E":
                    box8E.Show();
                    break;
                case "8F":
                    box8F.Show();
                    break;
                case "8G":
                    box8G.Show();
                    break;
                case "8H":
                    box8H.Show();
                    break;
                case "8I":
                    box8I.Show();
                    break;
                case "8J":
                    box8J.Show();
                    break;
                case "9A":
                    box9A.Show();
                    break;
                case "9B":
                    box9B.Show();
                    break;
                case "9C":
                    box9C.Show();
                    break;
                case "9D":
                    box9D.Show();
                    break;
                case "9E":
                    box9E.Show();
                    break;
                case "9F":
                    box9F.Show();
                    break;
                case "9G":
                    box9G.Show();
                    break;
                case "9H":
                    box9H.Show();
                    break;
                case "9I":
                    box9I.Show();
                    break;
                case "9J":
                    box9J.Show();
                    break;
                case "10A":
                    box10A.Show();
                    break;
                case "10B":
                    box10B.Show();
                    break;
                case "10C":
                    box10C.Show();
                    break;
                case "10D":
                    box10D.Show();
                    break;
                case "10E":
                    box10E.Show();
                    break;
                case "10F":
                    box10F.Show();
                    break;
                case "10G":
                    box10G.Show();
                    break;
                case "10H":
                    box10H.Show();
                    break;
                case "10I":
                    box10I.Show();
                    break;
                case "10J":
                    box10J.Show();
                    break;
            } 
            finalPathTaken = String.Concat(finalPathTaken, TraversalX, startingLettorOfY, ", ");
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
                newVisibleBox = String.Concat(TraversalX, letterOfY);
                switch (newVisibleBox)
                {
                    case "1A":
                        box1A.Show();
                        break;
                    case "1B":
                        box1B.Show();
                        break;
                    case "1C":
                        box1C.Show();
                        break;
                    case "1D":
                        box1D.Show();
                        break;
                    case "1E":
                        box1E.Show();
                        break;
                    case "1F":
                        box1F.Show();
                        break;
                    case "1G":
                        box1G.Show();
                        break;
                    case "1H":
                        box1H.Show();
                        break;
                    case "1I":
                        box1I.Show();
                        break;
                    case "1J":
                        box1J.Show();
                        break;
                    case "2A":
                        box2A.Show();
                        break;
                    case "2B":
                        box2B.Show();
                        break;
                    case "2C":
                        box2C.Show();
                        break;
                    case "2D":
                        box2D.Show();
                        break;
                    case "2E":
                        box2E.Show();
                        break;
                    case "2F":
                        box2F.Show();
                        break;
                    case "2G":
                        box2G.Show();
                        break;
                    case "2H":
                        box2H.Show();
                        break;
                    case "2I":
                        box2I.Show();
                        break;
                    case "2J":
                        box2J.Show();
                        break;
                    case "3A":
                        box3A.Show();
                        break;
                    case "3B":
                        box3B.Show();
                        break;
                    case "3C":
                        box3C.Show();
                        break;
                    case "3D":
                        box3D.Show();
                        break;
                    case "3E":
                        box3E.Show();
                        break;
                    case "3F":
                        box3F.Show();
                        break;
                    case "3G":
                        box3G.Show();
                        break;
                    case "3H":
                        box3H.Show();
                        break;
                    case "3I":
                        box3I.Show();
                        break;
                    case "3J":
                        box3J.Show();
                        break;
                    case "4A":
                        box4A.Show();
                        break;
                    case "4B":
                        box4B.Show();
                        break;
                    case "4C":
                        box4C.Show();
                        break;
                    case "4D":
                        box4D.Show();
                        break;
                    case "4E":
                        box4E.Show();
                        break;
                    case "4F":
                        box4F.Show();
                        break;
                    case "4G":
                        box4G.Show();
                        break;
                    case "4H":
                        box4H.Show();
                        break;
                    case "4I":
                        box4I.Show();
                        break;
                    case "4J":
                        box4J.Show();
                        break;
                    case "5A":
                        box5A.Show();
                        break;
                    case "5B":
                        box5B.Show();
                        break;
                    case "5C":
                        box5C.Show();
                        break;
                    case "5D":
                        box5D.Show();
                        break;
                    case "5E":
                        box5E.Show();
                        break;
                    case "5F":
                        box5F.Show();
                        break;
                    case "5G":
                        box5G.Show();
                        break;
                    case "5H":
                        box5H.Show();
                        break;
                    case "5I":
                        box5I.Show();
                        break;
                    case "5J":
                        box5J.Show();
                        break;
                    case "6A":
                        box6A.Show();
                        break;
                    case "6B":
                        box6B.Show();
                        break;
                    case "6C":
                        box6C.Show();
                        break;
                    case "6D":
                        box6D.Show();
                        break;
                    case "6E":
                        box6E.Show();
                        break;
                    case "6F":
                        box6F.Show();
                        break;
                    case "6G":
                        box6G.Show();
                        break;
                    case "6H":
                        box6H.Show();
                        break;
                    case "6I":
                        box6I.Show();
                        break;
                    case "6J":
                        box6J.Show();
                        break;
                    case "7A":
                        box7A.Show();
                        break;
                    case "7B":
                        box7B.Show();
                        break;
                    case "7C":
                        box7C.Show();
                        break;
                    case "7D":
                        box7D.Show();
                        break;
                    case "7E":
                        box7E.Show();
                        break;
                    case "7F":
                        box7F.Show();
                        break;
                    case "7G":
                        box7G.Show();
                        break;
                    case "7H":
                        box7H.Show();
                        break;
                    case "7I":
                        box7I.Show();
                        break;
                    case "7J":
                        box7J.Show();
                        break;
                    case "8A":
                        box8A.Show();
                        break;
                    case "8B":
                        box8B.Show();
                        break;
                    case "8C":
                        box8C.Show();
                        break;
                    case "8D":
                        box8D.Show();
                        break;
                    case "8E":
                        box8E.Show();
                        break;
                    case "8F":
                        box8F.Show();
                        break;
                    case "8G":
                        box8G.Show();
                        break;
                    case "8H":
                        box8H.Show();
                        break;
                    case "8I":
                        box8I.Show();
                        break;
                    case "8J":
                        box8J.Show();
                        break;
                    case "9A":
                        box9A.Show();
                        break;
                    case "9B":
                        box9B.Show();
                        break;
                    case "9C":
                        box9C.Show();
                        break;
                    case "9D":
                        box9D.Show();
                        break;
                    case "9E":
                        box9E.Show();
                        break;
                    case "9F":
                        box9F.Show();
                        break;
                    case "9G":
                        box9G.Show();
                        break;
                    case "9H":
                        box9H.Show();
                        break;
                    case "9I":
                        box9I.Show();
                        break;
                    case "9J":
                        box9J.Show();
                        break;
                    case "10A":
                        box10A.Show();
                        break;
                    case "10B":
                        box10B.Show();
                        break;
                    case "10C":
                        box10C.Show();
                        break;
                    case "10D":
                        box10D.Show();
                        break;
                    case "10E":
                        box10E.Show();
                        break;
                    case "10F":
                        box10F.Show();
                        break;
                    case "10G":
                        box10G.Show();
                        break;
                    case "10H":
                        box10H.Show();
                        break;
                    case "10I":
                        box10I.Show();
                        break;
                    case "10J":
                        box10J.Show();
                        break;
                }
                finalPathTaken = String.Concat(finalPathTaken, TraversalX, letterOfY, ", ");
            }
            label29.Text = finalPathTaken;
        }
    }
}    
