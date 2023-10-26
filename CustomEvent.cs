using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment5
{
    internal class CustomEvent
    {
        readonly string name;
        string type { get; set; }
        string location { get; set; }
        DateTime date { get; set; }
        double price { get; set; }

        public CustomEvent()
        {

        }
 
        public CustomEvent(string name, string type, string location, DateTime date, double price)
        {
            this.name = name;
            this.type = type;
            this.location = location;
            this.date = date;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{name} - {type} - {location} - {date:yyyy-MM-dd} - {price}";
        }
    }
}
