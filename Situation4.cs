using System;

namespace ExamenGrupalT3d26._1
{
    internal class Situation4 : Situation
    {
        public Situation4() : base("Corridor of Spikes", "El suelo tiembla.")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine("Un mecanismo antiguo despierta.");

            Console.WriteLine("1. Correr antes que caiga la trampa");

            Console.WriteLine("2. Buscar el símbolo que desactiva el mecanismo");

            string option =
             Console.ReadLine();

            if (player.LifePotion == true)
            {
                Console.WriteLine("quieres usar la pocion de vida?");
                Console.WriteLine("1.si");
                Console.WriteLine("2.no");

                string optionP = Console.ReadLine();
                if (optionP == "1")
                {
                    player.Life += 5;
                    Console.Write($"usas pocion de vida (vida actual {player.Life}).");
                    player.LifePotion = false;
                }
            }

            if (option == "1")
            {
                //player.TakeDamage(5);
                //player.life -= 5;
                player.Life -= 5;
                Console.WriteLine($"Mientras corres te tropiezas y recibes daño por caida... pero logras pasar la trampa.(vida actual{player.Life})");

            }

            else
            {
                Console.WriteLine("Tardaste en encontrarlo...pero logras desactivar la trampa.");
            }
        }
    }
}
