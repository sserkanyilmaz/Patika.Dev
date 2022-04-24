import java.util.Scanner;
public class UsRecursive {
    static int UsAl(int taban,int us)
    {
        if(us==1)
            return taban;
        else if(us==0)
            return 1;
        else
            return taban*UsAl(taban,us-1) ;
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int taban,us,sonuc;
        System.out.println("Taban degeri giriniz : ");
        taban= scanner.nextInt();
        System.out.println("Us degeri giriniz : ");
        us=scanner.nextInt();
        System.out.println("Sonuc : "+UsAl(taban,us));

    }
}
