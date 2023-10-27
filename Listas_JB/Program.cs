using System;

namespace Listas_JB
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Lista lista = new Lista();

            for (int i = 0; i < 5; i++)
            {
           Console.WriteLine("Ingrese el valor del nuevo nodo:");
                int valor = int.Parse(Console.ReadLine());
                lista.Insertnodo(valor);
            }

            lista.PrintList();
            Console.ReadKey();
        }
    }
    }

