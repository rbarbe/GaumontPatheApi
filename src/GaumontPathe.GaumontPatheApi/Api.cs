using System;
using System.Net.Http;
using System.Threading.Tasks;
using GaumontPathe.GaumontPatheApi.Models;
using Newtonsoft.Json;

namespace GaumontPathe.GaumontPatheApi
{
    public class Api
    {
        private readonly HttpClient _httpClient;

        public Api()
        {
            if (BaseUri == null)
            {
                BaseUri = new Uri("https://api.cinemasgaumontpathe.com/", UriKind.Absolute);
            }
            _httpClient = new HttpClient {BaseAddress = BaseUri};
        }

        private Uri BaseUri { get; }

        public async Task<FilmCinema> GetFilmCinema(int version)
        {
            var uriStr = $"/film-cinema-reference/{version}";
            var uri = new Uri(uriStr, UriKind.Relative);
            var response = await _httpClient.GetAsync(uri);
            var filmCinemaStr = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FilmCinema>(filmCinemaStr);
        }

        public async Task<SeanceZone> GetSeanceZone(int zone)
        {
            var uri = new Uri($"/seance/1/zone/{zone}", UriKind.Relative);
            var response = await _httpClient.GetAsync(uri);
            var seanceZoneStr = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SeanceZone>(seanceZoneStr);
        }
    }
}