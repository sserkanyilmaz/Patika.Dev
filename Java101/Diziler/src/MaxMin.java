import java.util.Arrays;
import java.util.Scanner;

public class MaxMin {
    public static void main(String[] args) {
        int[] dizi = new int[]{15,12,788,1,-1,-778,2,0};
        Scanner scanner = new Scanner(System.in);
        System.out.println("dizi : "+Arrays.toString(dizi));
        System.out.print("Girilen sayi : ");
        int girilenSayi=scanner.nextInt();
        Arrays.sort(dizi);
        int kontrol=0;
        for(int i=0;i<dizi.length;i++)
        {
            if(girilenSayi>dizi[i])
                kontrol=i;
        }
        System.out.println("Girilen sayidan kucuk en yakin sayi :"+dizi[kontrol]);
        System.out.println("Girilen sayidan buyuk en yakin sayi :"+dizi[kontrol+1]);
    }
}
