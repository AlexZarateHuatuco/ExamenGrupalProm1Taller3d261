using System;

namespace ExamenGrupalT3d26._1
{
    internal class Enemies
    {
        public int enemyHP;//he cambiado esto a public para tener acceso de ese script a este
        public int enemyDamage;//he cambiado esto a public para tener acceso de ese script a este
        private int stamina;
        private int cost;
        private bool isArcher = false;
        private bool isNecromancer = false;

        public void EnemyPuglist()
        {
            //Console.WriteLine("¡Un pug boxeador gigante se mete en tu camino!");
            this.enemyHP = 20;
            this.enemyDamage = 2;
            this.stamina = 9999; //completamente inecesario. no corre codigo para perder estamina ^-^
            this.cost = 1;
        }

        public void EnemyArcher()
        {
            //Console.WriteLine("¡Un Arquero Equeletico se mete en tu camino!!");
            this.enemyHP = 10;
            this.enemyDamage = 6;
            this.stamina = 3;
            this.cost = 1;
            this.isArcher = true;

        }

        public void EnemySniper()
        {
            //Console.WriteLine("¡Un Arquero Equeletico se mete en tu camino!!");
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
            this.isNecromancer = true;
        }


        public void EnemyCorpse()
        {
            this.enemyHP = 10;
            this.enemyDamage = 0;
            this.stamina = -1;
            this.cost = 3;
        }

        public void TakeTurn(Action<int> dealDamage, Action<Enemies> spawnCorpse)
        {

            if (stamina > 0)
            {
                if (isNecromancer)
                {
                    //Enemies corpse = new Enemies();
                    //corpse.EnemyCorpse();
                    //spawnCorpse(corpse);
                }
                else
                {
                    // El resto inflige daño! Pew pew
                    //obvii el pug nunca se le acaba

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

