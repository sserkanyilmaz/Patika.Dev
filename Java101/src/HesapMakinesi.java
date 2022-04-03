import org.w3c.dom.ls.LSOutput;

import java.util.Scanner;
public class HesapMakinesi {
    public static void main(String[] args) {
        int n1,n2,select;
        Scanner scanner = new Scanner(System.in);
        System.out.println("İlk Sayiyi Giriniz : ");
        n1=scanner.nextInt();
        System.out.println("İkinci Sayiyi Giriniz : ");
        n2=scanner.nextInt();
        System.out.println("1-Toplama\n2-Çıkarma}n3-Çarpma\n4-Bölme");
        select= scanner.nextInt();
        switch(select){
            case 1:
                System.out.println("Toplam : "+(n1+n2));
            case 2:
                System.out.println("Çıkarma : "+(n1-n2));
            case 3:
                System.out.println("Çarpma : "+(n1*n2));
            case 4:
                System.out.println("Bölme : "+(n1/n2));
        }
    }

}
