//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 9,12,4,768,34 };

//            var res = numbers.Select(numbers => new { Number = numbers, SqrNo = numbers * numbers });

//            foreach (var item in res)
//            {
//                Console.WriteLine($"{{ Number = {item.Number}, SqrNo = {item.SqrNo} }}");
//            }
//        }
//    }
//}
