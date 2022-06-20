using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] sayilar = {1, 2 ,3, 4, 5, 4 ,3, 2 ,1, 3, 4 };

            int enbuyuksayi = 0;

            for (int i = 0; i < 11; i++) // burda döngü 12 kere dönecek.
            {
            if (sayilar[i] > enbuyuksayi) // eğer sayıların i. elemanı yani o an i kaçsa o elemanı enbuyuksayi değişkeninden buyukse en buyuk sayı değişkenine o değer atanıyor.
            {
            enbuyuksayi = sayilar[i];
            }

            }

            int sayac = 0;
            for (int j = 0; j < 11; j++) // burdaki dongude 12 kere dönecek çünkü dizi 12 elemanlı
            {
            if (enbuyuksayi == sayilar[j]) // eğer en buyuk sayı sayıların j.elemanına eşitse sayac 1 tane artacak.Böylece kaç kere en büyük sayı girildiği bu kodda oluyor
            {
            sayac++;
            }

            }

            Console.WriteLine("{0} kere {1} girildi", sayac, enbuyuksayi);
        }
    }
} 
