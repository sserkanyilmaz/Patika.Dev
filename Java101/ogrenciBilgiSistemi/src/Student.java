public class Student {
    String name,stuNo;
    int classes;
    Course mat;
    Course fizik;
    Course kimya;
    double average;
    boolean isPass;
    int matVerbalNote,fizikVerbalNote,kimyaVerbalNote;
    public Student(String name,String stuNo,int classes, Course mat,Course fizik,Course kimya)
    {
        this.name = name;
        this.classes=classes;
        this.mat=mat;
        this.fizik=fizik;
        this.kimya=kimya;
        this.stuNo=stuNo;
    }
    public void addBulkExamNote(int mat,int fizik,int kimya)
    {
        if (mat>=0&&mat<=100){
            this.mat.note=mat;
        }
        if (fizik>=0&&fizik<=100){
            this.fizik.note=fizik;
        }
        if (kimya>=0&&kimya<=100){
            this.kimya.note=kimya;
        }
    }
    public void isPass(){
        if(this.mat.note==0||this.fizik.note==0||this.kimya.note==0)
        {
            System.out.println("Notlar tam olarak girilmemiştir.");
        }
        else {
            this.isPass = isCheckPass();
            printNote();
            System.out.println("Ortalama : " + this.average);
            if (this.isPass) {
                System.out.println("Sinifi gecti.");
            } else
                System.out.println("Sinifta kaldi.");
        }
    }
    public void calcAverage(){
        this.average=(((this.fizik.note*0.8)+(this.fizikVerbalNote)*0.2)+
                ((this.mat.note*0.8)+(this.matVerbalNote)*0.2)+
                ((this.kimya.note*0.8)+(this.kimyaVerbalNote)*0.2))/3;
    }
    public boolean isCheckPass(){
        calcAverage();
        return this.average>55;
    }
    public void printNote(){
        System.out.println("===============");
        System.out.println("Öğrenci : " + this.name);
        System.out.println("Matematik Notu : " + this.mat.note);
        System.out.println("Fizik Notu : " + this.fizik.note);
        System.out.println("Kimya Notu : " + this.kimya.note);
    }
}
