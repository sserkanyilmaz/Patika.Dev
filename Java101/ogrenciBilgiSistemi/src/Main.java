public class Main {
    public static void main(String[] args) {
        Course mat = new Course("Matematik","Mat101","Mat");
        Course fizik = new Course("Fizik","Fizik101","Fizik");
        Course kimya = new Course("Kimya","Kimya101","Kimya");


        Teacher t1 = new Teacher("Cuma Batan", "90550000000", "Mat");
        Teacher t2 = new Teacher("Yusuf Gunes", "90550000001", "Fizik");
        Teacher t3 = new Teacher("Ali Kockıran", "90550000002", "Kimya");

        mat.addTeacher(t1);
        fizik.addTeacher(t2);
        kimya.addTeacher(t3);

        Student s1= new Student("Serkan","4",1,mat,fizik,kimya);
        s1.addBulkExamNote(50,50,89);
        Student s2= new Student("Zafer","4",2,mat,fizik,kimya);
        s2.addBulkExamNote(45,67,80);
        Student s3= new Student("Osman","4",3,mat,fizik,kimya);
        s3.addBulkExamNote(100,50,50);
        t1.addVerbalNote(s1,40);
        t1.addVerbalNote(s2,45);
        t1.addVerbalNote(s3,80);

        t2.addVerbalNote(s1,87);
        t2.addVerbalNote(s2,45);
        t2.addVerbalNote(s3,76);

        t3.addVerbalNote(s1,55);
        t3.addVerbalNote(s2,60);
        t3.addVerbalNote(s3,100);

        s1.isPass();
        s2.isPass();
        s3.isPass();
    }
}
