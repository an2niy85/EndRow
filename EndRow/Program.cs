using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndRow
{
    class Program
    {
        static void Main(string[] args)
        {
            string myRow = "";

            for (int i = 7; i < 100; i+=7)
            {
                myRow = myRow + " " +i; 
            }

            Console.WriteLine(myRow);
            Console.ReadLine();
        }
    }
}
