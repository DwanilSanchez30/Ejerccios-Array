using System;

namespace Array_8
{
    class Program
    {
    /*8. Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas.
    Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.*/
        private float[] Alturas;
        private float Promedio;
        public void Agregar()
        {
            Alturas = new float[5];
        
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese altura de una persona: ");
                string linea = Console.ReadLine();
                Alturas[f] = float.Parse(linea);
            }
        }
        public void CPromedio()
        {
            float suma;
            suma = 0;
            for (int f = 0; f < 5; f++)
            {
                suma = suma + Alturas[f];
            }
            Promedio = suma / 5;
            Console.WriteLine("Promedio de las alturas es: " + Promedio);
        }
        public void DiferenciasAlturas()
        {
            int Mayor, Menor;

            Mayor = 0;
            Menor = 0;
            for (int f = 0; f < 5; f++)
            {
                if (Alturas[f] > Promedio)
                {
                    Mayor++;
                }
                else
                {
                    if (Alturas[f] < Promedio)
                    {
                        Menor++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas Mayores al Promedio: " + Mayor);
            Console.WriteLine("Cantidad de personas Menores al Promedio: " + Menor);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program Alt = new Program();
            Alt.Agregar();
            Alt.CPromedio();
            Alt.DiferenciasAlturas();
        }
    }
}