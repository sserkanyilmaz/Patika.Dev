import java.util.Scanner;
public class TaksiUcreti {
    public static void main(String[] args)
    {
        Scanner scanner=new Scanner(System.in);
        double km,kmBasiFiyat=2.2,toplamUcret=0,baslangicUcreti=10;
        System.out.println("Kac kilometre gidildi");
        km= scanner.nextDouble();
        toplamUcret=baslangicUcreti+(km*kmBasiFiyat);
        toplamUcret=(toplamUcret>=20)?toplamUcret:20;
        System.out.println("Odenecek toplam ucret : "+toplamUcret);
    }
}
