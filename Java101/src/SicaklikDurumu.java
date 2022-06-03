import java.util.Scanner;

public class SicaklikDurumu {
    public static void main(String[] args) {
        int sicaklik;
        Scanner scan =new Scanner(System.in);
        System.out.println( "Sicaklik Derecesi Giriniz : ");
        sicaklik=scan.nextInt();

        if (sicaklik <= 5) { System.out.println( "Kayak yapabilirsin"); }
        else if ( sicaklik>5 && sicaklik<=15) {System.out.println(" Sinamaya gidebilirsin"); }
        else if ( sicaklik>=15 && sicaklik<=25) { System.out.println( " Piknik yapmaya gidebilirsin");}
        else if ( sicaklik>=25) { System.out.println( " Yuzmeye gidebilirsin");}
    }
}
