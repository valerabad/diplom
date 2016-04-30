using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProject
{
    class New
    { }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");            
            Console.WriteLine("change on master");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //singleton            
            Something(Singletone.Instance);                                 
            Console.ReadKey();
        }

        static public void Something(Singletone singl)
        {
            // my change in work
        }
    }
}
