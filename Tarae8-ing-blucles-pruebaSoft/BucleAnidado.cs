using System;

namespace Tarae8_ing_blucles_pruebaSoft
{
    //Class that verifies if the number entered is positive and verify if that result is less than 10 or equal
    class BucleAnidado
    {
        //Refereces
        private int value = 0;
        public BucleAnidado()
        {
            RegisterValue();
        }

        private void RegisterValue()
        {
            Console.WriteLine("Insert a data (positive and less than 10 or equal)");
            value = Int32.Parse(Console.ReadLine());
            VerifyValueNumber();
        }

        private void VerifyValueNumber()
        {
            if (value >= 0)
            {
                Console.WriteLine("The number is positive");
                Console.ReadKey();
                LimitNumber();
            }
            else
            {
                Console.WriteLine("The number is not positive");
                Console.ReadKey();
                RegisterValue();
            }
        }

        private void LimitNumber()
        {
            if (value <= 10)
            {
                Console.WriteLine("The number is less than 10");
                Console.WriteLine("Bucle anidado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The number is greater than 10");
                Console.ReadKey();
                RegisterValue();
            }
        }
    }
}