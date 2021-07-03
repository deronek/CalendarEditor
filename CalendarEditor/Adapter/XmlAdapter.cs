using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace CalendarEditor.Adapter
{
    public class XmlAdapter : ICalendarAdapter
    {
        public string GetFileContent(MyCalendarEvent myCalendarEvent)
        {
            var serializer = new XmlSerializer(typeof(MyCalendarEvent));
            using var writer = new StringWriter();

            serializer.Serialize(writer, myCalendarEvent);
            return writer.ToString();
        }

        public MyCalendarEvent GetCalendarEvent(string fileContent)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(MyCalendarEvent));
                return (MyCalendarEvent) serializer.Deserialize(new StringReader(fileContent));
            }
            catch (InvalidOperationException e)
            {
                throw new SerializationException("Error while deserializing XML file", e);
            }

        }
    }
}