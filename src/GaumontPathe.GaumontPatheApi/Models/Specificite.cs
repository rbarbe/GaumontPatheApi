using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Specificite
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("p")]
        public int P { get; set; }

        [JsonProperty("o")]
        public int O { get; set; }

        [JsonProperty("im")]
        public Im Im { get; set; }
    }
}