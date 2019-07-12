using System;

namespace Tarae8_ing_blucles_pruebaSoft
{
    //Registra el nombre y la edad de una persona, sumara un año si la persona tiene menos de 18, 30 o 60 años.
    class BucleEstructurado
    {
        //Refeces
        private bool tick = true;
        public BucleEstructurado()
        {
            RegistrarEdad();
        }

        private void RegistrarEdad()
        {
            Console.WriteLine("Registra tu edad");
            int edad = Int32.Parse(Console.ReadLine());
            VerificarAdulto(edad);
        }

        private void VerificarAdulto(int edad)
        {
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
                tick = true;
                RegistrarNombre(edad);
            }
            else
            {
                Console.WriteLine("No eres mayor de edad, edad actual: " + edad);
                tick = false;
                SumarEdad(edad);
            }
        }

        private void SumarEdad(int edad)
        {
            if (tick)
            {
                Console.WriteLine("Pasaron 12 meses, un año mas");
                Console.ReadKey();
                int result = edad + 1;
                RegistrarNombre(result);
            }
            else
            {
                VerificarAdulto(edad);
            }
        }

        private void RegistrarNombre(int edad)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            VerificarEdadMedia(edad, nombre);
        }

        private void VerificarEdadMedia(int edad, string nombre)
        {
            if (edad >= 30)
            {
                Console.WriteLine("Tu edad es mayor a 30...");
                Console.ReadKey();
                VerificarTerceraEdad(edad, nombre);
            }
            else
            {
                Console.WriteLine("Aun no tienes 30 años, vuele en un años, edad actual: " + edad);
                SumarEdad(edad);
            }
        }

        private void VerificarTerceraEdad(int edad, string nombre)
        {
            if (edad >= 60)
            {
                Console.WriteLine("Hola: " + nombre + ", tu edad es: " + edad + ". Bienvenido a la tercera edad cof cof...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Aun no estas en la tercera edad, felicidades?, tu edad actual: " + edad);
                Console.ReadKey();
                SumarEdad(edad);
            }
        }
    }
}