using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teachers = CreateTeacher();
            var students = CreateStudent();

            var result =
                from t in teachers
                join s in students
                on t.ClassName equals s.ClassName
                select
                new ResultInfo
                { ClassName = t.ClassName, Teacher = t.Teacher, Student = s.Student };

            foreach(var item in result)
            {
                Console.WriteLine($"{item.ClassName} : {item.Teacher} : {item.Student}");
            }

            Console.ReadLine();
        }
        static List<TeacherInfo> CreateTeacher()
        {
            return new List<TeacherInfo>
            {
                new TeacherInfo { ClassName ="1A" , Teacher ="Bill" },
                new TeacherInfo { ClassName ="1B" , Teacher ="David"}
            };
        }
        static List<StudentInfo> CreateStudent()
        {
            return new List<StudentInfo>
            {
                new StudentInfo{ ClassName = "1A", Student = "魯夫"},
                new StudentInfo{ ClassName = "1A", Student = "索隆"},
                new StudentInfo{ ClassName = "1B", Student = "櫻木"},
                new StudentInfo{ ClassName = "1A", Student = "香吉士"},
                new StudentInfo{ ClassName = "1B", Student = "流川風"}
            };
        }
    }
}
