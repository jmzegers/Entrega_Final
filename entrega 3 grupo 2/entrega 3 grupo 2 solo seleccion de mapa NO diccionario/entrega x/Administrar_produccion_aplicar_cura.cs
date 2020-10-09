using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Administrar_produccion_aplicar_cura
    {
        public delegate void ApplyCure(object source, EventArgs args);
        public event ApplyCure AplicarCura;
    }
}
