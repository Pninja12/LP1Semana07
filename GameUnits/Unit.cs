namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public int Move(){
            return movement;
        }

        public abstract float Cost{ get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name}: HP={Health} COST={Cost:f2}";
        }
    }
}
