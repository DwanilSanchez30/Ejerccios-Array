using System;

namespace array_4
{
    class Program
    {
        /*Un programa que pida al usuario 10 números y luego calcule y 
        *muestre cuál es el mayor de todos ellos*/
        private int[] Números;
        public void Agregar()
        {
            Números = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese 10 números: ");
                Números[i] = int.Parse(Console.ReadLine());
            }
        }
        public void NumMayor()
        {
            int Mayor;
            Mayor=Números[0];

            for (int i = 1; i < 0; i++)
            {
                if (Números[i] > Mayor)
                {
                    Mayor = Números[i];
                }
            }
            Console.WriteLine("El Numero mayor es: "+Mayor);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program Num = new Program();
            Num.Agregar();
            Num.NumMayor();
        }
    }
}
