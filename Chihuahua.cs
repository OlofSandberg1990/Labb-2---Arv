using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{

                                                                                //See more detailed comments in the BorderCollie-class
    internal class Chihuahua : Hund
    {
        public bool _FårPlatsIHandväskan {  get; set; }

        public Chihuahua(string namn, int ålder, double vikt, bool kanApportera)
            :base(namn, ålder, vikt, kanApportera)
        {
            _Art = "Chihuahua";
            _Läte = "bjäbb bjäbb";
            _FårPlatsIHandväskan = vikt < 3;
        }
        public Chihuahua()
            : base()
        {
            _Art = "Chihuahua";
            _Läte = "bjäbb bjäbb";
            _FårPlatsIHandväskan = false;
        }

        public void LäggIHandVäskan()
        {
            if(_FårPlatsIHandväskan)
            {
                    Console.WriteLine($"Eftersom {_Namn} väger så lite som {_Vikt}kg går det alldeles utmärkt att lägga honom i handväskan");
            }
            else 
            {
                Console.WriteLine($"Ajajaj, {_Namn} väger {_Vikt} vilket är lite för mycket får att få plats i en väska...");
            }
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Får plats i handväskan : " + (_FårPlatsIHandväskan ? "Ja" : "Nej"));
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{_Namn} tar i för fulla muggar - {_Läte}");
        }
    }

   
}
