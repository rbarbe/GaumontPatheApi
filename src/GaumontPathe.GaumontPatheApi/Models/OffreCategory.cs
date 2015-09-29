using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class OffreCategory
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("l")]
        public string L { get; set; }

        [JsonProperty("o")]
        public int O { get; set; }
    }
}