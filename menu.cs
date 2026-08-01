using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static foodorderingsystem.selecteditems;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace foodorderingsystem
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearCartTable();

            // Beverages
            if (checkBox1.Checked)
                AddItem("Cold Coffee", 100);

            if (checkBox2.Checked)
                AddItem("Smoothies", 120);

            if (checkBox3.Checked)
                AddItem("Fruit Punch", 150);

            if (checkBox4.Checked)
                AddItem("Berry Blast", 140);

            if (checkBox5.Checked)
                AddItem("Mojito", 130);


            // Mexican
            if (checkBox9.Checked)
                AddItem("Mexican Rice", 180);

            if (checkBox8.Checked)
                AddItem("Tacos", 160);

            if (checkBox7.Checked)
                AddItem("Enchiladas", 200);

            if (checkBox6.Checked)
                AddItem("Elote", 120);

            if (checkBox10.Checked)
                AddItem("Burritos", 190);


            // Italian
            if (checkBox11.Checked)
                AddItem("Veg Lasagna", 220);

            if (checkBox13.Checked)
                AddItem("Alfredo Pasta", 210);

            if (checkBox12.Checked)
                AddItem("Risotto", 230);

            if (checkBox14.Checked)
                AddItem("Cheesy Nachos", 170);

            if (checkBox15.Checked)
                AddItem("Farmhouse Pizza", 280);


            // Chinese
            if (checkBox16.Checked)
                AddItem("Spring Rolls", 140);

            if (checkBox17.Checked)
                AddItem("Chilli Paneer", 200);

            if (checkBox18.Checked)
                AddItem("Veg Manchurian", 180);

            if (checkBox20.Checked)
                AddItem("Hakka Noodles", 170);

            if (checkBox19.Checked)
                AddItem("Fried Rice", 160);


            // Desserts
            if (checkBox21.Checked)
                AddItem("Churros", 150);

            if (checkBox22.Checked)
                AddItem("Tiramisu", 220);

            if (checkBox23.Checked)
                AddItem("Biscoff Cheesecake", 240);

            if (checkBox24.Checked)
                AddItem("Chocolate Brownie", 130);

            if (checkBox25.Checked)
                AddItem("Pancake With Honey", 160);

            MessageBox.Show("Selected items added to cart 😊");

            // clear old items first

            cart obj = new cart();
            obj.Show();
            this.Hide();
        }
        private void AddItem(string Name, decimal price)
        {
            using (OracleConnection conn = new OracleConnection(
        "User Id=system;Password=it4;Data Source=localhost:1521/XE"))
            {
                conn.Open();

                // Check if item already exists
                string checkQuery = "SELECT COUNT(*) FROM CART_ITEMS WHERE ITEM_NAME = :name";
                OracleCommand checkCmd = new OracleCommand(checkQuery, conn);
                checkCmd.Parameters.Add(":name", Name);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    // If exists → increase quantity
                    string updateQuery = "UPDATE CART_ITEMS SET QUANTITY = QUANTITY + 1 WHERE ITEM_NAME = :name";
                    OracleCommand updateCmd = new OracleCommand(updateQuery, conn);
                    updateCmd.Parameters.Add(":name", Name);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    // If not exists → insert new
                    string insertQuery = "INSERT INTO CART_ITEMS (ITEM_NAME, PRICE, QUANTITY) VALUES (:name, :price, 1)";
                    OracleCommand insertCmd = new OracleCommand(insertQuery, conn);
                    insertCmd.Parameters.Add(":name", Name);
                    insertCmd.Parameters.Add(":price", price);
                    insertCmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        private void ClearCartTable()
        {
            using (OracleConnection conn = new OracleConnection(
                "User Id=system;Password=it4;Data Source=localhost:1521/XE"))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("DELETE FROM CART_ITEMS", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home obj = new home();
            obj.Show();
            this.Close();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }

}




