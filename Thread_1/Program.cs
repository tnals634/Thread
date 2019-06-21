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
            Console.WriteLine("2번 스레드 : {0}",Thread.CurrentThread.GetHashCode());
        }

        
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(Func1));
            
            th.Start();
            Console.WriteLine("메인 스레드 {0}", Thread.CurrentThread.GetHashCode());
            Console.WriteLine("메인 종료");
        }
    }
}
