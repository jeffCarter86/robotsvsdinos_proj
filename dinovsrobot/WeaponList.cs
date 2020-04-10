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
        public Weapon canon;
        public Weapon blaster;
        public WeaponList()
        {
            plunger = new Weapon("Plunger", 10);
            canon = new Weapon("Canon", 15);
            blaster = new Weapon("Particle Blaster", 25);

        }
    }
}
