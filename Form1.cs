using Bingo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form1 : Form
    {
        int ballX = 0; //setup ball positions
        int ballY = 0;

        string ballID; //i think this is redundant, but program breaks without it

        int count = 91; //must have this existing - amount of balls + 1

        Random bingoNumber = new Random(); //generates the number - add seed later

        string StartPath = Application.StartupPath; //makes it able to run in any directory, with any image

        public Form1()
        {
            InitializeComponent();
            
            DrawBalls(true, 0, 0); //initialises the grid of balls. "init" value makes sure they arent being drawn from scratch every time
                                   //can you imagine that?
        }

        public void DrawBalls(bool init, int ballX, int ballY)
        {
            drawBut.Enabled = true; //lets you draw again after reset - ugly, works

            //image setup
            int rows = 9;
            int cols = 10;

            PictureBox[,] balls = new PictureBox[rows, cols]; //creates an array of pictureboxes

            for (int r = 0; r < rows; r++) // loops rows
            {
                for (int c = 0; c < cols; c++) //loops columns
                {
                    if (init) //if program first time running then:
                    {
                        balls[r, c] = new PictureBox();
                        string path = "ball2.png"; //creates a path
                        balls[r, c].Image = System.Drawing.Image.FromFile(Path.Combine(StartPath, path)); //draws from same directory as executable

                        //standard image setup
                        balls[r, c].Location = new Point(5 + c * 40, 100 + r * 40);
                        balls[r, c].SizeMode = PictureBoxSizeMode.Zoom;
                        balls[r, c].Height = 40;
                        balls[r, c].Size = new Size(40, 40);

                        ballID = r.ToString() + (c + 1).ToString(); //again, removing this breaks it - but ballID is only every referenced here
                        balls[r, c].Name = ballID;

                        //draws the number labels
                        balls[r, c].Paint += new PaintEventHandler(this.numbers_Paint);

                        //actually draws balls
                        this.Controls.Add(balls[r, c]);

                        //layers them correctly. apparently WinForms doesn't play nice with transparent backgrounds. Qt FTW
                        balls[r, c].BringToFront();
                    }
                    //
                    if (!init && r == ballX && c == ballY) //ballx = 4, y =0
                    {
                        //Console.WriteLine(ballX.ToString());
                        //Console.WriteLine(ballY.ToString());
                        //Console.WriteLine(ballX.ToString() + ballY.ToString());
                        //debug shit ^^^

                        string ballPosition = ballX.ToString() + ballY.ToString(); //easier to read

                        if (ballPosition == "00")
                        {
                            this.Controls[0].BackColor = Color.Red; //checks for a zero value: aka 90
                            break;
                        }

                        if (Convert.ToInt32(ballPosition) % 10 == 0)
                        { //messy way to check for values of 10 - could also do ballY == 0? yeah i probably should
                            this.Controls[90- Convert.ToInt32(ballPosition)].BackColor = Color.Red;
                        }
                        else
                        {
                            this.Controls[ballPosition].BackColor = Color.Red; //makes the balls red by getting a X value and a Y value
                        }
                            
                    }
                }

            }
        }
        public void DrawNumber()
        {
            //initialises the number
            int number = bingoNumber.Next(90);

            //quick validation - have we already called every number?
            if (pastNumberList.Items.Count >= 90)
            {
                //crashes the program???
                for (int i = 0; i <= 90; i++)
                {
                    this.Controls[i].BackColor = Color.Green;
                }

                drawBut.Enabled = false; //disable drawing
            }

            //checks if it already exists
            if (pastNumberList.Items.Contains(number) == false)
            {
                curNum.Text = "";

                for (int i = 0; i<4; i++)               // little pause effect
                {
                    curNum.Text = curNum.Text + ".";
                    curNum.Refresh();
                    Task.Delay(300).Wait(); //can hang up the program if hastily pressed
                }
                
                count = number + 1; //keeps the text on the balls updated

                //makes the ball red - "init" is false
                if (number > 9)
                {
                    DrawBalls(false, number / 10, number - ((number / 10) * 10));
                    //looks messy - isnt.
                    // number/10 is division with an integer - so automatic rounding. the result will always be the first digit
                    // second half grabs the Y value - the second digit of the number
                }
                else
                {
                    DrawBalls(false, 0, number); //if there is no second digit, sub in 0 as the first so that DrawBalls doesnt throw a tantrum
                }

                //this is all messy code - balls are drawn from the bottom up
                // 0 is 90 and vice versa - this just flips them around
                if (number == 0 && !pastNumberList.Items.Contains("90"))
                {
                    pastNumberList.Items.Add("90");
                    curNum.Text = "90";
                }
                else
                {
                    pastNumberList.Items.Add(number); //appends number to the list
                    curNum.Text = number.ToString(); //adds the number to the window
                }
                    
            }
            else
            {
                if (pastNumberList.Items.Count >= 90)
                {
                    drawBut.Text = "Game Over";
                    count = -1; //stops graphics loop
                }

                Console.WriteLine("duplicate detected! "); 
                //catches duplicates and redraws
                DrawNumber();
            }
        }


        bool found90 = false; 
        private void numbers_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (pastNumberList.Items.Contains("90") && !found90)            //more 0/90 boilerplate
            {
                g.DrawString("90", DefaultFont, System.Drawing.Brushes.Black, new Point(13, 13));
                found90 = true;
            }

            if (count > 1) {
                count--;
                // draw the text
                g.DrawString(count.ToString(), DefaultFont, System.Drawing.Brushes.Black, new Point(13, 13));
            }
        }

        private void drawBut_Click(object sender, EventArgs e)
        {
            DrawNumber(); //self explanatory, no?
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //total reset
            pastNumberList.Items.Clear();
            curNum.Text = "";
            found90 = false;

            //dont know how, but it works
            for (int i = 1; i <= 90; i++)
            {
                Controls.RemoveAt(0);
            }
            drawBut.Enabled = false;
            DrawBalls(true, 0, 0);

        }
    }
}

