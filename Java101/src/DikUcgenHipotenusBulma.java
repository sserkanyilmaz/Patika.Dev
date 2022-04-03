import java.util.Scanner;
public class DikUcgenHipotenusBulma {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        System.out.println("1.kenari giriniz");
        double birinciKenar=scan.nextInt();
        System.out.println("2.kenari giriniz");
        double ikinciKenar=scan.nextInt();
        double ucuncuKenar= (ikinciKenar*ikinciKenar)+(birinciKenar*birinciKenar);
        ucuncuKenar=Math.sqrt(ucuncuKenar);
        System.out.println("hipotenus :"+ucuncuKenar);
        double alan=(birinciKenar*ikinciKenar)/2;
        System.out.println("Alan :"+alan);
        System.out.println("Cevre :"+(birinciKenar+ikinciKenar+ucuncuKenar));
        System.out.println("********************************************");
        System.out.println("1.kenari giriniz");
        birinciKenar=scan.nextInt();
        System.out.println("2.kenari giriniz");
        ikinciKenar=scan.nextInt();
        System.out.println("3.kenari giriniz");
        ucuncuKenar=scan.nextInt();
        double u=(birinciKenar+ikinciKenar+ucuncuKenar)/2;
        double Alan= u * (u-birinciKenar)*(u-ikinciKenar) * (u-ucuncuKenar);
        System.out.println("3 kenari verilen ucgenin alani :"+(Math.sqrt(Alan)));
    }
}
