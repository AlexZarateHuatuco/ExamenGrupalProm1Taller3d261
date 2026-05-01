using System;

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
