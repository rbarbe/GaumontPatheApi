using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Film
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("ba")]
        public string Ba { get; set; }

        [JsonProperty("c")]
        public string C { get; set; }

        [JsonProperty("l")]
        public string L { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("lk")]
        public string Lk { get; set; }

        [JsonProperty("a")]
        public A A { get; set; }

        [JsonProperty("e")]
        public int E { get; set; }

        [JsonProperty("s")]
        public string S { get; set; }

        [JsonProperty("pr")]
        public string Pr { get; set; }

        [JsonProperty("ca")]
        public string Ca { get; set; }

        [JsonProperty("d")]
        public string D { get; set; }

        [JsonProperty("sy")]
        public string Sy { get; set; }

        [JsonProperty("fl")]
        public int Fl { get; set; }

        [JsonProperty("no")]
        public No No { get; set; }

        [JsonProperty("g")]
        public int[] G { get; set; }

        [JsonProperty("nc")]
        public int Nc { get; set; }
    }
}