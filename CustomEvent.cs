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
        public readonly string Name;
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public CustomEvent()
        {

        }

        public CustomEvent(string name, string type, string location, DateTime date, double price)
        {
            this.Name = name;
            this.Type = type;
            this.Location = location;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Type} - {Location} - {Date:yyyy-MM-dd} - {Price}";
        }
    }
}
