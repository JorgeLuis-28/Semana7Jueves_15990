using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static int cnt = 0;
        static void Main(string[] args)
        {
            string[] Nombres = new string[0];
            int[] Numeros = new int[0];
            int op;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(":::::::::::::: AGENDA DE CONTACTO UPN 2026 ::::::::::::::");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Registrar nuevo contacto");
                Console.WriteLine("2. Ver contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Actualizar contacto");
                Console.WriteLine("5. Eliminar contacto");
                Console.WriteLine("6. Ordenar los contactos");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opcion: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                op = int.Parse(Console.ReadLine());
                Console.ResetColor();
                switch (op)
                {
                    case 1:
                        RegistrarContacto(ref Nombres, ref Numeros);
                        break;
                    case 2:
                        MostrarContactos( Nombres, Numeros);
                        break;
                    case 3:
                        BuscarContactos(Nombres, Numeros);
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("SALIENDO...");
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            } while (op != 0);
        }
        private static void RegistrarContacto(ref string[] nombres,ref int[] numeros)
        {
            Array.Resize(ref nombres, cnt + 1);
            Array.Resize(ref numeros, cnt + 1);

            Console.WriteLine("--- Nuevo Contacto ---");
            Console.WriteLine("Ingrese nombre de su contacto");
            nombres[cnt] = Console.ReadLine();

            Console.WriteLine("Ingrese numero del comntacto");
            numeros[cnt]= int.Parse(Console.ReadLine());
            cnt++;
        }
        private static void MostrarContactos(string[] nombres, int[] numeros)
        {
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine($"- Contacto: {nombres[i]} ({numeros[i]})");
                
            }
        }
        private static void BuscarContactos(string[] nombres, int[] numeros)
        {
            string buscar;
            Console.WriteLine("--- BUSQUEDA DE CONTACTO ---");
            Console.Write("Ingresa un nombre: ");
            buscar = Console.ReadLine();

            for (int i = 0; i < cnt; i++)
            {
                if (nombres[i]==buscar)
                {
                Console.WriteLine($"- Contacto: {nombres[i]} ({numeros[i]})");
                return;
                }
            }
            Console.WriteLine("No esta registrado el contacto");
        }
    }
}
