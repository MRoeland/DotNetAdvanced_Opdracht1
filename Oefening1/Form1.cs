namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String title = "Begroeting";
            String name = Environment.UserName;
            String tijd = DateTime.Now.ToShortTimeString();
            String datum = DateTime.Now.ToShortDateString();

            MessageBox.Show("Hello " + name + ". Het is " + tijd + "u op " + datum + ".", title);
        }
    }
}