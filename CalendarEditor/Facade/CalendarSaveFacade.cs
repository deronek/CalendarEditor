using System.IO;
using System.Runtime.Versioning;
using System.Windows.Forms;
using CalendarEditor.Adapter;
using CalendarEditor.Properties.Resources;

namespace CalendarEditor.Facade
{
    public static class CalendarSaveFacade
    {
        public static void SaveCalendar(MyCalendarEvent myCalendarEvent)
        {
            SaveCalendarIcs(myCalendarEvent);

            SaveCalendarXml(myCalendarEvent);

            SaveCalendarJson(myCalendarEvent);
        }

        public static void SaveCalendarJson(MyCalendarEvent myCalendarEvent)
        {
            ICalendarAdapter adapter = new JsonAdapter();
            var fileContent = adapter.GetFileContent(myCalendarEvent);
            SaveCalendarFile(fileContent, Strings.JsonFilter);
        }

        public static void SaveCalendarXml(MyCalendarEvent myCalendarEvent)
        {
            ICalendarAdapter adapter = new XmlAdapter();
            var fileContent = adapter.GetFileContent(myCalendarEvent);
            SaveCalendarFile(fileContent, Strings.XmlFilter);
        }

        public static void SaveCalendarIcs(MyCalendarEvent myCalendarEvent)
        {
            ICalendarAdapter adapter = new ICalAdapter();
            var fileContent = adapter.GetFileContent(myCalendarEvent);
            SaveCalendarFile(fileContent, Strings.iCalFilter);
        }

        private static void SaveCalendarFile(string fileContent, string filter)
        {
            using var saveFileDialog = new SaveFileDialog
            {
                Filter = filter
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, fileContent);
        }
    }
}