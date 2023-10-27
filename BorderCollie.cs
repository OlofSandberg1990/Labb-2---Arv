using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class BorderCollie : Hund              /// A new class that inheritance from the Hund-class.
    {
        public bool _KanVallaFår {  get; set; }             // //A new variable for this perticular class.

        public BorderCollie(string namn, int ålder, double vikt, bool kanApportera, bool kanVallaFår)           //a constructor for the breed Border Collie. So I set the _Art to "Border Collie" right away.
            :base(namn, ålder, vikt, kanApportera)                                                      
        {
            _Art = "Border Collie";
            _KanVallaFår = kanVallaFår;
        }
        public BorderCollie()
            :base("Okänt", 0, 0.0, false)
        {
            _Art = _Art = "Border Collie";                                                          //My default constructor.
            _KanVallaFår = false;
        }

        public void RullarRunt()
        {
            Console.WriteLine($"{_Namn} rullar runt");
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("Kan valla får : " + (_KanVallaFår? "Ja": "Nej"));                //Making the Info and MakeSound methods override methods.
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{_Namn} skäller på fåren, {_Läte}");
        }
    }
}
