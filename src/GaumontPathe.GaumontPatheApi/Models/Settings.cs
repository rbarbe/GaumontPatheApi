using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Settings
    {
        [JsonProperty("tr")]
        public int Tr { get; set; }

        [JsonProperty("sat")]
        public int Sat { get; set; }

        [JsonProperty("sapi")]
        public string Sapi { get; set; }

        [JsonProperty("saf")]
        public int Saf { get; set; }

        [JsonProperty("sad")]
        public bool Sad { get; set; }
    }
}