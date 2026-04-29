using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Situation10 : Situation
    {
        public Situation10() : base("Fallen Crown", "Sobre el trono reposa una corona negra.")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine("La voz del Rey Caído susurra:");

            Console.WriteLine("\"Tómala... o destruyeme.\"");

            Console.WriteLine("1. Destruir corona");

            Console.WriteLine("2. Reclamar poder");

            string option =
             Console.ReadLine();

            if (option == "1")
            {
                if (player.items.Contains(3))
                {
                    Console.WriteLine("La Reliquia Oscura ayuda a romper la corrupción.");

                    Console.WriteLine("La corona se resquebraja.");
                }
                else
                {
                    player.TakeDamage(10);

                    Console.WriteLine("La corona libera una explosión oscura.");

                    Console.WriteLine("Logras destruirla, pero pagas un precio.");
                }
            }


            else
            {
                player.TakeDamage(15);

                Console.WriteLine("El poder intenta consumirte.");
            }
        }
    }
}
