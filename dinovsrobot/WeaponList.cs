using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class WeaponList
    {
        public Weapon plunger;
        public Weapon cannon;
        public Weapon blaster;
        public WeaponList()
        {
            plunger = new Weapon("Plunger", 10);
            canon = new Weapon("Cannon", 15);
            blaster = new Weapon("Particle Blaster", 25);

        }
    }
}
