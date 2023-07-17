//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics.Metrics;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            char[] charlist = { 'X', 'Y', 'Z', };
//            int[] numlist = {1,2,3 };
//            string[] stringlist = { "Green","Gray" };

//            var Find= from letter in charlist from number in numlist from colour in stringlist select new { letter,number, colour };
//            foreach (var item in Find)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}

////Write a program in C# Sharp to generate a cartesian product of three sets.
////Expected Output :
////The cartesian product are :
////{ letter = X, number = 1, colour = Green }
