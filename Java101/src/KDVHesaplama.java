import java.util.Scanner;
public class KDVHesaplama {
    public static void main(String[] args)
    {
        Scanner scan   = new Scanner(System.in);
        System.out.println("Para tutari giriniz");
        int deger=scan.nextInt();
        System.out.println("KDV'siz tutar :"+deger);
        double kdv=(deger>0&&1000>deger)?0.18:0.08;
        System.out.println("KDV'li tutar :"+(deger+(deger*kdv)));
        System.out.println("KDV miktari :"+(kdv*deger));
    }
}
