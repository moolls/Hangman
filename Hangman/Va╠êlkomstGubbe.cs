using System;
namespace OOP1spel
{
    public class VälkomstGubbe : Gubbe //arv
    {
        public VälkomstGubbe() : base(0)
        {

        }

        public override void Rita(int value)
{
    string ascii1 = @"
 \ \    / (_) (_) | |                                        | | (_) | |
  \ \  / /  __ _| | | _____  _ __ ___  _ __ ___   ___ _ __   | |_ _| | |
   \ \/ /  / _` | | |/ / _ \| '_ ` _ \| '_ ` _ \ / _ \ '_ \  | __| | | |
    \  /  | (_| | |   < (_) | | | | | | | | | | |  __/ | | | | |_| | | |
     \/    \__,_|_|_|\_\___/|_| |_| |_|_| |_| |_|\___|_| |_|  \__|_|_|_|";

    string ascii2 = @"      
      | |   (_) (_)                               | |   | |        | |
      | |__   __ _ _ __   __ _  __ _    __ _ _   _| |__ | |__   ___| |
      | '_ \ / _` | '_ \ / _` |/ _` |  / _` | | | | '_ \| '_ \ / _ \ |
      | | | | (_| | | | | (_| | (_| | | (_| | |_| | |_) | |_) |  __/_|
      |_| |_|\__,_|_| |_|\__, |\__,_|  \__, |\__,_|_.__/|_.__/ \___(_)
                          __/ |         __/ |                         
                         |___/         |___/       ";

    if (value == 0)
    {
        Console.Clear();
        Console.WriteLine(ascii1);
        Console.WriteLine(ascii2);
        
        Thread.Sleep(2000);
        for (int steg = 1; steg <= 5; steg++)
        {
            Console.Clear();
            RitaSteg(steg);
            Thread.Sleep(800);
        }
    }
}


private void RitaSteg(int steg)
{
    switch (steg)
    {
        case 1:
            Console.WriteLine("+---+");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
            break;
        case 2:
            Console.WriteLine("+---+");
            Console.WriteLine("O   |");
            Console.WriteLine("    |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
            break;
        case 3:
            Console.WriteLine("+---+");
            Console.WriteLine("O   |");
            Console.WriteLine("|   |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
            break;
        case 4:
            Console.WriteLine("+---+");
            Console.WriteLine(" O  |");
            Console.WriteLine("/|\\ |");
            Console.WriteLine("    |");
            Console.WriteLine("   ===");
            break;
        case 5:
            Console.WriteLine("+---+");
            Console.WriteLine(" O  |");
            Console.WriteLine("/|\\ |");
            Console.WriteLine("/ \\ |");
            Console.WriteLine("   ===");
            break;
    }
}


   
    }
}

