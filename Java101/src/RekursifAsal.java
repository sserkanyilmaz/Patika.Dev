import java.util.Scanner;

public class RekursifAsal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number=scanner.nextInt();
        boolean result=asalMi(number,2);
    }
    static boolean asalMi(int number,int i){
        boolean result;
        if (i >= number) {
            System.out.println(number + " sayisi ASALDIR !");
            result = true;
        } else if (number % i == 0) {
            System.out.println(number + " sayisi ASAL değildir !");
            result = false;
        } else {
            result = asalMi(number, i + 1);
        }
        return result;
    }
}
