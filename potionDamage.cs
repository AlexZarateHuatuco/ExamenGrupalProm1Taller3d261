using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class potionDamage
    {
        public void DamageEnemy(Enemies enemigo)
        {
            enemigo.enemyHP -= 5;
        }
    }
}
