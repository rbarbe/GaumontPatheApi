using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Section
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("c")]
        public string C { get; set; }

        [JsonProperty("dborne")]
        public string Dborne { get; set; }
    }
}