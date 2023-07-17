//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30Tasks
//{
//    class Program
//    {
//        public static void Main()
//        {
//            Console.Write("Input number of strings to store in the array: ");
//            int count = int.Parse(Console.ReadLine());

//            string[] array = new string[count];

//            Console.WriteLine("Input {0} strings for the array:", count);
            
//            for (int i = 0; i < count; i++)
//            {
//                Console.Write("Element[{0}]: ", i);
//                array[i] = Console.ReadLine();
//            }

//            Console.Write("Input the minimum length of the item you want to find: ");
            
//            int minLength = int.Parse(Console.ReadLine());

//            Console.WriteLine("The items of minimum {0} characters are:", minLength);
//            FindStrings(array, minLength);
//        }

//        static void FindStrings(string[] array, int minLength)
//        {
//            foreach (string item in array)
//            {
//                if (item.Length >= minLength)
//                {
//                    Console.WriteLine("Item: " + item);
//                }
//            }
//        }
//    }
//}



//Write a program in C# Sharp to find the strings for a specific minimum length.
//Test Data :
//Input number of strings to store in the array :4
//Input 4 strings for the array:
//Element[0] : this
//Element[1] : is
//Element[2] : a
//Element[3] : string
//Input the minimum length of the item you want to find : 5
//Expected Output:
//The items of minimum 5 characters are :
//Item: string
