using System;

namespace Laba_1_1
{
    class Program
    {
        public delegate double CalcOp(double x, double y);
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.WriteLine("Оберіть дію: +,-,*,/");
            string str = Console.ReadLine();
            Console.WriteLine("Введіть перше число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть друге число: ");
            double y = Convert.ToDouble(Console.ReadLine());

            switch (str)
            {
                case "+":
                    CalcOp Add = (a, b) => a + b;
                    double add = Add(x, y);
                    Console.WriteLine("Сума: {0:F2}", add);
                    break;
                case "-":
                    CalcOp Sub = (a, b) => a - b;
                    double sub = Sub(x, y);
                    Console.WriteLine("Різниця:{0:F2}", sub);
                    break;
                case "*":
                    CalcOp Mul = (a, b) => a * b;
                    double mul = Mul(x, y);
                    Console.WriteLine("Добуток:{0:F2}", mul);
                    break;
                case "/":
                    CalcOp Div = (a, b) =>
                    b == 0 ? throw new DivideByZeroException("Ділення на 0 недопустиме.") : a / b;
                    double div = Div(x, y);
                    Console.WriteLine("Частка:{0:F2}", div); 
                    break;
                default:
                    Console.WriteLine("Повторіть вибір дії");
                    break;
            }
            Console.ReadLine();
        }
    }
}