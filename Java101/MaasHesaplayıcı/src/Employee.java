public class Employee {
    String name;
    double salary;
    int workHours;
    int hireYear;
    public Employee(String name,double salary,int workHours,int hireYear){
        this.name = name;
        this.salary=salary;
        this.workHours=workHours;
        this.hireYear=hireYear;
    }
    public double tax(){
        if(this.salary<1000){
            return 0;
        }
        else{
            return this.salary*0.03;
        }
    }
    public int bonus(){
        if(this.workHours>40)
        {
            return (this.workHours-40)*30;
        }
        return 0;
    }
    public double raiseSalary(){
        if((2021-this.hireYear)<10)
        {
            return this.salary*0.05;
        }
        else if((2021-this.hireYear)>9&&(2021-this.hireYear)<20){
            return this.salary*0.1;
        }
        else if((2021-this.hireYear)>19)
        {
            return this.salary*0.15;
        }
        return 0;
    }
    public void print(){
        System.out.println("Isim Soyisim : "+this.name);
        System.out.println("Ise baslama yili : "+this.hireYear);
        System.out.println("Calisma saati : "+this.workHours);
        System.out.println("Vergi : "+ tax());
        System.out.println("Bonus : " +bonus());
        System.out.println("Maaş Artisi : "+raiseSalary());
        System.out.println("Vergi ve Bonuslar ile birlikte maas : "+(this.salary-tax()+bonus()));
        System.out.println("Toplam maas :  "+(this.salary-tax()+bonus()+raiseSalary()));

    }

}
