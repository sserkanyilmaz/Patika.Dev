using System;
using System.Collections;

namespace odev2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 tane sayi giriniz. (negatif veya string girersiniz tekrar girmeniz gerekecektir)");
            int a=0;
            int sayi=0;
            ArrayList arr =new ArrayList();
            while(a!=20){
                try
                {
                    sayi=Convert.ToInt32(Console.ReadLine());
                    if(sayi>0)
                    {
                        arr.Add(sayi);
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
            arr.Sort();
            double bastanOrt=(Convert.ToDouble(arr[0])+Convert.ToDouble(arr[1])+Convert.ToDouble(arr[2]))/3;
            double sondanOrt=(Convert.ToDouble(arr[19])+Convert.ToDouble(arr[18])+Convert.ToDouble(arr[17]))/3;
            Console.WriteLine("En buyuk 3 tanesinin ortalamasi  "+sondanOrt);
            Console.WriteLine("En kucuk 3 tanesinin ortalamasi  "+bastanOrt);
        }
    }
}
