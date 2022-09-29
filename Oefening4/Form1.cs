namespace Oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalGloves = double.Parse(nudGloves.Value.ToString()) * double.Parse(tbPriceEachGloves.Text);
            tbExtPriceGloves.Text = "€ " + totalGloves.ToString();
            double totalBoots = double.Parse(nudBoots.Value.ToString()) * double.Parse(tbPriceEachBoots.Text);
            tbExtPriceBoots.Text = "€ " + totalBoots.ToString();
            double totalHat = double.Parse(nudHat.Value.ToString()) * double.Parse(tbPriceEachHat.Text);
            tbExtPriceHat.Text = "€ " + totalHat.ToString();
            double totalSkis = double.Parse(nudSkis.Value.ToString()) * double.Parse(tbPriceEachSkis.Text);
            tbExtPriceSkis.Text = "€ " + totalSkis.ToString();

            double subTotal = totalGloves + totalGloves + totalHat + totalSkis;
            subTotal = Math.Round(subTotal, 2);
            tbSubTotal.Text = "€ " + subTotal.ToString();
            double taxes = double.Parse(tbTaxRate.Text);
            double totalTaxes = 0;
            if (taxes <= 0.99)
            {
               totalTaxes  = subTotal * taxes;
            }
            else
            {
                totalTaxes = subTotal / taxes;
            }
            totalTaxes = Math.Round(totalTaxes, 2);

            tbSalesTax.Text = "€ " + totalTaxes.ToString();
            double total = totalTaxes + subTotal;
            total = Math.Round(total, 2);
            tbGrandTotal.Text = "€ " + total.ToString();
        }
    }
}