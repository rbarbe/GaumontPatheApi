using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Genre
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("p")]
        public int P { get; set; }
    }
}