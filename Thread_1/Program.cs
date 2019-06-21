using System;
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
            Console.WriteLine("Test!");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Test test = new Test();
            Thread th = new Thread(new ThreadStart(test.Print));
            th.Start();
        }
    }
}
