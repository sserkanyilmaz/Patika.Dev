import java.util.Scanner;
public class BasDegerlerToplami {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);
        int girilenSayi,basamakSayisi=0,toplam=0,tempSayi,bolen=10;
        System.out.println("Sayi giriniz : ");
        girilenSayi=scanner.nextInt();
        tempSayi=girilenSayi;
        while (tempSayi != 0) {
            tempSayi /= 10;
            basamakSayisi++;
        }
        while(basamakSayisi!=0)
        {
            tempSayi=girilenSayi;
            tempSayi=tempSayi%bolen;
            toplam+=(tempSayi/(bolen/10));
            bolen*=10;
            basamakSayisi--;

        }
        System.out.println("toplam : "+toplam);


    }
}
