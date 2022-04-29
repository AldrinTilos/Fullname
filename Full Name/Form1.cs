namespace Full_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hello Aldrin Geogangco Tilos", "Caption", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("You clicked Yes!");
            }
            else
            {
                MessageBox.Show("You clicked No!");
            }
        }

        private void button2_ClickAldrin(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += ("Aldrin");
        }

        private void button3_ClickTilos(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += ("Tilos");
        }

        private void button4_ClickGeogangco(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += ("Geogangco");
        }
    }
}