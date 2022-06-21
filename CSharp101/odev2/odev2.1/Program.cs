using System;
using System.Collections;
using System.Collections.Generic;

namespace odev2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 tane sayi giriniz. (negatif veya string girersiniz tekrar girmeniz gerekecektir)");
            int sayi=0;
            int[] arr = new int[20];
            ArrayList asal =new ArrayList();
            ArrayList asalDegil = new ArrayList();
            int toplamAsal=0;
            int toplamAsalDegil=0;
            int a=0;
            while(a!=20){
                try
                {
                    sayi=Convert.ToInt32(Console.ReadLine());
                    if(sayi>0)
                    {
                        arr[a]=sayi;
                        a++;
                        System.Console.WriteLine(a+". sayiyi girdiniz");
                    }
                    else 
                        Console.WriteLine("Hatali giris");
                    
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Hatali giris");
                }
            }
            foreach(int item in arr){
                if(isPrime(item)){
                    toplamAsal+=item;
                    asal.Add(item);
                }
                else{
                    asalDegil.Add(item);
                    toplamAsalDegil+=item;
                }
            }
            Console.WriteLine("Asallar ");
            asal.Sort();
            asal.Reverse();
            foreach (var item in asal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal olmayanlar");
            asalDegil.Sort();
            asalDegil.Reverse();
            foreach (var item in asalDegil)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal olanların ortalaması : "+(toplamAsal/asal.Count));
            Console.WriteLine("Asal olmayanların ortalaması : "+(toplamAsalDegil/asalDegil.Count));

        }
        static bool isPrime(int sayi){
            int kontrol=0;
            if(sayi==1)
                return false;
                for (int j = 2; j < sayi; j++) {
                    if (sayi % j == 0) {
                        kontrol++;
                    }
                }
                if(kontrol==0)
                    return true;
            return false;
        }
    }
}
