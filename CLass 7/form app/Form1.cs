namespace Timer_control_and_graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nClicks = Convert.ToInt16(textBox1.Text);
            nClicks = nClicks + 1; // or nClicks++; or nClicks += 1;
            textBox1.Text = Convert.ToString(nClicks);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}