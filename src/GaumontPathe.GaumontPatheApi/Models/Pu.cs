using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Pu
    {
        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("nb")]
        public int Nb { get; set; }
    }
}