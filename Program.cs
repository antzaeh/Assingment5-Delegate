using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Assingment5
{
    internal class Program
    {
        
        static void Main()
        {
            Console.WriteLine("123");
            CustomEventHandler handler = new CustomEventHandler();
            HandleEvent add, search, update, delete;
            add = new HandleEvent(handler.AddEvent);
            Console.WriteLine(handler.HandleEvent(add, "Event1", "Sport", "HallA", new DateTime(2001, 1, 1), 73.00));
            Console.WriteLine(handler.HandleEvent(add, "Event2", "Music", "HallB", new DateTime(2022, 2, 2), 69.00));
            Console.WriteLine(handler.HandleEvent(add, "Event3", "Other", "HallC", new DateTime(2033, 3, 3), 420.00));
            Console.WriteLine(handler.HandleEvent(add, "Event4", "Gaming", "HallD", new DateTime(2044, 4, 4), 13.00));

            Console.WriteLine("Display all events");
            Console.WriteLine(handler.DisplayALLEvents());

            Console.WriteLine("Search event Event1, Music and HallD");
            search = new HandleEvent(handler.SearchEvent);
            Console.WriteLine(handler.HandleEvent(search, "Event1", null, null, default, default));
            Console.WriteLine(handler.HandleEvent(search, null, "Music", null, default, default));
            Console.WriteLine(handler.HandleEvent(search, null, null, "HallD", default, default));

            Console.WriteLine("Update Event1 and Event3");
            update = new HandleEvent(handler.UpdateEvent);
            Console.WriteLine(handler.HandleEvent(update,"Event1", "PARTY", "HallXD", new DateTime(2055, 5, 5), 42.00));            
            Console.WriteLine(handler.HandleEvent(update, "Event3", "Other", "Galaxy far far away", new DateTime(2033, 3, 3), 420.00));

            Console.WriteLine("Delete Event2");
            delete = new HandleEvent(handler.DeleteEvent);
            Console.WriteLine(handler.HandleEvent(delete, "Event2", default, default, default, default));
       

            Console.WriteLine("Updated list");
            Console.WriteLine("\n"+ CustomEventHandler.Log);
            
            
        }
    }
}
