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
//            Console.Write("Input the number of members on the List: ");
//            int count = Convert.ToInt32(Console.ReadLine());

//            int[] members = new int[count];

//            for (int i = 0; i < count; i++)
//            {
//                Console.Write("Member " + i + " : ");
//                members[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            Console.Write("Input the value above which you want to display the members of the List: ", count);
//            int threshold = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("The numbers greater than " + threshold + " are:");

//            foreach (int member in members)
//            {
//                if (member > threshold)
//                {
//                    Console.WriteLine(member);
//                }
//            }
//        }
//    }
//}


//BAXILACAQ TEZDEN