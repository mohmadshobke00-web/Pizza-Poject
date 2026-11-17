namespace Pizza____Poject
{
    partial class Form1
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
            System.Windows.Forms.Label label1;
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.sdavs = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(242, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(621, 81);
            label1.TabIndex = 2;
            label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(55, 154);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(140, 163);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(34, 130);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(55, 20);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.TabStop = true;
            this.rbLarg.Tag = "40";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Checked = true;
            this.rbMeduim.Location = new System.Drawing.Point(34, 83);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(76, 20);
            this.rbMeduim.TabIndex = 0;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(34, 36);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Location = new System.Drawing.Point(55, 366);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(140, 174);
            this.gbCrustType.TabIndex = 1;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(34, 90);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(94, 20);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(34, 44);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(87, 20);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Location = new System.Drawing.Point(330, 154);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(284, 163);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(124, 129);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(124, 84);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(124, 37);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(6, 129);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 83);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(6, 37);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(101, 20);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(330, 375);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(284, 100);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(114, 39);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rbTakeOut.TabIndex = 2;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(23, 39);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 1;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lbTotalPrice);
            this.gbOrderSummary.Controls.Add(this.label5);
            this.gbOrderSummary.Controls.Add(this.lbWhereToEat);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.lbCrustType);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.lbToppings);
            this.gbOrderSummary.Controls.Add(this.sdavs);
            this.gbOrderSummary.Controls.Add(this.lbSize);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Location = new System.Drawing.Point(732, 154);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(321, 386);
            this.gbOrderSummary.TabIndex = 5;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = " ";
            this.gbOrderSummary.Enter += new System.EventHandler(this.gbOrderSummary_Enter);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(140, 317);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(0, 51);
            this.lbTotalPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Price:";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.Location = new System.Drawing.Point(140, 241);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(0, 18);
            this.lbWhereToEat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Where To Eat:";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(140, 180);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(0, 18);
            this.lbCrustType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Crust Type:";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoEllipsis = true;
            this.lbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(62, 106);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(238, 74);
            this.lbToppings.TabIndex = 3;
            // 
            // sdavs
            // 
            this.sdavs.AutoSize = true;
            this.sdavs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdavs.Location = new System.Drawing.Point(28, 72);
            this.sdavs.Name = "sdavs";
            this.sdavs.Size = new System.Drawing.Size(82, 18);
            this.sdavs.TabIndex = 2;
            this.sdavs.Text = "Toppings:";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(88, 38);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(0, 18);
            this.lbSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "size: ";
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.Location = new System.Drawing.Point(330, 537);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(125, 39);
            this.btOrderPizza.TabIndex = 6;
            this.btOrderPizza.Text = "Order Pizza";
            this.btOrderPizza.UseVisualStyleBackColor = true;
            this.btOrderPizza.Click += new System.EventHandler(this.btOrderPizza_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(label1);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label sdavs;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Button button1;
    }
}

