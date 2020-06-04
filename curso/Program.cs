using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "luis fernando valencia ibarra";
            int edad = 29;
            bool verdadero = false;

            Console.WriteLine(nombre);
            Console.WriteLine(edad);
            Console.WriteLine(verdadero);


            int num1 = 1;
            int num2 = 4;
            int num3 = 5;
           int resultado =  multi(num1, num2, num3);
            Console.WriteLine(resultado);


            Nombreyedad();
            Console.Read();

        }

        static int  multi(int a, int b, int c)
        {
            return  a * b * c;
        }

        static void Nombreyedad()
        {
            int edad;
            string nombre;

            Console.Write("escribe tu nombre ");
            nombre = Console.ReadLine();

            Console.Write("escribe tu edad");
            edad = int.Parse(Console.ReadLine());

            string papa = string.Format("tu nombre es{0}y tu edad es{1}", nombre, edad);
            Console.WriteLine(papa);
            Console.Read();


        }
    }
}
