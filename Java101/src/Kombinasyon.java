import java.util.Scanner;
public class Kombinasyon {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);
        int n,r,nFak=1,rFak=1,nEksiR,nEksiRFak=1;
        System.out.println("Kümeniz kac elemanli : ");
        n=scanner.nextInt();
        System.out.println("Kacli kombinasyonun sayisini ogrenmek istiyorsunuz : ");
        r= scanner.nextInt();
        for (int i=1;i<=n;i++)
            nFak*=i;
        for (int i=1;i<=r;i++)
            rFak*=i;
        nEksiR=n-r;
        for (int i=1;i<=nEksiR;i++)
            nEksiRFak*=i;
        int sonuc=nFak/rFak*nEksiRFak;
        System.out.println("Kombinasyon sayisi = "+sonuc);
    }
}

