import java.util.Scanner;
public class MukemmelSayi {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int sayi,kontrol=0;
        System.out.println("Bir sayi giriniz : ");
        sayi=scanner.nextInt();
        for(int i=1;i<sayi;i++)
        {
            if(sayi%i==0)
                kontrol+=i;
        }
        if(sayi==kontrol)
            System.out.println(sayi+" Mukemmel sayidir");
        else
            System.out.println(sayi+" Mukemmel sayi degildir");
    }
}
