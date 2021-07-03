using Ical.Net;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;

namespace CalendarEditor.Adapter
{
    public class ICalAdapter : ICalendarAdapter
    {
        public string GetFileContent(MyCalendarEvent myCalendarEvent)
        {
            var calendar = new Calendar();

            var iCalEvent = new CalendarEvent
            {
                Summary = myCalendarEvent.Title,
                Description = myCalendarEvent.Message,
                Start = new CalDateTime(myCalendarEvent.Start),
                End = new CalDateTime(myCalendarEvent.End)
            };

            calendar.Events.Add(iCalEvent);

            var serializer = new CalendarSerializer();
            var result = serializer.SerializeToString(calendar);

            return result;
        }

        public MyCalendarEvent GetCalendarEvent(string fileContent)
        {
            var calendar = Calendar.Load(fileContent);
            var calendarEvent = calendar.Events[0];

            var myCalendarEvent = new MyCalendarEvent
            {
                Title = calendarEvent.Summary,
                Message = calendarEvent.Description,
                Start = calendarEvent.Start.Date,
                End = calendarEvent.End.Date
            };

            return myCalendarEvent;
        }
    }
}