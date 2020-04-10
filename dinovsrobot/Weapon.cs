using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class Weapon
    {
         public string type;
        public double damage;
        public Weapon(string type, double damage)
        {
            this.type = type;
            this.damage = damage;
        }
    }
}
