import java.util.Scanner;
public class BurcHesaplama {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int day,month;
        String burc="";
        boolean isError=false;
        System.out.print("Gün giriniz : ");
        day=scanner.nextInt();
        System.out.print("Ay giriniz : ");
        month=scanner.nextInt();
        if (month == 1){
            if (day >= 1) {
                if (day < 22) {
                    burc="Burcunuz Oğlak.";
                } else if ((day >= 22 && day <= 31)) {
                    burc="Burcunuz Kova.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 2){
            if (day >= 1) {
                if (day < 20) {
                    burc="Burcunuz Kova.";
                } else if ((day >= 20 && day <= 29)) {
                    burc="Burcunuz Balık.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 3){
            if (day >= 1) {
                if (day < 21) {
                    burc="Burcunuz Balık.";
                } else if ((day >= 21 && day <= 31)) {
                    burc="Burcunuz Koç.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 4){
            if (day >= 1) {
                if (day < 21) {
                    burc="Burcunuz Koç.";
                } else if ((day >= 21 && day <= 30)) {
                    burc="Burcunuz Boğa.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 5){
            if (day >= 1) {
                if (day < 22) {
                    burc="Burcunuz Boğa.";
                } else if ((day >= 22 && day <= 31)) {
                    burc="Burcunuz İkizler.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 6){
            if (day >= 1) {
                if (day < 23) {
                    burc="Burcunuz İkizler.";
                } else if ((day >= 23 && day <= 30)) {
                    burc="Burcunuz Yengeç.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 7){
            if (day >= 1) {
                if (day < 23) {
                    burc="Burcunuz Yengeç.";
                } else if ((day >= 23 && day <= 31)) {
                    burc="Burcunuz Aslan.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 8){
            if (day >= 1) {
                if (day < 23) {
                    burc="Burcunuz Aslan.";
                } else if ((day >= 23 && day <= 31)) {
                    burc="Burcunuz Başak.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 9){
            if (day >= 1) {
                if (day < 23) {
                    burc="Burcunuz Başak.";
                } else if ((day >= 23 && day <= 30)) {
                    burc="Burcunuz Terazi.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 10){
            if (day >= 1) {
                if (day < 23) {
                    burc="Burcunuz Terazi.";
                } else if ((day >= 23 && day <= 31)) {
                    burc="Burcunuz Akrep.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 11){
            if (day >= 1) {
                if (day < 22) {
                    burc="Burcunuz Akrep.";
                } else if ((day >= 22 && day <= 30)) {
                    burc="Burcunuz Yay.";
                } else {
                    isError=true;
                }
            }
        }

        if (month == 12){
            if (day >= 1) {
                if (day < 22) {
                    burc="Burcunuz Yay.";
                } else if ((day >= 22 && day <= 31)) {
                    burc="Burcunuz Oğlak.";
                } else {
                    isError=true;
                }
            }
        }
        if(isError==true)
            System.out.println("Geçersiz bir gün girdiniz.");
    }
}
