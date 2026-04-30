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
                //player.TakeDamage(5);
                //player.life -= 5;
                Console.WriteLine("¡Un pug boxeador gigante se mete en tu camino!");
                Enemies enemy = EnemiesData.Enemies[0];
                combat(player, enemy);
                Console.WriteLine("Recibiste mordidas y arañasos tratando de luchar.");
                Console.Write("al morir el enemigo aparecio una pocion de vida, te la guardas para mas tarde");
                player.LifePotion = true;

            }

            else
            {
                Console.WriteLine("Evitas el combate... por ahora.");
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
