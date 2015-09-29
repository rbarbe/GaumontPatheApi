using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Hor
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sup")]
        public bool Sup { get; set; }

        [JsonProperty("s")]
        public bool? S { get; set; }

        [JsonProperty("d")]
        public string D { get; set; }

        [JsonProperty("l")]
        public bool? L { get; set; }

        [JsonProperty("sp")]
        public string[] Sp { get; set; }

        [JsonProperty("np")]
        public bool? Np { get; set; }
    }
}