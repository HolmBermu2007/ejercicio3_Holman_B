using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_Holman_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora com = new Computadora();
            com.encender();
            
            Console.WriteLine("De que tamaño es su disco: ");
            com.Disco=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el archivo a añadir: ");
            int datos=int.Parse(Console.ReadLine());
            com.añadirdatos(datos);
            int capacidad;
            Console.WriteLine("ingrese el dato a eliminar: ");
            capacidad=int.Parse(Console.ReadLine());
            com.Eliminardato(capacidad);
            com.Apagar();
           
            Console.ReadKey();

        }
    }
}
