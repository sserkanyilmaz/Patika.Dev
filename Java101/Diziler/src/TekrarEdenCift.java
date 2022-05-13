import java.util.Arrays;

public class TekrarEdenCift {
    public static void main(String[] args) {
        int[] list= new int []{3,7,2,3,2,9,10,21,1,33,9,1};
        int[] duplicate=new int[list.length];
        int startIndex=0;
        for(int i=0;i<list.length;i++)
        {
            for(int j=0;j<list.length;j++)
            {
                if((i!=j)&&(list[i]==list[j])){
                    duplicate[startIndex++]=list[i];
                    break;
                }
            }
        }
        for(int i=0;i<duplicate.length;i++) {
            if (duplicate[i] % 2 == 0)
                System.out.print(duplicate[i] + " ");
        }
        System.out.println("\n"+Arrays.toString(duplicate));
    }
}
