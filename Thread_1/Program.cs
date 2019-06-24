using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_1
{
    class Program
    {
        static void Func1()
        {
            for(int i=0;i<30;i++)
            {
                Console.WriteLine("{0}",i);
                Thread.Sleep(300);
            }
        }

        
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(Func1));
            
            th.Start();
            th.Join();
            Console.WriteLine("메인 종료");
        }
    }
}
