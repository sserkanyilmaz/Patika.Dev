public class HarmonikOrtalama {
    public static void main(String[] args) {
        double[] numbers = {1, 2, 3, 4, 5};
        double payda = 0;
        for(int i=0;i<numbers.length;i++)
            payda+=(1/numbers[i]);
        System.out.println("Harmonik ortalamasi : "+(numbers.length/payda));
    }
}
