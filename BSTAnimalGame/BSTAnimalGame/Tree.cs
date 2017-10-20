using System;
using System.Collections.Generic;
using System.Text;

namespace BSTAnimalGame
{
    class Tree<T>
    {
        public Node Root { get; set; }

        public Tree(string data)
        {
            Root = new Node(data);
        }

        public void AskQuestion(Node curr)
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

        public void MakeGuess(Node node)
        {
            Console.WriteLine($"Were you thinking of a {node.Data}?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer == "yes")
            {
                Console.WriteLine("Hooray!");
            }
            else
            {
                Console.WriteLine("What was the animal you were thinking of?");
                string newAnimal = Console.ReadLine().ToLower();
                Console.WriteLine($"Please enter a question that would help us clarify. The 'Yes' answer should be {node.Data}.");
                string newQuestion = Console.ReadLine();
                node.Left = new Node(node.Data);
                node.Right = new Node(newAnimal);
                node.Data = newQuestion;
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer == "yes")
            {
                AskQuestion(Root);
                return;
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
                return;
            }
        }
    }
}
