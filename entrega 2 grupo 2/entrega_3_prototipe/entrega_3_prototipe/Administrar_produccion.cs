using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_3_prototipe
{
    class Administrar_produccion_agregar_agua_o_comida
    {
        public delegate void AddWaterOrFood(object source, EventArgs args);
        public event AddWaterOrFood AddSomething;
    }
}
