import java.util.Scanner;
public class EbobEkok {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int sayi1,sayi2,kontrol,enBuyukBolen=0,enKucukBolen=0;
        System.out.println("1. sayiyi giriniz : ");
        sayi1= scanner.nextInt();
        System.out.println("2. sayiyi giriniz : ");
        sayi2=scanner.nextInt();
        int i=1,j;
        while(i<=sayi1)
        {
            if(sayi1%i==0)
            {
                j=1;
                while(j<=sayi2)
                {
                    if(sayi2%j==0)
                    {
                        if(j==i)
                            enBuyukBolen=i;
                    }
                    j++;
                }
            }
            i++;
        }
        System.out.println(enBuyukBolen);
        enKucukBolen=(sayi2*sayi1)/enBuyukBolen;
        System.out.println(enKucukBolen);
    }
}
