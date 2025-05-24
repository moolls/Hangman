using System;

namespace OOP1spel
{
    class program
    {
        static void Main(string[] args)
        {

            int spela = 1;
            Gubbe VälkommenGubbe = new VälkomstGubbe();
            VälkommenGubbe.Rita(0);
            while (spela == 1)
            {
           
            
            string menyVal = Meny();

                switch (menyVal)
                {
                    case "1":
                        Gubbe enkelGubbe = new EasyGubbe();     //subtyppolymorfism
                        HangmanGame HängaGubbe1 = new HangmanGame(enkelGubbe);
                        spela = HängaGubbe1.Play();
                        break;

                    case "2":
                        Gubbe normalGubbe = new NormalGubbe();  //subtyppolymorfism
                        HangmanGame HängaGubbe2 = new HangmanGame(normalGubbe);
                        spela = HängaGubbe2.Play();
                        break;

                    case "3":
                        Gubbe svårGubbe = new HardGubbe();      //subtyppolymorfism
                        HangmanGame HängaGubbe3 = new HangmanGame(svårGubbe);
                        spela = HängaGubbe3.Play();
                        
                        break;
                    default:
                        Console.WriteLine("Ange ett korrekt värde"); 

                        break;
                }
      
            }

        }

        public static string Meny()
        {
            Console.WriteLine("Detta spel har ingen AI implementerad ännu därför krävs 2 spelare");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Välj vilken svårighetsgrad ni vill spela:");
            Console.WriteLine("1. Enkel");
            Console.WriteLine("2. Medel");
            Console.WriteLine("3. Svår");
            string? menyVal = Console.ReadLine();
            if (menyVal != null)
            {
                return menyVal;
            }
            return "";
        }

    }

}

