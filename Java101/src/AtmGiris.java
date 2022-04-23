import java.util.Scanner;
public class AtmGiris {
    public static void main(String[] args) {
            Scanner scanner = new Scanner(System.in);
            String userName,password;
            int right=3,balance=1500,select,price;
            while(right>0) {
                System.out.println("Kullanici Adiniz : ");
                userName = scanner.nextLine();
                System.out.println("Sifreniz : ");
                password = scanner.nextLine();
                if (userName.equals("serkan") && (password.equals("1234"))) {
                    System.out.println("Merhaba, Yimaz Bankasına Hoşgeldiniz!");
                    do {
                        System.out.println("1-Para yatırma\n" +
                                "2-Para Çekme\n" +
                                "3-Bakiye Sorgula\n" +
                                "4-Çıkış Yap");
                        System.out.print("Lütfen yapmak istediğiniz işlemi seçiniz : ");
                        select = scanner.nextInt();
                        switch(select)
                        {
                            case 1:
                                System.out.println("Para yatirma miktarini giriniz : ");
                                balance+=scanner.nextInt();
                                break;
                            case 2:
                                System.out.println("Para cekme miktarini giriniz : ");
                                balance-=scanner.nextInt();
                                break;
                            case 3:
                                System.out.println("Bakiyeniz : "+balance);
                        }
                    } while (select != 4);
                    System.out.println("Tekrar görüşmek üzere.");
                    break;
                }
                else {
                    right--;
                    System.out.println("Hatalı kullanıcı adı veya şifre. Tekrar deneyiniz.");
                    if (right == 0) {
                        System.out.println("Hesabınız bloke olmuştur lütfen banka ile iletişime geçiniz.");
                    } else {
                        System.out.println("Kalan Hakkınız : " + right);
                    }
                }
            }
    }
}
