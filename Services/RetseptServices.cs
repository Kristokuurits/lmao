using MauiApp1.Models;
using System.Numerics;

namespace MauiApp1.Services
{
    internal static class RetseptServices
    {
        private static List<Retsept> retseptid = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "toit.png",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            }
        };
        public static List<Retsept> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = retseptid.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Retsept> GetAllPlanets()
            => retseptid;
    }
}