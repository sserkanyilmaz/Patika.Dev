using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
                int a = 8;
        a+=2;
        Console.WriteLine(a);

        a/=2;
        Console.WriteLine(a);

        bool isCompleted = true;
        bool isSuccess = true;

        if(isCompleted && isSuccess) {
            Console.WriteLine("Operation succesfully completed");
        }

        a = 5;
        int b = 2;

        bool control = b < a;
        Console.WriteLine(control);

        a = 8;
        b = 2;

        int result = a*b;
        Console.WriteLine(result);

        result = a/b;
        Console.WriteLine(result);

        result = a % b;
        Console.WriteLine(result);

        double c = 5.0;
        int f = 5;
        double result3 = c+f;
        Console.WriteLine(result3);
        }
    }
}
