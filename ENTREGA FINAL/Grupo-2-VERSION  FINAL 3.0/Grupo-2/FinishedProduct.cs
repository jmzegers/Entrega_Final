using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_2
{
    [Serializable]
    public class FinishedProduct
    {
        public string tipo; // nombre o tipo  de la semilla o ganadado
        public double calidad;

        public FinishedProduct(string tipo, double calidad)
        {
            this.tipo = tipo;
            this.calidad = calidad;
        }
    }
}
