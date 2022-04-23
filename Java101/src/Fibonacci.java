import java.util.Scanner;
public class Fibonacci {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);
        int sayi1=0,sayi2=1,sayi3,dongu;
        System.out.println("Kac seri olsun ? ");
        dongu= scanner.nextInt();
        System.out.print("0 1 ");
        for (int i=0;i<=dongu-2;i++)
        {
            sayi3=sayi1+sayi2;
            System.out.print(sayi3+" ");
            sayi1=sayi2;
            sayi2=sayi3;
        }
    }
}
