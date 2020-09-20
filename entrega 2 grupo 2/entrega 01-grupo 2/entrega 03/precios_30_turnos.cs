using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2.entrega_03
{
    class precios_30_turnos
    {
        public delegate void Prices30Shifts(object source, EventArgs args);
        public event Prices30Shifts TurnosPrecios;
    }
}
