﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega
{
    class Pasar_de_turno
    {
        public delegate void PassTurn(object source, EventArgs args);
        public event PassTurn Turn;
    }
}
