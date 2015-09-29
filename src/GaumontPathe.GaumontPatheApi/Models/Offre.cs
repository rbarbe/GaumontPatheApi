using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Offre
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("c")]
        public int C { get; set; }

        [JsonProperty("o")]
        public int O { get; set; }

        [JsonProperty("i")]
        public I I { get; set; }

        [JsonProperty("te")]
        public string Te { get; set; }

        [JsonProperty("d")]
        public string D { get; set; }

        [JsonProperty("dd")]
        public object Dd { get; set; }

        [JsonProperty("df")]
        public object Df { get; set; }

        [JsonProperty("sup")]
        public bool? Sup { get; set; }
    }
}