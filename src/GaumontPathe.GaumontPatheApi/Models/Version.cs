using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Version
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("v")]
        public bool V { get; set; }

        [JsonProperty("o")]
        public string O { get; set; }

        [JsonProperty("s")]
        public bool S { get; set; }
    }
}