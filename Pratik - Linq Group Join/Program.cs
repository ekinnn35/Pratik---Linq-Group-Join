using System;
using System.Collections.Generic;
using System.Linq;
using Pratik___Linq_Group_Join;

class Program
{
    static void Main()
    {
        // Öğrenci listesi
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
            new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
            new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
            new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
        };

        // Sınıf listesi
        List<Class> classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Türkçe" },
            new Class { ClassId = 3, ClassName = "Kimya" }
        };

        // Group Join ile sınıfları ve öğrencileri birleştirme
        var studentGroups = from c in classes
                            join s in students on c.ClassId equals s.ClassId into studentGroup
                            select new { ClassName = c.ClassName, Students = studentGroup };

        // Sonuçları ekrana yazdırma
        foreach (var group in studentGroups)
        {
            Console.WriteLine($"Class: {group.ClassName}");
            foreach (var student in group.Students)
            {
                Console.WriteLine($"  - {student.StudentName}");
            }
        }
    }
}
