﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_1
{
    class Program
    {

        static void Func()
        {
            Console.WriteLine("스레드에서 호출");
        }

        static void ParameterizedFunc2(object obj)
        {
            for(int i=0;i<(int)obj;i++)
            {
                Console.WriteLine("Parameterized 스레드에서 호출 : {0}",i);
            }
        }

        static void Main(string[] args)
        {
            ////Thread th = new Thread(new ThreadStart(Func));

            //ThreadStart thStart = new ThreadStart(Func);
            //Thread th = new Thread(thStart);
            //th.Start();

            int i = 5;
            Thread th2 = new Thread(new ParameterizedThreadStart(ParameterizedFunc2));
            th2.Start(i);
        }
    }
}
