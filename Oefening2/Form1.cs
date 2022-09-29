namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int getal1 = int.Parse(lblGetal1.Text);
            int getal2 = int.Parse(lblGetal2.Text);
            int getal3 = int.Parse(lblGetal3.Text);
            int getal4 = int.Parse(lblGetal4.Text);

            int product1 = getal1 * getal2;
            int product2 = getal3 * getal4;

            lblResult1.Text = product1.ToString();
            lblResult2.Text = product2.ToString();

            bool vergelijking = product1 > product2;
            lblResult3.Text = vergelijking.ToString();
        }
    }
}