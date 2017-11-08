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

        public void EnqueueAnimal(string type)
        {
            if (type == "cat")
            {
                Cats.Enqueue(new Animal
                {
                    Species = type,
                    IntakeNumber = LinePosition
                });
                LinePosition++;
            }
            else if (type == "dog")
            {
                Dogs.Enqueue(new Animal
                {
                    Species = type,
                    IntakeNumber = LinePosition
                });
                LinePosition++;
            }
            else
            {
                Console.WriteLine("Did not understand your animal species.");
            }
        }
    }
}
