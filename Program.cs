using System.ComponentModel;

namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Djur> djurLista = new List <Djur> ();     //declaring a new list for my animals


            Katt katt = new Katt ("Kalle", 8, 3.5, "beige");                                
            Hund hund = new Hund ("Fido", 12, 11.4, true);
            Fisk fisk = new Fisk("Nemo", 1, 3.3, true);
            Djur elefant = new Djur("Dumbo", "Elefant", 17, 722, true, "tuuut");                                    //creating some objetcs from my classes
            Chihuahua chihuahua = new Chihuahua("Mozart", 4, 3.1, false);
            BorderCollie borderCollie = new BorderCollie("Bosse", 5, 13.1, true, true);
            Djur kanin = new Djur("Robban", "Kanin", 3, 1.6, true, "pip pip");
            Människa människa = new Människa("Olof", "Sandberg", 33, 94.3, "Finns det mer kaffe?", "tacos");
                        
            djurLista.Add(katt);
            djurLista.Add(hund);
            djurLista.Add(fisk);
            djurLista.Add(elefant);                                     //adding the objects to my list
            djurLista.Add(chihuahua);
            djurLista.Add(borderCollie);
            djurLista.Add(kanin);
            djurLista.Add(människa);



            Console.WriteLine("Välkommen, här kommer först lite info om djuren!");
            Console.ReadKey();
            Console.Clear();
            bool myBool = true;
            while (myBool)
            {
                foreach (Djur djur in djurLista)
                {
                    Console.WriteLine("=======Info om djuren=======");              //printing some info about the animals through my info-method.
                    djur.Info();

                    Console.ReadKey();
                    Console.Clear();
                }
                myBool = false;


                Console.WriteLine("=======Djurens läte=======");

                foreach (Djur djur in djurLista)
                {
                    djur.MakeSound();                                               //printing the sounds by calling the MakeSound-method

                }

                Console.ReadKey();
                Console.Clear();



                Console.WriteLine("Här är alla dägdjur i listan");
                List<Djur> däggdjurLista = djurLista.FindAll(d => d._ÄrEttDäggDjur == true);        //also practised some properties for lists, so here I created a new list
                                                                                                    //that only contains the mammals.
                foreach (Djur däggdjur in däggdjurLista)
                {
                    Console.WriteLine($"{däggdjur._Namn} : {däggdjur._Art}");
                }

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Här är alla djur i listan som väger över 5kg");
                List<Djur> djurÖver5Kg = djurLista.FindAll(d => d._Vikt > 5);

                foreach (Djur item in djurÖver5Kg)
                {
                    Console.WriteLine($"{item._Namn} : {item._Vikt}");                              //another list with the animals that weigh more than 5kg
                }

                Console.ReadKey();
                Console.Clear();





                Console.WriteLine("På återseende!");
                Console.ReadKey();






            }
        }
    }
}