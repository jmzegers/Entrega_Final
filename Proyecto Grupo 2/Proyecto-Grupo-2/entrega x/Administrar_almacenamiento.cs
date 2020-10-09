using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Administrar_almacenamiento
    {
        public delegate void ManageStorage(object source, EventArgs args);
        public event ManageStorage AdministrarA;
    }
}
