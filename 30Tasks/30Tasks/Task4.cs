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

//            Console.WriteLine("The number and the Frequency are : ");

//            foreach (var item in number)
//            {
//                Console.WriteLine("Number " + item.Key + " appears " + item.Count() + " times");
//            }
//        }
//    }
//}

//. Write a program in C# Sharp to display the number and frequency of a given number from an array.
//Expected Output :
//The number and the Frequency are :
//Number 5 appears 3 times
//Number 9 appears 2 times
//Number 1 appears 1 times
