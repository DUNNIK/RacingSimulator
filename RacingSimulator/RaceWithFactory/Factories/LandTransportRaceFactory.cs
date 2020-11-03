
namespace RacingSimulator.RaceWithFactory.Factories
{
    public class LandTransportRaceFactory : ITransportRaceFactory
    {
        public RaceWithFactory CreatRace()
        {
            return new LandTransportRace();
        }
    }
}