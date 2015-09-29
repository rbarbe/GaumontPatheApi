using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace GaumontPathe.GaumontPatheApi.Test
{
    public class Functional
    {
        [Fact]
        public async Task Test()
        {
            var client = new Api();
            var reference = await client.GetFilmCinema(1);
            Assert.True(reference.Cinemas.Any());
            var seanceZone = await client.GetSeanceZone(100);
            Assert.True(seanceZone.Seances.Any());
        }
    }
}
