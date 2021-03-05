using System;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") 
            *y luego los muestre en el orden contrario al que se introdujeron.*/
            float aNumeros = new float[5];
            
            Console.WriteLine("Introduzca 5 números: ");

            for ( i = 0; i < 5; i++)
            {
                aNumeros[i] = float.Parse(Console.ReadLine());
            }

            for (float i = 4; i >= 0; i--)
            {
                Console.WriteLine(aNumeros[i]);
            }
            Console.ReadLine();
        }
    }
}
