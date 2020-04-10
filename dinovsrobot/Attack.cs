using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class Attack
    {
        public string type;
        public double damage;
        public Attack(string type, double damage)
        {
            this.type = type;
            this.damage = damage;
        }
    }
}
