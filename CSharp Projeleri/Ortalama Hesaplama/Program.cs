using System;

namespace Ortalama_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derinlik Giriniz : ");
            Console.WriteLine("Ortalamasi : "+ FibOrt(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }
        public static double FibOrt(int n)
        {
            int birinci=0,ikinci=1,ucuncu=1;
            double ortalama=1;
            for (int i = 0; i < n-2; i++)
            {
                ucuncu = birinci + ikinci;
                birinci = ikinci;
                ikinci = ucuncu;
                ortalama+=ucuncu;
            }
            return ortalama/n;
        }
    }
}
