using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class AttackList
    {
        public Attack chomp;
        public Attack kick;
        public Attack tailwhip;
        public AttackList()
        {
            chomp = new Attack("chomp", 10);
            kick = new Attack("kick", 15);
            tailwhip = new Attack("tail whip", 25);
        }
    }
}
