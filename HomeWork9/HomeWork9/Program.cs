using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("Виберіть яку дію ви хочете обрати");
        Console.WriteLine("+;-;*;/;");
        string z = Console.ReadLine();



        switch (z)
        {
            case "+":
                Console.WriteLine(x+y);
                break;

            case "-":
                Console.WriteLine(x - y);
                break;
            case "*":
                Console.WriteLine(x * y);
                break;
            case "/":
               try
                    {
                        double q = x / y;
                    Console.WriteLine(q);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Возникло исключение DivideByZeroException");

                    }
                break;
        }
    }
}

