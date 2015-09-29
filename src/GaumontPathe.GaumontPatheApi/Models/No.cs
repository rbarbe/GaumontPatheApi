using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class No
    {
        [JsonProperty("pr")]
        public Pr Pr { get; set; }

        [JsonProperty("pu")]
        public Pu Pu { get; set; }
    }
}