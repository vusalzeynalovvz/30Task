//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

//namespace _30Tasks
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string[] strings = new string[] { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "aaaa.PDF", "abc.xml", "ccc.txt", "zzz.txt " };
//            var fGrp = strings.Select(x => Path.GetExtension(x).TrimStart('.').ToLower()).GroupBy(z => z, (EXT, EXTCT) => new
//            {
//                Extension = EXT,
//                Count = EXTCT.Count()
//            });
//            foreach (var item in fGrp)
//            {
//                Console.WriteLine("{0} File(s) with {1} Extension ", item.Count, item.Extension);
//            }
//        }
//    }
//}

////Write a program in C# Sharp to count file extensions and group it using LINQ.
////Test Data :
////The files are : aaa.frx, bbb.TXT, xyz.dbf,abc.pdf
////aaaa.PDF, xyz.frt, abc.xml, ccc.txt, zzz.txt
////Expected Output :
////Here is the group of extension of the files :
////1 File(s) with .frx Extension
////3 File(s) with .txt Extension
////1 File(s) with .dbf Extension
////2 File(s) with .pdf Extension
////1 File(s) with .frt Extension
////1 File(s) with .xml Extension
