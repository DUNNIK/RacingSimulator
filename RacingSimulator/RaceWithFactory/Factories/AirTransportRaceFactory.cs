namespace RacingSimulator.RaceWithFactory.Factories
{
    public class AirTransportRaceFactory : ITransportRaceFactory
    {
        public RaceWithFactory CreatRace()
        {
            return new AirTransportRace();
        }
    }
}