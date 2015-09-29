using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class Cinema
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sup")]
        public bool IsSup { get; set; }

        [JsonProperty("n")]
        public string Name { get; set; }

        [JsonProperty("r")]
        public string SubName { get; set; }

        // 1 Gaumont, else Pathe
        [JsonProperty("l")]
        public int? Logo { get; set; }

        [JsonProperty("a")]
        public string Address { get; set; }

        [JsonProperty("d")]
        public string Departement { get; set; }

        [JsonProperty("v")]
        public string City { get; set; }

        [JsonProperty("ar")]
        public int? Arrondissement { get; set; }

        [JsonProperty("la")]
        public string Latitude { get; set; }

        [JsonProperty("lo")]
        public string Longitude { get; set; }

        [JsonProperty("ac")]
        public string Access { get; set; }

        [JsonProperty("ra")]
        public string Rates { get; set; }

        [JsonProperty("p")]
        public CinemaPhoto[] CinemaPhotos { get; set; }

        [JsonProperty("pmr")]
        public bool? Accessibility { get; set; }

        [JsonProperty("z")]
        public int? Zone { get; set; }

        // Boolean, true if principal
        [JsonProperty("s")]
        public string Master { get; set; }

        [JsonProperty("m")]
        public int? MasterId { get; set; }

        [JsonProperty("e")]
        public bool? State { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("areg")]
        public string AdressGroup { get; set; }
    }
}