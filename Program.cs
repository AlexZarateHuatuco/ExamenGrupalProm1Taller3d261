using System;
using System.Collections.Generic;

namespace ExamenGrupalT3d26._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool c = true;
            while (c)
            {
                Character j = new Character("", 0, 0);
                j.CharacterCreation();

                List<Enemies> e = new List<Enemies>(); //llenan la lista
               
                Juego(j,e);
                                
                Console.WriteLine("¿Volver a intentar?\n1 - Sí\n2 - No");
                string cont = Console.ReadLine();
                if(cont == "2")
                {
                    c = false;
                }
            }
        }

        public static void Juego(Character j,List<Enemies> enemies)
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
                    Console.WriteLine("FINAL MALO: HP agotado");
                    return;
                }
            }

            int victoryCount = 0;
            //se van contando los enemigos derrotados, victoryCount++;
            if(victoryCount == enemies.Count)
            {
                Console.WriteLine("FINAL BUENO: Sobreviviste y derrotaste a todos los enemigos");
            }
            else
            {
                Console.WriteLine("FINAL NEUTRO: Lograste escapar de la mazmorra");
            }
        }
    }
}
