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
            log.Append($"Captains log: {DateTime.Now} \n");
        }
        public string AddEvent(string name, string type, string location, DateTime date, double price)
        {
            CustomEvent newEvent = new CustomEvent(name, type, location, date, price);
            events.Add(name, newEvent);
            return $"Events in collection: {events.Count}";
        }

        public string SearchEvent(string name, string type, string location, DateTime date, double price)
        {
            foreach (CustomEvent customEvent in events.Values)
            {
                if (customEvent.Name.Equals(name)|| customEvent.Type.Equals(type) || customEvent.Location.Equals(location)
                    || customEvent.Date.Equals(date) || customEvent.Price == price)
                {
                    return $"Event searched: {customEvent}";
                }
            }
            return "";
        }
        public string UpdateEvent(string name, string type, string location, DateTime date, double price)
        {
            if (events.Keys.Contains(name))
            {
                CustomEvent oldEvent = events[name];
                events[name] = new CustomEvent(name, type, location, date, price);
                return $"Event updated. Old event: {oldEvent}";
            }
            return "";
        }
        public string DeleteEvent(string name, string type, string location, DateTime date, double price)
        {
            string result = SearchEvent(name, type, location, date, price);
            if (result.Length != 0)
            {
                
                events.Remove(name);
                return $"Event deleted: {result}";
                    }
 
            return "";
        }

        public string HandleEvent(HandleEvent handleEvent, string name, string type, string location, DateTime date, double price)
        {
            string result = handleEvent.Invoke(name, type, location, date, price);
            log.AppendLine(result);
            return result;
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
        public static string Log
        {
            get
            { 
            return log.ToString();
            }
        }
    }
}

