using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_2
{
    [Serializable]
    public abstract class Edification
    {
        public string tipo;
        public string Name;
        public int PurchasePrice;
        public int SalesPrice;
        public int Health;
        public double Water;
        public int Maturity;
        public bool Disease;
        public double Calidad;
        public List<int> Coordinates; //Coordenadas. Se llenan cuando se compra el producto.

        public virtual int FinalProduction(int calidad)
        {
           
            return calidad;
        }
    }
}
