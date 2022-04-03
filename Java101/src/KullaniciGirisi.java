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
        else if(userName.equals("patika"))
        {
            if (!password.equals("java123"))
            {
                System.out.println("Şifreniz Yanlış Sıfırlamak İçin sifirla Yazınız");
                karar=scanner.nextLine();
                if(karar=="sifirla"){
                    System.out.println("Yeni Sifre Giriniz : ");
                    newPassword=scanner.nextLine();
                    if(newPassword==password)
                        System.out.println("Şifre oluşturulamadı, lütfen başka şifre giriniz.");
                    else{
                        System.out.println("Şifre oluşturuldu" );
                    }
                }
            }
        }
    }
}
