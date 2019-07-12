using System;

namespace Tarae8_ing_blucles_pruebaSoft
{
    class BucleConcatenado
    {
        //Refereces
        private int value = 0;
        private bool tick = true;
        public BucleConcatenado()
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
                Add(value);
            }
            else
            {
                Console.WriteLine("The number is not positive");
                Console.ReadKey();
                RegisterValue();
            }
        }

        private void Add(int value)
        {

            if (tick)
            {
                Console.WriteLine("We add 5 the value");
                Console.ReadKey();
                int result = value + 5;
                LimitNumber(result);
            }
            else
            {
                LimitNumber(value);
            }
        }

        private void LimitNumber(int i)
        {
            if (i <= 10)
            {
                Console.WriteLine("The number is less than 10 or equal: " + i);
                Console.WriteLine("##Bucle Concatedado##");
                Console.ReadKey();
            }
            else
            {
                tick = false;
                Console.WriteLine("We subtract 1 from the positive number: " + i);
                Console.ReadKey();
                Add(i - 1);
            }
        }
    }
}
