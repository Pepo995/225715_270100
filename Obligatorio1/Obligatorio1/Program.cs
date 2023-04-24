using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string contraseña;

            Console.WriteLine("Escribir nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribir contraseña");
            contraseña = Console.ReadLine();

            Cliente cliente = new Cliente()
            {
                NombreUsuario = nombre,
                Contraseña = contraseña,
            };
            Console.WriteLine("el cliente es:");
            Console.WriteLine(cliente.NombreUsuario);
        }
    }
}
