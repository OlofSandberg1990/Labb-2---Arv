using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Katt : Djur
    {
        public string _Färg {  get; set; }

        public Katt(string namn, int ålder, double vikt, string färg)
            : base(namn, "Katt", ålder, vikt, true, "mjau mjau")
        {
            _Färg = färg;
            
        }
        public Katt()
            : base("okänt", "Katt", 0, 0.0, true, "mjau mjau")
        {
            _Färg = "okänt";
        }
        public void Spinner()
        {
            Console.WriteLine($"{_Namn} spinner...");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_Namn} säger {_Läte}");
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Färg : " + _Färg);
        
        }

    }
}
