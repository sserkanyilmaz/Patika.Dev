using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //birinciOdev();
            //ikinciodev();
            //ucuncuOdev();
            dorduncuOdev();
        }
        static void birinciOdev(){
            Console.WriteLine("Pozitif bir sayi giriniz : ");
            int n=Convert.ToInt32(Console.ReadLine());
            if(!n.isBiggerThanZero())
            {
                Console.WriteLine("negatif sayi girdiniz !!");
                birinciOdev();
            }
            else 
                birinciOdevSayiAl(n);
        }
        static void birinciOdevSayiAl(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i+1)+".sayiyi giriniz : ");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in arr)
            {
                if(item%2==0)
                    Console.WriteLine(item);
            }
        }
        static void ikinciodev(){
            int sayi1=-1;
            int sayi2=-1;
            Console.WriteLine("iki tane pozitif sayi giriniz : ");
            while(!sayi1.isBiggerThanZero())
            {
                Console.WriteLine("1. sayiyi giriniz :(hatali girersiniz tekrar sayi istenecektir)");
                sayi1=Convert.ToInt32(Console.ReadLine());
            }
            while(!sayi2.isBiggerThanZero())
            {
                Console.WriteLine("2. sayiyi giriniz :(hatali girersiniz tekrar sayi istenecektir)");
                sayi2=Convert.ToInt32(Console.ReadLine());
            }
            int[] arr = new int[sayi1];
            for (int i = 0; i < sayi1; i++)
            {
                Console.WriteLine((i+1)+".sayiyi giriniz : ");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in arr)
            {
                if(item%sayi2==0)
                    Console.WriteLine(item);
            }
        }
        static void ucuncuOdev()
        {
            int sayi1=-1;
            while(!sayi1.isBiggerThanZero())
            {
                Console.WriteLine("bir  pozitif adet sayi giriniz : ");
                sayi1=Convert.ToInt32(Console.ReadLine());
            }
            string[] arr = new string[sayi1];
            for (int i = 0; i < sayi1; i++)
            {
                Console.WriteLine((i+1)+". kelimeyi giriniz : ");
                arr[i]=Console.ReadLine();
            }
            for (int i = sayi1-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);    
            }
        }
        static void dorduncuOdev()
        {
            int harfsayisi=0;
            Console.WriteLine("Bir cumle yaziniz : ");
            string cumle=Console.ReadLine();
            string[] splitArr= cumle.Split(" ");
            Console.WriteLine("Kelime sayisi : "+splitArr.Length);
            foreach (var item in splitArr)
            {
                harfsayisi+=item.Length;
            }
            Console.WriteLine("Harf sayisi : "+harfsayisi);
        }

    }
    static class Extension
    {
        public static bool isEven(this int sayi)
        {
            if(sayi%2==0)
                return true;
            return false;
        }
        public static bool isBiggerThanZero(this int sayi){
            if(sayi<=0)
                return false;
            return true;
        }
    }
}
