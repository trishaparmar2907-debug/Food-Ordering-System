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


    public partial class onlinepayment : Form
    {
        string username;
        string totalamount;

        public onlinepayment(string userName, string totalAmount)
        {
            //InitializeComponent();

            //label1.Text = userName;
            //label2.Text = "₹ " + totalAmount;
            InitializeComponent();

            username = userName;
            totalamount = totalAmount;

            label1.Text = userName;
            label2.Text = "₹ " + totalAmount;
        }

        public onlinepayment()
        {
            InitializeComponent();
        }

        private void onlinepayment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    if (textBox1.Text == "" ||
            //textBox2.Text == "" ||
            //textBox3.Text == "" ||
            //textBox4.Text == "")
            //    {
            //        MessageBox.Show("Please fill all bank details!");
            //        return;
            //    }

            //    MessageBox.Show("Payment Successful! 🎉");

            //    // Open Feedback Form
            //    feedback fb = new feedback();
            //    fb.Show();

            //    this.Close();
            if (textBox1.Text == "" ||
            textBox2.Text == "" ||
            textBox3.Text == "" ||
            textBox4.Text == "")
            {
                MessageBox.Show("Please fill all bank details!");
                return;
            }

            // Create Bill Receipt
            string receipt =
                "============================\n" +
                "        FOOD ORDER RECEIPT\n" +
                "============================\n" +
                "Customer: " + username + "\n" +
                "Total Amount: ₹" + totalamount + "\n" +
                "Payment Mode: Online Payment\n" +
                "Bank Name: " + textBox1.Text + "\n" +
                "============================\n" +
                "   Payment Successful 🎉\n" +
                "============================";

            MessageBox.Show(receipt);

            // Open Feedback Form
            feedback fb = new feedback(this);
            fb.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            payment obj = new payment();
            obj.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            textBox1.Focus();
        }
    }
}
