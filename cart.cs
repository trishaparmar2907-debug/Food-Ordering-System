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
using static foodorderingsystem.selecteditems;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace foodorderingsystem
{
    public partial class cart : Form
    {
        OracleConnection conn;
        string str = "User Id=system;Password=it4;Data Source=localhost:1521/XE";
        public cart()
        {
            InitializeComponent();
            conn = new OracleConnection(str);

        }

        private void cart_Load(object sender, EventArgs e)
        {

            LoadCartData();



        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row.Cells["price"].Value != null &&
                row.Cells["quantity"].Value != null)
            {
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                int qty = Convert.ToInt32(row.Cells["quantity"].Value);

                if (!dataGridView1.Columns.Contains("Total"))
                {
                    dataGridView1.Columns.Add("Total", "Total");
                }

                row.Cells["Total"].Value = price * qty;
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }



        private void LoadCartData()
        {

            //try
            //{
            //    conn.Open();

            //    OracleDataAdapter da = new OracleDataAdapter(
            //        "SELECT ITEM_NAME as name, PRICE as price, QUANTITY as quantity FROM CART_ITEMS",
            //        conn);

            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    dataGridView1.DataSource = dt;

            //    dataGridView1.Columns["name"].ReadOnly = true;
            //    dataGridView1.Columns["price"].ReadOnly = true;
            //    dataGridView1.Columns["quantity"].ReadOnly = false;

            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    conn.Close();
            //}
            try
             {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string query = @"SELECT 
                         ITEM_NAME AS name,
                         PRICE AS price,
                         QUANTITY AS quantity,
                         (PRICE * QUANTITY) AS total
                         FROM CART_ITEMS";

                OracleDataAdapter da = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;

                // Optional: make columns neat
                dataGridView1.Columns["name"].ReadOnly = true;
                dataGridView1.Columns["price"].ReadOnly = true;
                dataGridView1.Columns["quantity"].ReadOnly = false;
                dataGridView1.Columns["total"].ReadOnly = true;

                // 🔥 Calculate Grand Total
                decimal grandTotal = 0;

                foreach (DataRow row in dt.Rows)
                {
                    grandTotal += Convert.ToDecimal(row["total"]);
                }

                textBox3.Text = grandTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.CurrentRow == null) return;

            //try
            //{
            //    //string itemName = dataGridView1.CurrentRow.Cells["name"].Value.ToString();

            //    // 🔥 TAKE VALUE FROM TEXTBOX
            //    string itemName = textBox1.Text.Trim();
            //    int quantity = Convert.ToInt32(textBox2.Text);

            //    conn.Open();

            //    string query = "UPDATE CART_ITEMS SET QUANTITY = :qty WHERE ITEM_NAME = :name";

            //    OracleCommand cmd = new OracleCommand(query, conn);
            //    cmd.BindByName = true;

            //    cmd.Parameters.Add(":qty", OracleDbType.Int32).Value = quantity;
            //    cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = itemName;

            //    cmd.ExecuteNonQuery();
            //    conn.Close();

            //    // 🔥 UPDATE GRID ALSO
            //    dataGridView1.CurrentRow.Cells["quantity"].Value = quantity;

            //    MessageBox.Show("Quantity updated successfully!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    if (conn.State == ConnectionState.Open)
            //        conn.Close();
            //}
            //try
            //{
            //    conn.Open();

            //    string query = "UPDATE CART_ITEMS SET QUANTITY = :qty WHERE ITEM_NAME = :name";

            //    OracleCommand cmd = new OracleCommand(query, conn);
            //    cmd.Parameters.Add(":qty", textBox2.Text);
            //    cmd.Parameters.Add(":name", textBox1.Text);

            //    cmd.ExecuteNonQuery();

            //    conn.Close();

            //    // 🔥 VERY IMPORTANT
            //    LoadCartData();   // reloads grid + recalculates grand total

            //    MessageBox.Show("Quantity Updated Successfully");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    conn.Close();
            //}
            //try
            //{
            //    conn.Open();

            //    int newQty;

            //    if (!int.TryParse(textBox2.Text, out newQty))
            //    {
            //        MessageBox.Show("Enter valid quantity!");
            //        return;
            //    }

            //    string query = @"UPDATE CART_ITEMS 
            //         SET QUANTITY = :qty,
            //             TOTAL = PRICE * :qty
            //         WHERE ITEM_NAME = :name";

            //    OracleCommand cmd = new OracleCommand(query, conn);

            //    cmd.Parameters.Add(":qty", newQty);
            //    cmd.Parameters.Add(":name", textBox1.Text);

            //    cmd.ExecuteNonQuery();

            //    conn.Close();

            //    LoadCartData();   // reload grid + grand total

            //    MessageBox.Show("Quantity Updated Successfully 😊");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    conn.Close();
            //}
            //int newQty;

            //if (!int.TryParse(textBox2.Text, out newQty))
            //{
            //    MessageBox.Show("Enter valid quantity!");
            //    return;
            //}

            //try
            //{

            //   // int newQty;
            //    if (conn.State != ConnectionState.Open)
            //        conn.Open();

            //    string query = @"UPDATE CART_ITEMS 
            //             SET QUANTITY = :qty
            //             WHERE ITEM_NAME = :name";

            //    using (OracleCommand cmd = new OracleCommand(query, conn))
            //    {
            //        cmd.Parameters.Add(":qty", OracleDbType.Int32).Value = newQty;
            //        cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = textBox1.Text;

            //        cmd.ExecuteNonQuery();
            //    }

            //    MessageBox.Show("Quantity Updated Successfully 😊");

            //    LoadCartData();   // reload grid

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (conn.State == ConnectionState.Open)
            //        conn.Close();
            //}
            //MessageBox.Show("Textbox value is: '" + textBox2.Text + "'");

            //int newQty;

            //if (!int.TryParse(textBox2.Text.Trim(), out newQty))
            //{
            //    MessageBox.Show("Enter valid quantity!");
            //    return;
            //}


            // int newQty;

            // string qtyText = textBox2.Text.Trim();  // 🔥 Remove spaces
            // //MessageBox.Show("Value = '" + qtyText + "'");
            //// MessageBox.Show("Textbox2 contains: " + textBox2.Text);


            // if (!int.TryParse(qtyText, out newQty))
            // {
            //     MessageBox.Show("Enter valid quantity (numbers only)!");
            //     return;
            // }

            // if (newQty <= 0)
            // {
            //     MessageBox.Show("Quantity must be greater than 0!");
            //     return;
            // }

            // if (newQty <= 0)
            // {
            //     MessageBox.Show("Quantity must be greater than 0!");
            //     return;
            // }
            //    int newQty;

            //    string qtyText = textBox2.Text.Trim();

            //    if (!int.TryParse(qtyText, out newQty))
            //    {
            //        MessageBox.Show("Enter valid quantity (numbers only)!");
            //        return;
            //    }
            //    try
            //    {
            //        conn.Open();

            //        string query = "UPDATE CART_ITEMS SET ITEM_NAME = :name WHERE QUANTITY = :qty";

            //        OracleCommand cmd = new OracleCommand(query, conn);
            //        cmd.Parameters.Add(":qty", newQty);
            //        cmd.Parameters.Add(":name", textBox1.Text);

            //        cmd.ExecuteNonQuery();

            //        MessageBox.Show("Updated Successfully");

            //        LoadCartData();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }

            //}
            //if (dataGridView1.CurrentRow == null)
            //{
            //    MessageBox.Show("Please select a row first.");
            //    return;
            //}
//            MessageBox.Show(
//           "Textbox2 raw value = [" + textBox2.Text + "]\n" +
//           "Length = " + textBox2.Text.Length
//);

            int newQty;

            if (!int.TryParse(textBox2.Text.Trim(), out newQty))
            {
                MessageBox.Show("Enter valid quantity!");
                return;
            }

            if (newQty <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0!");
                return;
            }

            string itemName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            // Column 0 = Elote (we confirmed)



            try
            {
                using (OracleConnection conn = new OracleConnection(str))
                {
                    conn.Open();

                    string query = "UPDATE CART_ITEMS SET QUANTITY = :qty WHERE ITEM_NAME = :name";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(":qty", newQty);
                        cmd.Parameters.Add(":name", itemName);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Quantity Updated Successfully ✅");

                LoadCartData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["ITEM_NAME"].Value.ToString();
        //        textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString();
        //    }
        //if (e.RowIndex >= 0)
        //{
        //    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            //    // Convert properly to integer
            //    decimal qtyDecimal = Convert.ToDecimal(
            //        dataGridView1.Rows[e.RowIndex].Cells[2].Value);

            //    textBox2.Text = Convert.ToInt32(qtyDecimal).ToString();
            //}
            //if (e.RowIndex >= 0)
            //{
            //    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            //    textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            //}
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            //    textBox1.Text = row.Cells["ITEM_NAME"].Value.ToString();
            //    textBox2.Text = row.Cells["QUANTITY"].Value.ToString();
            //}
            //if (dataGridView1.CurrentRow != null)
            //{
            //    for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //    {
            //        MessageBox.Show("Column " + i + " = " +
            //            dataGridView1.CurrentRow.Cells[i].Value.ToString());
            //    }
            //}
            //if (dataGridView1.CurrentRow != null)
            //{
            //    textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();  // Item Name
            //    textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();  // Quantity
            //}

            //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                string itemName = dataGridView1.CurrentRow.Cells["name"].Value.ToString();

                conn.Open();

                string query = "DELETE FROM CART_ITEMS WHERE ITEM_NAME = :name";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":name", itemName);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();

                LoadCartData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu obj = new menu();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(textBox3.Text.Replace("Grand Total: ₹ ", ""));

            payment pay = new payment(total);
            pay.Show();
        }
    }
}








