import java.util.Scanner;
public class ManavKasaHesaplama {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double  armut,elma,domates,muz,patlican,toplam;
        System.out.println("Armut kac kilo");
        armut=scanner.nextDouble();
        System.out.println("Elma kac kilo");
        elma=scanner.nextDouble();
        System.out.println("Domates kac kilo");
        domates=scanner.nextDouble();
        System.out.println("Muz kac kilo");
        muz=scanner.nextDouble();
        System.out.println("Patlican kac kilo");
        patlican=scanner.nextDouble();
        toplam=2.14*armut+3.67*elma+1.11*domates+0.95*muz+5*patlican;
        System.out.println("Toplam tutar : "+toplam);

    }
}
