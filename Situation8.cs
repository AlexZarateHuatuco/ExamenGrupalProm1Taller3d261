using System;

namespace ExamenGrupalT3d26._1
{
    internal class Situation8 : Situation
    {
        public Situation8() : base("Cursed Library", "Un grimorio encadenado susurra tu nombre")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine("mientras late como un órgano vivo.");

            Console.WriteLine("1. Leer Grimorio");

            Console.WriteLine("2. Sellarlo con fuego");

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
                //player.IncreaseDamage(4);
                player.Damage += 4;
                //player.TakeDamage(5);
                //player.life -= 5;
                player.Life -= 5;
                Console.WriteLine($"Obtienes poder prohibido.(tu vida actual es {player.Life} y tu daño actual es {player.Damage})");
            }

            else
            {
                if (player.items.Contains(1))
                {
                    Console.WriteLine("La Llave Antigua revela una ruta secreta.");
                }

                else
                {
                    Console.WriteLine("El libro arde lentamente.");
                }
            }
        }
    }
}
