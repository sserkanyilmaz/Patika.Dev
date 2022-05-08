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
        s1.addBulkExamNote(65,60,50);
        Student s2= new Student("Zafer","4",2,mat,fizik,kimya);
        s2.addBulkExamNote(88,80,10);
        Student s3= new Student("Osman","4",3,mat,fizik,kimya);
        s3.addBulkExamNote(55,70,50);

        t1.addVerbalNote(s1,52);
        t1.addVerbalNote(s2,76);
        t1.addVerbalNote(s3,46);

        t2.addVerbalNote(s1,46);
        t2.addVerbalNote(s2,75);
        t2.addVerbalNote(s3,43);

        t3.addVerbalNote(s1,87);
        t3.addVerbalNote(s2,24);
        t3.addVerbalNote(s3,57);

        s1.isPass();
        s2.isPass();
        s3.isPass();
    }
}
