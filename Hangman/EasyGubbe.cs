using System;
namespace OOP1spel
{
    public class EasyGubbe : Gubbe // arv
    {

        public EasyGubbe() : base(11)
        {

        }
        public override void Rita(int antalFel)
        {

            if (antalFel == 1)
            {
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("   ===");

            }

            else if (antalFel == 2)
            {
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }

            else if (antalFel == 3)
            {
                Console.WriteLine("     ");
                Console.WriteLine("     ");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }

            else if (antalFel == 4)
            {
                Console.WriteLine("     ");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }

            else if (antalFel == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }

            else if (antalFel == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }


            else if (antalFel == 7)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (antalFel == 8)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (antalFel == 9)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }

            else if (antalFel == 10)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("   ===");
            }
            else if (antalFel == 11)
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




