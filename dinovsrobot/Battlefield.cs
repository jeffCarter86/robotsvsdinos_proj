using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class Battlefield
    {
      
        public Fleet robotFleet;
        public Herd dinosaurHerd;
        List<Robot> robotList;
        List<Dinosaur> dinoList;
      
        public Battlefield()
        {
            robotFleet = new Fleet();
            dinosaurHerd = new Herd();
            robotList = new List<Robot> { robotFleet.robbie, robotFleet.dalek, robotFleet.cyberman };
            dinoList = new List<Dinosaur> { dinosaurHerd.tRex, dinosaurHerd.raptor, dinosaurHerd.triceratops };
        }

        public void Battle()
        {
            int round = 0;
            do
            {
                round++;
                Console.WriteLine($"Round {round}");
                DisplayBattlefield();
                Attack();

            } while (dinoList.Count > 0 && robotList.Count > 0);
            DisplayBattlefield();
            Console.WriteLine("Robots killed all the dinosaurs\nRobots win the Battle!!");
            Console.ReadKey();
        }

        public void DisplayBattlefield()
        {
            DisplayRobots();
            DisplayDinos();
        }

        public void Attack()
        {
            // dino attack
            for (int i = 0; i < dinoList.Count; i++)
            {
                if (i < robotList.Count)
                {
                    dinoList[i].ChooseAttack();
                    robotList[i].health -= dinoList[i].attackPower;
                }
            }
            //update damage to robots
            for (int i = 0; i < robotList.Count; i++)
            {
                if (robotList[i].health <= 0)
                {
                    robotList.Remove(robotList[i]);
                    i--;
                }

            }
            //robots attack
            for (int i = 0; i < robotList.Count; i++)
            {
                if (i < dinoList.Count)
                {
                    //
                    dinoList[i].health -= robotList[i].attackPower;
                }
            }
            // update damage to dinos
            for (int i = 0; i < dinoList.Count; i++)
            {
                if (dinoList[i].health <= 0)
                {
                    dinoList.Remove(dinoList[i]);
                    i--;
                }

            }

        }
        public void DisplayRobots()
        {

            int i = 0;
            
            Console.WriteLine("Robot  -  Health -  Energy  -  Can Attack  ");
           
            foreach (Robot bot in robotList)
            {
                bot.DisplayRobot();
                if (i == 2)
                {
                    Console.WriteLine("");
                }
                else
                {

                    Console.WriteLine("");
                    i++;
                }
            }

            Console.WriteLine();
        }
        public void DisplayDinos()
        {
            int i = 0;
          
            Console.WriteLine("Dinosaur  -  Health - Power -  Can Attack  ");
           
            foreach (Dinosaur dino in dinoList)
            {
                dino.DisplayDinosaur();
                if (i == 2)
                {
                    Console.WriteLine("");
                }
                else
                {

                    Console.WriteLine("");
                    i++;
                }
            }

            Console.WriteLine();
        }
       
    }
}
