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
            int firstElemetRow = 7;
            int stepRow = 7;
            int limitRow = 100;

            string myRow = "";

            for (int i = firstElemetRow; i < limitRow; i+=stepRow)
            {
                myRow = myRow + " " +i; 
            }

            Console.WriteLine(myRow);
            Console.ReadLine();
        }
    }
}
