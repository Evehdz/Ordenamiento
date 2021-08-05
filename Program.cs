using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 5, 1, 50, 9, 30, 2 };
            Stopwatch sw = new Stopwatch();

            /*Directo.Mostrar(A);
            Directo.Burbuja(A);
            Directo.Mostrar(A);*/

            A = Directo.GenerarAleatorio(5000);
            //Directo.Mostrar(A);   
            sw.Start();
            Directo.Burbuja(A);
            sw.Stop();
            Console.WriteLine("Tiempo de ejecución en [ms]: {0}", sw.ElapsedMilliseconds); 
            Directo.Mostrar(A);
            Console.ReadLine();



        }
    }
}
