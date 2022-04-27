import java.util.Scanner;
public class DeseneGoreMetot {
    static void Islem(int sayi,int tempSayi,boolean durum,int donme){
        if(durum){
            System.out.print(sayi+" ");
            sayi-=5;
            donme++;
            if(sayi<=0)
            {
                durum=false;
            }
            Islem(sayi,tempSayi,durum,donme);
        }
        else if(durum==false){
            System.out.print(sayi+" ");
            sayi+=5;
            donme--;
            if(donme>=0)
                Islem(sayi,tempSayi,durum,donme);

        }
    }
    public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
        System.out.println("Sayi giriniz : ");
        int sayi=scanner.nextInt();
        Islem(sayi,sayi,true,0);
    }
}
