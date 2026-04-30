using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Character
    {
        bool continueFlag = true;

        int life;//lo hice public para poder acceder desde las situaciones
        int damage;//lo hice public para poder acceder desde las situaciones
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Life
        {
            get { return life; }
            set { life = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public List<int> items = new List<int>();
        public void CharacterCreation()
        {
            while (continueFlag)
            {
                Console.WriteLine("Ingrese el nombre del personaje de la historia: ");
                name = Console.ReadLine();

                // VIDA
                Console.WriteLine($"Ingrese la cantidad de vida que tendrá {name}: ");
                life = int.Parse(Console.ReadLine());

                if (life > 100 || life < 0)
                {
                    Console.WriteLine("La vida debe estar entre 0 y 100.");
                    continue;
                }

                Console.WriteLine($"La vida de {name} será de: {life}.");

                // DAÑO
                Console.WriteLine($"Ingrese la cantidad de daño que tendrá {name}: ");
                damage = int.Parse(Console.ReadLine());

                if (damage > 100 || damage < 0)
                {
                    Console.WriteLine("El daño debe estar entre 0 y 100.");
                    continue;
                }

                Console.WriteLine($"El daño de {name} será de: {damage}.");

                continueFlag = false;
            }
        }
        public Character(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }
    }
}
