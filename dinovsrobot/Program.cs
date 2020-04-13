using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The War between Robots and Dinosaurs is finally among us!! Who Shall have Win?");
            Battlefield battleField = new Battlefield();
            Console.WriteLine("LETS GET READY TO RUMMBBLLEEE!!!");
            battleField.Battle();
        }
    }
}
