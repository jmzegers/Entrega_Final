using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_01_grupo_2.entrega_03
{
    class Revisar_los_precios_históricos_por_semilla
    {
        public delegate void ReviewHistoricalPricesPerSeed(object source, EventArgs args);
        public event ReviewHistoricalPricesPerSeed HistoricalSeed;
    }
}
