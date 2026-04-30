using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Situation3 : Situation
    {
        public Situation3() : base("Rat Nest", "Un corredor lleno de huesos cruje..")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine("Decenas de ratas emergen de los cadáveres.");

            Console.WriteLine("1. Abrirte paso luchando");

            Console.WriteLine("2. Rodearlo por un túnel estrecho");

            string option =
             Console.ReadLine();

            if (option == "1")
            {
                player.TakeDamage(5);

                Console.WriteLine("Recibiste mordidas y arañasos tratando de luchar.");
          
            }

            else
            {
                Console.WriteLine("Evitas el combate... por ahora.");
            }
        }

    }
}
