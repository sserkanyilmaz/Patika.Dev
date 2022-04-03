import java.util.Scanner;
public class KullaniciGirisi {
    public static void main(String[] args) {
        String userName,password,karar,newPassword;
        Scanner scanner = new Scanner(System.in);
        System.out.println("Kullanıcı Adınız : ");
        userName= scanner.nextLine();
        System.out.println("Sifreniz : ");
        password=scanner.nextLine();
        if (userName.equals("patika")&&password.equals("java123"))
            System.out.println("Giris Yaptınız !");
        else if(userName.equals("patika")&&!password.equals("java123"))
        {
            System.out.println("Şifreniz Yanlış Sıfırlamak İçin sifirla Yazınız");
            karar=scanner.nextLine();
            if(karar.equals("sifirla"))
            {
                System.out.println("Yeni Sifre Giriniz : ");
                newPassword=scanner.nextLine();
                if (!newPassword.equals(password))
                {
                    password = newPassword ;
                    System.out.println("Şifreniz Değiştirilmiştir");
                } else
                {
                    System.out.println("Yeni Şifreniz Eski şifrenizle aynı olamaz");
                }
            }
        }
    }
}
