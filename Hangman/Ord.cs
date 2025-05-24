using System;
using System.Security.Cryptography;

namespace OOP1spel
{
    public class Ord : IOrd
    {

        public int AntalFelBokstäver { get; private set; } = 0;
        private string Ordet = "";
        private List<char> GissadeBokstäverHittils = new List<char>();
        public char c { get; private set;}
        public string hemligtOrd {get; private set; }


        public Ord(string hemligtOrd)
        {
            this.hemligtOrd = hemligtOrd;
            if(hemligtOrd == null)
            {
                throw new ArgumentException("Ordet kan inte vara null");
            }
            if (hemligtOrd == "")
            {
                throw new ArgumentException("Ordet kan inte vara null");
            }
        }

        public void KonstrueraOrd()
        {

            while (true)
            {
                if (this.hemligtOrd != null)
                {
                    bool ÄrBokstav = this.hemligtOrd.All(Char.IsLetter);
                    this.hemligtOrd = this.hemligtOrd.ToLower();
                    Console.Clear();
                    break;

                }

                else Console.WriteLine("Du angav ett fel värde");
            }

            for (int i = 0; i < this.hemligtOrd.Length; i++)
            {
                Ordet += "_";
            }
        }

        public void TaEmotBokstav()
        {
            Console.WriteLine("skriv in en bokstav du vill gissa"); 
            string? bokstav = Console.ReadLine();
            if (bokstav != null)
            {

                bool ÄrBokstav = bokstav.All(Char.IsLetter);
                bokstav = bokstav.ToLower();

                try
                {

                    if (ÄrBokstav == true && bokstav.Length == 1)
                    {

                        c = char.Parse(bokstav);
                 
                    }
                    else
                    {
                        Console.WriteLine("Du angav inte en giltig input");
                        TaEmotBokstav();
                    }
                }

                catch
                {
                  Console.WriteLine("Ange en bokstav");
                    
                }
            }
            

       
        }



        public string SkrivUtOrd(char bokstav)
        {
            string temp = "";
            bool rättGissning = false;



            for (int i = 0; i < this.hemligtOrd.Length; i++)
            {

                if (this.hemligtOrd[i] == bokstav)
                {
                    rättGissning = true;


                    if (temp != null)
                    {

                        if (Ordet[i] == '_')
                        {
                            temp += bokstav;
                        }
                        else
                        {
                            temp += Ordet[i];
                        }
                    }
                }

                else if (Ordet[i] == ' ')
                {
                    temp += "";

                }
                else
                {
                    temp += Ordet[i];

                }

            }

            if (rättGissning == false)
            {
                AntalFelBokstäver++;
            }

            if (temp == null)
                temp = "";
            Ordet = temp;
          
 
            return temp;

        }

 

        public void GissadeBokstäver(char bokstav)
        {
            GissadeBokstäverHittils.Add(bokstav);
            Console.Write("de gissade bokstäverna hittils: ");
            foreach (char c in GissadeBokstäverHittils)
            {
                Console.Write(c + " ");

            }
            Console.WriteLine();


        }

        public bool OmRedanGissad()
        {
            if (GissadeBokstäverHittils.Contains(c))
            {
                return true;
            }
            else return false;
        }

        public bool AllaRätt()
        {
            for (int i = 0; i < hemligtOrd.Length; i++)
            {
                if (hemligtOrd == Ordet)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

