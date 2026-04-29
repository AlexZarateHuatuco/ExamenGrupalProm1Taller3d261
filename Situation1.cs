using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Situation1 : Situation
    {
        public Situation1() : base("Runed Gate", "Una inmensa puerta cubierta de runas bloquea el descenso.")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine(description);

            Console.WriteLine("Una voz susurra desde la piedra...");

            Console.WriteLine("1. Forzar la puerta");

            Console.WriteLine("2. Resolver mecanismo");

            string option =
             Console.ReadLine();

            if (option == "1")
            {
                player.TakeDamage(5);

                Console.WriteLine("Una aguja envenenada atraviesa tu brazo.");
            }

            else
            {
                Console.WriteLine("Las runas se apagan.");

                Console.WriteLine("Obtienes Llave antigua.");

                player.items.Add(1);
            }
        }
    }
}
