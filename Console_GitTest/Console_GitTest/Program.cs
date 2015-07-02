using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console_GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateAndTimes();
            SystemEnvironment();
            Console.ReadLine();
            Dialog();
        }
        static void DateAndTimes()
        {
            Console.WriteLine("Current date and time: {0}", DateTime.Now);

            //День місяця
            DateTime dtime = new DateTime(2015, 07, 07);
            Console.WriteLine("The day of {0} is {1}", dtime.Date, dtime.DayOfWeek);
            Console.WriteLine();
        }
        static void SystemEnvironment()
        {
            //дані про дискові пристрої ПК
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine();
            //дані про версію ОС
            Console.WriteLine("Your os: {0}", Environment.OSVersion);
            Console.WriteLine();
            //дані про версію .Net
            Console.WriteLine(".Net version: {0}", Environment.Version);
        }
        static void Dialog()
        {
            DialogResult msgboxyesorno;
            msgboxyesorno = MessageBox.Show("Ви дійсно бажаєте вийти?");


        }

    }
}

