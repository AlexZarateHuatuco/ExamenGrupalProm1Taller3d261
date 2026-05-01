using System;

namespace ExamenGrupalT3d26._1
{
    internal class Situation2 : Situation
    {
        public Situation2() : base("Prisoner Cell", "Un hombre encadenado tiembla en una celda.")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine("No soy tu enemigo...");

            Console.WriteLine("1. Liberarlo");

            Console.WriteLine("2. Dejarlo");

            string option =
             Console.ReadLine();

            if (option == "1")
            {
                //player.IncreaseDamage(2);
                player.Damage += 2;

                player.items.Add(2);

                Console.WriteLine("Te entrega una Daga de plata.");

                Console.WriteLine($"Tu daño aumenta.(tu daño actual {player.Damage})");

            }

            else
            {
                Console.WriteLine("Sus cadenas resuenan mientras te alejas.");
            }
        }
    }
}
