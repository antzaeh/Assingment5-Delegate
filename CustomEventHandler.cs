using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static Assingment5.Program;

namespace Assingment5
{
    
    internal class CustomEventHandler
    {
        static StringBuilder log = new StringBuilder();
        SortedList<string, CustomEvent> events;
        public CustomEventHandler()
        {
            events = new SortedList<string, CustomEvent>();
            log.Append($"Captains log: {DateTime.Now} ");
        }
        public string AddEvent(string name, string type, string location, DateTime date, double price)
        {
            CustomEvent newEvent = new CustomEvent(name, type, location, date, price);
            events[name] = newEvent;
            return $"Event added: {name}. Events in collection: {events.Count}";
        }

        public string SearchEvent(string name, string type, string location, DateTime date, double price)
        {
            foreach (CustomEvent customEvent in events.Values)
            {
                //string result = "Event found: ";
                if (events.Keys.Contains(name))
                {
                    return  $"Event searched: {customEvent}";
                }
            }
            return $"No event was found with name {name}";
        }
        public string UpdateEvent(string name, string type, string location, DateTime date, double price)
        {
            if (events.Keys.Contains(name))
            {
                CustomEvent oldEvent = events[name];
                events[name] = new CustomEvent(name, type, location, date, price);
                return $"Event updated. Old event: {oldEvent}";
            }
            return $"No event was found with name {name}";
        }
        public string DeleteEvent(string name, string type, string location, DateTime date, double price)
        {
            for (int i = 0; i < events.Count; i++)
            {
                if (events.ContainsKey(name))
                {
                    CustomEvent deletedEvent = events[name];
                    events.Remove(name);
                    return $"Event deleted: {deletedEvent}";
                }
            }
            return null;
        }
        public string HandleEvent(HandleEvent handleEvent, string name, string type, string location, DateTime date, double price)
        {

           return handleEvent.Invoke(name,type,location,date,price);
          
        }
        public string DisplayALLEvents()
        {
            StringBuilder all = new StringBuilder();
            foreach (CustomEvent events in events.Values)
            {
                all.Append(events.ToString() + Environment.NewLine);
            }
            return all.ToString();
        }
        public string GetLog()
        {
            return log.ToString();
        }
    }
}

