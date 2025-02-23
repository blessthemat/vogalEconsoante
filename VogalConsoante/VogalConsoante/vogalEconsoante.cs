using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogalEconsoante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra:");
            string letra = Console.ReadLine();

            if (letra == "a" ||
                letra == "e" ||
                letra == "i" ||
                letra == "o" ||
                letra == "u")
            {
                Console.WriteLine("A letra digitada é uma volgal.");
            }
            else
            {
                Console.WriteLine("A letra digitada é uma consoante.");
            }


        }
    }
}
