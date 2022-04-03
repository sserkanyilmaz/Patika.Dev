import java.util.Scanner;
public class SayiSiralama {
    public static void main(String[] args) {
        int a,b,c;
        Scanner scanner = new Scanner(System.in);
        System.out.println("Birinci Sayiyi Giriniz : ");
        a=scanner.nextInt();
        System.out.println("Ikinci Sayiyi Giriniz : ");
        b=scanner.nextInt();
        System.out.println("Ucuncu Sayiyi Giriniz : ");
        c=scanner.nextInt();
        if(a>b&&a>c&&b>c)
        {
            System.out.println("Girilen sayilar sirayla : "+a+" "+b+" "+c);
        }
        else if(a>b&&a>c&&c>b)
        {
            System.out.println("Girilen sayilar sirayla : "+a+" "+c+" "+b);
        }
        else if(b>a&&b>c&&a>c)
        {
            System.out.println("Girilen sayilar sirayla : "+b+" "+a+" "+c);
        }
        else if(b>a&&b>c&&c>a)
        {
            System.out.println("Girilen sayilar sirayla : "+b+" "+c+" "+a);
        }
        else if(c>a&&c>b&&b>a)
        {
            System.out.println("Girilen sayilar sirayla : "+c+" "+b+" "+a);
        }
        else if(c>a&&c>b&&a>b)
        {
            System.out.println("Girilen sayilar sirayla : "+c+" "+a+" "+b);
        }

    }
}
