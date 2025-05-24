using System;
namespace OOP1spel
{
    public class NormalGubbe : Gubbe //arv
    {
        public NormalGubbe() : base(7)
        {

        }
        public override void Rita(int antalFel)
        {
            if (antalFel == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (antalFel == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }


            else if (antalFel == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (antalFel == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (antalFel == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (antalFel == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("   ===");
            }
            else if (antalFel == 7)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/ \\ |");
                Console.WriteLine("   ===");
            }
        }

    }
}
