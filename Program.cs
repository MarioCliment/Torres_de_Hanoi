using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            String recolectaStr = "";
            int recoleta = 0;
            

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            recolectaStr = Console.ReadLine();
            recoleta = Int32.Parse(recolectaStr);

            Pila ini = new Pila(recoleta);
            Pila aux = new Pila();
            Pila fin = new Pila();
        }
    }
}
