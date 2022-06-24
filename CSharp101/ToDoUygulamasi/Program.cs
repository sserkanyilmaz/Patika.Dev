using System;
using System.Collections.Generic;

namespace ToDoUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kart> TODO = new List<Kart>();
            List<Kart> INPROGRESS = new List<Kart>();
            List<Kart> DONE = new List<Kart>();
            int secim=0;
            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)******************************************\n(1) Board Listelemek\n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek\n(4) Kart Taşımak\n(5)Cikis");
                secim=Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:{
                        kartlariListele(TODO,INPROGRESS,DONE);
                        break;
                    }
                    case 2:
                    {
                        kartEkle(TODO);
                        break;
                    }
                    case 3:
                    {
                        kartSil(TODO, INPROGRESS, DONE);
                        break;
                    }
                    case 4:
                    {
                        kartTasi(TODO, INPROGRESS, DONE);
                        break;
                    }
                }
            } while (secim!=5);
            Console.ReadLine();
        }
        static void kartEkle(List<Kart> list){
            Kart kart = new Kart();
            Console.WriteLine("Başlık Giriniz                                   : ");
            kart.baslik=Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                   : ");
            kart.icerik = Console.ReadLine();
            Console.WriteLine("Atanan Kisiyi  Giriniz                           : ");
            kart.atananKisi = Console.ReadLine();
        BUYUKLUK_DON:
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int tempbuyukluk = Convert.ToInt32(Console.ReadLine().ToLower());
            if (tempbuyukluk == (int)Buyukluk.XS)
                kart.buyukluk = "XS";
            else if (tempbuyukluk == (int)Buyukluk.S)
                kart.buyukluk = "S";
            else if (tempbuyukluk == (int)Buyukluk.M)
                kart.buyukluk = "M";
            else if (tempbuyukluk == (int)Buyukluk.L)
                kart.buyukluk = "L";
            else if (tempbuyukluk == (int)Buyukluk.XL)
                kart.buyukluk = "XL";
            else
            {
                Console.WriteLine("Yanlış Tuşlama Yaptınız Tekrar Deneyiniz.");
                goto BUYUKLUK_DON;
            }
            list.Add(kart);
        }
        static void kartGuncelle(List<Kart> listTODO, List<Kart> listINPROGRESS, List<Kart> listDone){
            
        }
        static void kartSil(List<Kart> listTODO, List<Kart> listINPROGRESS, List<Kart> listDone)
        {
            bool kontrol = true;
            Kart kart= new Kart();
            kart.baslik=" ";
            int secim=0;
            string bulunduMu="";
            string tempBaslik="";
            do
            {
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
                tempBaslik=Console.ReadLine();
                foreach (var item in listTODO)
                {
                    if(item.baslik==tempBaslik){
                        listTODO.Remove(item);
                        bulunduMu = "evet";
                        if(listTODO.Count==0)
                        {
                            break;
                        }
                    }
                }
                foreach (var item in listINPROGRESS)
                {
                    if (item.baslik == tempBaslik)
                    {
                        listINPROGRESS.Remove(item);
                        bulunduMu = "evet";
                        if (listINPROGRESS.Count == 0)
                        {
                            break;
                        }
                    }
                }
                foreach (var item in listDone)
                {
                    if (item.baslik == tempBaslik)
                    {
                        listDone.Remove(item);
                        bulunduMu="evet";
                        if (listDone.Count == 0)
                        {
                            break;
                        }
                    }
                }
                if(bulunduMu!="evet"){
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\nSilmeyi sonlandırmak için: (1)\nYeniden denemek için: (2)");
                    secim=Convert.ToInt32(Console.ReadLine());
                    if(secim==1)
                        kontrol=false;
                }
                else if(bulunduMu=="evet")
                {
                    kontrol=false;
                }
            } while (kontrol);
        }
        static void kartTasi(List<Kart> listTODO, List<Kart> listINPROGRESS, List<Kart> listDone){
            bool kontrol = true;
            Kart kart = new Kart();
            string tempBaslik="";
            string bulunduMu="";
            int hangiList=0;
            int secim=0;
            do
            {
                Console.WriteLine(" Öncelikle tasimak istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
                tempBaslik = Console.ReadLine();
                foreach (var item in listTODO)
                {
                    if(item.baslik==tempBaslik)
                    {
                        kart=item;
                        bulunduMu="evet";
                        hangiList=1;
                        break;
                    }
                }
                foreach (var item in listINPROGRESS)
                {
                    if (item.baslik == tempBaslik)
                    {
                        kart = item;
                        bulunduMu = "evet";
                        hangiList=2;
                        break;
                    }
                }
                foreach (var item in listDone)
                {
                    if (item.baslik == tempBaslik)
                    {
                        kart = item;
                        bulunduMu = "evet";
                        hangiList=3;
                        break;
                    }
                }
                if(bulunduMu=="evet"){
                    Console.WriteLine("Bulunan kart bilgileri\n*************************");
                    Console.WriteLine("Baslik           :" + kart.baslik);
                    Console.WriteLine("Icerik           :" + kart.icerik);
                    Console.WriteLine("Aranan kisi      :" + kart.atananKisi);
                    Console.WriteLine("Buyukluk         :" + kart.buyukluk.ToString());
                    Console.WriteLine("\nLutfen tasimak istediginiz Line'ı seciniz :\n(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                    secim=Convert.ToInt32(Console.ReadLine());
                    if(secim==1)
                    {
                        if(hangiList==2)
                        {
                            listINPROGRESS.Remove(kart);
                            listTODO.Add(kart);
                            kontrol=false;
                        }
                        else if(hangiList==3)
                        {
                            listDone.Remove(kart);
                            listTODO.Add(kart);
                            kontrol = false;
                        }
                    }
                    else if(secim==2){
                        if (hangiList == 1)
                        {
                            listTODO.Remove(kart);
                            listINPROGRESS.Add(kart);
                            kontrol = false;
                        }
                        else if (hangiList == 3)
                        {
                            listTODO.Remove(kart);
                            listDone.Add(kart);
                            kontrol = false;
                        }
                    }
                    else if (secim == 3)
                    {
                        if (hangiList == 1)
                        {
                            listINPROGRESS.Remove(kart);
                            listTODO.Add(kart);
                            kontrol = false;
                        }
                        else if (hangiList == 2)
                        {
                            listINPROGRESS.Remove(kart);
                            listDone.Add(kart);
                            kontrol = false;
                        }
                    }

                }
                else if(bulunduMu!="evet"){
                    kontrol=true;
                    Console.WriteLine("Tekrar deneyiniz");
                }
            } while (kontrol);
        }
        static void kartlariListele(List<Kart> listTODO,List<Kart> listINPROGRESS,List<Kart> listDone)
        {
            Console.WriteLine("TODO Line\n***********************");
            foreach (var item in listTODO)
            {
                Console.WriteLine("Baslik           :" + item.baslik);
                Console.WriteLine("Icerik           :" + item.icerik);
                Console.WriteLine("Aranan kisi      :" + item.atananKisi);
                Console.WriteLine("Buyukluk         :" + item.buyukluk.ToString());
                Console.WriteLine("-");
            }
            Console.WriteLine("IN PROGRESS Line\n***********************");
            foreach (var item in listINPROGRESS)
            {
                Console.WriteLine("Baslik           :" + item.baslik);
                Console.WriteLine("Icerik           :" + item.icerik);
                Console.WriteLine("Aranan kisi      :" + item.atananKisi);
                Console.WriteLine("Buyukluk         :" + item.buyukluk.ToString());
                Console.WriteLine("-");
            }
            Console.WriteLine("DONE Line \n***********************");
            foreach (var item in listDone)
            {
                Console.WriteLine("Baslik           :" + item.baslik);
                Console.WriteLine("Icerik           :" + item.icerik);
                Console.WriteLine("Aranan kisi      :" + item.atananKisi);
                Console.WriteLine("Buyukluk         :" + item.buyukluk.ToString());
                Console.WriteLine("-");
            }
            

        }
    }
    class Kart{
        public string baslik { get; set; }
        public string icerik { get; set; }
        public string atananKisi { get; set; }
        public string buyukluk { get; set; }      
    }
    enum Buyukluk{
        XS=1,
        S,
        M,
        L,
        XL
    }
}
