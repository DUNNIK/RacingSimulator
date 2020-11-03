namespace RacingSimulator.RaceWithFactory.Factories
{
    public class AllTransportRaceFactory : ITransportRaceFactory
    {
        public RaceWithFactory CreatRace()
        {
            return new AllTransportRace();
        }
    }
}