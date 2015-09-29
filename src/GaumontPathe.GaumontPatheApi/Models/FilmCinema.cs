using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi.Models
{
    public class FilmCinema
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("cinemas")]
        public Cinema[] Cinemas { get; set; }

        [JsonProperty("films")]
        public Film[] Films { get; set; }

        [JsonProperty("genresParent")]
        public GenresParent[] GenresParent { get; set; }

        [JsonProperty("genres")]
        public Genre[] Genres { get; set; }

        [JsonProperty("profilGenres")]
        public ProfilGenre[] ProfilGenres { get; set; }

        [JsonProperty("section")]
        public Section[] Section { get; set; }

        [JsonProperty("loisirs")]
        public Loisir[] Loisirs { get; set; }

        [JsonProperty("payss")]
        public Payss[] Payss { get; set; }

        [JsonProperty("cadeaux")]
        public Cadeau[] Cadeaux { get; set; }

        [JsonProperty("versions")]
        public Version[] Versions { get; set; }

        [JsonProperty("labels")]
        public Label[] Labels { get; set; }

        [JsonProperty("specificites")]
        public Specificite[] Specificites { get; set; }

        [JsonProperty("classifications")]
        public Classification[] Classifications { get; set; }

        [JsonProperty("prepayes")]
        public Prepaye[] Prepayes { get; set; }

        [JsonProperty("offreCategories")]
        public OffreCategory[] OffreCategories { get; set; }

        [JsonProperty("offres")]
        public Offre[] Offres { get; set; }

        [JsonProperty("astuceCategories")]
        public object[] AstuceCategories { get; set; }

        [JsonProperty("astuces")]
        public Astuce[] Astuces { get; set; }

        [JsonProperty("magazine")]
        public Magazine Magazine { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("passwordRules")]
        public PasswordRule[] PasswordRules { get; set; }

        [JsonProperty("partageFacebook")]
        public PartageFacebook PartageFacebook { get; set; }
    }
}