using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        public SpyUnit(int mov = 0, int health = 0)
        : base(mov = 8, health = 2)
        {
            Cost = 12.5f;
        }

        

        public void GetSecretInfo(Unit unit)
        {
            SpyUnit defaultSpy = new SpyUnit();
            MilitaryUnit defaultMilitary = new MilitaryUnit(0,0,0);
            if(unit.GetType() == defaultSpy.GetType())
            {
                XP += 3;
            }
            else if(unit.GetType() == defaultMilitary.GetType())
            {
                XP += 2;
            }
            else
            {
                XP += 1;
            }
        }
    }
}