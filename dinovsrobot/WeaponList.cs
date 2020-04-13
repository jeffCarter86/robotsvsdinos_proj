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
            plunger = new Weapon("Plunger", new Random().Next(1, 11));
            cannon = new Weapon("Cannon", new Random().Next(1, 16));
            blaster = new Weapon("Particle Blaster", new Random().Next(1, 26));

        }
    }
}
