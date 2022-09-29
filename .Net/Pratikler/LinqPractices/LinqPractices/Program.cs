using System;
using System.Linq;
using LinqPractices.DbOperations;

namespace LinqPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();
            Console.WriteLine("********* FIND ********");

            var student = _context.Students.Find(1);
            System.Console.WriteLine(student.Name);

            Console.WriteLine("********* FIRST OR DEFAULT ********");

            student = _context.Students.Where(x => x.Surname == "Arda").FirstOrDefault();
            //Where koşulunu içine de yazabiliriz
            student = _context.Students.FirstOrDefault(x=>x.Surname == "Arda");
            System.Console.WriteLine(student.Name);

            Console.WriteLine("********* SINGLE OR DEFAULT ********");
            //bir tane veri bekler birden fazla veri gelirse hata verir
            student = _context.Students.SingleOrDefault(x=>x.Name=="Deniz");
            System.Console.WriteLine(student.Name);

            Console.WriteLine("********* TO LIST ********");
            var studentList=_context.Students.Where(x=>x.ClassId == 2 ).ToList();
            System.Console.WriteLine(studentList.Count());

            Console.WriteLine("********* ORDER BY ********");
            studentList = _context.Students.OrderBy(x => x.StudentId).ToList();
            foreach (var s in studentList)
            {
                System.Console.WriteLine(s.Name + " " + s.StudentId);
            }

            Console.WriteLine("********* ORDER BY DESC ********");
            studentList = _context.Students.OrderByDescending(x => x.StudentId).ToList();
            foreach (var s in studentList)
            {
                System.Console.WriteLine(s.Name + " " + s.StudentId);
            }

            Console.WriteLine("********* ANONYMOUS OBJECT RESULT ********");
            var anonymousObject =_context.Students.Where(x=>x.ClassId==2).Select(x=> new {
                Id=x.StudentId,
                FullName=x.Name+x.Surname
            });
            foreach (var obj in anonymousObject)
            {
                System.Console.WriteLine(obj.Id+" "+ obj.FullName);
            }
        }
    }
}
