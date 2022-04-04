import java.util.Scanner;
public class ArtikYilHesaplama {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int yil;
        System.out.println("Yıl giriniz :" );
        yil=scanner.nextInt();
            if(yil%4==0)
            {
                if(yil%100==0&&!(yil%400==0))
                    System.out.println(yil+" bir artık yil degildir !");
                else
                    System.out.println(yil+" bir artık yıldır !" );
            }
            else
                System.out.println(yil+" bir artık yil degildir !");

    }
}
