using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class Fleet
    {
        public Robot robbie;
        public Robot dalek;
        public Robot cyberman;

        public Fleet()
        {
            robbie = new Robot(" Robbie");
            Console.WriteLine($"Robot: {robbie.name} chose a {robbie.weapon.type} and has attack power of {robbie.attackPower}");
            dalek = new Robot("Dalek");
            Console.WriteLine($"Robot: {dalek.name} chose a {dalek.weapon.type} and has attack power of {dalek.attackPower}");
            cyberman = new Robot("Cyberman");
            Console.WriteLine($"Robot: {cyberman.name} chose a {cyberman.weapon.type} and has attack power of {cyberman.attackPower}");
            Console.ReadLine();

        }
        public void DisplayRobots(List<Robot> robots)
        {

            foreach (Robot robot in robots)
            {
                robot.DisplayRobot();
            }
        }
    }
}
