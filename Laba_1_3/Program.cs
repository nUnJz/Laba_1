using System;

namespace Laba_1_3
{
    class Program
    {
        delegate double CalcAver(int x, int y, int z);

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.WriteLine("Введіть перше число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть третє число: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            CalcAver CA = delegate (int a, int b, int c)
            {
                double aver;
                aver = (a + b + c) / (double)3;
                return aver;
            };

            double res = CA(x, y, z);

            Console.WriteLine("Середнє арифметичне трьох чисел: {0:F2}", res);
            Console.ReadLine();
        }
    }
}