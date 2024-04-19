namespace GameUnits
{
    public class SettlerUnit : Unit // Heranca!!
    {

        public SettlerUnit(int mov, int health)
        : base(mov = 1, health = 3) //Inicializa mov e health a 1 e 3
        // Unit(int, int)
        {
        }

        public override float Cost
        {
            get
            {
                return 5;
            }
        }
    }
}
