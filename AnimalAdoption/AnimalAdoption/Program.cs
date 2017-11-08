using System;

namespace AnimalAdoption
{
    class Program
    {
        static void Main(string[] args)
        {
            AdoptionCenter pawesomePlace = new AdoptionCenter();
        }

        public void Menu(AdoptionCenter center)
        {
            Console.WriteLine("Please enter the number of your selection:");
            Console.WriteLine("1. Adopt a Pet");
            Console.WriteLine("2. Donate a Pet");
            int userResponse = Convert.ToInt32(Console.ReadLine());

            switch (userResponse)
            {
                case 1:
                    AdoptPet(center);
                    break;
                case 2:
                    DonatePet(center);
                    break;
                default:
                    break;
            }
        }

        public void AdoptPet(AdoptionCenter center)
        {
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("1. Adopt a Cat!");
            Console.WriteLine("2. Adopt a Dog!");
            Console.WriteLine("3. Adopt whatever!");
            Console.WriteLine("0. Return to Menu");
            int userResponse = Convert.ToInt32(Console.ReadLine());


            switch (userResponse)
            {
                case 1:
                    Console.WriteLine($"You have adopted the cat in position {center.DequeueCat().IntakeNumber}.");
                    break;
                case 2:
                    Console.WriteLine($"You have adopted the dog in position {center.DequeueDog().IntakeNumber}.");
                    break;
                case 3:
                    center.DequeueAny();
                    break;
                case 0:
                    Menu(center);
                    break;
                default:
                    break;
            }
        }

        public void DonatePet(AdoptionCenter center)
        {

        }
    }
}
