import java.util.Scanner;

public class NotOrtalamasiHesaplama {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int matematikNotu, fizikNotu, kimyaNotu, turkceNotu, tarihNotu, muzikNotu;
        double toplam = 0;
        System.out.print("matematik notunuzu giriniz :");
        matematikNotu= scan.nextInt();
        System.out.print("fizik notunuzu giriniz :");
        fizikNotu= scan.nextInt();
        System.out.print("kimya notunuzu giriniz :");
        kimyaNotu= scan.nextInt();
        System.out.print("turkce notunuzu giriniz :");
        turkceNotu= scan.nextInt();
        System.out.print("tarih notunuzu giriniz :");
        tarihNotu= scan.nextInt();
        System.out.print("muzik notunuzu giriniz :");
        muzikNotu= scan.nextInt();
        toplam =(matematikNotu+fizikNotu+kimyaNotu+tarihNotu+turkceNotu+muzikNotu)/6;
        System.out.println("toplam : " + toplam);
        String sonuc = (toplam >= 60) ? "Sinifi Geçti" : "Sinifta kaldı";
        System.out.println(sonuc);


    }
}

