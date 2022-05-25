import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        MineSweeper mine = new MineSweeper();
        Scanner scanner = new Scanner(System.in);
        System.out.println("kac satir olsun : ");
        mine.satir=scanner.nextInt();
        System.out.println("kac sutun olsun : ");
        mine.sutun=scanner.nextInt();
        mine.tarlaBelirle(mine.satir, mine.sutun);
        mine.tarlaHazirla();
        mine.tarlaYazdir();
        mine.mayinla();
        mine.tarlaYazdir();
        mine.secim();
    }
}
