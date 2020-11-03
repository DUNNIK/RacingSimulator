namespace RacingSimulator.Transport
{
    public abstract class LandTransport : Transport
    {
        protected float RestInterval;
        protected int RestCount;
        protected abstract float RestDuration();
    }

    public class BactrianCamel : LandTransport
    {
        public BactrianCamel()
        {
            RestInterval = 30;
            Speed = 10;
        }

        protected override float RestDuration()
        {
            float first = 5;
            float other = 8;
            if (RestCount == 0)
            {
                RestCount++;
                return first;
            }

            return other;

        }

        public override float TimeForDistance(float distance)
        {
            float resultTime = 0;
            while (distance > 0)
            {
                if (Speed * RestInterval > distance)
                {
                    resultTime += distance / Speed;
                    break;
                }
                resultTime += RestInterval;
                distance -= Speed * RestInterval;
                resultTime += RestDuration();
            }

            return resultTime;
        }

        public override bool IsAir()
        {
            return false;
        }

        public override bool IsLand()
        {
            return true;
        }

        public override string ToString()
        {
            return "Bactrian camel";
        }
    }

    public class SpeedCamel : LandTransport
    {
        public SpeedCamel()
        {
            RestInterval = 10;
            Speed = 40;
        }

        protected override float RestDuration()
        {
            const float first = 5;
            const float second = (float) 6.5;
            const float other = 8;
            if (RestCount == 0)
            {
                RestCount++;
                return first;
            }

            if (RestCount == 1)
            {
                RestCount++;
                return second;
            }

            RestCount++;
            return other;
        }

        public override float TimeForDistance(float distance)
        {
            float resultTime = 0;
            while (distance > 0)
            {
                if (Speed * RestInterval > distance)
                {
                    resultTime += distance / Speed;
                    break;
                }
                resultTime += RestInterval;
                distance -= Speed * RestInterval;
                resultTime += RestDuration();
            }

            return resultTime;
        }

        public override bool IsAir()
        {
            return false;
        }

        public override bool IsLand()
        {
            return true;
        }

        public override string ToString()
        {
            return "Speed camel";
        }
    }
    public class Centaur : LandTransport
    {
        public Centaur()
        {
            Speed = 15;
            RestInterval = 8;
        }

        protected override float RestDuration()
        {
            float all = 2;
            return all;
        }

        public override float TimeForDistance(float distance)
        {
            float resultTime = 0;
            while (distance > 0)
            {
                if (Speed * RestInterval > distance)
                {
                    resultTime += distance / Speed;
                    break;
                }
                resultTime += RestInterval;
                distance -= Speed * RestInterval;
                resultTime += RestDuration();
            }

            return resultTime;
        }

        public override bool IsAir()
        {
            return false;
        }

        public override bool IsLand()
        {
            return true;
        }

        public override string ToString()
        {
            return "Centaur";
        }
    }

    public class AllTerrainBoots : LandTransport
    {
        public AllTerrainBoots()
        {
            Speed = 6;
            RestInterval = 60;
        }

        protected override float RestDuration()
        {
            const float first = 10;
            const float other = 5;
            if (RestCount == 0)
            {
                RestCount++;
                return first;
            }

            return other;
        }

        public override float TimeForDistance(float distance)
        {
            float resultTime = 0;
            while (distance > 0)
            {
                if (Speed * RestInterval > distance)
                {
                    resultTime += distance / Speed;
                    break;
                }
                resultTime += RestInterval;
                distance -= Speed * RestInterval;
                resultTime += RestDuration();
            }

            return resultTime;
        }

        public override bool IsAir()
        {
            return false;
        }

        public override bool IsLand()
        {
            return true;
        }

        public override string ToString()
        {
            return "All-terrain boots";
        }
    }
}