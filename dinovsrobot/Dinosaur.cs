using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class Dinosaur
    {
        //public string name;
        public string type;
        public double health;
        public double energyLevel;
        public double attackModifier;
        public bool canAttack;
        public double attackPower;
        public AttackList attackList;
        public Attack attack;

        public Dinosaur(string type)
        {
           
            this.type = type;
            attackList = new AttackList();
            health = 1000;
            energyLevel = new Random().Next(1, 101);
            attackModifier = 10;
            canAttack = true;
            attackPower = this.attackModifier + this.energyLevel;

        }


        public void DisplayDinosaur()
        {
           
             {
            string space = "";
            if (type != "T-Rex")
            {
                space = "   ";
            }
            Console.WriteLine($"{space}{type}  -  {health}   -  {energyLevel}    -   {canAttack}      ");
        }

        }
        public void ChooseAttack()
        {
            Console.Write($"Chose an attack(Chomp - Kick - Tail Whip ) for {type}: ");
            string choice = Console.ReadLine().ToLower();
            while (choice != "chomp" && choice != "kick" && choice != "tail whip")
            {
                Console.WriteLine("Invaid weapon selection!!");
                choice = Console.ReadLine().ToLower();
            }
            switch (choice)
            {
                case "chomp":
                    attack = attackList.chomp;
                    break;
                case "kick":
                    attack = attackList.kick;
                    break;
                case "tail whip":
                    attack = attackList.tailwhip;
                    break;
            }
        }
        }
    } 
