using ExamenGrupalT3d26._1;
using System;

namespace ExamenGrupal
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

            if (player.LifePotion == true)
            {
                Console.WriteLine("quieres usar la pocion de vida?");
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
                Enemies enemy = EnemiesData.Enemies[2];
                combat(player, enemy);
                Console.WriteLine("¡Logras matar al caballero!!,deja caer una pocion de vida");
                player.LifePotion = true;
                /*if (player.items.Contains(2))
                {
                    //player.TakeDamage(4);
                    //player.life = -4;
                    Console.WriteLine("La Daga de plata atraviesa la armadura.");
                }

                else
                {
                    //player.TakeDamage(10);
                    //player.life -= 10;

                    Console.WriteLine("Sin arma sagrada el duelo es brutal.");
                }*/
            }
            else
            {
                //player.Heal(5);
                //player.life += 5;

                player.Life += 5;

                Console.WriteLine("El caballero prueba tu espíritu");

                Console.WriteLine($"y sana tus heridas.(tu vida actual es {player.Life})");

            }
        }

        public void combat(Character player, Enemies enemy)
        {
            if (player.damagePotion == true)
            {
                Console.WriteLine("quieres usar la pocion de daño?");
                Console.WriteLine("1.si");
                Console.WriteLine("2.no");

                string optionP = Console.ReadLine();
                if (optionP == "1")
                {
                    Console.Write($"usas pocion de daño (vida actual del enemigo{enemy.enemyHP}).");
                    player.damagePotion = false;
                }
            }

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
