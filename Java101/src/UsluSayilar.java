import java.util.Scanner;
public class UsluSayilar {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int taban,us,sonuc;
        System.out.println("Taban giriniz : ");
        taban=scanner.nextInt();
        System.out.println("Us giriniz : ");
        us=scanner.nextInt();
        sonuc=taban;
        for(int i=0;i<us-1;i++)
            sonuc*=taban;
        System.out.println("Sonuc = " + sonuc);
    }
}
