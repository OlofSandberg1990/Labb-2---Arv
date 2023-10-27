using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Djur
    {
        public string _Namn {  get; set; }
        public string _Art { get; set; }
        public int _Ålder { get; set; }                 
        public double _Vikt { get; set; }
        public bool _ÄrEttDäggDjur { get; set; }
        public string _Läte { get; set; }

        public Djur(string namn, string art, int ålder, double vikt, bool ärEttDäggdjur, string läte)       
        {
            _Namn = namn;
            _Art = art;
            _Ålder = ålder;                                                 //A constructor for the variables
            _Vikt = vikt;
            _ÄrEttDäggDjur = ärEttDäggdjur;
            _Läte = läte;
                            
        }
        public Djur()
        {
            _Namn = "Okänt";
            _Art = "Okänt";                                                 //My "default" constructor
            _Ålder = 0;
            _Vikt = 0;
            _ÄrEttDäggDjur = false;
            _Läte = "Okänt";
        }

        public void Äter()
        {
            Console.WriteLine($"{_Namn} äter");

        }
        public void Leker()                                                 //some methods
        {
            Console.WriteLine($"{_Namn} leker");
        }
        public virtual void MakeSound()                                   //using the virtual-modifyer so I can use override in my other classes with this method as well.
        {
            Console.WriteLine($"{_Namn} säger {_Läte}");
        }
        public virtual void Info()
        {
            Console.WriteLine("Namn : " + _Namn);
            Console.WriteLine("Art : " + _Art);
            Console.WriteLine("Ålder : " + _Ålder + "år");
            Console.WriteLine("Vikt : " + _Vikt + "kg");
            Console.WriteLine("Är ett däggdjur : " + (_ÄrEttDäggDjur ? "Ja" : "Nej"));
            Console.WriteLine("Läte : " + _Läte);
        }

    }
}
