using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[0];
            string[] Numeros = new string[0];
            int cnt = 0;
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine(":::::::::::::: AGENDA DE CONTACTO UPN ::::::::::::::");
                Console.WriteLine("1. Registrar nuevo contacto");
                Console.WriteLine("2. Ver contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Actualizar contacto");
                Console.WriteLine("5. Eliminar contacto");
                Console.WriteLine("6. Ordenar los contactos");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opcion: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        break;
                    case 0:
                        Console.WriteLine("SALIENDO...");
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }while (op != 0);
        }
    }
}
