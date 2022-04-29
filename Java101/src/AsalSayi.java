public class AsalSayi {
    public static void main(String[] args) {
        int kontrol=0;
        for (int i = 2; i < 100; i++) {
            kontrol=0;
            for (int j = 2; j < i; j++) {
                if (i % j == 0) {
                    kontrol++;
                }
            }
            if(kontrol==0)
                System.out.println(i + " ");
        }
    }
}
