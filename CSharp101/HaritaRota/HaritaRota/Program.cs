using System;

namespace HaritaRota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempMesafe = 0;
            int bitisNoktasi = 1;
            int baslangicNoktasi = 0;
            double[] dikey= new double[5];
            for (int i = 0; i < dikey.Length; i++)
            {
                Console.WriteLine(i+". elemani giriniz dikey");
                dikey[i] = Convert.ToDouble(Console.ReadLine());
            }
            double[] yatay = new double[5];
            for (int i = 0; i < yatay.Length; i++)
            {
                Console.WriteLine(i + ". elemani giriniz yatay ");
                yatay[i] = Convert.ToDouble(Console.ReadLine());
            }
            double[] mesafe = new double[5];
            for (int i = 0; i < dikey.Length-1; i++)
            {
                mesafe[i]=mesafeBul(dikey, yatay, i,i+1);
            }
            foreach (double item in mesafe)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < dikey.Length - 2; i++)
            {
                Console.WriteLine(araAciBul(mesafeBul(dikey, yatay, i, i + 1), mesafeBul(dikey, yatay, i + 1, i + 2), mesafeBul(dikey, yatay, i, i + 2)));
            }
            while (bitisNoktasi!=dikey.Length-1)
            {
                tempMesafe = araAciBul(mesafeBul(dikey, yatay, baslangicNoktasi, bitisNoktasi), mesafeBul(dikey, yatay, baslangicNoktasi + 1, bitisNoktasi + 1), mesafeBul(dikey, yatay, baslangicNoktasi, bitisNoktasi + 1));
                if(tempMesafe>=0.9||tempMesafe<=(-0.9))
                {
                    yatay[baslangicNoktasi + 1] = yatay[baslangicNoktasi + 2];
                    dikey[baslangicNoktasi + 1] = dikey[baslangicNoktasi + 2];
                    baslangicNoktasi += 1;
                    bitisNoktasi += 1;
                    Console.WriteLine("degistirildi");
                }
                else
                {
                    baslangicNoktasi += 1;
                    bitisNoktasi += 1;
                    Console.WriteLine("degistirilmedi");
                }
            }
            for (int i = 0; i < dikey.Length - 1; i++)
            {
                mesafe[i] = mesafeBul(dikey, yatay, i, i + 1);
            }
            foreach (double item in mesafe)
            {
                Console.WriteLine(item);
            }
        }
        public static double mesafeBul(double[] dikey, double[] yatay,int baslangic,int bitis)
        {
            double mesafe = 0;
            mesafe = Math.Sqrt(Math.Pow((dikey[baslangic] - dikey[bitis]), 2) + Math.Pow((yatay[baslangic] - yatay[bitis]), 2));
            return mesafe;
        }
        public static double araAciBul(double ilkKenar,double ikinciKenar,double ucuncuKenar)
        {
            double cos;
            cos = ((Math.Pow(ilkKenar, 2) + Math.Pow(ikinciKenar, 2) - Math.Pow(ucuncuKenar, 2)) / (2 * ilkKenar * ikinciKenar));
            return cos;
        }
    }
}
