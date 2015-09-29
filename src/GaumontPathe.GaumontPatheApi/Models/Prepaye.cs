using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Prepaye
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("l")]
        public string L { get; set; }

        [JsonProperty("p")]
        public P3 P { get; set; }

        [JsonProperty("a")]
        public bool A { get; set; }

        [JsonProperty("c")]
        public string[] C { get; set; }

        [JsonProperty("u")]
        public string U { get; set; }

        [JsonProperty("pr")]
        public string Pr { get; set; }

        [JsonProperty("wa")]
        public string Wa { get; set; }

        [JsonProperty("sup")]
        public bool? Sup { get; set; }
    }
}