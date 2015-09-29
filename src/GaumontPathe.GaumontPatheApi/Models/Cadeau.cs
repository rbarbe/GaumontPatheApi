using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Cadeau
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("nbp")]
        public string Nbp { get; set; }

        [JsonProperty("p")]
        public P2 P { get; set; }

        [JsonProperty("cf")]
        public bool Cf { get; set; }

        [JsonProperty("masc")]
        public bool Masc { get; set; }
    }
}