using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class potionDamage
    {
        int DamageToEnemy;

        public potionDamage(int damageToEnemy)
        {
            this.DamageToEnemy = damageToEnemy;
            DañarEnemigo();
        }

        void DañarEnemigo()
        {
            DamageToEnemy = -2;
        }
    }
}
