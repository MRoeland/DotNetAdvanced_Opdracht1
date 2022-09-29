namespace Oefening5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCtoF_Click(object sender, EventArgs e)
        {
            double C = double.Parse(tbCelsius.Text);
            double F = C * 9 / 5 + 32;  
            tbFahrenheit.Text = "°" + F.ToString();
        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            double F = double.Parse(tbFahrenheit.Text);
            double C = (F - 32) * 5 / 9;
            tbCelsius.Text = "°" + C.ToString();
        }
    }
}