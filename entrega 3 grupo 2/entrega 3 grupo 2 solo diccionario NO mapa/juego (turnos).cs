using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class tiempo__turnos_
    {
        public delegate void ShiftTime(object source, EventArgs args);
        public event ShiftTime PassTurn;
    }
}
