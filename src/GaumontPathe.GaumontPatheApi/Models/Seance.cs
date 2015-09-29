using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Seance
    {
        [JsonProperty("u")]
        public string U { get; set; }

        [JsonProperty("f")]
        public int F { get; set; }

        [JsonProperty("c")]
        public int C { get; set; }

        [JsonProperty("v")]
        public int V { get; set; }

        [JsonProperty("o")]
        public int O { get; set; }

        [JsonProperty("a")]
        public int A { get; set; }

        [JsonProperty("h")]
        public bool H { get; set; }

        [JsonProperty("sm")]
        public bool Sm { get; set; }

        [JsonProperty("fl")]
        public string Fl { get; set; }

        [JsonProperty("vf")]
        public bool Vf { get; set; }

        [JsonProperty("hor")]
        public Hor[] Hor { get; set; }
    }
}