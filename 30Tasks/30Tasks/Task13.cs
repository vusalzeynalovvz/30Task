//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Input number of strings to store in the array: ");

//            int count = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Input " + count + " string for the array:");
            
//            string[] array = new string[count];

//            for (int i = 0; i < count; i++)
//            {
//                Console.Write($"Element[{i}]: ");

//                array[i] = Console.ReadLine();
//            }

//            string newstring = String.Join(", ", array.Select(x => x.ToString()).ToArray());
//            Console.WriteLine("Here is the string below created with elements of the above array :\r");
//            Console.WriteLine(newstring);
//        }
//    }
//}

////Element[0] : cat
////Element[1] : dog
////Element[2] : rat
////Expected Output:
////Here is the string below created with elements of the above array :
////cat, dog, rat
