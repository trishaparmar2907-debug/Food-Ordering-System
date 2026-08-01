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
    public partial class thankyou : Form
    {
        public thankyou()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            feedback obj = new feedback(this);
            obj.ShowDialog();
            this.Close();
        }

        private void thankyou_Load(object sender, EventArgs e)
        {

        }
    }
}
