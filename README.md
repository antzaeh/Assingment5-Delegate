# Assingment5-Delegate
Write the following programs in C# language:

Write an application which can be used to handle the information of events. To do this, define class CustomEvent, which has a read only field called name and the following attributes: type, location, date and price. Define necessary constructors, properties and methods for the class.
Define also class CustomEventHandler, which has as attributes a SortedList collection of events and a static attribute called log, which is a StringBuilder object and should be automatically initialized with the current date and time. 
Define necessary constructors and properties as well as a HandleEvent() method, which can receive different methods as arguments. Methods, which can be passed to HandleEvent() could be for instance, the followings:

AddEvent(), which receives event data (name, type, location, date and price) and writes the information to the event collection and writes to the log when new data was added to the collection.
The AddEvent() must return a text message indicating the current number of events in the collection. 

SearchEvent(), which receives event data (name, type, location, date and price) and searches from the collection any event, whose attributes match any of the values passed to the SearchEvent() method and returns the event information as text. 
The SearchEvent() must also write to the log when new data was searched from the collection.

UpdateEvent(), which receives event data (name, type, location, date and price) and searches from the collection any event, whose name matches the passed name and changes the rest of event information to the passed values. 
The UpdateEvent() method must  write to the log when event data was updated and and return the information of the old even as string. 

DeleteEvent(), which receives event data (name, type, location, date and price) and searches from the collection any event, whose attributes match any of the values passed to the DeleteEvent() method and delete the event from the collection. 
The DeleteEvent() must write to the log when data was deleted from the collection and return the information of the deleted event as text. 
