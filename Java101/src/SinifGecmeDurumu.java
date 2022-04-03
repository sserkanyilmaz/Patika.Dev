import java.util.Scanner;
public class SinifGecmeDurumu {
    public static void main(String[] args) {
        int mat,fizik,turkce,kimya,muzik,n=0;
        double ortalama=0;
        Scanner scanner = new Scanner(System.in);

        System.out.println("Fizik notunuz : ");
        fizik = scanner.nextInt();
        if (fizik>=0&&fizik<=100){
            ortalama+=fizik;
            n++;
        }
        System.out.println("Turkce notunuz : ");
        turkce = scanner.nextInt();
        if (turkce>=0&&turkce<=100){
            ortalama+=turkce;
            n++;
        }
        System.out.println("Kimya notunuz : ");
        kimya = scanner.nextInt();
        if (kimya>=0&&kimya<=100){
            ortalama+=kimya;
            n++;
        }
        System.out.println("Matematik notunuz : ");
        mat = scanner.nextInt();
        if (mat>=0&&mat<=100)
        {
            ortalama+=mat;
            n++;
        }
        System.out.println("Muzik notunuz : ");
        muzik = scanner.nextInt();
        if (muzik>=0&&muzik<=100)
        {
            ortalama+=muzik;
            n++;
        }
        ortalama=ortalama/n;
        if(ortalama<=55)
        {
            System.out.println("Sınıfta kaldınız.");
            System.out.println("Ortalamanız : "+ortalama);
        }
        else{
            System.out.println("Tebrikler sınıfı geçtiniz !");
            System.out.println("Ortalamanız : "+ortalama);
        }

    }
}
