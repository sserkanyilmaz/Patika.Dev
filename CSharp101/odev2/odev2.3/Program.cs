using System;
using System.Collections.Generic;

namespace odev2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cumle giriniz");
            List<char> list = new List<char>();
            string cumle = Console.ReadLine();
            cumle.Split(" ");
            for (int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i]=='i'||cumle[i]=='a'||cumle[i]=='e'||cumle[i]=='u'||cumle[i]=='o')
                    list.Add(cumle[i]);
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
        }
    }
}
