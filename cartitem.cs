using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace foodorderingsystem
{
    public  class cartitem
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public static class SelectedItems
    {
        public static List<cartitem> items = new List<cartitem>();
    }
}
