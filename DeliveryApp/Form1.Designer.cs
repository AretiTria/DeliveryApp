namespace DeliveryApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            salad = new RadioButton();
            pizza = new RadioButton();
            burger = new RadioButton();
            button1 = new Button();
            btnClear = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            textboxTotal = new TextBox();
            textboxTax = new TextBox();
            textboxInPrice = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(401, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Ingredients (0.70/each)";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 10.8F);
            checkBox3.Location = new Point(41, 135);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(65, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Egg";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += Egg_CheckedChange;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 10.8F);
            checkBox2.Location = new Point(41, 92);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(79, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Mayo";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += Mayo_CHeckedChange;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.8F);
            checkBox1.Location = new Point(41, 49);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "French Fries\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += Fries_CheckedChenged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(salad);
            groupBox2.Controls.Add(pizza);
            groupBox2.Controls.Add(burger);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 194);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // salad
            // 
            salad.AutoSize = true;
            salad.Font = new Font("Segoe UI", 10.8F);
            salad.Location = new Point(36, 135);
            salad.Name = "salad";
            salad.Size = new Size(125, 29);
            salad.TabIndex = 2;
            salad.TabStop = true;
            salad.Text = "Salad (4.5€)";
            salad.UseVisualStyleBackColor = true;
            salad.CheckedChanged += salad_CheckedChanged;
            // 
            // pizza
            // 
            pizza.AutoSize = true;
            pizza.Font = new Font("Segoe UI", 10.8F);
            pizza.Location = new Point(36, 92);
            pizza.Name = "pizza";
            pizza.Size = new Size(117, 29);
            pizza.TabIndex = 1;
            pizza.TabStop = true;
            pizza.Text = "Pizza (10€)";
            pizza.UseVisualStyleBackColor = true;
            pizza.CheckedChanged += pizza_CheckedChanged;
            // 
            // burger
            // 
            burger.AutoSize = true;
            burger.Font = new Font("Segoe UI", 10.8F);
            burger.Location = new Point(36, 49);
            burger.Name = "burger";
            burger.Size = new Size(120, 29);
            burger.TabIndex = 0;
            burger.TabStop = true;
            burger.Text = "Burger (5€)";
            burger.UseVisualStyleBackColor = true;
            burger.CheckedChanged += Burger_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(546, 239);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 3;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOrder_click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(546, 286);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_click;
            // 
            // button3
            // 
            button3.Location = new Point(546, 366);
            button3.Name = "button3";
            button3.Size = new Size(120, 29);
            button3.TabIndex = 5;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnExit_click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textboxTotal);
            groupBox3.Controls.Add(textboxTax);
            groupBox3.Controls.Add(textboxInPrice);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(387, 194);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Total";
            // 
            // textboxTotal
            // 
            textboxTotal.Font = new Font("Segoe UI", 10.2F);
            textboxTotal.Location = new Point(105, 120);
            textboxTotal.Name = "textboxTotal";
            textboxTotal.ReadOnly = true;
            textboxTotal.Size = new Size(125, 30);
            textboxTotal.TabIndex = 5;
            // 
            // textboxTax
            // 
            textboxTax.Font = new Font("Segoe UI", 10.2F);
            textboxTax.Location = new Point(105, 83);
            textboxTax.Name = "textboxTax";
            textboxTax.ReadOnly = true;
            textboxTax.Size = new Size(125, 30);
            textboxTax.TabIndex = 4;
            // 
            // textboxInPrice
            // 
            textboxInPrice.Font = new Font("Segoe UI", 10.2F);
            textboxInPrice.Location = new Point(105, 45);
            textboxInPrice.Name = "textboxInPrice";
            textboxInPrice.ReadOnly = true;
            textboxInPrice.Size = new Size(125, 30);
            textboxInPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 120);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Total Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 83);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Tax 24%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 45);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Initial Price";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 418);
            Controls.Add(groupBox3);
            Controls.Add(button3);
            Controls.Add(btnClear);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private RadioButton salad;
        private RadioButton pizza;
        private RadioButton burger;
        private Button button1;
        private Button btnClear;
        private Button button3;
        private GroupBox groupBox3;
        private TextBox textboxTax;
        private TextBox textboxInPrice;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textboxTotal;
    }
}
