using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 ob = new Class1();
            Console.WriteLine("List 1");
            List<int> list1 = ob.getlist();

            Console.WriteLine("List 2");
            List<int> list2 = ob.getlist();
            //ob.list11(list1, list2);
            //ob.superlist(list1, list2);
            Console.Read();



        }
    }
}
