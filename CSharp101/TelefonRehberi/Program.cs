using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kisiler> rehber = new List<Kisiler>();
            rehber.Add(new Kisiler{isim="serkan",soyisim="yilmaz",telefonNumarasi=1});
            rehber.Add(new Kisiler { isim = "samsar", soyisim ="karaca", telefonNumarasi = 2 });
            rehber.Add(new Kisiler { isim = "salah", soyisim = "dogan", telefonNumarasi = 3});
            rehber.Add(new Kisiler { isim = "sinan", soyisim = "sanmaz", telefonNumarasi = 4 });
            rehber.Add(new Kisiler { isim = "selam", soyisim = "taze", telefonNumarasi = 5 });
            rehber.Add(new Kisiler { isim = "salih", soyisim = "okan", telefonNumarasi = 6 });
            int secim=1;
            do
            {
                Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz : \n*******************************************\n(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\n(6)Cikmak");
                secim=Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:{
                        rehber.Add(NumaraKaydet());
                        break;
                    } 
                    case 2:{
                        NumaraSil(rehber);
                        break;
                    }
                    case 3:{
                        NumaraGuncelle(rehber);
                        break;
                    }
                    case 4:{
                        RehberiListele(rehber);
                        break;
                    }
                    case 5:{
                        AramaYap(rehber);
                        break;
                    }
                        

                }
            }while(secim!=6);
        }
        static Kisiler NumaraKaydet(){
            Kisiler kisi = new Kisiler();
            Console.WriteLine("İsim giriniz : ");
            kisi.isim=Console.ReadLine();
            Console.WriteLine("Soyisim giriniz : ");
            kisi.soyisim=Console.ReadLine();
            Console.WriteLine("Numara giriniz : ");
            kisi.telefonNumarasi=Convert.ToInt64(Console.ReadLine());
            return kisi;
        }
        static void NumaraSil(List<Kisiler> list)
        {
            bool kontrol = true;
            bool kontrol2=true;
            string isimVeyaSoyisim="";
            int secim=0;
            string secim2="";
            do
            {    
                Console.WriteLine("Silmek istediginiz kişinin ismin veya soyismini giriniz : ");
                isimVeyaSoyisim=Console.ReadLine();
                foreach (var item in list)
                {
                    if(item.isim==isimVeyaSoyisim||item.soyisim==isimVeyaSoyisim)
                    {
                        Console.WriteLine("Silmeyi onaylıyor musunuz (y/n)");
                        secim2=Console.ReadLine();
                        if(secim2=="y")
                        {
                            list.Remove(item);
                            kontrol = false;
                            kontrol2=false;
                            break;
                        }
                        if(secim2=="n")
                        {
                            kontrol2=false;
                            kontrol=false;
                            break;
                        }
                        
                    }
                }
                if(kontrol2==true){
                    Console.WriteLine("Aradiginiz kisi bulunamadi !!\n(1)tekrar denemek(2)islemi iptal etmek");
                    secim=Convert.ToInt32(Console.ReadLine());
                    if(secim==2)
                    {
                        kontrol=false;
                    }
                }
                
            } while (kontrol);
        }
        static void NumaraGuncelle(List<Kisiler> list){
            
            bool kontrol = true;
            int kontrol2=1;
            string isimVeyaSoyisim="";
            int secim=0;
            do
            {    
                Console.WriteLine("Numarasini guncellemek istediginiz kişinin ismin veya soyismini giriniz : ");
                isimVeyaSoyisim=Console.ReadLine();
                foreach (var item in list)
                {
                    if(item.isim==isimVeyaSoyisim||item.soyisim==isimVeyaSoyisim)
                    {
                        Console.WriteLine("Eslesme bulundu !\nYeni numarayi giriniz");
                        item.telefonNumarasi=Convert.ToInt32(Console.ReadLine());
                        kontrol2=2;
                        kontrol=false;
                        break;
                    }
                }
                if(kontrol2==1){
                    Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı !!\n(1)tekrar denemek(2)islemi iptal etmek");
                    secim=Convert.ToInt32(Console.ReadLine());
                    if(secim==2)
                    {
                        kontrol=false;
                    }
                }
                
            } while (kontrol);
        }
        static void RehberiListele(List<Kisiler> list)
        {
            string[] arr = new string[list.Count];
            int i=0;
            int a=0;
            foreach(var item in list)
            {
                arr[i]=item.isim;
                i++;
            }
            i=0;
            Array.Sort(arr);
            Console.WriteLine("A-Z icin (1)\nZ-A icin (2)\n giriniz ");
            a=Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                for (int z = 0; z < arr.Length; z++)
                {
                    foreach (var item in list)
                    {
                        if (arr[i] == item.isim)
                        {
                            Console.WriteLine("Isim : " + item.isim + " Soyisim : " + item.soyisim + " Telefon Numarasi : " + item.telefonNumarasi + "\n-");
                            arr[i] = " ";
                            i++;
                            if (i == arr.Length)
                            {
                                i--;
                            }
                        }
                    }
                }
            }
            Array.Reverse(arr);
            if (a == 2)
            {
                for (int z = 0; z < arr.Length; z++)
                {
                    foreach (var item in list)
                    {
                        if (arr[i] == item.isim)
                        {
                            Console.WriteLine("Isim : " + item.isim + "Soyisim : " + item.soyisim + " Telefon Numarasi : " + item.telefonNumarasi + "\n-");
                            arr[i] = " ";
                            i++;
                            if (i == arr.Length)
                            {
                                i--;
                            }
                        }
                    }
                }
            }
        }
        static void AramaYap(List<Kisiler> list){
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
            int secim=Convert.ToInt32(Console.ReadLine());
            string isimVeyaSoyisim="";
            long numara=0;
            if(secim==1)
            {
                Console.WriteLine("Isim veya Soyisim giriniz : ");
                isimVeyaSoyisim=Console.ReadLine();
                foreach (var item in list)
                {
                    if (item.isim == isimVeyaSoyisim || item.soyisim == isimVeyaSoyisim)
                    {
                        Console.WriteLine("Isim : " + item.isim + "Soyisim : " + item.soyisim + " Telefon Numarasi : " + item.telefonNumarasi + "\n-");
                    }
                }
            }
            if (secim == 2)
            {
                Console.WriteLine("Isim veya Soyisim giriniz : ");
                numara = Convert.ToInt64(Console.ReadLine());
                foreach (var item in list)
                {
                    if (item.telefonNumarasi == numara)
                    {
                        Console.WriteLine("Isim : " + item.isim + " Soyisim : " + item.soyisim + " Telefon Numarasi : " + item.telefonNumarasi + "\n-");
                    }
                }
            }
        }
    }
    class Kisiler{
        public string isim { get; set; }
        public string soyisim { get; set; }
        public long telefonNumarasi { get; set; }
    }

}
