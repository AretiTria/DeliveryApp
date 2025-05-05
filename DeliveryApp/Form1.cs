using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeliveryApp
{
    public partial class Form1 : Form
    {
        Double InPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_click(object sender, EventArgs e)
        {
            textboxInPrice.Clear();
            textboxTax.Clear();
            textboxTotal.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            burger.Checked = false;
            pizza.Checked = false;
            salad.Checked = false;


        }

        private void btnExit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Burger_CheckedChanged(object sender, EventArgs e)
        {
            InPrice = 5;

            textboxInPrice.Text = InPrice.ToString();


        }

        private void pizza_CheckedChanged(object sender, EventArgs e)
        {
            InPrice = 10;

            textboxInPrice.Text = InPrice.ToString();

        }

        private void salad_CheckedChanged(object sender, EventArgs e)
        {
            InPrice = 4.5;

            textboxInPrice.Text = InPrice.ToString();

        }

        private void btnOrder_click(object sender, EventArgs e)
        {
            double Tax = InPrice * 0.24;
            double Total = InPrice + Tax;

            textboxTax.Text = Tax.ToString();
            textboxTotal.Text = (InPrice + Tax).ToString();
        }

        private void Fries_CheckedChenged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                InPrice += 0.70;
            }
            else
            {
                InPrice -= 0.70;
            }

            textboxInPrice.Text = (InPrice).ToString();
        }

        private void Mayo_CHeckedChange(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                InPrice += 0.70;
            }
            else
            {
                InPrice -= 0.70;
            }

            textboxInPrice.Text = (InPrice).ToString();
        }

        private void Egg_CheckedChange(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                InPrice += 0.70;
            }
            else 
            {
                InPrice -= 0.70;
            }

            textboxInPrice.Text = (InPrice).ToString();
        }
    }
}
