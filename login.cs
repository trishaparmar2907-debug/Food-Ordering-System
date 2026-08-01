using System.Drawing.Drawing2D;

namespace foodorderingsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " && textBox2.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else if (textBox1.Text == "system" && textBox2.Text == "password")
            {
                home obj = new home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("please enter the correct username and password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
