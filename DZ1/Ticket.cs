using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class Ticket
    {
        internal int Price { set; get; }
        internal string Availability { set; get; }
        
        internal Ticket(int price)
        {
            Price = price;
            Availability = "Available";
        }
    }

}
