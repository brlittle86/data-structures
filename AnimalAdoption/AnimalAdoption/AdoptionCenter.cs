using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption
{
    class AdoptionCenter
    {
        public Queue<Animal> Cats { get; set; }
        public Queue<Animal> Dogs { get; set; }
        public int LinePosition { get; set; }

        public AdoptionCenter()
        {
            Cats = new Queue<Animal>();
            Dogs = new Queue<Animal>();
            LinePosition = 0;
        }
    }
}
