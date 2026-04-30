using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (option == "1")
            {
                player.TakeDamage(5);

                Console.WriteLine("Mientras corres te tropiezas y recibes daño por caida... pero logras pasar la trampa.");

            }

            else
            {
                Console.WriteLine("Tardaste en encontrarlo...pero logras desactivar la trampa.");
            }
        }
    }
}
