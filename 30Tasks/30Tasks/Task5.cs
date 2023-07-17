//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    using System;
//    using System.Linq;
//    using System.Collections.Generic;

//    class LinqExercise5
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Input the string : ");
//            var Input = Console.ReadLine();

//            var Frequency = from str in Input group str by str into str select str;

//            foreach (var item in Frequency)
//            {
//                Console.WriteLine("Character " + item.Key + ": " + item.Count() + " times");
//            }
//        }
//    }

//}

//Write a program in C# Sharp to display the characters and frequency of each character in a given string.
//Test Data:
//Input the string: apple
//Expected Output:
//The frequency of the characters are :
//Character a: 1 times
//Character p: 2 times
//Character l: 1 times
//Character e: 1 times
