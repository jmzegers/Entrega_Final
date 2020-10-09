using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class administrar_produccion_Obtener_producto_terminado
    {
        public delegate void GetFinishedProduct(object source, EventArgs args);
        public event GetFinishedProduct ObtenerProducto;
    }
}
