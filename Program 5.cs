using System;

namespace Array_5
{
    class Program
    {
        /*5. Un programa que prepare espacio para un máximo de 100 nombres.El usuario deberá ir introduciendo un nombre cada vez, 
        hasta que se pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres y se mostrará en 
        pantalla la lista de los nombres que se han introducido.*/

        static void main(string[] args)
        {
            string[] Nombres = new string[100];
            int i = 0;
            do
            {
                Console.WriteLine("Ingrese un nombre");
                Nombres[i] = Console.ReadLine();

            } while (Nombres[i] != "");
            Console.WriteLine();

            for (i = 0; i = 100; i++) ;
            Console.WriteLine("los nombres tecleados son los de arriba {0}", Nombres[i]);
        } 
    }
}
        