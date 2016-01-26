///By Anjali
/// Candy Store for Tiny Town
/// Jan. 25,2015
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
    public partial class DandyForm : Form
    {
        //global array
        int[] items = { 0, 0, 0, 0, 0, 0, 0 };

        //declare constants
        const decimal PRICE = 2.00M;
        const decimal HST = 0.13M;

        //variable creation
        decimal subtotal = 0;
        decimal taxAmount = 0;
        decimal total = 0;
        decimal amountGiven = 0;
        decimal change = 0;

        public DandyForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method for adding and taking items into and out of cart
        /// </summary>
        public void itemsUpdate()
        {
            //Clear Cart
            cartLabel.Text = "";

            //if statements for adding and taking away items in cart
            if (items[0] > 0)
            {
                cartLabel.Text += " \n Gummy Bears      @" + Convert.ToString(items[0]) + "  =   $" + PRICE * (items[0]);
            }
            if (items[1] > 0)
            {
                cartLabel.Text += " \n Gummy Worms      @" + Convert.ToString(items[1]) + "  =   $" + PRICE * (items[1]);
            }
            if (items[2] > 0)
            {
                cartLabel.Text += " \n Gummy Fruits     @" + Convert.ToString(items[2]) + "  =   $" + PRICE * (items[2]);
            }
            if (items[3] > 0)
            {
                cartLabel.Text += " \n Chocolate Balls  @" + Convert.ToString(items[3]) + "  =   $" + PRICE * (items[3]);
            }
            if (items[4] > 0)
            {
                cartLabel.Text += " \n M & M's           @" + Convert.ToString(items[4]) + "  =   $" + PRICE * (items[4]);
            }
            if (items[5] > 0)
            {
                cartLabel.Text += " \n Chocolate Chips  @" + Convert.ToString(items[5]) + "  =   $" + PRICE * (items[5]);
            }
            if(items[6] > 0)
            {
                cartLabel.Text += " \n Jelly Beans      @" + Convert.ToString(items[6]) + "  =   $" + PRICE * (items[6]);
            }

            //Calculations
            subtotal = PRICE * (items[0]) + PRICE * (items[1]) + +PRICE * (items[2]) + PRICE * (items[3])
                + PRICE * (items[4]) + PRICE * (items[5]) + PRICE * (items[6]);
            taxAmount = subtotal * HST;
            total = subtotal + HST;

            //output amounts
            totalsLabel.Text = "";
            totalsLabel.Text += "               Subtotal: $ " + subtotal;
            totalsLabel.Text += "\n               Tax:      $ " + taxAmount;
            totalsLabel.Text += "\n               Total:    $ " + total;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //change background, hide buttons,show buttons
            this.BackgroundImage = Properties.Resources.Screenshot__3_;
            startOrderButton.Visible = false;
            completeOrderButton.Visible = true;
            jellyBeanUpDown.Visible = true;
            gummyBearUpDown.Visible = true;
            gummyFruitUpDown.Visible = true;
            gummyWormsUpDown.Visible = true;
            chocolateBallsUpDown1.Visible = true;
            chocolateChipsUpDown.Visible = true;
            MmUpDown.Visible = true;
            cartLabel.Visible = true;
            totalsLabel.Visible = true;
            myCartLabel.Visible = true;
            backgroundCartLabel.Visible = true;
        }
        private void gummyBearUpDown_ValueChanged(object sender, EventArgs e)
        {
            //gummy bears
            items[0] = Convert.ToInt16(gummyBearUpDown.Value);
            itemsUpdate();
        }

        private void gummyWormsUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Gummy Worms 
            items[1] = Convert.ToInt16(gummyWormsUpDown.Value);
            itemsUpdate();
        }

        private void gummyFruitUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Gummy Fruits
            items[2] = Convert.ToInt16(gummyFruitUpDown.Value);
            itemsUpdate();
        }

        private void chocolateBallsUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Chocoalte Balls
            items[3] = Convert.ToInt16(chocolateBallsUpDown1.Value);
            itemsUpdate();
            amountGivenInput.Visible = true;
        }

        private void MmUpDown_ValueChanged(object sender, EventArgs e)
        {
            //M & M's 
            items[4] = Convert.ToInt16(MmUpDown.Value);
            itemsUpdate();
        }

        private void chocolateChipsUpDown_ValueChanged(object sender, EventArgs e)
        {
            //Chocolate chips
            items[5] = Convert.ToInt16(chocolateChipsUpDown.Value);
            itemsUpdate();
        }

        private void jellyBeanUpCown_ValueChanged(object sender, EventArgs e)
        {
            ////Jelly Beans
            items[6] = Convert.ToInt16(jellyBeanUpDown.Value);
            itemsUpdate();
        }

        private void completeOrderButton_Click(object sender, EventArgs e)
        {
            //show change options
            amountGivenInput.Visible = true;
            amountGivenInput.BringToFront();
            amountGivenLabel.Visible = true;
            amountGivenLabel.BringToFront();
            calculateChangeButton.Visible = true;
            calculateChangeButton.BringToFront();
            changeLabel.Visible = true;
            changeLabel.BringToFront();
            
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            ////Get Inputs
            amountGiven = Convert.ToDecimal(amountGivenInput.Text);

            //Calculate Change
            change = amountGiven - total;

            //Output Amounts
            if(amountGiven < total)
            {
                //amount given is not enough
                MessageBox.Show("Sorry, that is not enough money for this purcahse");
            }
            else if (Form1.wallet < amountGiven)
            {
                //not enough money in wallet
                MessageBox.Show("You do not have enough money for this purchase in your wallet");
            }
            else if (amountGiven > total)
            {
                //amount given is enough
                changeLabel.Text = "Your change is " + change.ToString("C") + "";
                finishButton.Visible = true;

                //Completed order sound effect
                SoundPlayer paidSound = new SoundPlayer(Properties.Resources.Cash_Register_Cha_Ching);
                paidSound.Play();
            }

            if (Form1.wallet > total) 
            {
                //subtract total from wallet
                Form1.wallet = Form1.wallet - total;
            }
        }

        private void exitStoreButton_Click(object sender, EventArgs e)
        {
            //exit game
            this.Close();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
         
            //change background
            this.BackgroundImage = Properties.Resources.last_candy;

            //visible = false
            completeOrderButton.Visible = false;
            jellyBeanUpDown.Visible = false;
            gummyBearUpDown.Visible = false;
            gummyFruitUpDown.Visible = false;
            gummyWormsUpDown.Visible = false;
            chocolateBallsUpDown1.Visible = false;
            chocolateChipsUpDown.Visible = false;
            MmUpDown.Visible =  false;
            cartLabel.Visible = false;
            totalsLabel.Visible = false;
            myCartLabel.Visible = false;
            backgroundCartLabel.Visible = false;
            finishButton.Visible = false;
            amountGivenInput.Visible = false;
            amountGivenLabel.Visible = false;
            calculateChangeButton.Visible = false;
            changeLabel.Visible = false;

            //visible = true
            newOrderButton.Visible = true;
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //reset array
            for(int i = 0; i < items.Length; i++)
            {
                items[i] = 0;                
            }

            //reset varibales
            subtotal = 0;
            taxAmount = 0;
            total = 0;
            amountGiven = 0;
            change = 0;

            //reset to new backgroud and layout
            this.BackgroundImage = Properties.Resources.Screenshot__3_;
            completeOrderButton.Visible = true;
            jellyBeanUpDown.Visible = true;
            gummyBearUpDown.Visible = true;
            gummyFruitUpDown.Visible = true;
            gummyWormsUpDown.Visible = true;
            chocolateBallsUpDown1.Visible = true;
            chocolateChipsUpDown.Visible = true;
            MmUpDown.Visible = true;
            cartLabel.Visible = true;
            totalsLabel.Visible = true;
            myCartLabel.Visible = true;
            backgroundCartLabel.Visible = true;

            //reset labels and updown buttons to 0
            cartLabel.Text = "";
            jellyBeanUpDown.Value = 0;
            gummyBearUpDown.Value = 0;
            gummyFruitUpDown.Value = 0;
            gummyWormsUpDown.Value = 0;
            chocolateBallsUpDown1.Value = 0;
            chocolateChipsUpDown.Value = 0;
            MmUpDown.Value = 0;
            totalsLabel.Text = "";
            changeLabel.Text = "";
            amountGivenInput.Text = "";
        }
        private void DandyForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Wallet:$" + Form1.wallet, new Font("Courier New", 12), new SolidBrush(Color.Red), 540, 10);
        }
    }
}
