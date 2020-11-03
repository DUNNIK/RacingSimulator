using RacingSimulator.Exceptions;

namespace RacingSimulator.RaceWithBuilder
{
    public abstract class RaceBuilder
    {
        protected readonly RaceWithBuilder RaceWithBuilder;

        protected RaceBuilder() => RaceWithBuilder = new RaceWithBuilder();
        protected RaceBuilder(RaceWithBuilder raceWithBuilder) 
            => RaceWithBuilder = raceWithBuilder;

        public abstract RaceBuilder AddCompetitor(Transport.Transport transport);

        public RaceBuilder AddDistance(float distance)
        {
            if (distance < 0)
            {
                throw new DistanceException();
            }
            RaceWithBuilder.Distance = distance;
            return this;
        }
        public RaceWithBuilder Build() => RaceWithBuilder;
        public static implicit operator 
            RaceWithBuilder(RaceBuilder builder)
            => builder.RaceWithBuilder;
    }
    public class LandTransportRaceBuilder : RaceBuilder
    {
        public override RaceBuilder AddCompetitor(Transport.Transport transport)
        {
            if (transport.IsLand())
            {
                RaceWithBuilder.Competitors.Add(transport);
            }
            else
            {
                throw new AddTransportException();
            }

            return this;
        }
    }
    public class AllTransportRaceBuilder : RaceBuilder
    {
        public override RaceBuilder AddCompetitor(Transport.Transport transport)
        {
            RaceWithBuilder.Competitors.Add(transport);
            return this;
        }
    }
    public class AirTransportRaceBuilder : RaceBuilder
    {
        public override RaceBuilder AddCompetitor(Transport.Transport transport)
        {
            if (transport.IsAir())
            {
                RaceWithBuilder.Competitors.Add(transport);
            }
            else
            {
                throw new AddTransportException();
            }

            return this;
        }
    }
}