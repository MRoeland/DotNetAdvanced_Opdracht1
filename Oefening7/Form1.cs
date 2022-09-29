namespace Oefening7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = int.Parse(tbNumber.Text);
            int totaal = 0;

            for(int i = number; i > 0; i--)
            {
                totaal = totaal+ i;
            }

            tbResult.Text = totaal.ToString();
        }
    }
}