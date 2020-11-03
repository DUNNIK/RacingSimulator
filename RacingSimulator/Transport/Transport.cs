namespace RacingSimulator.Transport
{
    public abstract class Transport
    {
        protected float Speed;
        public abstract float TimeForDistance(float distance);
        public abstract bool IsAir();
        public abstract bool IsLand();
    }
    
}