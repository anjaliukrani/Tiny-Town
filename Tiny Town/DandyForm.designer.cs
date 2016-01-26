namespace Tiny_Town
{
    partial class DandyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DandyForm));
            this.startOrderButton = new System.Windows.Forms.Button();
            this.exitStoreButton = new System.Windows.Forms.Button();
            this.endGameButton = new System.Windows.Forms.Button();
            this.completeOrderButton = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.jellyBeanUpDown = new System.Windows.Forms.NumericUpDown();
            this.gummyBearUpDown = new System.Windows.Forms.NumericUpDown();
            this.gummyFruitUpDown = new System.Windows.Forms.NumericUpDown();
            this.chocolateBallsUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MmUpDown = new System.Windows.Forms.NumericUpDown();
            this.chocolateChipsUpDown = new System.Windows.Forms.NumericUpDown();
            this.gummyWormsUpDown = new System.Windows.Forms.NumericUpDown();
            this.backgroundCartLabel = new System.Windows.Forms.Label();
            this.myCartLabel = new System.Windows.Forms.Label();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.amountGivenLabel = new System.Windows.Forms.Label();
            this.amountGivenInput = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jellyBeanUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyBearUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyFruitUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocolateBallsUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MmUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocolateChipsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyWormsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startOrderButton
            // 
            this.startOrderButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.startOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startOrderButton.Location = new System.Drawing.Point(597, 426);
            this.startOrderButton.Name = "startOrderButton";
            this.startOrderButton.Size = new System.Drawing.Size(75, 23);
            this.startOrderButton.TabIndex = 0;
            this.startOrderButton.Text = "Start Order";
            this.startOrderButton.UseVisualStyleBackColor = false;
            this.startOrderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitStoreButton
            // 
            this.exitStoreButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitStoreButton.Location = new System.Drawing.Point(12, 426);
            this.exitStoreButton.Name = "exitStoreButton";
            this.exitStoreButton.Size = new System.Drawing.Size(75, 23);
            this.exitStoreButton.TabIndex = 1;
            this.exitStoreButton.Text = "Exit Store";
            this.exitStoreButton.UseVisualStyleBackColor = false;
            this.exitStoreButton.Click += new System.EventHandler(this.exitStoreButton_Click);
            // 
            // endGameButton
            // 
            this.endGameButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.endGameButton.Location = new System.Drawing.Point(105, 426);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(75, 23);
            this.endGameButton.TabIndex = 3;
            this.endGameButton.Text = "End Game";
            this.endGameButton.UseVisualStyleBackColor = false;
            // 
            // completeOrderButton
            // 
            this.completeOrderButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.completeOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.completeOrderButton.Location = new System.Drawing.Point(199, 278);
            this.completeOrderButton.Name = "completeOrderButton";
            this.completeOrderButton.Size = new System.Drawing.Size(83, 35);
            this.completeOrderButton.TabIndex = 4;
            this.completeOrderButton.Text = "Complete Order";
            this.completeOrderButton.UseVisualStyleBackColor = false;
            this.completeOrderButton.Visible = false;
            this.completeOrderButton.Click += new System.EventHandler(this.completeOrderButton_Click);
            // 
            // cartLabel
            // 
            this.cartLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLabel.Location = new System.Drawing.Point(9, 76);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(284, 150);
            this.cartLabel.TabIndex = 5;
            this.cartLabel.Visible = false;
            // 
            // jellyBeanUpDown
            // 
            this.jellyBeanUpDown.Location = new System.Drawing.Point(448, 442);
            this.jellyBeanUpDown.Name = "jellyBeanUpDown";
            this.jellyBeanUpDown.Size = new System.Drawing.Size(35, 20);
            this.jellyBeanUpDown.TabIndex = 6;
            this.jellyBeanUpDown.Visible = false;
            this.jellyBeanUpDown.ValueChanged += new System.EventHandler(this.jellyBeanUpCown_ValueChanged);
            // 
            // gummyBearUpDown
            // 
            this.gummyBearUpDown.Location = new System.Drawing.Point(323, 173);
            this.gummyBearUpDown.Name = "gummyBearUpDown";
            this.gummyBearUpDown.Size = new System.Drawing.Size(35, 20);
            this.gummyBearUpDown.TabIndex = 7;
            this.gummyBearUpDown.Visible = false;
            this.gummyBearUpDown.ValueChanged += new System.EventHandler(this.gummyBearUpDown_ValueChanged);
            // 
            // gummyFruitUpDown
            // 
            this.gummyFruitUpDown.Location = new System.Drawing.Point(559, 173);
            this.gummyFruitUpDown.Name = "gummyFruitUpDown";
            this.gummyFruitUpDown.Size = new System.Drawing.Size(35, 20);
            this.gummyFruitUpDown.TabIndex = 8;
            this.gummyFruitUpDown.Visible = false;
            this.gummyFruitUpDown.ValueChanged += new System.EventHandler(this.gummyFruitUpDown_ValueChanged);
            // 
            // chocolateBallsUpDown1
            // 
            this.chocolateBallsUpDown1.Location = new System.Drawing.Point(323, 317);
            this.chocolateBallsUpDown1.Name = "chocolateBallsUpDown1";
            this.chocolateBallsUpDown1.Size = new System.Drawing.Size(35, 20);
            this.chocolateBallsUpDown1.TabIndex = 9;
            this.chocolateBallsUpDown1.Visible = false;
            this.chocolateBallsUpDown1.ValueChanged += new System.EventHandler(this.chocolateBallsUpDown1_ValueChanged);
            // 
            // MmUpDown
            // 
            this.MmUpDown.Location = new System.Drawing.Point(448, 317);
            this.MmUpDown.Name = "MmUpDown";
            this.MmUpDown.Size = new System.Drawing.Size(35, 20);
            this.MmUpDown.TabIndex = 10;
            this.MmUpDown.Visible = false;
            this.MmUpDown.ValueChanged += new System.EventHandler(this.MmUpDown_ValueChanged);
            // 
            // chocolateChipsUpDown
            // 
            this.chocolateChipsUpDown.Location = new System.Drawing.Point(559, 326);
            this.chocolateChipsUpDown.Name = "chocolateChipsUpDown";
            this.chocolateChipsUpDown.Size = new System.Drawing.Size(35, 20);
            this.chocolateChipsUpDown.TabIndex = 11;
            this.chocolateChipsUpDown.Visible = false;
            this.chocolateChipsUpDown.ValueChanged += new System.EventHandler(this.chocolateChipsUpDown_ValueChanged);
            // 
            // gummyWormsUpDown
            // 
            this.gummyWormsUpDown.Location = new System.Drawing.Point(448, 173);
            this.gummyWormsUpDown.Name = "gummyWormsUpDown";
            this.gummyWormsUpDown.Size = new System.Drawing.Size(35, 20);
            this.gummyWormsUpDown.TabIndex = 12;
            this.gummyWormsUpDown.Visible = false;
            this.gummyWormsUpDown.ValueChanged += new System.EventHandler(this.gummyWormsUpDown_ValueChanged);
            // 
            // backgroundCartLabel
            // 
            this.backgroundCartLabel.BackColor = System.Drawing.Color.Blue;
            this.backgroundCartLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundCartLabel.Location = new System.Drawing.Point(-6, 29);
            this.backgroundCartLabel.Name = "backgroundCartLabel";
            this.backgroundCartLabel.Size = new System.Drawing.Size(312, 385);
            this.backgroundCartLabel.TabIndex = 13;
            this.backgroundCartLabel.Visible = false;
            // 
            // myCartLabel
            // 
            this.myCartLabel.BackColor = System.Drawing.Color.Blue;
            this.myCartLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCartLabel.Location = new System.Drawing.Point(101, 41);
            this.myCartLabel.Name = "myCartLabel";
            this.myCartLabel.Size = new System.Drawing.Size(103, 23);
            this.myCartLabel.TabIndex = 14;
            this.myCartLabel.Text = "My Cart";
            this.myCartLabel.Visible = false;
            // 
            // totalsLabel
            // 
            this.totalsLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.Location = new System.Drawing.Point(9, 226);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(284, 100);
            this.totalsLabel.TabIndex = 15;
            this.totalsLabel.Visible = false;
            // 
            // amountGivenLabel
            // 
            this.amountGivenLabel.AutoSize = true;
            this.amountGivenLabel.BackColor = System.Drawing.Color.Blue;
            this.amountGivenLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amountGivenLabel.Location = new System.Drawing.Point(7, 333);
            this.amountGivenLabel.Name = "amountGivenLabel";
            this.amountGivenLabel.Size = new System.Drawing.Size(80, 13);
            this.amountGivenLabel.TabIndex = 17;
            this.amountGivenLabel.Text = "Amount Given: ";
            this.amountGivenLabel.Visible = false;
            // 
            // amountGivenInput
            // 
            this.amountGivenInput.Location = new System.Drawing.Point(93, 331);
            this.amountGivenInput.Name = "amountGivenInput";
            this.amountGivenInput.Size = new System.Drawing.Size(100, 20);
            this.amountGivenInput.TabIndex = 18;
            this.amountGivenInput.Visible = false;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.calculateChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateChangeButton.Location = new System.Drawing.Point(199, 329);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(94, 22);
            this.calculateChangeButton.TabIndex = 19;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Visible = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Blue;
            this.changeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeLabel.Location = new System.Drawing.Point(75, 377);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 13);
            this.changeLabel.TabIndex = 20;
            this.changeLabel.Visible = false;
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.finishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finishButton.Location = new System.Drawing.Point(576, 426);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(96, 23);
            this.finishButton.TabIndex = 21;
            this.finishButton.Text = "Finished Order";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Visible = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.newOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newOrderButton.Location = new System.Drawing.Point(197, 426);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(96, 23);
            this.newOrderButton.TabIndex = 22;
            this.newOrderButton.Text = "Place New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Visible = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // DandyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tiny_Town.Properties.Resources.welcome_candy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.amountGivenInput);
            this.Controls.Add(this.amountGivenLabel);
            this.Controls.Add(this.completeOrderButton);
            this.Controls.Add(this.totalsLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.myCartLabel);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.backgroundCartLabel);
            this.Controls.Add(this.gummyWormsUpDown);
            this.Controls.Add(this.chocolateChipsUpDown);
            this.Controls.Add(this.MmUpDown);
            this.Controls.Add(this.chocolateBallsUpDown1);
            this.Controls.Add(this.gummyFruitUpDown);
            this.Controls.Add(this.gummyBearUpDown);
            this.Controls.Add(this.jellyBeanUpDown);
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.exitStoreButton);
            this.Controls.Add(this.startOrderButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DandyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dandy\'s Candy";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DandyForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.jellyBeanUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyBearUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyFruitUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocolateBallsUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MmUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocolateChipsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gummyWormsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startOrderButton;
        private System.Windows.Forms.Button exitStoreButton;
        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.Button completeOrderButton;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.NumericUpDown jellyBeanUpDown;
        private System.Windows.Forms.NumericUpDown gummyBearUpDown;
        private System.Windows.Forms.NumericUpDown gummyFruitUpDown;
        private System.Windows.Forms.NumericUpDown chocolateBallsUpDown1;
        private System.Windows.Forms.NumericUpDown MmUpDown;
        private System.Windows.Forms.NumericUpDown chocolateChipsUpDown;
        private System.Windows.Forms.NumericUpDown gummyWormsUpDown;
        private System.Windows.Forms.Label backgroundCartLabel;
        private System.Windows.Forms.Label myCartLabel;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Label amountGivenLabel;
        private System.Windows.Forms.TextBox amountGivenInput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button newOrderButton;
    }
}

