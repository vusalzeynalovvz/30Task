//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
////    class Program
//{
//    static void Main()
//    {
//        List<char> charList = new List<char> { 'V', 'U', 'S', 'A', 'L' };

//        PrintList(charList);

//        char Remove = Convert.ToChar(Console.ReadLine());

//        charList.Remove(Remove);

//        Console.WriteLine("Removing the item list:", Remove);

//        PrintList(charList);

//        Console.ReadLine();
//    }

//    static void PrintList(List<char> list)
//    {
//        foreach (char item in list)
//        {
//            Console.WriteLine("Char: {0}", item);
//        }
//    }
//}
//}

//Write a program in C# Sharp to remove items from list using remove function by passing the object.
//Test Data :
//Here is the list of items :
//Char: m
//Char: n
//Char: o
//Char: p
//Char: q
//Expected Output:
//Here is the list after removing the item 'o' from the list :
//Char: m
//Char: n
//Char: p
//Char: q