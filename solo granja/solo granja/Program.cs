using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entrega1
{
    class Program
    {
        static void Main(string[] args)
        {            
            string aviso = "ojo que puede que no se pueda ver todo, para eso haga clic derecho en la consola y en propiedades, y luego bajar la letra (por lo menos a 10)";
            Console.WriteLine(aviso);
            Console.WriteLine("¿desea agregar un rio (si(0), no(1)?");
            Console.WriteLine("¿desea agregar un lago (si(0), no(1)?");
            Terrain t = new Terrain();

            Console.WriteLine(t);

            Farm f = new Farm();

            Console.ReadKey();
        }
    }
}
