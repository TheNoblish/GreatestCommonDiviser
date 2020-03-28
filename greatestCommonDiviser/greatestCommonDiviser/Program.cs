using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greatestCommonDiviser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FindDiviser(45, 10));
            Console.ReadLine();
           

            


        }
        public static int FindDiviser(int a, int b)
        {
            int diviser;
            int left = a;
            int right = b;
            do
            {
                diviser = remainder(left, right);
                left = right;
                right = diviser;
            } while (diviser != 0);

            return left;
        }
        public static int remainder(int a, int b)
        {
            return a % b;
        }
    }
}
