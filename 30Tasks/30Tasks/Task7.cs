//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] numbers = new int[] { 1, 2, 4, 6, 3, 2, 5, 6, 2, 1, 3, 7, 9, 0, 6, 3, 2, 9, 2, 6, 5, 7, 9 };

//            var number = from num in numbers group num by num into num select num;

//            foreach (var item in number)
//            {
//                Console.WriteLine(item.Key + "\t" + item.Sum() + "\t\t\t" + item.Count());
//            }
//        }
//    }
//}

//Write a program in C# Sharp to display numbers, multiplication of numbers with frequency and the frequency 
//of a number in an array.
