using System;

namespace Stringhe_Maiuscole_e_Minuscole
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Inserire una frase:");
            string frase = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"La frase è ");
            if (frase != null)
            {
                foreach (char c in frase)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        Console.Write(char.ToLower(c));
                    }
                    else
                    {
                        Console.Write(char.ToUpper(c));
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
