using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CalendarEditor.Adapter
{
    public class JsonAdapter : ICalendarAdapter
    {
        public string GetFileContent(MyCalendarEvent myCalendarEvent)
        {
            return JsonConvert.SerializeObject(myCalendarEvent, Formatting.Indented);
        }

        public MyCalendarEvent GetCalendarEvent(string fileContent)
        {
            try
            {
                return JsonConvert.DeserializeObject<MyCalendarEvent>(fileContent);
            }
            catch (JsonReaderException e)
            {
                throw new SerializationException("Error while deserializing JSON file", e);
            }
        }
    }
}