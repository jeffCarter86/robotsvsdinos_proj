using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinovsrobot
{
    class Herd
    {
        public Dinosaur tRex;
        public Dinosaur raptor;
        public Dinosaur triceratops;
        public Herd()
        {
            tRex = new Dinosaur("T-rex");
            raptor = new Dinosaur("Raptor");
            triceratops = new Dinosaur("Triceratops");

        }

        public void DisplayDinosaurs(List<Dinosaur> dinosaurs)
        {
            foreach (Dinosaur dinosaur in dinosaurs)
            {
                dinosaur.DisplayDinosaur();
            }
        }
    }
}
