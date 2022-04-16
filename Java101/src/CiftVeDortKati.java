import java.util.Scanner;
public class CiftVeDortKati {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int sayi,toplam=0;
        do {
            System.out.println("Bir sayi giriniz");
            sayi=scanner.nextInt();
            if(sayi%4==0&&sayi%2==0)
                toplam+=sayi;
        }while(sayi%2==0);
        System.out.println("Toplam : "+toplam);
    }
}
