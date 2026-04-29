using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupalT3d26._1
{
    internal class potionLife
    {
        int RecoveredLife;

        public potionLife(int recoveredLife)
        {
            this.RecoveredLife = recoveredLife;
            recoverLife();
        }

        void recoverLife()
        {
            RecoveredLife++;
        }
    }
}
