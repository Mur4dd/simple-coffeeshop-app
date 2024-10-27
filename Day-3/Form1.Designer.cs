namespace Day_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            money = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            price = new Label();
            label3 = new Label();
            label2 = new Label();
            checkoutList = new ListBox();
            americano = new PictureBox();
            hotChocolate = new PictureBox();
            mocha = new PictureBox();
            mojito = new PictureBox();
            latte = new PictureBox();
            espresso = new PictureBox();
            menu = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)americano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotChocolate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mocha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mojito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)latte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)espresso).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(money);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 461);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 415);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 2;
            label4.Text = "Your Money :";
            // 
            // money
            // 
            money.Anchor = AnchorStyles.Bottom;
            money.AutoSize = true;
            money.Location = new Point(136, 415);
            money.Name = "money";
            money.Size = new Size(45, 25);
            money.TabIndex = 1;
            money.Text = "100";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Coffeeshop";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(price);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkoutList);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(607, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 461);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.ForeColor = Color.White;
            button1.Location = new Point(37, 405);
            button1.Name = "button1";
            button1.Size = new Size(106, 44);
            button1.TabIndex = 4;
            button1.Text = "PAY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(90, 368);
            price.Name = "price";
            price.Size = new Size(0, 25);
            price.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 368);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Price :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 9);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "Checkout";
            // 
            // checkoutList
            // 
            checkoutList.FormattingEnabled = true;
            checkoutList.ItemHeight = 25;
            checkoutList.Location = new Point(18, 51);
            checkoutList.Name = "checkoutList";
            checkoutList.Size = new Size(147, 304);
            checkoutList.TabIndex = 0;
            // 
            // americano
            // 
            americano.Image = (Image)resources.GetObject("americano.Image");
            americano.Location = new Point(190, 94);
            americano.Name = "americano";
            americano.Size = new Size(112, 102);
            americano.SizeMode = PictureBoxSizeMode.StretchImage;
            americano.TabIndex = 2;
            americano.TabStop = false;
            americano.Click += americano_Click;
            // 
            // hotChocolate
            // 
            hotChocolate.Image = (Image)resources.GetObject("hotChocolate.Image");
            hotChocolate.Location = new Point(345, 244);
            hotChocolate.Name = "hotChocolate";
            hotChocolate.Size = new Size(111, 115);
            hotChocolate.SizeMode = PictureBoxSizeMode.StretchImage;
            hotChocolate.TabIndex = 3;
            hotChocolate.TabStop = false;
            hotChocolate.Click += hotChocolate_Click;
            // 
            // mocha
            // 
            mocha.Image = (Image)resources.GetObject("mocha.Image");
            mocha.Location = new Point(190, 244);
            mocha.Name = "mocha";
            mocha.Size = new Size(112, 115);
            mocha.SizeMode = PictureBoxSizeMode.StretchImage;
            mocha.TabIndex = 4;
            mocha.TabStop = false;
            mocha.Click += mocha_Click;
            // 
            // mojito
            // 
            mojito.Image = (Image)resources.GetObject("mojito.Image");
            mojito.Location = new Point(498, 244);
            mojito.Name = "mojito";
            mojito.Size = new Size(103, 115);
            mojito.SizeMode = PictureBoxSizeMode.StretchImage;
            mojito.TabIndex = 5;
            mojito.TabStop = false;
            mojito.Click += mojito_Click;
            // 
            // latte
            // 
            latte.Image = (Image)resources.GetObject("latte.Image");
            latte.Location = new Point(498, 94);
            latte.Name = "latte";
            latte.Size = new Size(103, 102);
            latte.SizeMode = PictureBoxSizeMode.StretchImage;
            latte.TabIndex = 6;
            latte.TabStop = false;
            latte.Click += latte_Click;
            // 
            // espresso
            // 
            espresso.Image = (Image)resources.GetObject("espresso.Image");
            espresso.Location = new Point(345, 94);
            espresso.Name = "espresso";
            espresso.Size = new Size(111, 102);
            espresso.SizeMode = PictureBoxSizeMode.StretchImage;
            espresso.TabIndex = 7;
            espresso.TabStop = false;
            espresso.Click += espresso_Click;
            // 
            // menu
            // 
            menu.AutoSize = true;
            menu.Location = new Point(362, 9);
            menu.Name = "menu";
            menu.Size = new Size(69, 25);
            menu.TabIndex = 8;
            menu.Text = "MENU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(menu);
            Controls.Add(espresso);
            Controls.Add(latte);
            Controls.Add(mojito);
            Controls.Add(mocha);
            Controls.Add(hotChocolate);
            Controls.Add(americano);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.OrangeRed;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)americano).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotChocolate).EndInit();
            ((System.ComponentModel.ISupportInitialize)mocha).EndInit();
            ((System.ComponentModel.ISupportInitialize)mojito).EndInit();
            ((System.ComponentModel.ISupportInitialize)latte).EndInit();
            ((System.ComponentModel.ISupportInitialize)espresso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label money;
        private Label label1;
        private PictureBox americano;
        private PictureBox hotChocolate;
        private PictureBox mocha;
        private PictureBox mojito;
        private PictureBox latte;
        private PictureBox espresso;
        private Button button1;
        private Label price;
        private Label label3;
        private Label label2;
        private ListBox checkoutList;
        private Label menu;
        private Label label4;
    }
}
