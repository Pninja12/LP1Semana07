namespace GameUnits
{
    public class MilitaryUnit : XPUnit // Heranca!!
    {
        public int AttackPower { get; }
        public override int Health {get => base.Health + XP;}
        public override float Cost{ get => XP + AttackPower;}

        public MilitaryUnit(int mov, int health, int attackPower)
        : base(mov, health)
        // Unit(int, int)
        { 
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u){
            XP += 1;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return base.ToString() + 
            $" AP={AttackPower}";
        }
    }
}
