﻿using System;
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
        // in worh ch
        static public void Something(Singletone singl)
        {
 
        }//dfnjsfs
        // in master ch

        public void masterMethod()
        { }

        public void masterMethod222()
        { }
        public void testInMaster()
        { }  

        //new change in master
        //new change in master2


        //work
        //new change in master3
    }
}
