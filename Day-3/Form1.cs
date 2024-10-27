namespace Day_3
{
    public partial class Form1 : Form
    {
        double americano_price = 4.5;
        double espresso_price = 5.5;
        double latte_price = 6;
        double mocha_price = 7.4;
        double hotChocolate_price = 7.5;
        double mojito_price = 8.5;

        double lastPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void americano_Click(object sender, EventArgs e)
        {
            checkoutList.Items.Add("Americano");
            lastPrice += americano_price;
            price.Text = Convert.ToString(lastPrice);
        }

        private void espresso_Click(object sender, EventArgs e)
        {
            checkoutList.Items.Add("Espresso");
            lastPrice += espresso_price;
            price.Text = Convert.ToString(lastPrice);
        }

        private void latte_Click(object sender, EventArgs e)
        {
            checkoutList.Items.Add("Latte");
            lastPrice += latte_price;
            price.Text = Convert.ToString(lastPrice);
        }

        private void mocha_Click(object sender, EventArgs e)
        {
            checkoutList.Items.Add("Mocha");
            lastPrice += mocha_price;
            price.Text = Convert.ToString(lastPrice);
        }

        private void hotChocolate_Click(object sender, EventArgs e)
        {
            checkoutList.Items.Add("Hot Chocolate");
            lastPrice += hotChocolate_price;
            price.Text = Convert.ToString(lastPrice);
        }

        private void mojito_Click(object sender, EventArgs e)
        {
            checkoutList.Items.Add("Mojito");
            lastPrice += mojito_price;
            price.Text = Convert.ToString(lastPrice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastPrice = 0;
            money.Text = Convert.ToString(Convert.ToDouble(money.Text)-Convert.ToDouble(price.Text));
            price.Text = string.Empty;
            checkoutList.Items.Clear();
        }
    }
}
