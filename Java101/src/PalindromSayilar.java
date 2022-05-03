import java.util.Scanner;
public class PalindromSayilar {
    public static void main(String[] args) {
        int sayi;
        Scanner input = new Scanner(System.in);
        System.out.print("Sayi Giriniz : ");
        sayi = input.nextInt();
        int tempNumber = sayi, reverseNumber = 0, lastNumber;
        while (tempNumber != 0) {
            lastNumber = tempNumber % 10;
            reverseNumber = (reverseNumber * 10) + lastNumber;
            tempNumber /= 10;
        }
        if (reverseNumber == sayi) {
            System.out.println(sayi + " Palindrom Sayıdır");
        } else {
            System.out.println(sayi + " Palindrom Sayı Değildir");
        }
    }
}
