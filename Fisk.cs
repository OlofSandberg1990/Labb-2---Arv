using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Fisk : Djur                                  // A new class that inheritance from the Djur-class.
    {
        public bool _LeverISaltvatten { get; set; }             //A new variable for this perticular class.

        public Fisk(string namn, int ålder, double vikt, bool leverISaltvatten)
            : base(namn, "Fisk", ålder, vikt, false, "blubb blubb")                     //Assigning some variables right away, so when you creat a new object form the fish-class
        {                                                                               //the string art, bool däggsjur and läte will be set to "Fisk", false, and "blubb blubb".
            
            _LeverISaltvatten = leverISaltvatten;
        }

        public Fisk()
            : base("Okänd", "Fisk", 0, 0.0, false, "blubb blubb")                       //My default-constructor, but even if you create a new object in the main-method without asigning values
        {                                                                               //The art will still be "Fisk" däggdjur false and läte "blubb blubb".
            _LeverISaltvatten = false;
        }

        public void Simmar()
        {
            Console.WriteLine($"{_Namn} simmar");
        }
        public override void Info()
        { 
            base.Info();
            Console.WriteLine("Lever i saltvatten : " + (_LeverISaltvatten ? "Ja" : "Nej"));
        }
        public override void MakeSound()                                                    //Using the override-modifyer to give all the objects created from the fisk-class this method istead of 
        {                                                                                   //the Djur-class method with the same name.
            Console.WriteLine($"Eftersom {_Namn} är en {_Art} är det svårt att göra ljud. Men han försöker så gott det går med {_Läte}");
        }
    }
}
