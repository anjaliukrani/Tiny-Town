using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tiny_Town
{
    public partial class Form1 : Form
    {
        public static decimal wallet = 500;


        
        //strating points
        int drawX = 50;
        int drawY = 250;

        //candy door points
        int drawX2 = 120;
        int drawY2 = 255;

        //pizza door points
        int DrawX3 = 330;
        int DrawY3 = 255;

        //pet store 
        int DrawX4 = 540;
        int DrawY4 = 255;

       
        //determines whether a key is being pressed or not
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown;

        //create graphic objects
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        public static int moneyAmount = 500;

        public Form1()
        {
            InitializeComponent();

            //start the timer when the program starts
            gameTimer.Enabled = true;
            gameTimer.Start();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //check to see if a key is pressed and set is KeyDown value to true if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //check to see if a key has been released and set its KeyDown value to false if it has
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                default:
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //make visabilites true, and false, and change background when start button is pressed
            this.BackgroundImage = Properties.Resources.townImage;
            startButton.Visible = false;
            exitStoreLable.Visible = true;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            leftArrowDown = rightArrowDown = upArrowDown = downArrowDown = false;
            gameTimer.Enabled = true;
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //checks to see if any keys have been pressed and adjusts the X or Y value
            //for the rectangle appropriately
            if (leftArrowDown == true)
            {
                drawX -= 2;
            }
            if (downArrowDown == true)
            {
                drawY += 2;

            }
            if (rightArrowDown == true)
            {
                drawX += 2;

            }
            if (upArrowDown == true)
            {
                drawY -= 2;
            }

            double distance = Math.Sqrt(Math.Pow(drawX2 - drawX, 2) + Math.Pow(drawY2 - drawY, 2));
            if (distance < 10)
            {
                gameTimer.Enabled = false;
               
                drawY += 30;

                //Door Bell sound effect
                SoundPlayer bell = new SoundPlayer(Properties.Resources.Door_Bell);
                bell.Play();

                //show candy store
                DandyForm df = new DandyForm();
                df.Show();
                
            }

            distance = Math.Sqrt(Math.Pow(DrawX3 - drawX, 2) + Math.Pow(DrawY3 - drawY, 2));
            if (distance < 10)
            {
                gameTimer.Enabled = false;

                drawY += 30;

                //show pizza drive
                tinyTriplePizza tt = new tinyTriplePizza();
                tt.Show();
               
            }
            distance = Math.Sqrt(Math.Pow(DrawX4 - drawX, 2) + Math.Pow(DrawY4 - drawY, 2));
            if (distance < 10)
            {
                gameTimer.Enabled = false;

                drawY += 30;

                //Door Bell sound effect
                SoundPlayer bell = new SoundPlayer(Properties.Resources.Door_Bell);
                bell.Play();

                //show pet store
                petShop ps = new petShop();
                ps.Show();
            }
            if (drawX > this.Width - 20)
            {
                //exit game
                this.Close();
            }


                //refresh the screen, which causes the Form1_Paint method to run
                Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //draw rectangle to screen
            if (startButton.Visible == false)
            {
                e.Graphics.DrawImage(Properties.Resources.girl, drawX, drawY, 20, 50);
                e.Graphics.DrawString("Wallet:$" + wallet, new Font("Courier New", 12), new SolidBrush(Color.Red), 490, 10);
            }

        }
            

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
