using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appclase
{
    class Program
    {
        static void Main(string[] args)
        {
            Contraseña miContraseña;
            miContraseña = new Contraseña("16092001", "julio");
            Console.WriteLine(miContraseña.ToString());
            Console.ReadKey();

        }
    }
}
