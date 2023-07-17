//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            char[] charlist = { 'X', 'Y', 'Z' };
//            int[] numlist = { 1, 2, 3, 4 };

//            var Find = from letterList in charlist from numberList in numlist select new { letterList, numberList };

//            foreach (var Item in Find)
//            {
//                Console.WriteLine(Item);
//            }
//            Console.ReadLine();
//        }
//    }
//}


////Write a program in C# Sharp to generate a cartesian product of two sets.
////Expected Output :
////The cartesian product are :
////{ letterList = X, numberList = 1 }
////{ letterList = X, numberList = 2 }
////{ letterList = X, numberList = 3 }
////{ letterList = X, numberList = 4 }