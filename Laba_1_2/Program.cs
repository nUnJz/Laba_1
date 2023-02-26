using System;

namespace Laba_1_2
{
    class Program
    {
        delegate int Number();
        delegate double AverCalc(Number[] Array);

        static int GetRandom()
        {
            return new Random().Next(1,10);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.WriteLine("Введіть кількість елементів масиву: ");
            int n = int.Parse(Console.ReadLine());
            
            var Array = new Number[n];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = () => new Number(GetRandom)();
            }

            AverCalc AvC = delegate (Number[] B)
            {
                double sr = 0;
                Console.WriteLine("Суми елементів масиву: ");

                for (int i = 0; i < B.Length; i++)
                {
                    sr += B[i]();
                    // поточна сума елементів масиву виводиться для перевірки роботи програми
                    Console.WriteLine(sr);
                }
             
                return sr / B.Length;
            };

            double aver = AvC(Array);

            Console.WriteLine("Середнє арифметичне: {0:F2}", aver);
            Console.ReadLine();
        }
    }
}