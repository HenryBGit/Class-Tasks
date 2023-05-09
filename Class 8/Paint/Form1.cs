using System.Drawing;

namespace Paint
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Left += 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Top += 10;
        }
    }
}