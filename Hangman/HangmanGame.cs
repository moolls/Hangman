using System;
using System.Reflection.Emit;

namespace OOP1spel
{
    public class HangmanGame
    {
        private Ord ord;        //objektkomposition
        private Gubbe gubbe;    //objektkomposition

        private string kompisOrd = "";
        private bool RedanGissad;
        private int svar;

        public HangmanGame(Gubbe gubbe) // abstract injicerad?
        {
            this.gubbe = gubbe;
            kompisOrd = HämtaOrd();
            ord = new Ord(kompisOrd);
        }

        public int Play()
        {
            ord.KonstrueraOrd(); //instansmetod
            while (true)
            {
                
                while (true)
                {
                    ord.TaEmotBokstav(); //instansmetod

                    RedanGissad = ord.OmRedanGissad(); //instansmetod
                    if (RedanGissad == false)
                    {
                        break;
                    }
                   else if (RedanGissad == true)
                    {
                    Console.WriteLine("du har redan gissat den här bokstaven, försök igen :)");
                    }
                }

                Console.Clear();
                Console.WriteLine(ord.SkrivUtOrd(ord.c));
                int antalFel = ord.AntalFelBokstäver;
                gubbe.Rita(antalFel);


                if (RedanGissad == false)
                {
                    ord.GissadeBokstäver(ord.c);
                    bool ärDöd = gubbe.ÄrDöd(antalFel);
                    {
                        if (ärDöd == true)
                        {
                            Console.WriteLine("Gubben blev hängd :(");
                            Console.WriteLine($"Rätta ordet är: {kompisOrd}");
                            break;
                        }
                    }
                    bool allaRätt = ord.AllaRätt();
                    if (allaRätt == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Grattis du vann!");
                        break;
                    }
                }
            }
            svar = SpelaIgen();
            return svar;
        }

        private int SpelaIgen()
        {
            Console.WriteLine("Vill du spela igen?");
            Console.WriteLine("1. Ja");
            Console.WriteLine("2. Avsluta");
            string? SpelaIgen = Console.ReadLine();

            if (SpelaIgen != null)
            {

                switch (SpelaIgen)
                {
                    case "1":
                        return 1;
                    case "2":
                        return 0;

                }

            }
            return 0;
        }

        private string HämtaOrd()
        {
            Console.WriteLine("Låt din kompis skriva in ett ord du ska gissa :)");
            string? kompisOrd = Console.ReadLine();
            
            if (kompisOrd != null)
            {
              
                return kompisOrd;
            }
            return "";

        }
    }
}

//eventuellt kanske göra en metod som tar emot en string ifall amn vill gissa på hela ordet, overloading av konsturktorer, även instansmetod
//klasser med olika typer av ord, t.ex svåra lätta enkla.