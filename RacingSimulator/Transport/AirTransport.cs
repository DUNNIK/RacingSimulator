
namespace RacingSimulator.Transport
{
    public abstract class AirTransport : Transport
    {
        protected abstract float DistanceReducer(float distance);
    }
    public class MagicCarpet : AirTransport
    {
        public MagicCarpet()
        {
            Speed = 10;
        }

        protected override float DistanceReducer(float distance)
        {
            const double percent1 = 0.03;
            const double percent2 = 0.1;
            const double percent3 = 0.05;
            if (distance <= 1000)
            {
                return distance;
            }
            if (distance <= 5000 && distance > 1000)
            {
                return (float) (distance * (1 - percent1));
            }

            if (distance > 5000 && distance <= 10000)
            {
                return (float) (distance * (1 - percent2));
            }

            return (float) (distance * (1 - percent3));
        }

        public override float TimeForDistance(float distance)
        {
            var distanceAfterReducer = DistanceReducer(distance);
            var time = distanceAfterReducer / Speed;
            return time;
        }

        public override bool IsAir()
        {
            return true;
        }

        public override bool IsLand()
        {
            return false;
        }

        public override string ToString()
        {
            return "Magic carpet";
        }
    }
    public class Stupa : AirTransport
    {
        public Stupa()
        {
            Speed = 8;
        }

        protected override float DistanceReducer(float distance)
        {
            const double percent1 = 0.06;
            return (float) (distance * (1 - percent1));
        }

        public override float TimeForDistance(float distance)
        {
            var distanceAfterReducer = DistanceReducer(distance);
            var time = distanceAfterReducer / Speed;
            return time;
        }

        public override bool IsAir()
        {
            return true;
        }

        public override bool IsLand()
        {
            return false;
        }

        public override string ToString()
        {
            return "Stupa";
        }
    }
    public class Broom : AirTransport
    {
        public Broom()
        {
            Speed = 20;
        }

        protected override float DistanceReducer(float distance)
        {
            double percent1 = 1;

            for (var i = 0; i < distance / 1000; i++)
            {
                percent1 *= 0.99;
            }

            return (float) (distance * percent1);
        }

        public override float TimeForDistance(float distance)
        {
            var distanceAfterReducer = DistanceReducer(distance);
            var time = distanceAfterReducer / Speed;
            return time;
        }

        public override bool IsAir()
        {
            return true;
        }

        public override bool IsLand()
        {
            return false;
        }

        public override string ToString()
        {
            return "Broom";
        }
    }
}