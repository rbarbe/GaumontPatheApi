using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Im
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("mdpi")]
        public string Mdpi { get; set; }

        [JsonProperty("hdpi")]
        public string Hdpi { get; set; }

        [JsonProperty("xhdpi")]
        public string Xhdpi { get; set; }

        [JsonProperty("xxhdpi")]
        public string Xxhdpi { get; set; }
    }
}