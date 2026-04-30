using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Situation7 : Situation
    {
        public Situation7() : base("Lost Merchant", "Un figura encapuchada te espera en la oscuridad.")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine("\"Toda alma tiene un precio\".");

            Console.WriteLine("1. Comprar poción maldita");

            Console.WriteLine("2. Robarle");

            string option =
             Console.ReadLine();

            if (option == "1")
            {
                //player.IncreaseDamage(-1);
                player.Damage--;

                //player.Heal(8);
                //player.life += 8;
                player.Life += 8;
                Console.WriteLine("La poción sana tu cuerpo,");

                Console.WriteLine($"pero debilita tu fuerza.(tu vida actual es {player.Life} y tu daño actuales es {player.Damage})");

            }

            else if (option == "2")
            {
                //player.TakeDamage(4);
                //player.life -= 4;
                player.Life -= 4;

                player.items.Add(3);

                Console.WriteLine("Robas una Reliquia Oscura,");

                Console.WriteLine($"pero el mercader te maldice. (tu vida actual es {player.Life})");
            }

        }
    }
}
