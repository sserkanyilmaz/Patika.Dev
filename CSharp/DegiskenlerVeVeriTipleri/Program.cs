using System;

namespace DegiskenlerVeVeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("");
            String degisken =" ";  
            
            byte b= 5;      //1 byte
            sbyte c=5;      //1 byte
            short s=5;      //2 byte
            ushort us=5;    //2 byte

            Int16 i16= 2;   //2 byte
            int i=2;        //4 byte
            int i32=2;    //4 byte

            uint ui =2 ;      //4 byte 
            long l=4;         //8 byte
            ulong ul=4;       //8 byte

            float f=4;        //4 byte
            double d=5;       //8 byte
            decimal de= 5;    //16 byte

            char ch='2';      //2 byte;
            string str = "Serkan ";//sınırsız

            DateTime dt= DateTime.Now; 
            
            System.Console.WriteLine(dt);

            object o1="x";
            object o2='y';
            object o3 = 4;
            object o4=4.1;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Serkan YILMAZ";
            string ad = "Serkan";
            string soyad="YILMAZ";
            string tamAd=ad+" "+soyad;
            
            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2=3;
            int integer3 = integer1* integer2;

            //boolean 

            bool b1= 10<2;

            //degisken donusumleri

            string  str20 = "20";
            int int20=20;
            
            string yeniDeger= str20+int20.ToString();
            System.Console.WriteLine(yeniDeger);

            int int21 = int20+Convert.ToInt32(str20);
            System.Console.WriteLine(int21);

            int int22= int20+int.Parse(str20);


            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(datetime);
            
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH.MM");
            System.Console.WriteLine(datetime3);
        }


    }
}
