namespace Oefening6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalStardust = double.Parse(tbPriceEachStardust.Text) * double.Parse(tbQuantityStardust.Text);
            tbPriceStardust.Text = "€ " + totalStardust.ToString();
            double totalNation = double.Parse(tbPriceEachNation.Text) * double.Parse(tbQuantityNation.Text);
            tbPriceNation.Text = "€ " + totalNation.ToString();
            double totalTeddy = double.Parse(tbPriceEachTeddy.Text) * double.Parse(tbQuantityTeddy.Text);
            tbPriceTeddy.Text = "€ " + totalTeddy.ToString();
            double totalJuggling = double.Parse(tbPriceEachJuggling.Text) * double.Parse(tbQuantityJuggling.Text);
            tbPriceJuggling.Text = "€ " + totalJuggling.ToString();

            double subTotal = totalStardust + totalNation + totalTeddy + totalJuggling;
            subTotal = Math.Round(subTotal, 2);
            tbSubTotal.Text = subTotal.ToString();

            double taxesToPay = subTotal / 7;
            taxesToPay = Math.Round(taxesToPay, 2);
            tbSalesTax.Text = taxesToPay.ToString();

            double shipping = 0;
            if(subTotal < 20)
            {
                shipping = 5;
            }
            else if(subTotal < 50)
            {
                shipping = 7.5;
            }
            else if (subTotal < 75)
            {
                shipping = 10;
            }
            else if (subTotal >= 75)
            {
                shipping = 0;
            }
            else
            {
                shipping = 0;
            }
            tbShipping.Text = shipping.ToString();

            double grandTotal = subTotal + taxesToPay + shipping;
            grandTotal = Math.Round(grandTotal, 2);
            tbGrandTotal.Text = grandTotal.ToString();
        }
    }
}