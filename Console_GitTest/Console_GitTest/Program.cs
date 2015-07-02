using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateAndTimes();
            Console.ReadLine();
        }
        static void DateAndTimes()
        {
            Console.WriteLine("Current date and time: {0}", DateTime.Now);

        }
    }
}
