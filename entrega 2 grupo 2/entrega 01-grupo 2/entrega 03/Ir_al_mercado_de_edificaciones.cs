using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class Ir_al_mercado_de_edificaciones
    {
        public delegate void GoToTheBuildingMarket(object source, EventArgs args);
        public event GoToTheBuildingMarket DestructionSell;

        protected virtual void OnSellOrDestruction()
        {
            if (DestructionSell != null)
                DestructionSell(this, EventArgs.Empty);
        }
        protected virtual void OnSellOrDestruction1()
        {
            if (DestructionSell != null)
                DestructionSell(this, EventArgs.Empty);
        }
    }
}
