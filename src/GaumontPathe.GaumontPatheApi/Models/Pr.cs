using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Pr
    {
        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("nb")]
        public int Nb { get; set; }
    }
}