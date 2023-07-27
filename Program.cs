using System;
using System.Security.Cryptography;

namespace compteur
{
    class Program
    {
        static void Main(string[] args)
        {
            string msgConsole = "je suis un compteur simple a utiliser!";

            Console.WriteLine(msgConsole);

            Console.WriteLine("Il faut que tu entre le premier nombre ;)");
            string input = Console.ReadLine();
            int PremierNombre = int.Parse(input);

            Console.WriteLine("Entre maintenant le second nombre");
            int SecondNombre = int.Parse(Console.ReadLine());

            Console.WriteLine("les chiffres sont:");

            for (int i = PremierNombre; i <= SecondNombre; i = i +1)
            {
                Console.WriteLine(i);

            }

        }   

    }
}
