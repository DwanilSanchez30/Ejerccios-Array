/*1. Un programa que pida al usuario 4 números, los memorice (utilizando un array), 
calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.*/
/*using System;

namespace Ejercicio_Array
{
    class Program
    {
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
}*/

/*2. Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") 
*y luego los muestre en el orden contrario al que se introdujeron.*/
/*using System;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
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
}*/

/*3. Un programa que almacene en un array el número de días que tiene cada mes 
    (supondremos que es un año no bisiesto), pida al usuario que le indique un mes 
    (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.*/
/*using System;

namespace Array3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] Meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            var NombreMes=0;

            while (NombreMes <= 0 || NombreMes > 12)
            {
                Console.WriteLine("Ingrese el número de un mes: ");
                NombreMes = int.Parse(Console.ReadLine());
            }

            var Dias = System.DateTime.DaysInMonth(2021, NombreMes);
            Console.WriteLine(Meses[NombreMes - 1] + " tiene " + Dias + " Días ");
        }
    }
}*/

/*4. Un programa que pida al usuario 10 números y luego calcule y 
*muestre cuál es el mayor de todos ellos*/
/*using System;

namespace array_4
{
    class Program
    {
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
}*/

/*5. Un programa que prepare espacio para un máximo de 100 nombres.El usuario deberá ir introduciendo un nombre cada vez, 
        hasta que se pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres y se mostrará en 
        pantalla la lista de los nombres que se han introducido.*/
/*using System;

namespace Array_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[100];
            int i = 0, Nom = 0;
            do
            {
                Console.WriteLine("Ingrese un Nombre");
                Nombres[i] = Console.ReadLine();

            }while (Nombres[i] != "");
            Console.WriteLine();

            for (i = 0; i < 100; i++)
            {
                Nombres[i] = Console.ReadLine();
                
                if(Nombres[i]== "")
                {
                    Nom = i;
                    break;
                }
            }
            for (i = 0; i < Nom; i++)
            Console.WriteLine("los nombres tecleados son {0}", Nombres[i]);
        }
    }
}*/

/*7. Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio.
    Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n".*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_7
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Ingrese un Nombre: ");
            string Nombre=Console.ReadLine();
            for(int i=0; i<Nombre.Length; i++)
            {
                Console.Write(Nombre[i] + " ");
            }
        }
    }
}*/

/*8. Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas.
Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.*/
/*using System;

namespace Array_8
{
    class Program
    {
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
}*/

/*9. Crear una clase que permita ingresar valores enteros por teclado y 
nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.*/
/*using System;

namespace Array_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros=0;
             
            Console.WriteLine("Introduzca un numero: ");
            numeros=int.Parse(Console.ReadLine());
            
            while (true)
            {
                if (Valor != -1)
                {
                    Calcular(numeros);
                }
            }
        }
        public void Calcular(int V)
        { 
            for (int i = V; i <= V * 10; i = i + V)
            {
                Console.WriteLine(numeros+"x"+i+" = "+(i*numeros));
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese -1(negativo 1) para detener el programa");
        }
    }
}*/

/*10.	Confeccionar una clase que permita carga el nombre y la edad de una persona. 
Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18).*/
/*using System;


namespace Array_10
{
    class Program
    {
        
        private string nombre;
        private int edad;
        public void Agregar()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Mostrar()
        {
            Console.Write("Nombre:");
            Console.WriteLine(nombre);
            Console.Write("Edad:");
            Console.WriteLine(edad);
        }

        public void MayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write("Es mayor de 18 años");
            }
            else
            {
                Console.Write("No es mayor de 18 años");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program Persona = new Program();
            Persona.Agregar();
            Persona.Mostrar();
            Persona.MayorEdad();
        }
    }
}*/
