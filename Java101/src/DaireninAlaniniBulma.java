import java.util.Scanner;
public class DaireninAlaniniBulma {
    public static void main(String[] args)
    {
        Scanner scanner=new Scanner(System.in);
        double pi = 3.14;
        double yaricap;
        System.out.println("Yaricap giriniz :");
        yaricap=scanner.nextDouble();
        System.out.println("Alan :"+(Math.pow(yaricap,2)*pi));
        System.out.println("Cevre :"+(2+pi+yaricap));
        System.out.println("Merkez aci olcusu giriniz :");
        double aci=scanner.nextDouble();
        System.out.println("Acisi girilen daire diliminin alani :"+(pi*Math.pow(yaricap,2)*aci)/360);

    }
}