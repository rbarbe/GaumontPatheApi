using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Loisir
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }
    }
}