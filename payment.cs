using Oracle.ManagedDataAccess.Client;
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
    public partial class payment : Form
    {
        decimal grandtotal;
        public payment(decimal total)
        {
            InitializeComponent();
            grandtotal = total;
        }
        public payment()
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {
            texttotal.Text = grandtotal.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
                        textBox2.Text == "" ||
                        textBox3.Text == "" ||
                        textBox4.Text == "" ||
                        texttotal.Text == "")
            {
                MessageBox.Show("Please fill all details!");
                return;
            }

            // 2️⃣ Check payment method
            string paymentMethod = "";

            if (radioButton1.Checked)
            {
                paymentMethod = "Cash on Delivery";
            }
            else if (radioButton2.Checked)
            {
                paymentMethod = "Online Payment";
            }
            else
            {
                MessageBox.Show("Please select a payment method!");
                return;
            }

            // 3️⃣ Save into database
            string conStr = "User Id=system;Password=it4;Data Source=localhost:1521/XE";
            OracleConnection conn = new OracleConnection(conStr);

            try
            {
                conn.Open();

                string query = "INSERT INTO ORDERS " +
                               "(USER_NAME, ADDRESS, EMAIL, CONTACT_NO, GRAND_TOTAL, ORDER_DATE, PAYMENT_METHOD) " +
                               "VALUES (:name, :address, :email, :contact, :total, :odate, :method)";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":name", textBox1.Text);
                cmd.Parameters.Add(":address", textBox2.Text);
                cmd.Parameters.Add(":email", textBox3.Text);
                cmd.Parameters.Add(":contact", textBox4.Text);
                cmd.Parameters.Add(":total", Convert.ToDecimal(texttotal.Text));
                cmd.Parameters.Add(":odate", dateTimePicker1.Value);
                cmd.Parameters.Add(":method", paymentMethod);

                cmd.ExecuteNonQuery();

                conn.Close();

                // 4️⃣ IF CASH ON DELIVERY
                if (radioButton1.Checked)
                {
                    string receipt =
                        //"----- BILL RECEIPT -----\n\n" +
                        //"Name: " + txtUserName.Text + "\n" +
                        //"Total: ₹" + txtGrandTotal.Text + "\n" +
                        //"Payment: Cash on Delivery\n" +
                        //"Date: " + dateTimePicker1.Value.ToShortDateString() +
                        //"\n\nThank You for Your Order!";
                        "============================\n" +
                        "        FOOD ORDER RECEIPT\n" +
                        "============================\n" +
                        "Customer: " + textBox1.Text + "\n" +
                        "Total Amount: ₹" + texttotal.Text + "\n" +
                        "Payment Mode: Cash on Delivery\n" +
                         "Order Date: " + dateTimePicker1.Value.ToShortDateString() + "\n" +
                         "============================\n" +
                        "   Thank You! Visit Again\n" +
                         "============================";

                    MessageBox.Show(receipt);

                    // Open Feedback Form
                    feedback fb = new feedback(this);
                    fb.Show();

                    this.Hide();
                }

                // 5️⃣ IF ONLINE PAYMENT
                else if (radioButton2.Checked)
                {
                    //onlinepayment online = new onlinepayment();
                    //online.Show();

                    //this.Hide();

                    onlinepayment online = new onlinepayment(
                      textBox1.Text,
                      texttotal.Text
);

                    online.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            texttotal.Clear();

            // Reset Date
            dateTimePicker1.Value = DateTime.Now;

            // Uncheck Radio Buttons
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // Optional: Set focus back to first field
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cart obj = new cart();
            obj.Show();
            this.Close();
        }
    }




}

