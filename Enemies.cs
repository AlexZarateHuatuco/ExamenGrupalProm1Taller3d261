using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{

    internal class Enemies
    {

        private int enemyHP;
        private int enemyDamage;
        private int stamina;
        private int cost;
        private int archerdefaultval= 3;
        private bool isArcher = false;
        private bool isNecromancer = false;

        public void EnemyPuglist()
        {
            Console.WriteLine("¡Un pug boxeador gigante se mete en tu camino!");
            this.enemyHP = 50;
            this.enemyDamage = 2;
            this.stamina = 9999; //completamente inecesario. no corre codigo para perder estamina ^-^
        }

        public void EnemyArcher()
        {
            Console.WriteLine("¡Un Arquero Equeletico se mete en tu camino!!");
            this.enemyHP = 10;
            this.enemyDamage = 6;
            this.stamina = 3;
            this.cost = 1;
            this.isArcher = true;

        }

        public void EnemySniper()
        {
            Console.WriteLine("¡Un Arquero Equeletico se mete en tu camino!!");
            this.enemyDamage = 6;
            this.stamina = 3;
            this.cost = 1;
            
        }


        public void EnemyNecro()
        {
            this.enemyHP = 10;
            this.enemyDamage = 6;
            this.stamina = -2;
            this.cost = 3;
        }


        public void EnemyCorpse()
        {
            this.enemyHP = 10;
            this.enemyDamage = 0;
            this.stamina = -2;
            this.cost = 4;
            this.isNecromancer = true;
        }

        public void TakeTurn(Action<int> dealDamage, Action<Enemies> spawnCorpse)
        {
            // 1. Si tiene suficiente stamina, actúa
            if (stamina > 0)
            {
                if (isNecromancer)
                {
                    // Necromante invoca un cadáver (no hace daño directo)
                    Enemies corpse = new Enemies();
                    corpse.EnemyCorpse();
                    spawnCorpse(corpse);
                }
                else
                {
                    // El resto inflige daño
                    dealDamage(enemyDamage);
                }
                stamina -= cost;   
            }

            if (stamina <= 0)
            {
                if (isArcher)
                {
                    stamina = 3;   
                }
                else
                {
                    stamina++;     
                }
            }
        }
    }



}
