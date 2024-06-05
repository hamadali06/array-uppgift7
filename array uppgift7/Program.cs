using System;

namespace Inlamning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] länder = { "Kina", "Indien", "USA", "Indonesien", "Pakistan" };
            for (int i = 0; i < länder.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {länder[i]}");
            }
            Console.WriteLine("Ange nummer på länder att visa igen (separerade med mellanslag):");
            string[] val = Console.ReadLine().Split(' ');
            foreach (string s in val)
            {
                int index = int.Parse(s) - 1;
                Console.WriteLine($"{index + 1}. {länder[index]}");
            }
        }
    }
}
