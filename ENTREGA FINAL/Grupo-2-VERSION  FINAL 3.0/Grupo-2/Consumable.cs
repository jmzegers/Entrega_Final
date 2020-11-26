using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_2
{
    [Serializable]
    public abstract class Consumable
    {
        public string Name;
        public int Price; //precio de compra
        public bool Used = false; // posee un solo uso, false es qu no esta usado
       
    }
}
