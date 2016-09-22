using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0920_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "Chien";
            // string result = string.Format("Hello! \n{0}.", userName);
            // string result = string.Format("Hello! \"{0}\".", userName);
            Console.WriteLine("data1\tdata2\tdata3");
            Console.WriteLine("data4\tdata5\tdata6");
            // Console.WriteLine("c:\\temp\\new.txt");
            Console.WriteLine(@"c:\temp\new.txt");
        }
    }
}
