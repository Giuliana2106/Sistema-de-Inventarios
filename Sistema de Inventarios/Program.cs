using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_Inventarios
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = "";
            string[] nombre = new string[20];
            string[] cantidad = new string[20];
            string[] precio = new string[20];

            for (int i = 0; i < 20; i++) 
            {
                Console.Write("Ingrese nombre del producto: ");
                nombre[i] = Console.ReadLine;
                Console.Write("Ingrese cantidad del producto: ");
                cantidad[i] = Console.ReadLine;
                Console.Write("Ingrese precio: ");
                precio[i] = Console.ReadLine;

            }
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("nombre del producto: " + nombre[x] + "cantidad: " + "precio: ";
            }
            Console.Write("Ingrese el nombre del producto a buscar: ");
            line = Console.ReadLine();

            string consulta = "producto no encontrado";
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese nombre del producto a modificar: ");
                line = Console.ReadLine();

                string consulta = "producto modificado";
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Ingrese nombre del producto a eliminar: ");
                    line = Console.ReadLine();

                    for (int x = 0; x < 5; x++)
                    {
                        if (nombre[x] == line)
            {
                nombre[x] = "";
            }
                    }
        Console.WriteLine(consulta);
            Console.ReadKey();
                   
                    }
                }
            }

        }
    }
}
