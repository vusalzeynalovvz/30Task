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
//            Console.Write("The members of the list are : ");
//            int count = Convert.ToInt32(Console.ReadLine());

//            int[] members = new int[count];

//            for (int i = 0; i < count; i++)
//            {
//                members[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            Console.Write("How many records you want to display ? : ", count);
//            int threshold = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("The top " + threshold + " records from the list are :");

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


