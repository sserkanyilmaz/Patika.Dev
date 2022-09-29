using System;

namespace Ucgen_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yükseklik degeri giriniz : ");
            int dikey=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Genişlik degeri giriniz : ");
            int yatay = Convert.ToInt32(Console.ReadLine());
            UcgenCiz(dikey,yatay);
            Console.ReadLine();
        }
        public static void UcgenCiz(int dikey,int yatay)
        {
            for (int i = 0; i <= dikey; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}
