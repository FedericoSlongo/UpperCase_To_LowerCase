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
            string frase;
            char frase_temp;
            Console.WriteLine("Inserire una frase:");
            frase = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"La frase è");
            for (int i = 0; i < frase.Length; i++)
            {
                switch (frase[i])
                {
                    case 'A':
                        Console.Write("a");
                        break;
                    case 'B':
                        Console.Write("b");
                        break;
                    case 'C':
                        Console.Write("c");
                        break;
                    case 'D':
                        Console.Write("d");
                        break;
                    case 'E':
                        Console.Write("e");
                        break;
                    case 'F':
                        Console.Write("f");
                        break;
                    case 'G':
                        Console.Write("g");
                        break;
                    case 'H':
                        Console.Write("h");
                        break;
                    case 'I':
                        Console.Write("i");
                        break;
                    case 'L':
                        Console.Write("l");
                        break;
                    case 'M':
                        Console.Write("m");
                        break;
                    case 'N':
                        Console.Write("n");
                        break;
                    case 'O':
                        Console.Write("o");
                        break;
                    case 'P':
                        Console.Write("p");
                        break;
                    case 'Q':
                        Console.Write("q");
                        break;
                    case 'R':
                        Console.Write("r");
                        break;
                    case 'S':
                        Console.Write("s");
                        break;
                    case 'T':
                        Console.Write("t");
                        break;
                    case 'U':
                        Console.Write("u");
                        break;
                    case 'V':
                        Console.Write("v");
                        break;
                    case 'Z':
                        Console.Write("z");
                        break;
                    case 'W':
                        Console.Write("w");
                        break;
                    case 'K':
                        Console.Write("k");
                        break;
                    case 'J':
                        Console.Write("j");
                        break;
                    case 'Y':
                        Console.Write("y");
                        break;
                    case 'X':
                        Console.Write("x");
                        break;
                    default:
                        string temp = Convert.ToString(frase[i]);
                        Console.Write(temp.ToUpper());
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
