using System;

namespace Tarae8_ing_blucles_pruebaSoft
{
    //Class that verifies if the number entered is positive and then add it to 5 and verify if that result is less than 10 or equal
    class BucleSimple
    {
        //Refeces
        private bool tick = true;
        public BucleSimple()
        {
            Console.WriteLine("Insert a data (positive and less than 10 or equal)");
            VerifyNumberPositive(Int32.Parse(Console.ReadLine()));
        }

        private void VerifyNumberPositive(int value)
        {
            if (value >= 0)
            {
                Console.WriteLine("The value is positive");
                Console.ReadKey();
                Add(value);
            }
            else
            {
                FailedVerification();
            }
        }

        private void FailedVerification()
        {
            Console.WriteLine("The value has to be positive");
            Console.ReadKey();
            new BucleSimple();
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