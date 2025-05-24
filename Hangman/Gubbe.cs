using System;
namespace OOP1spel
{
    public abstract class Gubbe //abstrakt klass
    {
        private int dödsNummer;

        public Gubbe(int dödsNummer)
        {
            this.dödsNummer = dödsNummer;
        }

       public abstract void Rita(int antalFel);

       public virtual bool ÄrDöd(int antalFel)
        {
            {
                if (antalFel == dödsNummer)
                {
                    return true;
                }
                else return false;

            }
        }
    }
}
