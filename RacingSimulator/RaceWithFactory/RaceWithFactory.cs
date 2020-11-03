using System.Collections.Generic;
using RacingSimulator.Exceptions;

namespace RacingSimulator.RaceWithFactory
{
    public abstract class RaceWithFactory
    {
        protected Transport.Transport Winner;
        protected readonly List<Transport.Transport> Competitors;
        private float _distance ;

        protected RaceWithFactory()
        {
            Competitors = new List<Transport.Transport>();
        }

        protected RaceWithFactory(List<Transport.Transport> competitors)
        {
            Competitors = competitors;
        }

        public abstract RaceWithFactory AddCompetitor(Transport.Transport transport);

        public RaceWithFactory AddDistance(float distance)
        {
            if (distance < 0)
            {
                throw new DistanceException();
            }
            _distance = distance;
            return this;
        }
        public RaceWithFactory StartGame()
        {
            var minTime = float.MaxValue;
            foreach (var competitor in Competitors)
            {
                var competitorTime = competitor.TimeForDistance(_distance);
                if (competitorTime < minTime)
                {
                    minTime = competitorTime;
                    Winner = competitor;
                }
            }

            return this;
        }
    }
    public class LandTransportRace : RaceWithFactory
    {
        public override RaceWithFactory AddCompetitor(Transport.Transport transport)
        {
            if (transport.IsLand())
            {
                Competitors.Add(transport);
            }
            else
            {
                throw new AddTransportException();
            }

            return this;
        }
        public override string ToString()
        {
            return $"Land race was won by a {Winner}";
        }
    }
    public class AirTransportRace : RaceWithFactory
    {
        public override RaceWithFactory AddCompetitor(Transport.Transport transport)
        {
            if (transport.IsAir())
            {
                Competitors.Add(transport);
            }
            else
            {
                throw new AddTransportException();
            }

            return this;
        }
        public override string ToString()
        {
            return $"Air race was won by a {Winner}";
        }
    }
    public class AllTransportRace : RaceWithFactory
    {
        public override RaceWithFactory AddCompetitor(Transport.Transport transport)
        {
            Competitors.Add(transport);
            return this;
        }
        public override string ToString()
        {
            return $"Mix race was won by a {Winner}";
        }
    }
}