using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment5
{
    internal class Program
    {
        public delegate string HandleEvent(string name, string type, string location, DateTime date, double price);
        static void Main()
        {
            CustomEventHandler handler = new CustomEventHandler();
            HandleEvent add, search, update, delete;
            add = new HandleEvent(handler.AddEvent);
            Console.WriteLine(handler.GetLog() + handler.HandleEvent(add, "Event1", "Sport", "HallA", new DateTime(2001, 1, 1), 73.00));
            Console.WriteLine(handler.GetLog() + handler.HandleEvent(add, "Event2", "Music", "HallB", new DateTime(2022, 2, 2), 69.00));
            Console.WriteLine(handler.GetLog() + handler.HandleEvent(add, "Event3", "Other", "HallC", new DateTime(2033, 3, 3), 420.00));

            Console.WriteLine("Display all events");
            Console.WriteLine(handler.DisplayALLEvents());

            Console.WriteLine("Search event Event1");
            search = new HandleEvent(handler.SearchEvent);
            Console.WriteLine(handler.GetLog() + handler.HandleEvent(search, "Event1", "Sport", "HallA", new DateTime(2001, 1, 1), 73.00));
            Console.WriteLine(handler.GetLog() + handler.HandleEvent(search, "Event5", "PARTY", "HallXD", new DateTime(2055, 5, 5), 42.00));

            Console.WriteLine("Update Event1");
            update = new HandleEvent(handler.UpdateEvent);
            Console.WriteLine(handler.GetLog() + handler.HandleEvent(update,"Event1", "PARTY", "HallXD", new DateTime(2055, 5, 5), 42.00));
            Console.WriteLine(handler.GetLog() + handler.HandleEvent(update, "Event5", "PARTY", "HallXD", new DateTime(2055, 5, 5), 42.00));

            Console.WriteLine("Delete Event2");
            delete = new HandleEvent(handler.DeleteEvent);
            Console.WriteLine(handler.GetLog() + handler.HandleEvent(delete, "Event2", "Music", "HallB", new DateTime(2022, 2, 2), 69.00));
           
            Console.WriteLine("Updated list");
            Console.WriteLine(handler.GetLog()+"\n"+ handler.DisplayALLEvents());
            
        }
    }
}
