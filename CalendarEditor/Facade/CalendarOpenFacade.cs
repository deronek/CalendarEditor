using System;
using System.IO;
using System.Windows.Forms;
using CalendarEditor.Adapter;
using CalendarEditor.Properties.Resources;

namespace CalendarEditor.Facade
{
    public class CalendarOpenFacade
    {
        public static MyCalendarEvent OpenCalendar()
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = Strings.OpenFileFilter
            };
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var ext = Path.GetExtension(openFileDialog.FileName);
                var fileContent = File.ReadAllText(openFileDialog.FileName!);

                ICalendarAdapter adapter;
                MyCalendarEvent calendarEvent;

                switch (ext)
                {
                    case ".ics":
                        adapter = new ICalAdapter();
                        calendarEvent = adapter.GetCalendarEvent(fileContent);
                        break;
                    case ".xml":
                        adapter = new XmlAdapter();
                        calendarEvent = adapter.GetCalendarEvent(fileContent);
                        break;
                    case ".json":
                        adapter = new JsonAdapter();
                        calendarEvent = adapter.GetCalendarEvent(fileContent);
                        break;
                    default:
                        throw new FormatException();
                }

                return calendarEvent;
            }

            return null;
        }
    }
}