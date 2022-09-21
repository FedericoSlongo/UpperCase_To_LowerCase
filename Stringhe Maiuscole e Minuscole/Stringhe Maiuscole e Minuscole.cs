using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringhe_Maiuscole_e_Minuscole
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, frase_lower = "";
            Console.WriteLine("Inserire una frase:");
            frase = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < frase.Length; i++)
            {
                frase_lower += ((Convert.ToString(frase[i])).ToLower());
            }

            Console.WriteLine($"La frase è {frase_lower}");

            Console.ReadKey();
        }
    }
}
