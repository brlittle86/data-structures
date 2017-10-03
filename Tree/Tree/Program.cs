using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree("magnets");
            myTree.AddLeft("potato");
            myTree.AddRight("horses");
            myTree.AddLeft("bananas");
            myTree.AddLeft("apples");
            myTree.AddRight("squirrels");
            myTree.AddRight("rabbits");
            Console.Read();
        }
    }
}
