//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            List<char> itemList = new List<char>() { 'M', 'N', 'O', 'P', 'Q' };

//            var res1 = from x in itemList select x;

//            Console.Write("Here is the list of items:\n");

//            foreach (var item in res1)
//            {
//                Console.WriteLine("Char: {0} ", item);
//            }

//            itemList.RemoveAt(0);

//            var res2 = from y in itemList select y;

//            Console.Write("\nRemoving item from the list : \n");

//            foreach (var item in res2)
//            {
//                Console.WriteLine("Char: {0} ", item);
//            }
//        }
//    }
//}

//Write a program in C# Sharp to remove items from list by passing the item index.
//Test Data :
//Here is the list of items :
//Char: m
//Char: n
//Char: o
//Char: p
//Char: q
//Expected Output:
//Here is the list after removing item index 3 from the list :
//Char: m
//Char: n
//Char: o
//Char: q
