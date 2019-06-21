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
        static void Func()
        {
            int i = 0;
            while(true)
            {
                Console.WriteLine("{0}",i++);
                Thread.Sleep(300);
            }
        }

        
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(Func));
            th.IsBackground = true; //th는 백그라운드로 실행해라
            th.Start();
            Console.WriteLine("메인 종료");
        }
    }
}
