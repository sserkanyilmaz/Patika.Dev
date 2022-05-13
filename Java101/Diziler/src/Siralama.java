import java.util.Arrays;
import java.util.Scanner;

public class Siralama {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Dizinin boyutu : ");
        int boyut= scanner.nextInt();
        int[] array=new int[boyut];
        System.out.println("Dizinin elemanlarini giriniz : ");
        for(int i=0;i<boyut;i++)
        {
            System.out.println((i+1)+". elemani : ");
            array[i]=scanner.nextInt();
        }
        Arrays.sort(array);
        System.out.println("Sıralama : "+Arrays.toString(array));
    }
}
