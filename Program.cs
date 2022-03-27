using System;

namespace Сумма_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            byte startNumberRandom = 10;
            byte stopNumberRandom = 100;

            Random Rnd = new Random();

            int numberRandom = Rnd.Next(startNumberRandom, stopNumberRandom);
            int multipleNumber1 = 3; 
            int multipleNumber2 = 5;
            int summandNumber=0;

            for(int i=0;i<=numberRandom;i++)
            {
                if(i%multipleNumber1==0|i%multipleNumber2==0)
                {
                    summandNumber = summandNumber + i;
                }
            }
            Console.WriteLine("Сумма чисел кратных "+ multipleNumber1 +" и "+ multipleNumber2+" = " + summandNumber);
        }
    }
}
