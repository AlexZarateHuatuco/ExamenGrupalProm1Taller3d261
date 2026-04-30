using ExamenGrupal;
using ExamenGrupalT3d26._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Program
    {
        //List<Enemies> e = new List<Enemies>();//llenan la lista

        static void Main(string[] args)
        {


            bool c = true;
            while (c)
            {
                EnemiesData.Enemies.Clear();

                Character j = new Character("", 0, 0);
                j.CharacterCreation();

                Enemies pug = new Enemies();
                pug.EnemyPuglist();

                Enemies archer = new Enemies();
                archer.EnemyArcher();

                Enemies necro = new Enemies();
                necro.EnemyNecro();

                Enemies sniper = new Enemies();
                sniper.EnemySniper();

                Enemies corpse = new Enemies();
                corpse.EnemyCorpse();

                EnemiesData.Enemies.Add(pug);
                EnemiesData.Enemies.Add(archer);
                EnemiesData.Enemies.Add(necro);
                EnemiesData.Enemies.Add(sniper);
                EnemiesData.Enemies.Add(corpse);

                while (j.Life > 0)//he reemplazo el hp por life
                {
                    GameStart(j, EnemiesData.Enemies);
                    if (j.Life <= 0)
                    {
                        Console.WriteLine("FINAL MALO: HP agotado");
                    }
                }

                Console.WriteLine("¿Volver a intentar?\n1 - Sí\n2 - No");
                string cont = Console.ReadLine();
                if (cont == "2")
                {
                    c = false;
                }
            }
        }

        public static void GameStart(Character j, List<Enemies> enemies)
        {

            List<Situation> situations = new List<Situation>()
            {
                new Situation1(),
                new Situation2(),
                new Situation3(),
                new Situation4(),
                new Situation5(),
                new Situation6(),
                new Situation7(),
                new Situation8(),
                new Situation9(),
                new Situation10()
             };

            foreach (Situation s in situations)
            {
                s.Play(j);

                Console.WriteLine("\n--- Presiona ENTER para continuar ---");
                Console.ReadLine();

                // Si muere, salir del juego
                if (j.Life <= 0)
                {
                    //Console.WriteLine("FINAL MALO: HP agotado");
                    return;
                }
            }

            //int victoryCount = 0;
            //se van contando los enemigos derrotados, victoryCount++;
            /*if (j.items.Contains(3))
            {
                Console.WriteLine("FINAL BUENO: Sobreviviste y derrotaste a todos los enemigos");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("FINAL NEUTRO: Lograste escapar de la mazmorra");
                Environment.Exit(0);
            }*/
        }
    }
}
