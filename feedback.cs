using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodorderingsystem
{
    public partial class feedback : Form
    {
        Form previousForm;

        public feedback(Form form)
        {
            InitializeComponent();

            //label1.Text = userName;
            // label2.Text = date;
            previousForm = form;
        }

        //public feedback()
        //{
        //    InitializeComponent();
        //}

        private void feedback_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rating = "";

            // Check which rating is selected
            if (radioButton1.Checked)
                rating = "1 Star";
            else if (radioButton2.Checked)
                rating = "2 Star";
            else if (radioButton3.Checked)
                rating = "3 Star";
            else if (radioButton4.Checked)
                rating = "4 Star";
            else if (radioButton5.Checked)
                rating = "5 Star";
            else
            {
                MessageBox.Show("Please select a rating!");
                return;
            }

            string recommend = checkBox1.Checked ? "Yes" : "No";

            string message =
                "⭐ Thank You For Your Feedback! ⭐\n\n" +
                "Rating Given: " + rating + "\n" +
                "Recommend: " + recommend + "\n\n" +
                "We appreciate your response 😊";

            MessageBox.Show(message);

            // Close application or go back
            // Application.Exit(); // or this.Close();
            thankyou ty = new thankyou();
            ty.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //payment obj = new payment();
            //obj.Show();
            previousForm.Show();
            this.Hide();
        }
    }
}

