public class Teacher {
    String name;
    String mpno;
    String branch;
    public Teacher(String name,String mpno,String branch){
        this.name = name;
        this.mpno=mpno;
        this.branch=branch;
    }
    public void addVerbalNote(Student s,int verbalNote)
    {
        if (this.branch.equals("Fizik"))
        {
            s.fizikVerbalNote=verbalNote;
        }
        else if (this.branch.equals("Mat"))
        {
            s.matVerbalNote=verbalNote;
        }
        else if (this.branch.equals("Kimya"))
        {
            s.kimyaVerbalNote=verbalNote;
        }
    }
}
