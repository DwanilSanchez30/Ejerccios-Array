using System;

namespace Ejercicio_Array
{
    class Program
    {
        /*Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float")
        *y luego los muestre en el orden contrario al que se introdujeron*/
        private int[] Números;
        public void Agregar()
        {
            Números = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese 4 números: ");
                Números[i] = int.Parse(Console.ReadLine());
            }
        }
        public void CantidadNúmeros()
        {
            int Suma = 0;
            int Media = 0;
            for (int i = 0; i < 4; i++)
            {
                Suma += Números[i];
                Media = Suma / 4;
                Console.WriteLine("Los numeros son: {0}", Números[i], Suma);
            }
            Console.WriteLine("Total: {0}", Suma);
            Console.WriteLine("La media es: {0}", Media);
        }
        static void Main(string[] args)
        {
            Program Num = new Program();

            Num.Agregar();
            Num.CantidadNúmeros();
        }
    }
}        