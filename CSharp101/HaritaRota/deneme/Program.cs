using System;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(aciBul(2,3,4));
        }
        public static double aciBul(double bir,double iki,double ucuncu)
        {
            double cos;
            cos=((Math.Pow(bir,2)+Math.Pow(iki,2)-Math.Pow(ucuncu,2))/(2*bir*iki));
            return cos;
        } 
    }
}
