using System.Collections.Generic;

namespace RacingSimulator.RaceWithBuilder
{
    public class RaceWithBuilder
    {
        private Transport.Transport _winner;
        public readonly List<Transport.Transport> Competitors;
        public float Distance;
        public RaceWithBuilder()
        {
            Competitors = new List<Transport.Transport>();
        }
        public RaceWithBuilder StartGame()
        {
            var minTime = float.MaxValue;
            foreach (var competitor in Competitors)
            {
                var competitorTime = competitor.TimeForDistance(Distance);
                if (competitorTime < minTime)
                {
                    minTime = competitorTime;
                    _winner = competitor;
                }
            }

            return this;
        }

        public override string ToString()
        {
            return $"The race was won by a {_winner}";
        }
    }
}