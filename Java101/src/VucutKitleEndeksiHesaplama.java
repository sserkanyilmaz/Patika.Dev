import java.util.Scanner;
public class VucutKitleEndeksiHesaplama {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double boy,kilo,vucutKitleIndeksi;
        System.out.println("Lütfen boyunuzu (metre cinsinde) giriniz : ");
        boy= scanner.nextDouble();
        System.out.println("Lütfen kilonuzu giriniz : ");
        kilo=scanner.nextDouble();
        vucutKitleIndeksi=kilo/Math.pow(boy,2);
        System.out.println("Vücut Kitle İndeksiniz :"+vucutKitleIndeksi);
    }
}
