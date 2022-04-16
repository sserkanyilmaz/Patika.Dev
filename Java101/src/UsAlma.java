import java.util.Scanner;
public class UsAlma {
    public static void main(String[] args) {
        Scanner scanner =new Scanner(System.in);
        int sayi,us4=1,us5=1;
        System.out.println("Kacinci dereceye kadar us almak istiyorsunuz ? ");
        sayi=scanner.nextInt();
        if(sayi==0){
            us4=us5=1;
            System.out.println("4'un 0'inci derecesi => "+us4 );
            System.out.println("5'in 0'inci derecesi => "+us5 );
        }
        else {
            System.out.println("4'un derecesine gore sonuclari => ");
            for (int i = 1; i <= sayi; i++) {
                us4 *= 4;
                System.out.print(" " + us4);
            }
            System.out.println("\n5'un derecesine gore sonuclari => ");
            for (int i = 1; i <= sayi; i++) {
                us5 *= 5;
                System.out.print(" " + us5);
            }
        }


    }
}
