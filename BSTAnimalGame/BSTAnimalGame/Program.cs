using System;

namespace BSTAnimalGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree("Is it a mammal?");
            myTree.Root.Left = new Node("Does it live in water?")
            {
                Left = new Node("dolphin"),
                Right = new Node("cat")
            };
            myTree.Root.Right = new Node("Is it amphibious?")
            {
                Left = new Node("frog"),
                Right = new Node("fish")
            };

            myTree.AskQuestion(myTree.Root);
            Console.Read();

        }
    }
}
