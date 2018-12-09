using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PayCheck pay = new PayCheck();
            pay.SetGrossPay(200.00);
            string result = pay.GetGrossPay();
            Console.Out.WriteLine(result);
            Console.ReadLine();
        }
    }
}
