using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Labb_2___Arv
{
    internal class Hund : Djur                      // A new class that inheritance from the Djur-class.
    {
        public bool _KanApportera { get; set; }             //A new variable for this perticular class.

        public Hund(string namn, int ålder, double vikt, bool kanApportera)      //A cunstructor that assigns some of the values right away that I want all dogs to have In common.
            : base(namn, "Hund", ålder, vikt, true, "voff voff")                    
        {
            _KanApportera = kanApportera;                                           
        }

    
        public Hund()
            :base("Okänt", "Hund", 0, 0.0, true, "voff voff")
        {                                                                             //my default-constructor.
            _KanApportera = false;
        }

        public void ViftarPåSvansen()
        {
            Console.WriteLine($"{_Namn} viftar på svansen");                        //some methods.
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Kan apportera : " + (_KanApportera? "Ja" : "Nej"));      //A conditional operator that returns Ja or No depending if the _KanApportera-bool is true or false.

        }
        public override void MakeSound()
        {
            Console.WriteLine($"{_Namn} skäller - {_Läte}");
        }



    }
}
