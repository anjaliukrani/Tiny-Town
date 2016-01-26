//Created by: Tasia Reynen
//on Januray 19th, 2016
//Triple Tiny Pizza Resturant
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
using System.Media;

namespace Tiny_Town
{


    public partial class tinyTriplePizza : Form
    {
        //Constant variables
        const decimal SLUSHIE_COST = 3.00M; 
        const decimal COFFEE_COST = 1.50M; 
        const decimal MAC_COST = 7.99M;   
        const decimal BURGER_COST = 9.99M; 
        const decimal SALAD_COST = 5.99M;  
        const decimal ICE_CREAM_COST = 4.99M; 
        const decimal CHEESECAKE_COST = 5.99M;  
        const decimal PIZZA_COST = 10.99M; 
        const decimal HST = 0.13M;

        //Global variables
        decimal subTotal;
        decimal taxCost;
        decimal finalCost;
        decimal tipGiving = 0;
        decimal newTotal = 0;

        //Items array            
        decimal[] mealItems = { 0, 0, 0, 0, 0, 0, 0, 0, 0};

        //Initializing random counter for fire drawing
        public static Random randNum = new Random();

        Graphics g;
        Font drawFont = new Font("Comic Sans MS", 10, FontStyle.Bold);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        public tinyTriplePizza()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void dinningArea_Click(object sender, EventArgs e)
        {
            //Displaying wallet total
            walletTotal.Text = "" + Form1.wallet;

            //Door Bell sound effect
            SoundPlayer doorBell = new SoundPlayer(Properties.Resources.Door_Bell);
            doorBell.PlaySync();

            //Moving Leo the waiter onto the screen
            for (int x = 0; x < 148; x+=3)
            {
                waiterPicture.Location = new Point(x, 100);
                waiterPicture.Refresh();
                
            }
            Thread.Sleep(1000);

            ////Drawing Leo's script
            g.DrawString("Hello my name is", drawFont, drawBrush, 5, 100);
            Thread.Sleep(60);
            g.DrawString("Leo. I will be your", drawFont, drawBrush, 5, 115);
            Thread.Sleep(60);
            g.DrawString("waiter today.", drawFont, drawBrush, 5, 130);
            Thread.Sleep(2500);

            //Changing visibilty
            waiterPicture.Visible = false;

            //Changing background image to dinning area
            this.BackgroundImage = Properties.Resources.dinning_area_new;

            Refresh();

            //Changing font
            drawFont = new Font("Comic Sans MS", 10, FontStyle.Bold);

            g.DrawString("Would you like to see", drawFont, drawBrush, 205, 160);
            Thread.Sleep(60);
            g.DrawString("the drink menu?", drawFont, drawBrush, 220, 175);
            drinkButton.Visible = true;
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            //Changing visibility of certian objects on form
            drinkButton.Visible = false;
            waterNumeric.Visible = true;
            slushieNumeric.Visible = true;
            coffeeNumeric.Visible = true;
            doneButton.Visible = true;
            menuLabel.Visible = true;
            menuPicture.Visible = true;

            //Menu label text
            Refresh();
            menuLabel.Text += "                  Drink Menu";
            menuLabel.Text += "\n\n     Water";
            menuLabel.Text += "\n\n\n   Triple Tiny Slushie";
            menuLabel.Text += "\n\n\n   Coffee";
            Refresh();
        }
        private void doneButton_Click(object sender, EventArgs e)
        {
            //Changing visibility of certian objects on form
            menuLabel.Visible = false;
            waterNumeric.Visible = false;
            slushieNumeric.Visible = false;
            coffeeNumeric.Visible = false;
            doneButton.Visible = false;
            menuPicture.Visible = false;

            //Waiter's script
            Thread.Sleep(500);
            g.DrawString("Now, would you like to see", drawFont, drawBrush, 160, 160);
            Thread.Sleep(60);
            g.DrawString("the main menu?", drawFont, drawBrush, 190, 175);
            mainMenuButton.Visible = true;

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            //Changing visibility of certian objects on form
            macNumeric.Visible = true;
            burgerNumeric.Visible = true;
            saladNumeric.Visible = true;
            pizzaCheckBox.Visible = true;
            menuLabel.SendToBack();
            menuLabel.Visible = true;
            mainMenuButton.Visible = false;
            menuPicture.Visible = true;

            //Changing picture on menu label
            menuPicture.BackgroundImage = Properties.Resources.pasta;

            //Displaying main menu options
            Refresh();
            menuLabel.BackColor = Color.PaleTurquoise;
            menuLabel.Text = "          Triple Tiny Pizza Menu";
            menuLabel.Font = new Font("Arial", 7);
            menuLabel.Text += "\n                       Mains";
            menuLabel.Font = new Font("Adobe Heiti Std", 14, FontStyle.Bold);
            menuLabel.Text += "\n\nMac & Cheese";
            menuLabel.Text += "\n\nTriple Decker Burger";
            menuLabel.Text += "\n\nCesear Salad";

            //Changing visibility
            doneButton2.Visible = true;

        }

        private void doneButton2_Click(object sender, EventArgs e)
        {
            //Changing visibility of certian objects on form
            menuLabel.Visible = false;
            macNumeric.Visible = false;
            burgerNumeric.Visible = false;
            saladNumeric.Visible = false;
            pizzaCheckBox.Visible = false;
            doneButton2.Visible = false;
            mainMenuButton.Visible = false;
            menuPicture.Visible = false;

            //Waiter's script
            Refresh();
            Thread.Sleep(500);
            g.DrawString("Can I get you anything for", drawFont, drawBrush, 170, 160);
            Thread.Sleep(60);
            g.DrawString("dessert?", drawFont, drawBrush, 205, 175);
            dessertMenuButton.Visible = true;
        }

        private void dessertMenuButton_Click(object sender, EventArgs e)
        {
            //Changing visibility of certian objects on form
            dessertMenuButton.Visible = false;
            menuLabel.SendToBack();
            menuLabel.Visible = true;
            menuPicture.Visible = true;

            //Changing picutre on menu label
            menuPicture.BackgroundImage = Properties.Resources.Ice_Cream;

            //Displaying dessert menu options
            Refresh();
            menuLabel.BackColor = Color.PaleTurquoise;
            menuLabel.Text = "                Dessert Menu";
            menuLabel.Text += "\n\n\n\nIce Cream Sundae";
            menuLabel.Text += "\n\n\n\nCheesecake"; ;

            //Changing visibility of certian objects on form
            iceCreamNumeric.Visible = true;
            cheesecakeNumeric.Visible = true;
            doneButton3.Visible = true;
        }

        private void doneButton3_Click(object sender, EventArgs e)
        {
            //Changing visibility of certian objects on form
            doneButton3.Visible = false;
            cheesecakeNumeric.Visible = false;
            iceCreamNumeric.Visible = false;
            menuLabel.Visible = false;
            menuPicture.Visible = false;

            Refresh();
            Thread.Sleep(500);

            //Drawing waiter's script
            g.DrawString("Well I hope you enjoyed your meal.", drawFont, drawBrush, 120, 160);

            //Changing visibility 
            recieptButton.Visible = true;
        }

        //Checking for exit Button to be clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void coffeeNumeric_ValueChanged(object sender, EventArgs e)
        {
            mealItems[1] = Convert.ToInt16(coffeeNumeric.Value);
        }

        private void macNumeric_ValueChanged(object sender, EventArgs e)
        {
            mealItems[2] = Convert.ToInt16(macNumeric.Value);
        }

        private void burgerNumeric_ValueChanged(object sender, EventArgs e)
        {
            mealItems[3] = Convert.ToInt16(burgerNumeric.Value);
        }

        private void slushieNumeric_ValueChanged(object sender, EventArgs e)
        {
            mealItems[0] = Convert.ToInt16(slushieNumeric.Value);
        }

        private void saladNumeric_ValueChanged(object sender, EventArgs e)
        {
            mealItems[4] = Convert.ToInt16(saladNumeric.Value);
        }

        private void iceCreamNumeric_ValueChanged(object sender, EventArgs e)
        {
            mealItems[5] = Convert.ToInt16(iceCreamNumeric.Value);
        }

        private void cheesecakeNumeric_ValueChanged_1(object sender, EventArgs e)
        {
            mealItems[6] = Convert.ToInt16(cheesecakeNumeric.Value);
        }

        private void waterNumeric_ValueChanged(object sender, EventArgs e)
        {
            mealItems[8] = Convert.ToInt16(waterNumeric.Value);
        }

        private void recieptButton_Click(object sender, EventArgs e)
        {
            payMethod();
        }
        /// <summary>
        /// Calculates the users meal totals and creates the reciept for the meal.
        /// </summary>
        public void payMethod()
        {
            //Changing visibility of certian objects on form
            recieptButton.Visible = false;
            tipButton.Visible = true;
            recieptLabel.Visible = true;
            recieptLabel.SendToBack();
            Refresh();

            //Final meal costs
            subTotal = SLUSHIE_COST * mealItems[0] + COFFEE_COST * mealItems[1] + MAC_COST * mealItems[2] + BURGER_COST * mealItems[3] + SALAD_COST * mealItems[4] + 
                ICE_CREAM_COST * mealItems[5] + CHEESECAKE_COST * mealItems[6] + PIZZA_COST * mealItems[7];
            taxCost = subTotal * HST;
            finalCost = subTotal + taxCost;

            // Reciept sound effect
            SoundPlayer reciept = new SoundPlayer(Properties.Resources.Cash_Register_printing_sound);
            reciept.Play();

            //Drawing strings on reciept label
            Graphics lg = recieptLabel.CreateGraphics();
            drawFont = new Font("Adobe Heiti Std", 9, FontStyle.Regular);

            //Drawing reciept label information 
            lg.DrawString("Triple Tiny Pizza" , drawFont, drawBrush, 75, 5);
            lg.DrawString("124 Wellburn St.", drawFont, drawBrush, 77, 20);

            //variable for drawing y value
            int y = 50;

            //Slushie
            if (mealItems[0] >= 1)
            {
                lg.DrawString("Slushie                                                @" + SLUSHIE_COST + "x" + mealItems[0], drawFont, drawBrush, 2, y);
                y = y + 20;
                Thread.Sleep(250);
                reciept.Play();
            }

            //Coffee
            if (mealItems[1] >= 1)
            {
                lg.DrawString("Coffee                                                 @" + COFFEE_COST + "x" + mealItems[1], drawFont, drawBrush, 2, y);
                y = y + 20;
                Thread.Sleep(250);
                reciept.Play();

            }

            //Mac & Cheese
            if (mealItems[2] >= 1)
            {
                lg.DrawString("Mac & Cheese                                  @" + MAC_COST + "x" + mealItems[2], drawFont, drawBrush, 2, y);
                y = y + 20;
                Thread.Sleep(250);
                reciept.Play();
            }

            //Burger
            if (mealItems[3] >= 1)
            {
                lg.DrawString("Triple Decker Burger                      @" + BURGER_COST + "x" + mealItems[3], drawFont, drawBrush, 2, y);
                y = y + 20;
                Thread.Sleep(250);
                reciept.Play();
            }

            //Salad
            if (mealItems[4] >= 1)
            {
                lg.DrawString("Cesear Salad                                     @" + SALAD_COST + "x" + mealItems[4], drawFont, drawBrush, 2, y);
                y = y + 20;
                Thread.Sleep(250);
                reciept.Play();
            }

            //Ice Cream
            if (mealItems[5] >= 1)
            {
                lg.DrawString("Ice Cream                                          @" + ICE_CREAM_COST + "x" + mealItems[5], drawFont, drawBrush, 2, y);
                y = y + 20;
                Thread.Sleep(250);
                reciept.Play();
            }

            //Cheesecake
            if (mealItems[6] >= 1)
            {
                lg.DrawString("Cheesecake                                       @" + CHEESECAKE_COST + "x" + mealItems[6], drawFont, drawBrush, 2, y);
                y = y + 20;
                Thread.Sleep(250);
                reciept.Play();
            }

            //Pizza
            if (mealItems[7] >= 1)
            {
                lg.DrawString("Personal Pizza                                  @" + PIZZA_COST + "x" + mealItems[7], drawFont, drawBrush, 2, y);
                y = y + 20;
                Thread.Sleep(250);
                reciept.Play();
            }

            lg.DrawString("Subtotal                                         " + subTotal.ToString("C"), drawFont, drawBrush, 20, 240);
            Thread.Sleep(250);
              
            lg.DrawString("Tax                                                   " + taxCost.ToString("C"), drawFont, drawBrush, 20, 260);
            Thread.Sleep(250);

            lg.DrawString("Total                                                " + finalCost.ToString("C"), drawFont, drawBrush, 20, 280);
            Thread.Sleep(250);
        
            lg.DrawString("                    Thank-you for visiting", drawFont, drawBrush, 4, 300);
            Thread.Sleep(250);

            lg.DrawString("                         (519)346-7384", drawFont, drawBrush, 4, 320);

        }
        private void tipButton_Click(object sender, EventArgs e)
        {
            //Changing visibility of certian objects on form
            recieptLabel.Visible = false;
            tipButton.Visible = false;
            tipOutputLabel.Visible = true;
            tipOutputLabel.SendToBack();
            amountGivingLabel.Visible = true;
            tipInput.Visible = true;
            newTotalButton.Visible = true;

            Refresh();
        }

        private void newTotalButton_Click(object sender, EventArgs e)
        {
            //Changing visibility of certian objects on form
            amountGivingLabel.Visible = false;
            tipInput.Visible = false;
            newTotalButton.Visible = false;
            recieptLabel.Visible = false;

            //Try & Catch for tip amount
            try
            {
                tipGiving = Convert.ToDecimal(tipInput.Text);
                newTotal = finalCost + tipGiving;
                tipOutputLabel.Text = "\n\nNew Total: " + newTotal.ToString("C");
                payButton.Location = new Point(238, 220);
                payButton.Visible = true;
            }
            catch
            {
                tipOutputLabel.Text = "\n\n\nYou must enter a dollar amount ";
                amountGivingLabel.Visible = true;
                tipInput.Visible = true;
                newTotalButton.Visible = true;
            }

        }

        private void pizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //declaring that pizza option has been choosen
            mealItems[7] = 1;

            //text displaying pizza topping options
            pizzaOptionsLabel.Text = "\nCheese";
            pizzaOptionsLabel.Text += "\nPepperoni";
            pizzaOptionsLabel.Text += "\nMushrooms";

            //Changing visibility of certian objects on form
            cheeseInput.Visible = true;
            pepperoniInput.Visible = true;
            mushroomInput.Visible = true;
            makePizzaButton.Visible = true;
            menuLabel.Visible = false;
            macNumeric.Visible = false;
            burgerNumeric.Visible = false;
            saladNumeric.Visible = false;
            pizzaCheckBox.Visible = false;
            doneButton2.Visible = false;
            mainMenuButton.Visible = false;
            menuPicture.Visible = false;

        }

        private void makePizzaButton_Click(object sender, EventArgs e)
        {
            //Changing visibility of certian objects on form
            pizzaOptionsLabel.Visible = false;
            cheeseInput.Visible = false;
            pepperoniInput.Visible = false;
            mushroomInput.Visible = false;

            //Topping amount array
            double[] pizzaToppings = { 0, 0, 0 };

            //Getting inputs
            pizzaToppings[0] = Convert.ToInt16(cheeseInput.Value);
            pizzaToppings[1] = Convert.ToInt16(pepperoniInput.Value);
            pizzaToppings[2] = Convert.ToInt16(mushroomInput.Value);

            //Random generators
            int rand;
            rand = randNum.Next(1, 201);
            int xValue;
            int yValue;

            //graphics pen and brush
            Pen drawPen = new Pen(Color.BurlyWood, 10);
            drawBrush.Color = Color.Gold;

            //Drawing base of pizza
            g.DrawEllipse(drawPen, 130, 50, 300, 300);
            g.FillEllipse(drawBrush, 130, 50, 300, 300);

            //Drawing the pizza with the selected toppings
            //Cheese topping
            for (int i = 0; i < pizzaToppings[0]; i++)
            {
                //generate random values
                xValue = randNum.Next(150, 360);
                yValue = randNum.Next(60, 300);

                //Changing pen and brush colour
                drawPen.Color = Color.Yellow;
                drawBrush.Color = Color.LightGoldenrodYellow;

                //draw
                g.DrawRectangle(drawPen, xValue, yValue, 1, 7);
                g.FillRectangle(drawBrush, xValue, yValue, 1, 7);
                Thread.Sleep(10);
            }

            //Pepperoni topping
            for (int i = 0; i < pizzaToppings[1]; i++)
            {
                //Changing pen and brush colour
                drawPen.Color = Color.RosyBrown;
                drawBrush.Color = Color.Red;

                //generate random values
                xValue = randNum.Next(150, 360);
                yValue = randNum.Next(60, 300);

                //draw
                g.DrawEllipse(drawPen, xValue, yValue, 50, 50);                g.FillEllipse(drawBrush, xValue, yValue, 50, 50);
                Thread.Sleep(10);
            }

            //Mushroom topping
            for (int i = 0; i < pizzaToppings[2]; i++)
            {
                //Changing pen and brush colour
                drawPen.Color = Color.Brown;
                drawBrush.Color = Color.SandyBrown;

                //generate random values
                xValue = randNum.Next(150, 360);
                yValue = randNum.Next(60, 300);

                //draw
                g.DrawPie(drawPen, xValue, yValue, 20, 20, 30, 45);                g.FillPie(drawBrush, xValue, yValue, 20, 20, 30, 45);
                Thread.Sleep(10);
            }

            //Changing visibility of certian objects on form
            cheeseInput.Visible = false;
            pepperoniInput.Visible = false;
            mushroomInput.Visible = false;
            makePizzaButton.Visible = false;

            Thread.Sleep(4500);
            Refresh();

            //Waiter's script
            drawBrush.Color = Color.Black;
            g.DrawString("Can I get you anything for", drawFont, drawBrush, 170, 160);
            Thread.Sleep(60);
            g.DrawString("dessert?", drawFont, drawBrush, 205, 175);

            dessertMenuButton.Visible = true;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            //Visibilty
            payButton.Visible = false;

            //Completed order sound effect
            SoundPlayer paidSound = new SoundPlayer(Properties.Resources.Cash_Register_Cha_Ching);
            paidSound.Play();

            //Calculating new game total for user
            if (newTotal < Form1.wallet)
            {
                Form1.wallet = Form1.wallet - newTotal;
                walletTotal.Text = "" + Form1.wallet;
            }
            else
            {
                MessageBox.Show("Sorry you do not have enough money in your wallet");
            }

            //Visibilty 
            newOrderButton.Visible = true;
            newOrderButton.Location = new Point(238, 220);
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //Reset of inputs
            mealItems[0] = slushieNumeric.Value = 0;
            mealItems[1] = coffeeNumeric.Value = 0;
            mealItems[2] = macNumeric.Value = 0;
            mealItems[3] = burgerNumeric.Value = 0;
            mealItems[4] = saladNumeric.Value = 0;
            mealItems[5] = iceCreamNumeric.Value = 0;
            mealItems[6] = cheesecakeNumeric.Value = 0;
            mealItems[7] = 0;
            mealItems[8] = waterNumeric.Value = 0;
            tipInput.Text = "";

            //Reset of lables
            recieptLabel.Text = "";
            tipOutputLabel.Text = "";

            //Reset of totals
            subTotal = 0;
            finalCost = 0;
            taxCost = 0;
            tipGiving = 0;
            newTotal = 0;

            //Visibility
            tipOutputLabel.Visible = false;
            newOrderButton.Visible = false;
            tipInput.Visible = false;
            amountGivingLabel.Visible = false;
            waterNumeric.Visible = true;
            slushieNumeric.Visible = true;
            coffeeNumeric.Visible = true;
            doneButton.Visible = true;
            menuLabel.Visible = true;
            menuPicture.Visible = true;

            //Changing menu picture back to first image
            menuPicture.BackgroundImage = Properties.Resources.Coffee;

            //Changing label back to drink menu
            menuLabel.Text = "";
            menuLabel.Text = "                   Drink Menu";
            menuLabel.Text += "\n\n\n     Water";
            menuLabel.Text += "\n\n\n   Triple Tiny Slushie";
            menuLabel.Text += "\n\n\n   Coffee";
        }
    }
}
