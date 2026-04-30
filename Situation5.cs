using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Situation5 : Situation
    {
        public Situation5() : base("Skeleton Guard", "Un caballero esquelético vigila un puente sin fondo.")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine("Sus ojos brillan con fuego azul.");

            Console.WriteLine("1. Enfrentarlo");

            Console.WriteLine("2. Mostrar la llave antigua");

            string option =
             Console.ReadLine();

            if (option == "1")
            {
                player.TakeDamage(8);

                Console.WriteLine("Mientras enfrentas al caballero esquelético recibes daño... pero logras derrotarlo.");

            }

            else if (option == "2")
            {
                if (player.items.Contains(1))
                {
                    Console.WriteLine("El guardia reconoce la llave.");

                    Console.WriteLine("Te permite pasar.");
                }

                else
                {
                    Console.WriteLine("No tienes la llave.");

                    Console.WriteLine("El guardia ataca.");

                    player.TakeDamage(10);
                }
            }
        }
    }
}

