using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Situation6 : Situation
    {
        public Situation6() : base("Dark Altar", "En una capilla en ruinas...")
        {

        }

        public override void Play(Character player)
        {
            Console.WriteLine("\n--- " + title + " ---");

            Console.WriteLine("un altar palpita como si tuviera corazón.");

            Console.WriteLine("1. Purificar el altar");

            Console.WriteLine("2. Tomar la reliquia negra");

            string option =
             Console.ReadLine();

            if (option == "1")
            {
                //player.TakeDamage(5);

                //player.Heal(10);

                //player.life += 10;

                player.Life += 10;

                Console.WriteLine("Logras purificarlo con éxito y siente como recobras fuerza.");


                Console.WriteLine($"Recuperas 10 puntos de salud.(tu vida actual es {player.Life})");

            }

            else
            {
                //player.TakeDamage(5);

                //player.life -= 5;

                //player.IncreaseDamage(2);
                //player.damage += 2;
                player.Life -= 5;
                player.Damage += 2;

                Console.WriteLine($"Ganas poder, pero la maldición responde.(tu vida actual es {player.Life} y tu daño actual es {player.Damage})");
            }

        }
    }
}
