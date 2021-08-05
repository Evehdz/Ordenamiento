using System;

namespace Ordenamiento
{
    class Directo
    {//Esto es documentar
        
        /// <summary>
        ///  Es el algoritmo directo de burbuja y devuelve una matriz o un arreglo unidimesional
        ///  ordenado de forma ascendente.
        /// </summary>
        /// <param name="A">Es un arreglo unidimensional</param>
        public static void Burbuja(int [] A)
        {
            int N = A.Length; //usa length para recorrer y saber cuantos datos tiene
            for(int i=0; i<N-1; i++)//un for recorre y otro compara
            {
                for(int j=0; j<N-1; j++)
                {
                    //comparamos elementos
                    int aux = 0;
                    if(A[j] > A[j+1])
                    {
                        aux = A[j];
                        //Realiza el intercambio
                        A[j] = A[j + 1];
                        A[j + 1] = aux;
                    }
                }
            }

        }

        //Imprime el arreglo ordenado
        /// <summary>
        /// Despliega en consola un vector unidemensional
        /// </summary>
        /// <param name="A">Es un arreglo unidimensional</param>
        public static void Mostrar(int [] A)
        {
            for(int i=0; i<A.Length; i++)
            {
                Console.Write("{0}, ", A[i]);

            }

            Console.WriteLine();//para que haga un salto de linea
            Console.ReadLine();

        }

        //Generador de vectores aleatorios

        public static int []  GenerarAleatorio(int N)
        {
            int[] A = new int[N];
            Random random = new Random();
            byte [] buffer = new byte[N];
            random.NextBytes(buffer);

            for(int i=0; i<N; i++)
            {
                A[i] = (int)buffer[i];
            }

            return A ;

        }
    }
    
}
