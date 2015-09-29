using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Astuce
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("c")]
        public object C { get; set; }

        [JsonProperty("o")]
        public int O { get; set; }

        [JsonProperty("d")]
        public string D { get; set; }
    }
}