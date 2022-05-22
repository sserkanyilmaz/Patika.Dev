import java.util.Scanner;

public class PalindromikKelime {
    public static String isPalidromik(String kelime)
    {
        StringBuilder sb=new StringBuilder(kelime);
        sb.reverse();
        return sb.toString();
    }
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String kelime=scanner.nextLine();
        System.out.println(isPalidromik(kelime));
        if(kelime.equals(isPalidromik(kelime)))
            System.out.println("Girdiginiz kelime palidromik");
        else
            System.out.println("Girdiginiz kelime palidromik degildir");
    }
}
