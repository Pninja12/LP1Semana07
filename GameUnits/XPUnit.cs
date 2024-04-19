using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits 
{
    public class XPUnit : Unit
    {

        public XPUnit(int mov, int health)
        : base(mov, health) //Inicializa mov e health a 1 e 3
        {
            XP = 0;
        }
        public int XP{ get; protected set; }
        public override float Cost{ get; set; }

        public override string ToString()
        {
            return base.ToString() + 
            $" XP={XP}";
        }


    }
}