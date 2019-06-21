﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_1
{
    class Test
    {
        public void Print()
        {
            Console.WriteLine("스레드 호출");
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Test test1 = new Test();
            Test test2 = new Test();

            Thread th1 = new Thread(new ThreadStart(test1.Print));
            Thread th2 = new Thread(new ThreadStart(test2.Print));

            th1.Start();
            th2.Start();
        }
    }
}
