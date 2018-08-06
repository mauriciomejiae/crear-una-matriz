using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crear_una_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[100]; //100 cantidad de cajones
            nombre[0] = "Juan";
            nombre[1] = "Pedro";
            nombre[2] = "Diego";
            nombre[3] = "Mauricio";

            Console.WriteLine(nombre[0]);
            Console.WriteLine(nombre[1]);
            Console.WriteLine(nombre[2]);
            Console.WriteLine(nombre[3]);
            Console.ReadKey();

        }
    }
}
