import java.util.Scanner;
public class DongulerIleBolunme {
    public static void main(String[] args) {
        Scanner scanner=new Scanner(System.in);
        int sayi1,j=0;
        double toplam=0;
        sayi1=scanner.nextInt();
        for (int i=0;i<=sayi1;i++)
        {
            if(i%12==0){
                System.out.println(i);
                toplam+=i;
                j++;
            }
        }
        System.out.println("Ortalama : "+(toplam/j));
    }
}
