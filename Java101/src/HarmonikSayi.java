import java.util.Scanner;
public class HarmonikSayi {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double toplam=0;
        int girilenSayi;
        System.out.println("N sayisi giriniz : ");
        girilenSayi=scanner.nextInt();
        for(double i=1;i<=girilenSayi;i++)
            toplam+=(1/i);
        System.out.println(toplam);
    }
}
