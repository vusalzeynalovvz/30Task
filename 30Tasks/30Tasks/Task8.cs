//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string[] cities = { "YASAMAL", "28", "NAIROBI", "Baku", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

//            Console.Write("Input starting string: ");
//            char startChar = Convert.ToChar(Console.ReadLine());

//            Console.Write("Input ending string: ");
//            char endChar = Convert.ToChar(Console.ReadLine());

//            string result = FindStringWithStartEnd(cities, startChar, endChar);

//            Console.WriteLine("The city starting with " + startChar + " and ending with " + endChar + " is: " + result);
//        }

//        public static string FindStringWithStartEnd(string[] cities, char startChar, char endChar)
//        {
//            foreach (string item in cities)
//            {
//                if (item.StartsWith(startChar) && item.EndsWith(endChar))
//                {
//                    return item;
//                }
//            }

//            return null;
//        }
//    }
//}
