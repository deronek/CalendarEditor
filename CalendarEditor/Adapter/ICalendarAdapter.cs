namespace CalendarEditor.Adapter
{
    public interface ICalendarAdapter
    {
        string GetFileContent(MyCalendarEvent myCalendarEvent);
        MyCalendarEvent GetCalendarEvent(string fileContent);
    }
}