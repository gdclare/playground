using Newtonsoft.Json;

namespace Common.Helpers
{
    public class JsonHelper
    {
        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
