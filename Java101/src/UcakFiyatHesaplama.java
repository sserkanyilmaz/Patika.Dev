import java.util.Scanner;
public class UcakFiyatHesaplama {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int mesafe,yas,yolculukTip;
        double toplamUcret,kmBasiUcret=0.1,yasIndirimi=1,yolculukIndirimi=1;
        System.out.println("Mesafeyi Km Türünden Giriniz : ");
        mesafe=scan.nextInt();
        if(mesafe<0)
            System.out.println("Hatalı Veri Girdiniz !");
        System.out.println("Yolculuk tipini giriniz (1 => Tek Yön , 2 => Gidiş Dönüş : ");
        yolculukTip=scan.nextInt();
        if(yolculukTip!=1&&yolculukTip!=2)
            System.out.println("Hatalı Veri Girdiniz !");
        System.out.println("Yaşınızı Giriniz : ");
        yas=scan.nextInt();
        if(yas<12)
            yasIndirimi=0.5;
        if(yas>=12&&yas<24)
            yasIndirimi=0.9;
        if(yas>65)
            yasIndirimi=0.7;
        if(yolculukTip==2)
            yolculukIndirimi=1.6;
        toplamUcret=mesafe*kmBasiUcret;
        toplamUcret=toplamUcret*yasIndirimi;
        toplamUcret=toplamUcret*yolculukIndirimi;

        System.out.println("Toplam Tutar : "+toplamUcret);
    }
}
