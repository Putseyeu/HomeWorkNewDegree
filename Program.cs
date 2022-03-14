using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkNewDegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumber = 1;
            int maxNumber = 100;
            int numberFromTask = 2;
            int randomNumber = random.Next(minNumber, maxNumber);
            double numberСomputed = 0;
            int degree = 0;

            while(numberСomputed < randomNumber)
            {
                degree++;
                numberСomputed = Math.Pow(numberFromTask, degree);
            }
            Console.WriteLine($"Случайное число {randomNumber}, число {numberFromTask} в степени {degree} равно {numberСomputed}");
        }
    }
}
