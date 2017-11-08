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

        public void DequeueAny()
        {
            if (Dogs != null && Cats != null)
            {
                if (Dogs.Peek().IntakeNumber > Cats.Peek().IntakeNumber)
                {
                    Console.WriteLine($"You have adopted the cat in position {DequeueCat().IntakeNumber}.");
                }
                else
                {
                    Console.WriteLine($"You have adopted the dog in position {DequeueDog().IntakeNumber}.");
                }
            }
            else if (Cats == null && Dogs != null)
            {
                Console.WriteLine($"You have adopted the dog in position {DequeueDog().IntakeNumber}.");
            }
            else if (Cats != null && Dogs == null)
            {
                Console.WriteLine($"You have adopted the cat in position {DequeueCat().IntakeNumber}.");
            }
            else
            {
                Console.WriteLine("No animals in the Adoption Center!");
            }
        }

        public Animal DequeueCat()
        {
            
            return Cats.Dequeue(); 
            
        }

        public Animal DequeueDog()
        {
            
            return Dogs.Dequeue(); 
            
        }
    }
}
