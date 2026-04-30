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
                //player.TakeDamage(8);
                //player.life -= 8;
                Console.WriteLine("¡Un Arquero Equeletico se mete en tu camino!!");
                Enemies enemy = EnemiesData.Enemies[1];
                combat(player, enemy);
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
                    player.Life -= 8;
                    Console.WriteLine($"No tienes la llave, el guardia te hace un corte y te deja pasar (tu vida actual es {player.Life}");

                    //player.TakeDamage(10);
                    //player.life -= 10;
                }
            }
        }
        public void combat(Character player, Enemies enemy)
        {
            while (player.Life > 0 && enemy.enemyHP > 0)
            {
                enemy.enemyHP -= player.Damage;
                Console.WriteLine($"Atacas al enemigo (vida actual del enemigo: {enemy.enemyHP})");
                if (enemy.enemyHP > 0)
                {
                    player.Life -= enemy.enemyDamage;
                    Console.WriteLine($"El enemigo te ataca (vida actual del jugador: {player.Life})");
                }
            }
        }
    }
}
