using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExamenGrupalT3d26._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool c = true;
            while (c)
            {
                Console.WriteLine("Ingresa tu nombre:");
                string name = Console.ReadLine();
                Console.WriteLine("Ingresa la cantidad de HP:");
                string hp = Console.ReadLine();
                Console.WriteLine("Ingresa el daño:");
                string dmg = Console.ReadLine();
                Character j = new Character(name, hp, dmg);

                List<Enemis> e = new List<Enemis>(); //llenan la lista

                while(j.hp > 0)
                {
                    Juego(j,e);
                    if (j.hp <= 0)
                    {
                        Console.WriteLine("FINAL MALO: HP agotado");
                    }
                }
                
                Console.WriteLine("¿Volver a intentar?\n1 - Sí\n2 - No");
                string cont = Console.ReadLine();
                if(cont == "2")
                {
                    c = false;
                }
            }
        }

        public void Juego(Character j,List<Enemis> enemies)
        {
            int victoryCount = 0;
            //se van contando los enemigos derrotados
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
