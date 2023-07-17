//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    public class Student
//    {
//        public string? Name { get; set; }
//        public int Grade { get; set; }
//        public int StudentId { get; set; }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            List<Student> List = new List<Student>();
//            List.Add(new Student { StudentId = 1, Name = "Vusal", Grade = 550 });
//            List.Add(new Student { StudentId = 2, Name = "Ali", Grade = 500 });
//            List.Add(new Student { StudentId = 3, Name = "Niyazi", Grade = 600 });
//            List.Add(new Student { StudentId = 4, Name = "Narmin", Grade = 100 });
//            List.Add(new Student { StudentId = 5, Name = "Vusal", Grade = 50 });
//            List.Add(new Student { StudentId = 6, Name = "Vusal", Grade = 400 });
//            List.Add(new Student { StudentId = 7, Name = "Vugar", Grade = 540 });
//            List.Add(new Student { StudentId = 8, Name = "Vusal", Grade = 570 });
//            List.Add(new Student { StudentId = 9, Name = "Nuray", Grade = 5 });

//            Console.Write("Which maximum grade point (1st, 2nd, 3rd, ...) you want to find: ");
//            int n = Convert.ToInt32(Console.ReadLine());

//            List.Sort((s1, s2) => s2.Grade.CompareTo(s1.Grade));

//            if (n > 0 && n <= List.Count)
//            {
//                Student student = List[n - 1];

//                Console.WriteLine($"Id: {student.StudentId}, Name: {student.Name}, Achieved Grade Point: {student.Grade}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid input");
//            }
//        }
//    }
    
//}
