using System;

namespace Сумма_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            byte startNumberRandom = 10;
            byte stopNumberRandom = 100;

            Random RandomNumber = new Random();

            int numberRandom = RandomNumber.Next(startNumberRandom, stopNumberRandom);
            int multipleNumber1 = 3;
            int multipleNumber2 = 5;
            int summandNumberFor3=0;
            int summandNumberFor5 = 0;

            for (int i=0;i<=numberRandom;i++)
            {
                if(i%multipleNumber1==0)
                {
                    summandNumberFor3 = summandNumberFor3 + i;
                }
                if (i % multipleNumber2 == 0)
                {
                    summandNumberFor5 = summandNumberFor5 + i;
                }
            }
            Console.WriteLine("Сумма чисел кратных 3 = " + summandNumberFor3+ "\nСумма чисел кратных 5 = " + summandNumberFor5);
        }
    }
}
