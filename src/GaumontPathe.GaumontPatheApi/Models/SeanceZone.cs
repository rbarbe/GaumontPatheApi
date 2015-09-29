using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class SeanceZone
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("seances")]
        public Seance[] Seances { get; set; }
    }
}