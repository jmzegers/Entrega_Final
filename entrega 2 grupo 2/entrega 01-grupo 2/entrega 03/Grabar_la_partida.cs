﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2
{
    class Grabar_la_partida
    {
        public delegate void SaveTheGame(object source, EventArgs args);
        public event SaveTheGame Save;
    }
}
