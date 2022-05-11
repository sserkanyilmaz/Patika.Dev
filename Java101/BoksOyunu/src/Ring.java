public class Ring {
    Fighter f1;
    Fighter f2;
    int minWeight;
    int maxWeight;
    int control=(int)(Math.random()*2);
    public Ring(Fighter f1,Fighter f2,int minWeight,int maxWeight) {
        this.f1 = f1;
        this.minWeight = minWeight;
        this.maxWeight = maxWeight;
        this.f2 = f2;
    }
    public void run(){
        if(checkWeight()){
            while(f1.health>0&&f2.health>0){
                if(this.control==1)
                {
                    System.out.println("======== YENI ROUND =======");
                    f1.health=f2.hit(f1);
                    if(isWin())
                        break;
                    f2.health = f1.hit(f2);
                    if (isWin()){
                        break;
                    }
                }
                if(this.control==0)
                {
                    System.out.println("======== YENI ROUND =======");
                    f2.health = f1.hit(f2);
                    if (isWin()){
                        break;
                    }
                    f1.health=f2.hit(f1);
                    if(isWin())
                        break;
                }
                printScore();
            }
        }
        else
            System.out.println("Sporcularin agiklari uyusmuyor.");
    }
    public boolean checkWeight(){
        return (f1.weight>=minWeight&& f1.weight<=maxWeight)&&(f2.weight>=minWeight&& f2.weight<=maxWeight);
    }
    public boolean isWin(){
        if(f1.health==0){
            System.out.println("Maci kazanan : "+f2.name);
            return true;
        }
        else if(f2.health==0){
            System.out.println("Maci kazanan : "+f1.name);
            return true;
        }
        return false;
    }
    public void printScore(){
        System.out.println("------------");
        System.out.println(f1.name + " Kalan Can :" + f1.health);
        System.out.println(f2.name + " Kalan Can :" + f2.health);
    }
}