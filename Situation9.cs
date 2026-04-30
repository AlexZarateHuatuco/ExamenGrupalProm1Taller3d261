using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Situation9 : Situation  
    {
        public Situation9() : base("Dark Knight", "Frente al trono aparece el Dark Knight.")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine("El guardian del trono levanta su espada.");

            Console.WriteLine("1. Combatir");

            Console.WriteLine("2. Aceptar juicio");

            string option =
             Console.ReadLine();

            if (option == "1")
            {
                if (player.items.Contains(2))
                {
                    player.TakeDamage(4);

                    Console.WriteLine("La Daga de plata atraviesa la armadura.");
                }

                else
                {
                    player.TakeDamage(10);

                    Console.WriteLine("Sin arma sagrada el duelo es brutal.");
                }
            }
            else
            {
                player.Heal(5);

                Console.WriteLine("El caballero prueba tu espíritu");

                Console.WriteLine("y sana tus heridas.");

            }
        }
    }
}
