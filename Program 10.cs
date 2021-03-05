using System;


namespace Array_10
{
    class Program
    {
        /*10.	Confeccionar una clase que permita carga el nombre y la edad de una persona. 
        Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18).*/
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
}
