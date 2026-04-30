using System;
using System.CodeDom;
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
                if (player.items.Contains(3))
                {
                    Console.WriteLine("La Reliquia Oscura ayuda a romper la corrupción.");

                    Console.WriteLine("La corona se resquebraja.");

                    Console.WriteLine("FINAL BUENO: al resquebrajar la corona logras elimnar por completo el mal que habitaba en la mazmorra");
                }
                else
                {

                    player.Life -= 20;
                    Console.WriteLine("La corona libera una explosión oscura.");

                    Console.WriteLine($"Logras destruirla, pero pagas un precio.(tu vida actual es {player.Life})");
                    if (player.Life <5)
                    {
                        Console.WriteLine("FINAL NEUTRAL: luego de destruir la corona caminas hacia el final de la mazmorra pero por tantas heridas que tienes caes ");
                    }
                    else
                    {
                        Console.WriteLine("FINAL NEUTRAL: luego de destruir la corona caminas hacia el final de la mazmorra");
                    }

                }
            }


            else
            {

                player.Life -= 15;
                Console.WriteLine($"El poder intenta consumirte.(tu vida actual es {player.Life})");
                if (player.Life > 0)
                {
                    Console.WriteLine("FINAL Malo: el poder logro consumirte y ahora te vuelves el nuevo jefe de la mazmorra");
                }
                else
                {
                    Console.WriteLine("FINAL Malo: no soportas el poder y mueres");
                }



            }
        }
    }
}
