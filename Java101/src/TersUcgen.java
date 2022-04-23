import java.util.Scanner;
public class TersUcgen {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int satirSayisi;
        System.out.println("Kac satir olmasini istersiniz ? ");
        satirSayisi=scanner.nextInt();
        for (int i = satirSayisi-1; i >= 0 ; i--) {
            for (int j = (satirSayisi - i); j > 0; j--) {
                System.out.print(" ");
            }
            for (int k = (2 * i + 1); k >= 1; k--) {
                System.out.print("*");
            }
            System.out.println(" ");
        }
    }
}
