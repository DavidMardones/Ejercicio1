using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundito");
            Console.WriteLine("Ingrese nombre : ");
            //Esto es un scanner
            string nombre = Console.ReadLine();
            //Console.WriteLine("Su nombre es " + nombre);
            Console.WriteLine("Ingrese la edad : ");
            string edadTx = Console.ReadLine().Trim();
            //TRIM = '  32  ' => '32'
            //TRIMSTART = '  32  ' => '32  '
            //TRIMEND = '  32  ' => '  32'

            try 
            {
                int edad2 = int.Parse(edadTx);
            } catch(Exception ex) 
            { 
            
            } 
            

            Console.WriteLine("Su nombre es {0} y la edad es {1}", nombre, edad2);
            Console.ReadKey();
        }
    }
}
