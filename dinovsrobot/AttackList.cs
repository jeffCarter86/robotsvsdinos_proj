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
            chomp = new Attack("chomp", new Random().Next(1, 11));
            kick = new Attack("kick", new Random().Next(1, 16));
            tailwhip = new Attack("tail whip", new Random().Next(1, 26));
        }
    }
}
