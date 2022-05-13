import java.util.Scanner;

public class TranspozeAlma {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Kac satir olsun : ");
        int satir=scanner.nextInt();
        System.out.println("Kac sutun olsun : ");
        int sutun=scanner.nextInt();
        int[][] array = new int[satir][sutun];
        for(int i=0;i<satir;i++){
            for(int j=0;j<sutun;j++)
            {
                System.out.println((i+1)+". satir "+(j+1)+". sutunun elamanini giriniz :");
                array[i][j]= scanner.nextInt();;
            }
        }
        System.out.println("---------TRANSPOZE-----------");
        for(int i=0;i<sutun;i++){
            for(int j=0;j<satir;j++)
            {
                System.out.print(array[j][i]+" ");
            }
            System.out.println("");
        }

    }
}
