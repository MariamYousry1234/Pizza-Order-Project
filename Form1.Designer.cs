
namespace Pizza_Project
{
    partial class frmPizzaOrder
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
            this.labMakePizza = new System.Windows.Forms.Label();
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gpCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.labToppings = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtToppings = new System.Windows.Forms.TextBox();
            this.txtCrustType = new System.Windows.Forms.TextBox();
            this.txtWhereToEat = new System.Windows.Forms.TextBox();
            this.gpGroupSummary = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.gpSize.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpCrustType.SuspendLayout();
            this.gpWhereToEat.SuspendLayout();
            this.gpGroupSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMakePizza
            // 
            this.labMakePizza.AutoSize = true;
            this.labMakePizza.BackColor = System.Drawing.Color.Transparent;
            this.labMakePizza.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMakePizza.ForeColor = System.Drawing.Color.Red;
            this.labMakePizza.Location = new System.Drawing.Point(337, 31);
            this.labMakePizza.Name = "labMakePizza";
            this.labMakePizza.Size = new System.Drawing.Size(466, 80);
            this.labMakePizza.TabIndex = 0;
            this.labMakePizza.Text = "Make Your Pizza";
            // 
            // gpSize
            // 
            this.gpSize.BackColor = System.Drawing.Color.Transparent;
            this.gpSize.Controls.Add(this.rbLarge);
            this.gpSize.Controls.Add(this.rbMedium);
            this.gpSize.Controls.Add(this.rbSmall);
            this.gpSize.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSize.ForeColor = System.Drawing.Color.White;
            this.gpSize.Location = new System.Drawing.Point(28, 114);
            this.gpSize.Name = "gpSize";
            this.gpSize.Size = new System.Drawing.Size(244, 208);
            this.gpSize.TabIndex = 1;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(6, 153);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(107, 33);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(6, 105);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(137, 33);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(6, 57);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(105, 33);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.BackColor = System.Drawing.Color.Transparent;
            this.gpToppings.Controls.Add(this.chkGreenPeppers);
            this.gpToppings.Controls.Add(this.chkOlives);
            this.gpToppings.Controls.Add(this.chkOnion);
            this.gpToppings.Controls.Add(this.chkTomatoes);
            this.gpToppings.Controls.Add(this.chkMushrooms);
            this.gpToppings.Controls.Add(this.chkExtraCheese);
            this.gpToppings.Font = new System.Drawing.Font("Verdana", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpToppings.ForeColor = System.Drawing.Color.White;
            this.gpToppings.Location = new System.Drawing.Point(333, 114);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(433, 208);
            this.gpToppings.TabIndex = 2;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(227, 157);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(203, 29);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(227, 107);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(103, 29);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(227, 57);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(100, 29);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(18, 157);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(145, 29);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(18, 107);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(165, 29);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(18, 57);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(184, 29);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // gpCrustType
            // 
            this.gpCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gpCrustType.Controls.Add(this.rbThickCrust);
            this.gpCrustType.Controls.Add(this.rbThinCrust);
            this.gpCrustType.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCrustType.ForeColor = System.Drawing.Color.White;
            this.gpCrustType.Location = new System.Drawing.Point(28, 372);
            this.gpCrustType.Name = "gpCrustType";
            this.gpCrustType.Size = new System.Drawing.Size(244, 164);
            this.gpCrustType.TabIndex = 3;
            this.gpCrustType.TabStop = false;
            this.gpCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(8, 111);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(181, 33);
            this.rbThickCrust.TabIndex = 2;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(6, 56);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(168, 33);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gpWhereToEat
            // 
            this.gpWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gpWhereToEat.Controls.Add(this.rbTakeOut);
            this.gpWhereToEat.Controls.Add(this.rbEatIn);
            this.gpWhereToEat.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpWhereToEat.ForeColor = System.Drawing.Color.White;
            this.gpWhereToEat.Location = new System.Drawing.Point(333, 372);
            this.gpWhereToEat.Name = "gpWhereToEat";
            this.gpWhereToEat.Size = new System.Drawing.Size(362, 144);
            this.gpWhereToEat.TabIndex = 4;
            this.gpWhereToEat.TabStop = false;
            this.gpWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(194, 72);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(151, 33);
            this.rbTakeOut.TabIndex = 3;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(0, 72);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(112, 33);
            this.rbEatIn.TabIndex = 2;
            this.rbEatIn.Tag = "0";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrderPizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOrderPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderPizza.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Black;
            this.btnOrderPizza.Location = new System.Drawing.Point(46, 610);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(249, 53);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetForm.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(374, 610);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(249, 53);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.BackColor = System.Drawing.Color.Transparent;
            this.labToppings.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.ForeColor = System.Drawing.Color.Lime;
            this.labToppings.Location = new System.Drawing.Point(6, 94);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(120, 32);
            this.labToppings.TabIndex = 9;
            this.labToppings.Text = "Toppings : ";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.BackColor = System.Drawing.Color.Transparent;
            this.labCrustType.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.ForeColor = System.Drawing.Color.Lime;
            this.labCrustType.Location = new System.Drawing.Point(6, 190);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(135, 32);
            this.labCrustType.TabIndex = 10;
            this.labCrustType.Text = "Crust Type : ";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.BackColor = System.Drawing.Color.Transparent;
            this.labSize.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.ForeColor = System.Drawing.Color.Lime;
            this.labSize.Location = new System.Drawing.Point(6, 50);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(60, 32);
            this.labSize.TabIndex = 8;
            this.labSize.Text = "Size:";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.labWhereToEat.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.ForeColor = System.Drawing.Color.Lime;
            this.labWhereToEat.Location = new System.Drawing.Point(6, 278);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(205, 35);
            this.labWhereToEat.TabIndex = 11;
            this.labWhereToEat.Text = "Where To Eat :";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labTotalPrice.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.ForeColor = System.Drawing.Color.Lime;
            this.labTotalPrice.Location = new System.Drawing.Point(4, 357);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(217, 45);
            this.labTotalPrice.TabIndex = 12;
            this.labTotalPrice.Text = "Total Price : ";
            // 
            // txtSize
            // 
            this.txtSize.Enabled = false;
            this.txtSize.Location = new System.Drawing.Point(72, 43);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(172, 39);
            this.txtSize.TabIndex = 13;
            // 
            // txtToppings
            // 
            this.txtToppings.Enabled = false;
            this.txtToppings.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToppings.ForeColor = System.Drawing.Color.Lime;
            this.txtToppings.Location = new System.Drawing.Point(12, 128);
            this.txtToppings.Multiline = true;
            this.txtToppings.Name = "txtToppings";
            this.txtToppings.Size = new System.Drawing.Size(348, 58);
            this.txtToppings.TabIndex = 14;
            // 
            // txtCrustType
            // 
            this.txtCrustType.Enabled = false;
            this.txtCrustType.ForeColor = System.Drawing.Color.Lime;
            this.txtCrustType.Location = new System.Drawing.Point(72, 225);
            this.txtCrustType.Name = "txtCrustType";
            this.txtCrustType.Size = new System.Drawing.Size(172, 39);
            this.txtCrustType.TabIndex = 15;
            // 
            // txtWhereToEat
            // 
            this.txtWhereToEat.Enabled = false;
            this.txtWhereToEat.Location = new System.Drawing.Point(81, 309);
            this.txtWhereToEat.Name = "txtWhereToEat";
            this.txtWhereToEat.Size = new System.Drawing.Size(172, 39);
            this.txtWhereToEat.TabIndex = 16;
            // 
            // gpGroupSummary
            // 
            this.gpGroupSummary.BackColor = System.Drawing.Color.Transparent;
            this.gpGroupSummary.Controls.Add(this.txtTotalPrice);
            this.gpGroupSummary.Controls.Add(this.txtWhereToEat);
            this.gpGroupSummary.Controls.Add(this.txtCrustType);
            this.gpGroupSummary.Controls.Add(this.txtToppings);
            this.gpGroupSummary.Controls.Add(this.txtSize);
            this.gpGroupSummary.Controls.Add(this.labTotalPrice);
            this.gpGroupSummary.Controls.Add(this.labWhereToEat);
            this.gpGroupSummary.Controls.Add(this.labSize);
            this.gpGroupSummary.Controls.Add(this.labCrustType);
            this.gpGroupSummary.Controls.Add(this.labToppings);
            this.gpGroupSummary.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpGroupSummary.ForeColor = System.Drawing.Color.Lime;
            this.gpGroupSummary.Location = new System.Drawing.Point(789, 114);
            this.gpGroupSummary.Name = "gpGroupSummary";
            this.gpGroupSummary.Size = new System.Drawing.Size(366, 518);
            this.gpGroupSummary.TabIndex = 11;
            this.gpGroupSummary.TabStop = false;
            this.gpGroupSummary.Text = "Order Summary";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Lime;
            this.txtTotalPrice.Location = new System.Drawing.Point(72, 405);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(172, 107);
            this.txtTotalPrice.TabIndex = 17;
            this.txtTotalPrice.Text = "$ 0";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.Pizza_Photo;
            this.ClientSize = new System.Drawing.Size(1179, 728);
            this.Controls.Add(this.gpGroupSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gpWhereToEat);
            this.Controls.Add(this.gpCrustType);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.gpSize);
            this.Controls.Add(this.labMakePizza);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Name = "frmPizzaOrder";
            this.Text = "My Pizza App 🍕";
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpCrustType.ResumeLayout(false);
            this.gpCrustType.PerformLayout();
            this.gpWhereToEat.ResumeLayout(false);
            this.gpWhereToEat.PerformLayout();
            this.gpGroupSummary.ResumeLayout(false);
            this.gpGroupSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMakePizza;
        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.GroupBox gpCrustType;
        private System.Windows.Forms.GroupBox gpWhereToEat;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtToppings;
        private System.Windows.Forms.TextBox txtCrustType;
        private System.Windows.Forms.TextBox txtWhereToEat;
        private System.Windows.Forms.GroupBox gpGroupSummary;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}

