using Newtonsoft.Json;

namespace TestPushNotifications.Models
{
    public class GoogleNotification
    {
        public class DataPayLoad
        {
            [JsonProperty("title")]
            public string Title { get; set; }
            [JsonProperty("body")]
            public string Body { get; set; }
        }
        [JsonProperty("Priority")]
        public string Priority { get; set; } = "high";
        [JsonProperty("data")]
        public DataPayLoad Data { get; set; }
        [JsonProperty("notification")]
        public DataPayLoad Notification { get; set; }
    }
}
