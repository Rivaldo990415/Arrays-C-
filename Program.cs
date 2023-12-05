using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oneway attribute way of creating an array

            int[] luckyNumbers = { 1, 2, 3, 4, 5, };
            //if you wanna manipulate later then 6

            string[] friends = new string[5];
            friends[0] = "jim";
            friends[1] = "john";
            friends[2] = "Peter";
            Console.WriteLine(friends[0]);

            Console.ReadLine();
        }
    }
}
