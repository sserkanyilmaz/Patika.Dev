import java.util.Scanner;
public class EnBuyukEnKucukBulma {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);
        int hafizadakiSayi=0,i,enBuyuk=0,enKucuk=0;
        System.out.println("Kac adet sayi gireceksiniz ? ");
        i= scanner.nextInt();
        for (int j=1;j<=i;j++)
        {
            System.out.println(j+". sayiyi giriniz : ");
            hafizadakiSayi=scanner.nextInt();
            if(hafizadakiSayi>enBuyuk)
                enBuyuk=hafizadakiSayi;
            if(hafizadakiSayi<enKucuk)
                enKucuk=hafizadakiSayi;
        }
        System.out.println("En buyuk : "+enBuyuk);
        System.out.println("En kucuk : "+enKucuk);
    }
}
