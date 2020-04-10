using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class Robot
    { //member varribles
        public string name;
        public double health;           
        public double powerLevel;      
        public Weapon weapon;      
        public double attackPower;
        public double attackModifier;
        public bool canAttack;
        public WeaponList armory;

        //constructer spawner
        public Robot(string name)
        {
            this.name = name;
            powerLevel = 100;
            health = 1000;
            armory = new WeaponList();
            weapon = ChoseWeapon();
            attackModifier = 10;
            attackPower = attackModifier + powerLevel + weapon.damage;
            canAttack = true;
        }

        //member methods can do
        Weapon ChoseWeapon()
        {
            Console.Write($"Chose a weapon(Plunger | Cannon | Particle Blaster |) for {name}: ");
            string choice = Console.ReadLine().ToLower();
            while (choice != "plunger" && choice != "cannon" && choice != "particle blaster")
            {
                Console.WriteLine("Invaid weapon selection!!");
                choice = Console.ReadLine().ToLower();
            }
            switch (choice)
            {
                case "plunger":
                    return armory.plunger;
                case "cannon":
                    return armory.cannon;
                case "particle blaster":
                    return armory.blaster;
                default:
                    return armory.blaster;
            }

            
        }
}
