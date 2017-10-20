using System;
using System.Collections.Generic;
using System.Text;

namespace BSTAnimalGame
{
    class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree(T data)
        {
            Root = new Node<T>(data);
        }

        public void AskQuestion(Node<T> curr)
        {
            if (curr.Left == null && curr.Right == null)
            {
                MakeGuess(curr);
            }
            else
            {
                Console.WriteLine($"{curr.Data}");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y" || answer == "yes")
                {
                    AskQuestion(curr.Left);
                }
                else
                {
                    AskQuestion(curr.Right);
                }
            }
        }

        public void MakeGuess(Node<T> node)
        {

        }
    }
}
