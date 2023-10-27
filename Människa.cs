using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Människa : Djur
    {
        public string _Efternamn { get; set; }
        public string _Favoritmat {  get; set; }

        public Människa(string namn, string efternamn, int ålder, double vikt, string läte, string favoritmat)
            :base(namn, "Människa", ålder, vikt, true, läte)
        {
            _Efternamn = efternamn;
            _Favoritmat = favoritmat;
        }
        public Människa()
            :base("Okänt", "Människa", 0, 0.0, true, "Okänt")
        {
            _Efternamn = "Okänt";
            _Favoritmat = "Okänt";
        }


        public override void Info()
        {
            Console.WriteLine("Förnamn : " + _Namn);
            Console.WriteLine("Efternamn : " + _Efternamn);
            Console.WriteLine("Art : " + _Art);
            Console.WriteLine("Ålder : " + _Ålder + "år");
            Console.WriteLine("Vikt : " + _Vikt + "kg");
            Console.WriteLine("Är ett däggdjur : " + (_ÄrEttDäggDjur ? "Ja" : "Nej"));
            Console.WriteLine($"Läte : \"{_Läte}\"");            
            Console.WriteLine("Favoritmat : " + _Favoritmat);
        }
        public void ÖppnarEnÖl()
        {
            Console.WriteLine($"{_Namn} öppnar en öl");

        }
        public override void MakeSound()
        {
            Console.WriteLine($"Eftersom {_Namn} är en människa kallpratar hen om absolut ingenting. Mycket av samtalet kretsar kring {_Favoritmat}");
        }



    }
}
