using System;
using System.Collections.Generic;

namespace odev2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=2222224;
            string sonuc="true";
            while(num>10){
                if(num%2==1){
                    sonuc="false";
                    num=1;
                }
                else if(num%2==0)
                {
                    num/=10;
                }
                
            }
            System.Console.WriteLine(sonuc);
        }
    }
}
