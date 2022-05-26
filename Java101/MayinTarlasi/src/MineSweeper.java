import java.util.Random;
import java.util.Scanner;
public class MineSweeper {
    int satir;
    int sutun;
    char[][] tarla;
    char[][] tempTarla;
    Random rand= new Random();
    Scanner scanner = new Scanner(System.in);
    public void run(){
        System.out.println("kac satir olsun : ");
        this.satir=scanner.nextInt();
        System.out.println("kac sutun olsun : ");
        this.sutun=scanner.nextInt();
        this.tarlaBelirle(this.satir, this.sutun);
        this.tarlaHazirla();
        this.tarlaYazdir();
        this.mayinla();
        this.tarlaYazdir();
        this.secim();
    }
    public void tarlaBelirle(int i,int j){
        tarla= new char[i+2][j+2];
        tempTarla= new char[i+2][j+2];
    }
    public void tarlaHazirla(){
        for (int i =0;i<this.satir+2;i++) {
            for (int j = 0; j <this.sutun+2; j++) {
                tarla[i][j] = '-';
                tempTarla[i][j]='-';
            }
        }
    }
    public void tarlaYazdir(){
        for (int i =1;i<this.satir+1;i++) {
            for (int j =1; j < this.sutun+1; j++) {
                System.out.print(tempTarla[i][j]+" ");
            }
            System.out.println("");
        }
        System.out.println("\n");
    }
    public void mayinla(){
        int mayinSayisi=(this.satir*this.sutun)/4;
        int mayinlar=0;
        int sayi1;
        int sayi2;
        Random rand= new Random();
        while (mayinSayisi!=mayinlar)
        {
            sayi1 =rand.nextInt(this.satir)+1;
            sayi2= rand.nextInt(this.sutun)+1;
            if(sayi1==this.satir-1||sayi2==this.sutun-1){
                continue;
            }
            else if (tarla[sayi1][sayi2]=='-')
            {
                tarla[sayi1][sayi2] ='*';
                mayinlar++;
            }

        }
    }
    public void secim(){
        int bombaSayisi=0;
        int satir;
        int sutun;
        char deger;
        satir=satirAl();
        sutun=sutunAl();
        while(tarla[satir+1][sutun+1]!='*')
        {

            if(tarla[satir+1][sutun+1]=='-')
            {
                if(tarla[satir][sutun]=='*')
                    bombaSayisi++;
                if(tarla[satir][sutun+1]=='*')
                    bombaSayisi++;
                if(tarla[satir][sutun+2]=='*')
                    bombaSayisi++;
                if(tarla[satir+1][sutun]=='*')
                    bombaSayisi++;
                if(tarla[satir+1][sutun+1]=='*')
                    bombaSayisi++;
                if(tarla[satir+1][sutun+2]=='*')
                    bombaSayisi++;
                if(tarla[satir+2][sutun]=='*')
                    bombaSayisi++;
                if(tarla[satir+2][sutun+1]=='*')
                    bombaSayisi++;
                if(tarla[satir+2][sutun+2]=='*')
                    bombaSayisi++;
            }
            deger=(char)(bombaSayisi+'0');
            tempTarla[satir+1][sutun+1]=deger;
            tarla[satir+1][sutun+1]=deger;
            this.tarlaYazdir();
            if(isWin()){
                System.out.println("KAZANDINIZZZ !!!!!!!!!");
                break;
            }
            satir=satirAl();
            sutun=sutunAl();
            bombaSayisi=0;

        }
        if(tarla[satir+1][sutun+1]=='*'){
            System.out.println("Game over !!!!!");
        }
    }
    public boolean isWin()
    {
        for(int i=1;i<this.satir+1;i++){
            for(int j=1;j<this.satir+1;j++)
                if(tempTarla[i][j]=='-')
                    return false;
        }
        return true;
    }
    public int satirAl(){
        int satirr;
        System.out.println("hangi satir : ");
        satirr=scanner.nextInt();
        if(satirr>this.satir-1){
            System.out.println("Tarlanin boyutunu astiniz !!!");
            return satirAl();
        }
        return satirr;
    }
    public int sutunAl(){
        int sutunn;
        System.out.println("hangi sutun : ");
        sutunn=scanner.nextInt();
        if(sutunn>this.sutun-1){
            System.out.println("Tarlanin boyutunu astiniz !!!");
            return satirAl();
        }
        return sutunn;
    }
}
