
public class main {
    public static void main(String[] args) {
        Fighter zafer = new Fighter("Zafer" , 15 , 100, 90, 0);
        Fighter serkan = new Fighter("Serkan" , 10 , 95, 100, 0);
        Ring r = new Ring(zafer,serkan , 90 , 100);
        r.run();
    }

}
