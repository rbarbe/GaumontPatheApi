using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class PasswordRule
    {
        [JsonProperty("c")]
        public string C { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("r")]
        public string R { get; set; }

        [JsonProperty("m")]
        public bool M { get; set; }

        [JsonProperty("o")]
        public int O { get; set; }
    }
}