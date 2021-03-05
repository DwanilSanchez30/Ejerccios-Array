using System;

namespace Array_9
{
    class Program
    {
        public void Agregar()
        {
            int Valor;
            string Linea;
            do
            {
                Console.Write("Ingrese un valor: ");
                Linea = Console.ReadLine();
                Valor = int.Parse(Linea);
               if (Valor != -1)
                {
                    Calcular(Valor);
                }
            } while (Valor != -1);
        }

        public void Calcular(int V)
        {
            for (int i = V; i <= V * 10; i = i + V)
            {
                Console.Write(i + " - ");
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese -1(negativo 1) para detener el programa");

        }

        static void Main(string[] args)
        {
            Program Num = new Program();
            Num.Agregar();
        }
    }
}
