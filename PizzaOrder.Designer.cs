namespace Pizza_Store
{
    partial class PizzaOrder
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
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.grOrderSummary = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalPrices = new System.Windows.Forms.Label();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.LabelCrust = new System.Windows.Forms.Label();
            this.labelTopping = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.grToppings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.grWhereToEat = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grCrust = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.grSize = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grToppings.SuspendLayout();
            this.grWhereToEat.SuspendLayout();
            this.grCrust.SuspendLayout();
            this.grSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(167, 124);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(4);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(98, 27);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(26, 124);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(4);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(75, 27);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOrderPizza.FlatAppearance.BorderSize = 0;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Linen;
            this.btnOrderPizza.Location = new System.Drawing.Point(415, 580);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(172, 83);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Now";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Gainsboro;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.ForeColor = System.Drawing.Color.Black;
            this.btnResetForm.Location = new System.Drawing.Point(762, 580);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(172, 83);
            this.btnResetForm.TabIndex = 5;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // grOrderSummary
            // 
            this.grOrderSummary.BackColor = System.Drawing.Color.OldLace;
            this.grOrderSummary.Controls.Add(this.pictureBox1);
            this.grOrderSummary.Controls.Add(this.label5);
            this.grOrderSummary.Controls.Add(this.labelTotalPrices);
            this.grOrderSummary.Controls.Add(this.labelWhereToEat);
            this.grOrderSummary.Controls.Add(this.LabelCrust);
            this.grOrderSummary.Controls.Add(this.labelTopping);
            this.grOrderSummary.Controls.Add(this.lblTotalPrice);
            this.grOrderSummary.Controls.Add(this.lblWhereToEat);
            this.grOrderSummary.Controls.Add(this.lblCrust);
            this.grOrderSummary.Controls.Add(this.lblToppings);
            this.grOrderSummary.Controls.Add(this.lblSize);
            this.grOrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grOrderSummary.Location = new System.Drawing.Point(943, 34);
            this.grOrderSummary.Margin = new System.Windows.Forms.Padding(4);
            this.grOrderSummary.Name = "grOrderSummary";
            this.grOrderSummary.Padding = new System.Windows.Forms.Padding(4);
            this.grOrderSummary.Size = new System.Drawing.Size(452, 538);
            this.grOrderSummary.TabIndex = 3;
            this.grOrderSummary.TabStop = false;
           
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizza_Store.Properties.Resources.pictureboxPizza;
            this.pictureBox1.Location = new System.Drawing.Point(86, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(32, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Order Summary";
            // 
            // labelTotalPrices
            // 
            this.labelTotalPrices.AutoSize = true;
            this.labelTotalPrices.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrices.Location = new System.Drawing.Point(35, 459);
            this.labelTotalPrices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPrices.Name = "labelTotalPrices";
            this.labelTotalPrices.Size = new System.Drawing.Size(108, 23);
            this.labelTotalPrices.TabIndex = 9;
            this.labelTotalPrices.Text = "Total Price : ";
            // 
            // labelWhereToEat
            // 
            this.labelWhereToEat.AutoSize = true;
            this.labelWhereToEat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhereToEat.Location = new System.Drawing.Point(21, 352);
            this.labelWhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhereToEat.Name = "labelWhereToEat";
            this.labelWhereToEat.Size = new System.Drawing.Size(130, 23);
            this.labelWhereToEat.TabIndex = 8;
            this.labelWhereToEat.Text = "Where To Eat : ";
            // 
            // LabelCrust
            // 
            this.LabelCrust.AutoSize = true;
            this.LabelCrust.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCrust.Location = new System.Drawing.Point(21, 311);
            this.LabelCrust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCrust.Name = "LabelCrust";
            this.LabelCrust.Size = new System.Drawing.Size(67, 23);
            this.LabelCrust.TabIndex = 7;
            this.LabelCrust.Text = "Crust : ";
            // 
            // labelTopping
            // 
            this.labelTopping.AutoSize = true;
            this.labelTopping.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopping.Location = new System.Drawing.Point(21, 258);
            this.labelTopping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTopping.Name = "labelTopping";
            this.labelTopping.Size = new System.Drawing.Size(98, 23);
            this.labelTopping.TabIndex = 6;
            this.labelTopping.Text = "Toppings : ";
            
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(131, 459);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(88, 23);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(131, 352);
            this.lblWhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(20, 23);
            this.lblWhereToEat.TabIndex = 3;
            this.lblWhereToEat.Text = "[]";
            
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Location = new System.Drawing.Point(82, 311);
            this.lblCrust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(88, 23);
            this.lblCrust.TabIndex = 2;
            this.lblCrust.Text = "Thin Crust";
            this.lblCrust.Click += new System.EventHandler(this.lblCrust_Click);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(105, 258);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(92, 23);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Toppings : ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(65, 201);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(54, 23);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size : ";
            // 
            // grToppings
            // 
            this.grToppings.BackColor = System.Drawing.Color.OldLace;
            this.grToppings.Controls.Add(this.label3);
            this.grToppings.Controls.Add(this.chkGreenPeppers);
            this.grToppings.Controls.Add(this.chkExtraCheese);
            this.grToppings.Controls.Add(this.chkOlives);
            this.grToppings.Controls.Add(this.chkMushroom);
            this.grToppings.Controls.Add(this.chkOnion);
            this.grToppings.Controls.Add(this.chkTomatos);
            this.grToppings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grToppings.Location = new System.Drawing.Point(474, 73);
            this.grToppings.Margin = new System.Windows.Forms.Padding(4);
            this.grToppings.Name = "grToppings";
            this.grToppings.Padding = new System.Windows.Forms.Padding(4);
            this.grToppings.Size = new System.Drawing.Size(399, 206);
            this.grToppings.TabIndex = 2;
            this.grToppings.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(213, 170);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(4);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(148, 27);
            this.chkGreenPeppers.TabIndex = 7;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = " Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(24, 99);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(4);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(130, 27);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(213, 135);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(77, 27);
            this.chkOlives.TabIndex = 6;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(24, 134);
            this.chkMushroom.Margin = new System.Windows.Forms.Padding(4);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(115, 27);
            this.chkMushroom.TabIndex = 3;
            this.chkMushroom.Tag = "5";
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(213, 100);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(79, 27);
            this.chkOnion.TabIndex = 5;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Location = new System.Drawing.Point(24, 169);
            this.chkTomatos.Margin = new System.Windows.Forms.Padding(4);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(105, 27);
            this.chkTomatos.TabIndex = 4;
            this.chkTomatos.Tag = "5";
            this.chkTomatos.Text = "Tomatoes";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // grWhereToEat
            // 
            this.grWhereToEat.BackColor = System.Drawing.Color.OldLace;
            this.grWhereToEat.Controls.Add(this.label4);
            this.grWhereToEat.Controls.Add(this.rbTakeOut);
            this.grWhereToEat.Controls.Add(this.rbEatIn);
            this.grWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grWhereToEat.Location = new System.Drawing.Point(474, 356);
            this.grWhereToEat.Margin = new System.Windows.Forms.Padding(4);
            this.grWhereToEat.Name = "grWhereToEat";
            this.grWhereToEat.Padding = new System.Windows.Forms.Padding(4);
            this.grWhereToEat.Size = new System.Drawing.Size(411, 192);
            this.grWhereToEat.TabIndex = 2;
            this.grWhereToEat.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Where To Eat";
            // 
            // grCrust
            // 
            this.grCrust.BackColor = System.Drawing.Color.OldLace;
            this.grCrust.Controls.Add(this.label2);
            this.grCrust.Controls.Add(this.rbThinkCrust);
            this.grCrust.Controls.Add(this.rbThinCrust);
            this.grCrust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grCrust.Location = new System.Drawing.Point(43, 356);
            this.grCrust.Margin = new System.Windows.Forms.Padding(4);
            this.grCrust.Name = "grCrust";
            this.grCrust.Padding = new System.Windows.Forms.Padding(4);
            this.grCrust.Size = new System.Drawing.Size(299, 192);
            this.grCrust.TabIndex = 1;
            this.grCrust.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Crust";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(16, 151);
            this.rbThinkCrust.Margin = new System.Windows.Forms.Padding(4);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(110, 27);
            this.rbThinkCrust.TabIndex = 4;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Tag = "10";
            this.rbThinkCrust.Text = "ThickCrust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(16, 105);
            this.rbThinCrust.Margin = new System.Windows.Forms.Padding(4);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(104, 27);
            this.rbThinCrust.TabIndex = 3;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "ThinCrust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(26, 129);
            this.rbMeduim.Margin = new System.Windows.Forms.Padding(4);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(94, 27);
            this.rbMeduim.TabIndex = 2;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Medium";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(27, 94);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(4);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(72, 27);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(26, 164);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(4);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(73, 27);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // grSize
            // 
            this.grSize.BackColor = System.Drawing.Color.OldLace;
            this.grSize.Controls.Add(this.label1);
            this.grSize.Controls.Add(this.rbLarge);
            this.grSize.Controls.Add(this.rbSmall);
            this.grSize.Controls.Add(this.rbMeduim);
            this.grSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grSize.ForeColor = System.Drawing.Color.Black;
            this.grSize.Location = new System.Drawing.Point(43, 78);
            this.grSize.Margin = new System.Windows.Forms.Padding(4);
            this.grSize.Name = "grSize";
            this.grSize.Padding = new System.Windows.Forms.Padding(4);
            this.grSize.Size = new System.Drawing.Size(299, 201);
            this.grSize.TabIndex = 0;
            this.grSize.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Size";
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::Pizza_Store.Properties.Resources.bgPizzaProject;
            this.ClientSize = new System.Drawing.Size(1446, 714);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grOrderSummary);
            this.Controls.Add(this.grWhereToEat);
            this.Controls.Add(this.grToppings);
            this.Controls.Add(this.grCrust);
            this.Controls.Add(this.grSize);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PizzaOrder";
            this.Text = "PizzaOrder";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.grOrderSummary.ResumeLayout(false);
            this.grOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grToppings.ResumeLayout(false);
            this.grToppings.PerformLayout();
            this.grWhereToEat.ResumeLayout(false);
            this.grWhereToEat.PerformLayout();
            this.grCrust.ResumeLayout(false);
            this.grCrust.PerformLayout();
            this.grSize.ResumeLayout(false);
            this.grSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox grOrderSummary;
        private System.Windows.Forms.Label labelTotalPrices;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.Label LabelCrust;
        private System.Windows.Forms.Label labelTopping;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.GroupBox grToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.GroupBox grWhereToEat;
        private System.Windows.Forms.GroupBox grCrust;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.GroupBox grSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

