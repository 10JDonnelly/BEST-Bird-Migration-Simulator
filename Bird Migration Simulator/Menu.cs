namespace Bird_Migration_Simulator
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Simulation f2 = new Simulation();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tutorial f3 = new Tutorial();
            f3.ShowDialog();
        }
    }

    public partial class Simulation : Form
    {
        
    }
}