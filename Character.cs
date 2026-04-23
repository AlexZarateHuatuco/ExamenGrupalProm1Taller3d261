using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class Character
    {
        int life;
        int damage;
        string name;
        public string Name => name;
        public int Life => life;
        public int Damage => damage;
        public List<int> items = new List<int>();
        void CharacterCreation()
        {
            Console.WriteLine("Ingrese el nombre del personaje de la historia: ");
            name = Console.ReadLine();
            Console.WriteLine($"Ingrese la cantidad de vida que tendrá {name}: ");
            life = int.Parse(Console.ReadLine());
            Console.WriteLine($"La vida de {name} será de: {life}.");
            Console.WriteLine($"Ingrese la cantidad de daño que tendrá {name}: ");
            damage = int.Parse(Console.ReadLine());
            Console.WriteLine($"El daño de {name} será de: {damage}.");
        }
        public Character(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }
    }
}
